namespace MiPrimeraaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Mi primera aplicación en C#!");
            MessageBox.Show("¡Soy Luis Miguel!");

        }
     

        private void btnDespedir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("¡Adiós, hasta luego!");
        }
    }
}
