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
using ToolsCripto_Alexx;

namespace Pescaderia
{
    public partial class form_registros : Form
    {
        List<Compra> comprasDatabase = Serializer.JSON_Deserialize<Compra>(directories.comprasFile);
        private int selectedClientIndex = 0;

        public form_registros()
        {
            InitializeComponent();
        }

        private void viewerUpdate()
        {
            if (viewer_clients.Rows.Count > 0)
                viewer_clients.Rows.Clear();

            if(comprasDatabase.Count > 0)
            {
                foreach(Compra compra in comprasDatabase)
                {
                    viewer_clients.Rows.Add(
                        compra.nombreCliente,
                        compra.totalPago,
                        compra.totalPagoDolar,
                        compra.referenciaPago,
                        compra.bancoPago,
                        compra.tipoPago
                    );
                }
            }
        }

        private void viewer_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_view_details.Enabled)
                btn_view_details.Enabled = true;

            selectedClientIndex = viewer_clients.CurrentCell.RowIndex;
        }

        private void btn_view_details_Click(object sender, EventArgs e)
        {
            form_client_info formClientInfo = new form_client_info(selectedClientIndex);
            formClientInfo.Show();
        }

        private void form_registros_Load(object sender, EventArgs e)
        {
            viewerUpdate();
        }
    }
}
