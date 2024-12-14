namespace Cassaforte_OD
{
    public partial class Form1 : Form
    {
        private Cassaforte cassaforte1;

        public Form1()
        {
            InitializeComponent();
            cassaforte1 = new Cassaforte("001", "Skel - Cassaforti", "SF90", "ABCDEF123456");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stato();
            TentativiSblocco();
        }

        public void Stato()
        {
            if (cassaforte1.Blocco == true)
            {
                label4.Text = "BLOCCATA";
                label4.ForeColor = Color.Bisque;
            }
            else if(cassaforte1.Blocco == false)
            {
                if (cassaforte1.Stato == true)
                {
                    label4.Text = "APERTA";
                    label4.ForeColor = Color.Green;
                }
                else
                {
                    label4.Text = "CHIUSA";
                    label4.ForeColor = Color.Red;
                }
            }
        }

        public void TentativiSblocco()
        {
            label3.Text = Convert.ToString(cassaforte1.TentativiDiSblocco);
        }

        //Set Codice Utente
        private void button1_Click(object sender, EventArgs e)
        {
            bool controllo = false;
            if (SetCodUtente.Text.Length != 5)
                return;
            for (int i = 0; i < SetCodUtente.Text.Length; i++)
            {
                if (SetCodUtente.Text[i] <= '0' && SetCodUtente.Text[i] >= '9')
                    controllo = true;
            }
            if (controllo == false)
            {
                cassaforte1.ImpostaCodiceUtente(SetCodUtente.Text);
                button1.Visible = false;
                SetCodUtente.Visible = false;
            }
        }

        //Set Data
        private void button2_Click(object sender, EventArgs e)
        {
            cassaforte1.ImpostaData(SetData.Text);
            button2.Visible = false;
            SetData.Visible = false;
            label12.Text = Convert.ToString(cassaforte1.DataProgrammata);
        }

        //Inserisci Codice Utente
        private void button3_Click(object sender, EventArgs e)
        {
            if (InserisciCodUtente.Text.Length != 5)
                return;
            if (cassaforte1.CodiceUtente != null)
            {
                cassaforte1.ApriCassaforte(InserisciCodUtente.Text);
                Stato();
                TentativiSblocco();
            }
        }

        //Inserisci Data
        private void button4_Click(object sender, EventArgs e)
        {
            cassaforte1.AperturaProgrammata(InserisciData.Text, InserisciCodUtente.Text);
            Stato();
            TentativiSblocco();
        }

        //Inserisci Codice Universale per Sblocco Cassaforte
        private void button5_Click(object sender, EventArgs e)
        {
            if (InserisciCodUniversale.Text.Length != 12)
            {
                return;
            }
            else if (cassaforte1.CodiceSblocco == null || InserisciData.Text != SetData.Text)
            {
                return;
            }
            else if (cassaforte1.CodiceSblocco != null && InserisciData.Text == SetData.Text)
            {
                cassaforte1.SbloccaCassaforte(InserisciCodUniversale.Text);
                Stato();
                TentativiSblocco();
            }
        }

        //Chiudi Cassaforte
        private void button6_Click(object sender, EventArgs e)
        {
            cassaforte1.ChiudiCassaforte();
            Stato();
        }
    }
}