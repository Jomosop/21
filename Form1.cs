using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        List<Kort> hand = new List<Kort>();
        Spelaren du;
        Spelaren dealer;
        KortLek lek;
        int spelarPoäng;
        int dealerPoäng;
        int saldo = 1000;
        int insats = 0;
        //delegate void visaKortDel(Spelaren spelare, FlowLayoutPanel panel, Label poängLabel);
        //visaKortDel dealerKort, spelarKort;
        

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1500;
            Insats();
            
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            dealer.NyttKort();            
            VisaDealerKort();
            dealerDrarKort();
        }

        void Spela()
        {
            labelSpelarPoäng.Enabled = true;
            labelDealerPoäng.Enabled = true;
            lek = new KortLek();
            lek.Blanda();
            buttonKort.Enabled = true;
            buttonStanna.Enabled = true;            
            du = new Spelaren(lek);
            dealer = new Spelaren(lek);            
            du.NyttKort();
            dealer.NyttKort();
            du.NyttKort();
            VisaSpelarKort();
            VisaDealerKort();
            spelarPoäng = du.beräknaPoäng();
            if (spelarPoäng == 21) buttonKort.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            du.NyttKort();
            VisaSpelarKort();
            spelarPoäng = du.beräknaPoäng();
            labelSpelarPoäng.Text = spelarPoäng.ToString();
            if (spelarPoäng == 21) buttonKort.Enabled = false;
            if (spelarPoäng > 21)
            {
                insats = 0;
                labelSaldo.Text = "Saldo: " + saldo + " kr";
                labelInsats.Text = "Insats: " + insats + " kr";
                buttonKort.Enabled = false;
                buttonStanna.Enabled = false;
                if (saldo > 0)
                {
                    var resultat = MessageBox.Show("Du blev tjock\nVill du fortsätta spela?", "Vill du fortsätta spela?", MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes) Insats();
                    else if (resultat == DialogResult.No) this.Close();
                }
                else
                {
                    var resultat = MessageBox.Show("Du Förlorade\nDina pengar är slut\nVill du spela igen?", "Bankrutt", MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes)
                    {
                        saldo = 1000;
                        Insats();
                    }
                    else if (resultat == DialogResult.No) this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonKort.Enabled = false;
            buttonStanna.Enabled = false;
            dealer.NyttKort();
            hand = dealer.GetHand();
            foreach (Kort k in hand)
            {
                flowLayoutPanelDealer.Controls.Add(k);
            }
            dealerDrarKort();
        }

        private void dealerDrarKort()
        {
            dealerPoäng=dealer.beräknaPoäng();
            labelDealerPoäng.Text = dealerPoäng.ToString();
            if (dealerPoäng > 21)
            {
                saldo += insats * 2;
                int vinst = insats;
                insats = 0;
                labelSaldo.Text = "Saldo: " + saldo + " kr";
                labelInsats.Text = "Insats: " + insats + " kr";
                var resultat = MessageBox.Show("Du Vann " + vinst + " kr\nVill du fortsätta spela?", "Vill du fortsätta spela?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes) Insats();
                else if (resultat == DialogResult.No) this.Close();
            }
            else if (dealerPoäng >= spelarPoäng)
            {
                insats = 0;
                labelSaldo.Text = "Saldo: " + saldo + " kr";
                labelInsats.Text = "Insats: " + insats + " kr";
                if (saldo > 0)
                {
                    var resultat = MessageBox.Show("Du Förlorade\nVill du fortsätta spela?", "Vill du fortsätta spela?", MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes) Insats();
                    else if (resultat == DialogResult.No) this.Close();
                }
                else{
                    var resultat = MessageBox.Show("Du Förlorade\nDina pengar är slut\nVill du spela igen?", "Konkurs", MessageBoxButtons.YesNo);
                    if (resultat == DialogResult.Yes)
                    {
                        saldo = 1000;
                        Insats();
                    }
                    else if (resultat == DialogResult.No) this.Close();
                }
            }
            else if (dealerPoäng < 16)
            {
                timer1.Start();
                
            }
            else if (dealerPoäng<spelarPoäng)
            {
                saldo += insats * 2;
                int vinst = insats;
                insats = 0;
                labelSaldo.Text = "Saldo: " + saldo + " kr";
                labelInsats.Text = "Insats: " + insats + " kr";
                var resultat = MessageBox.Show("Du Vann " + vinst + " kr\nVill du fortsätta spela?", "Vill du fortsätta spela?", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes) Insats();
                else if (resultat == DialogResult.No) this.Close();
            }

            
        }
        void Insats()
        {
            flowLayoutPanelSpelaren.Controls.Clear();
            flowLayoutPanelDealer.Controls.Clear();
            labelSpelarPoäng.Enabled = false;
            labelDealerPoäng.Enabled = false;
            buttonInsats1.Enabled = true;
            buttonInsats2.Enabled = true;
            buttonInsats3.Enabled = true;
            buttonKort.Enabled = false;
            buttonStanna.Enabled = false;
            buttonSatsa.Enabled = true;
            labelSaldo.Text = "Saldo: " + saldo + " kr";
            labelInsats.Text = "Insats: " + insats + " kr";
        }

        private void buttonInsats_Click(object sender, EventArgs e)
        {
            
            Button knapp = (Button)sender;
            int satsat = int.Parse(knapp.Text.ToString());
            if (saldo - satsat < 0) return;
            saldo -= satsat;
            insats += satsat;
            labelSaldo.Text = "Saldo: " + saldo + " kr";
            labelInsats.Text = "Insats: " + insats + " kr";
        }

        private void buttonSatsa_Click(object sender, EventArgs e)
        {
            if (insats == 0) return;
            buttonInsats1.Enabled = false;
            buttonInsats2.Enabled = false;
            buttonInsats3.Enabled = false;
            buttonKort.Enabled = true;
            buttonStanna.Enabled = true;
            buttonSatsa.Enabled = false;
            Spela();

        }
        void VisaSpelarKort()
        {
            hand = du.GetHand();
            foreach (Kort k in hand)
            {
                flowLayoutPanelSpelaren.Controls.Add(k);
            }
            labelSpelarPoäng.Text= du.beräknaPoäng().ToString();
        }
        void VisaDealerKort()
        {
            hand = dealer.GetHand();
            foreach (Kort k in hand)
            {
                flowLayoutPanelDealer.Controls.Add(k);
            }
            labelDealerPoäng.Text = dealer.beräknaPoäng().ToString();
        }

        
    }
}
