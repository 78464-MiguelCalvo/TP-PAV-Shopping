using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV1
{
    public partial class FormListados : Form
    {
        public FormListados()
        {
            InitializeComponent();
        }

        private void FormListados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'LocalesXTipoComercio.LocalesXTipoComercio' Puede moverla o quitarla según sea necesario.
            this.LocalesXTipoComercioTableAdapter.Fill(this.LocalesXTipoComercio.LocalesXTipoComercio);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
