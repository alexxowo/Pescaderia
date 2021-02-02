using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pescaderia.Internal.objects;
using Pescaderia.Internal;
using System.IO;
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_inventory : Form, Observer
    {
        private List<Articulos> database = new List<Articulos>();
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
                        database[i].Nombre,
                        database[i].Precio,
                        database[i].articulosStock
                    );
                }
            }
        }

        private void Init()
        {
            if (File.Exists(directories.productsFile)) 
                database = Serializer.JSON_Deserialize<Articulos>(directories.productsFile);

            if (!Directory.Exists(directories.productsFolder))
                Directory.CreateDirectory(directories.productsFolder);
        }

        private void AddArticle(object sender, EventArgs e)
        {
            if(tb_title.Text != string.Empty)
            {
                if(numeric_stock.Value > 0)
                {
                    string articleName = tb_title.Text;
                    double articlePrice = (double)numeric_price.Value;
                    float articleStock = (float)numeric_stock.Value;

                    Articulos article = new Articulos();
                    article.Nombre = articleName;
                    article.Precio = articlePrice;
                    article.articulosStock = articleStock;
                    article.id = database.Count + 1;

                    database.Add(article);

                    Serializer.JSON_Serializer<Articulos>(database, directories.productsFile);
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
            int ArticleSelectedIndex = dataview_database.CurrentCell.RowIndex;
            tb_edit_art_title.Enabled = true;
            numeric_edit_price.Enabled = true;
            numeric_edit_stock.Enabled = true;
            btn_edit.Enabled = true;

            string articleName = database[ArticleSelectedIndex].Nombre;
            double articlePrice = database[ArticleSelectedIndex].Precio;
            float articleStock = database[ArticleSelectedIndex].articulosStock;

            tb_edit_art_title.Text = articleName;
            numeric_edit_price.Value = (decimal)articlePrice;
            numeric_stock.Value = (decimal)articleStock;
        }

        private void EditSelectedArticle(object sender, EventArgs e)
        {
            int articleSelectedIndex = dataview_database.CurrentCell.RowIndex;

            database[articleSelectedIndex].Nombre = tb_edit_art_title.Text;
            database[articleSelectedIndex].Precio = (double)numeric_edit_price.Value;
            database[articleSelectedIndex].articulosStock = (float)numeric_edit_stock.Value;

            Serializer.JSON_Serializer<Articulos>(database, directories.productsFile);
            ArticlesDataBaseViewer();
        }

        public void NotifyChanges()
        {
            observable.Update();
        }
    }
}
