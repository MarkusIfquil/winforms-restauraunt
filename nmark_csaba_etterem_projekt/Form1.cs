namespace nmark_csaba_etterem_projekt
{
    public partial class Form1 : Form
    {
        Etterem Etterem = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRendeles_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Etterem);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}