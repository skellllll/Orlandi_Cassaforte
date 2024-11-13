using System.Diagnostics.Eventing.Reader;

namespace Orlandi_Cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte;

        public Form1()
        {
            InitializeComponent();
            cassaforte = new Cassaforte("01", "Sony", "J6", "01234", "01234", "abcdef123456", true, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            cassaforte.Apri();
            if (cassaforte.GetCassaforteAperta == true && cassaforte.GetBlocco == false)
                label1.Text = "Cassaforte Aperta";
            else if (cassaforte.GetCassaforteAperta == true && cassaforte.GetBlocco == true)
            {
                label1.Text = "Cassaforte Bloccata";
            }
        }

        private void Close2_Click(object sender, EventArgs e)
        {
            cassaforte.Chiudi();
            label1.Text = "Cassaforte Chiusa";
        }

        private void Unlock_Click(object sender, EventArgs e)
        {
            cassaforte.Sblocca();
            if(cassaforte.GetBlocco == false && cassaforte.GetCassaforteAperta == true)
            {
                label1.Text = "Cassaforte Sbloccata";
            }
            else
            {
                label1.Text = "Cassaforte Bloccata";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}