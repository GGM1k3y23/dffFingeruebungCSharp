using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dffFingeruebungCSharp
{
    public partial class frmSpielfeld : Form
    {
        string spieler = "X";

        //Abbildung des Spielfeldes in einer Liste zum schnellen
        //überprüfen der Siegbedingungen
        List<Button> zeile1 = new List<Button>(3);
        List<Button> zeile2 = new List<Button>(3);
        List<Button> zeile3 = new List<Button>(3);
        List<Button> spalte1 = new List<Button>(3);
        List<Button> spalte2 = new List<Button>(3);
        List<Button> spalte3 = new List<Button>(3);
        List<Button> diagonale1 = new List<Button>(3);
        List<Button> diagonale2 = new List<Button>(3);
        List<List<Button>> spielfeld = new List<List<Button>>(8);

        public frmSpielfeld()
        {
            InitializeComponent();

            lblRunde.Text = String.Format("Du bist dran, {0}", spieler);

            //Da jeder Button die gleichen Aktionen durchführen soll,
            //können auch alle die selbe Funktion beim Click Ereignis aufrufen.
            //Der Code wird dadurch wesentlich kürzer und übersichtlicher 
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            
            
            zeile1.AddRange(new Button[] { button1, button2, button3 });
            zeile2.AddRange(new Button[] { button4, button5, button6 });
            zeile3.AddRange(new Button[] { button7, button8, button9 });
            spalte1.AddRange(new Button[] { button1, button4, button7 });
            spalte2.AddRange(new Button[] { button2, button4, button8 });
            spalte3.AddRange(new Button[] { button3, button6, button9 });
            diagonale1.AddRange(new Button[] { button1, button5, button9 });
            diagonale2.AddRange(new Button[] { button7, button5, button3 });
            spielfeld.AddRange(new List<Button>[] { zeile1, zeile2, zeile3, spalte1, spalte2, spalte3, diagonale1, diagonale2 });
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;

            if (clickedButton.Text == String.Empty)
            {
                clickedButton.Text = spieler;

                if (CheckSieg())
                {
                    Ende();
                }
                else
                {
                    spieler = spieler == "X" ? "O" : "X";
                    lblRunde.Text = String.Format("Du bist dran, {0}", spieler);
                }
            }
        }

        private bool CheckSieg()
        {
            bool result = false;

            foreach(List<Button> teste in spielfeld)
            {
                if (teste[0].Text == teste[1].Text && teste[1].Text == teste[2].Text && teste[0].Text != String.Empty)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void Ende()
        {
            lblRunde.Text = String.Format("Spieler {0} hat \r\n gewonnen!", spieler);

            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name != "btnNeu")
                {
                    c.Enabled = false;
                }
            }
            btnNeu.Visible = true;
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            spieler = "X";
            lblRunde.Text = String.Format("Du bist dran, {0}", spieler);

            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name != "btnNeu")
                {
                    c.Enabled = true;
                    c.Text = String.Empty;
                }
            }
            btnNeu.Visible = false;
        }
    }
}
