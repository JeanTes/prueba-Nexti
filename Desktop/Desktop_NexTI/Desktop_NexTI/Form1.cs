using CapaAccesoDatos;
using CapaLogicaNegocio;
using System.Xml.Linq;
using System;
using System.Windows.Forms;

namespace Desktop_NexTI
{
    public partial class btnimg : Form
    {
        public btnimg()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        
            Cliente newClient = new Cliente
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Cedula = txtcedula.Text,
                Telefono = txttelefono.Text,
                Correo = txtcorreo.Text,
                FotoPerfil = ImageToByteArray(ptbPerfil.Image),
                Cursos = txtcurso.Text,
            };

            
            ServiceCliente clientService = new ServiceCliente("your_connection_string_here");

            try
            {
                // Call the AddClient method to validate and save the data
                int newClientId = clientService.AddClient(newClient);

                // Display a success message
                MessageBox.Show($"Client added successfully with ID: {newClientId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form input
                ClearForm();
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtcurso.Clear();
            ptbPerfil.Image = null;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialog1.Filter = "Select Valid Document(*.png; *.jpg)|*.png; *.jpg";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ptbPerfil.Image = new Bitmap(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}