using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pescaderia.Internal.objects;
using Pescaderia.Internal;
using System.IO;
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_inventory : Form
    {
        List<Articulos> database = new List<Articulos>();
        Observable observable;

        public form_inventory(Observable objObservable)
        {
            observable = objObservable;
            InitializeComponent();
        }

        private void form_inventory_Load(object sender, EventArgs e)
        {
            Init();
            dataViewerFill();
        }

        private void dataViewerFill()
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

        private void btn_add_article_Click(object sender, EventArgs e)
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
                    dataViewerFill();
                    observable.update();
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

        private void dataview_database_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dataview_database.CurrentCell.RowIndex;
            tb_edit_art_title.Enabled = true;
            numeric_edit_price.Enabled = true;
            numeric_edit_stock.Enabled = true;
            btn_edit.Enabled = true;

            string articleName = database[selectedIndex].Nombre;
            double articlePrice = database[selectedIndex].Precio;
            float articleStock = database[selectedIndex].articulosStock;

            tb_edit_art_title.Text = articleName;
            numeric_edit_price.Value = (decimal)articlePrice;
            numeric_stock.Value = (decimal)articleStock;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataview_database.CurrentCell.RowIndex;

            database[selectedIndex].Nombre = tb_edit_art_title.Text;
            database[selectedIndex].Precio = (double)numeric_edit_price.Value;
            database[selectedIndex].articulosStock = (float)numeric_edit_stock.Value;

            Serializer.JSON_Serializer<Articulos>(database, directories.productsFile);
            dataViewerFill();
        }
    }
}
