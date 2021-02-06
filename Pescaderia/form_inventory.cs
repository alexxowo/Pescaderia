using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pescaderia.Internal.objects.Productos;
using Pescaderia.Internal;
using System.IO;
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_inventory : Form, Observer
    {
        private List<Producto> database = new List<Producto>();
        private Observable observable;

        public form_inventory(Observable FormObservable)
        {
            observable = FormObservable;
            InitializeComponent();
        }

        private void FormInventoryLoad(object sender, EventArgs e)
        {
            Init();
            ArticlesDataBaseViewer();
        }

        private void ArticlesDataBaseViewer()
        {
            if (dataview_database.Rows.Count > 0)
                dataview_database.Rows.Clear();

            if (database.Count > 0)
            {
                for (int i = 0; i < database.Count; i++)
                {
                    dataview_database.Rows.Add(
                        database[i].id,
                        database[i].nombre,
                        database[i].precio,
                        database[i].articulosStock
                    );
                }
            }
        }

        private void Init()
        {
            if (File.Exists(directories.productsFile)) 
                database = Serializer.JSON_Deserialize<Producto>(directories.productsFile);

            if (!Directory.Exists(directories.productsFolder))
                Directory.CreateDirectory(directories.productsFolder);

            // Add items to combobox
            productTypeComboBox.DataSource = Enum.GetValues(typeof(TipoProducto));
        }

        private void AddArticle(object sender, EventArgs e)
        {
            if(tb_title.Text != string.Empty)
            {
                if(numeric_stock.Value > 0)
                {
                    int articleId = database.Count + 1;
                    string articleName = tb_title.Text;
                    double articlePrice = (double)numeric_price.Value;
                    float articleStock = (float)numeric_stock.Value;
                    TipoProducto articleType = (TipoProducto)productTypeComboBox.SelectedIndex;

                    Producto article = new Producto(
                        articleId,
                        articleName,
                        articleType,
                        articlePrice,
                        articleStock
                    );

                    database.Add(article);

                    Serializer.JSON_Serializer<Producto>(database, directories.productsFile);
                    ArticlesDataBaseViewer();
                    NotifyChanges();
                }
                else
                {
                    MessageBox.Show("No puedes poner 0 o menos como stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No haz puesto nombre al articulo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectArticleCell(object sender, DataGridViewCellEventArgs e)
        {
            int ArticleSelectedIndex   = dataview_database.CurrentCell.RowIndex;
            tb_edit_art_title.Enabled  = true;
            numeric_edit_price.Enabled = true;
            numeric_edit_stock.Enabled = true;
            btn_edit.Enabled           = true;
            deleteArticleBtn.Enabled   = true;

            string articleName  = database[ArticleSelectedIndex].nombre;
            double articlePrice = database[ArticleSelectedIndex].precio;
            float articleStock  = database[ArticleSelectedIndex].articulosStock;

            tb_edit_art_title.Text   = articleName;
            numeric_edit_price.Value = (decimal)articlePrice;
            numeric_stock.Value      = (decimal)articleStock;
        }

        private void EditSelectedArticle(object sender, EventArgs e)
        {
            int articleSelectedIndex = dataview_database.CurrentCell.RowIndex;

            database[articleSelectedIndex].nombre = tb_edit_art_title.Text;
            database[articleSelectedIndex].precio = (double)numeric_edit_price.Value;
            database[articleSelectedIndex].articulosStock = (float)numeric_edit_stock.Value;

            Serializer.JSON_Serializer<Producto>(database, directories.productsFile);
            ArticlesDataBaseViewer();
        }

        public void NotifyChanges()
        {
            observable.Update();
        }

        private void DeleteArticle(object sender, EventArgs e)
        {
            int articleSelectedIndex = dataview_database.CurrentCell.RowIndex;
            DialogResult resultDialog = MessageBox.Show("Desea eliminar el articulo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if(resultDialog == DialogResult.Yes)
            {
                database.RemoveAt(articleSelectedIndex);
                dataview_database.Rows.RemoveAt(articleSelectedIndex);
                Serializer.JSON_Serializer(database, directories.productsFile);
                ArticlesDataBaseViewer();
                observable.Update();
            }

        }
    }
}
