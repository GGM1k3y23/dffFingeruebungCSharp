using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dffFingeruebungCSharp
{
    public partial class frmSpielfeld : Form
    {
        string spieler = "X";

        public frmSpielfeld()
        {
            InitializeComponent();

            
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

            lblRunde.Text = String.Format("Du bist dran, {0}", spieler);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;

            clickedButton.Text = spieler;
            spieler = spieler == "X" ? "O" : "X";
            lblRunde.Text = String.Format("Du bist dran, {0}", spieler);

            // MessageBox.Show("Click durch: " + clickedButton.Name.ToString() );
        }
    }
}
