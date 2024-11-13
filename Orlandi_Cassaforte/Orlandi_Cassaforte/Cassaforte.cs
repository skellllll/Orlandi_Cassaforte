using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Orlandi_Cassaforte
{
    internal class Cassaforte
    {
        private string matricola;
        private string produttore;
        private string modello;
        private string codiceUtente;
        private string codiceInserito;
        private string codiceSblocco;
        private bool cassaforteAperta = false;
        private bool blocco = false;
        private const int tentativi = 5;

        public Cassaforte(string matricola, string produttore, string modello, string codiceUtente, string codiceInserito, string codiceSblocco, bool cassaforteAperta, bool blocco)
        {
            this.matricola = matricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceUtente = codiceUtente;
            this.codiceInserito = codiceInserito;
            this.codiceSblocco = codiceSblocco;
            this.cassaforteAperta = cassaforteAperta;
            this.blocco = blocco;
        }
        
        public string getMatricola
        {
            get { return matricola; }
        }
        public string getProduttore
        {
            get { return produttore; }
        }
        public string getModello
        {
            get { return modello; }
        }
        public string getCodiceUtente
        {
            get { return codiceUtente; }
            set { codiceUtente = value; }
        }
        public string getCodiceInserito
        {
            get { return codiceInserito; }
            set { codiceInserito = value; }
        }
        public string getCodiceSblocco
        {
            get { return codiceSblocco; }
            set { codiceSblocco = value; }
        }
        public bool GetCassaforteAperta
        {
            get { return cassaforteAperta; }
            set { cassaforteAperta = value; }
        }
        public bool GetBlocco
        {
            get { return blocco; }
            set { blocco = value; }
        }

        public void Apri()
        {
            if (blocco == false)
            {
                for (int i = 0; i < tentativi; i++)
                {
                    if (codiceInserito == codiceUtente)
                    {
                        cassaforteAperta = true;
                    }
                }
                cassaforteAperta = false;
                blocco = true;
            }
        }
        public void Chiudi()
        {
            cassaforteAperta = false;
        }
        public void Sblocca()
        {
            if (blocco == true && codiceInserito == codiceSblocco)
            {
                cassaforteAperta = true;
                blocco = false;
            }
            else
            {
                cassaforteAperta = false;
                blocco = true;
            }
        }
    }
}
