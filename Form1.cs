namespace WinFormsPrueba3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            this.saludar();
        }
        private void saludar()
        {
            string nom;
            nom = this.textBoxCaptura.Text;
            MessageBox.Show("hola "+nom);
        }
    }
}
