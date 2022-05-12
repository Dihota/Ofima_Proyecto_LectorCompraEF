using Lib_LectorCompraEF;
using Lib_LectorCompraEF.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LectorCompra_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emisor emisor = new Emisor();
            string Ruta = @"C:\Users\Hogar\Documents\Diego\ofima\Desarrollo\Lector Compra\XML\VILA-ad08110020620172200000014.xml";
            int Origen = 1;

            Lector_Compras_EF Lector = new Lector_Compras_EF();

            var DataEmisor = Lector.LectorXMLEmisor(Ruta,Origen);
            
            lblNumFact.Text = DataEmisor.NumFactura;
            lblNomEmisor.Text = DataEmisor.NomEmisor;
            lblNitEmisor.Text = DataEmisor.Nit;

            var DataAdquiriente = Lector.LectorXMLAdquiriente(Ruta, Origen);
            lblNomAdqui.Text = DataAdquiriente.NomAdquiriente;
            lblNitAdqui.Text = DataAdquiriente.Nit;
            lblFechExp.Text =  DataAdquiriente.FechaFact;
            lblDirec.Text = DataAdquiriente.Direccion;
            lblCiu.Text = DataAdquiriente.Ciudad;
            lblTel.Text = Convert.ToString(DataAdquiriente.Celular);
            lblFpago.Text = Convert.ToString(DataAdquiriente.FormaPago);
            lblCufe.Text = DataAdquiriente.CUFE;
            lblHora.Text = DataAdquiriente.HoraFact;
            lblVenci.Text = DataAdquiriente.FechaFact;
            lblPlazo.Text = Convert.ToString(DataAdquiriente.Plazo);
            lblmedpag.Text = Convert.ToString(DataAdquiriente.FormaPago);

            dgvDetalle.DataSource =  Lector.LectorXMLDetalle(Ruta, Origen);


        }
    }
}
