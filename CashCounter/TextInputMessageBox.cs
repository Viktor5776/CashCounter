using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCounter
{
    public partial class TextInputMessageBox : Form
    {
        public string output;

        public TextInputMessageBox( string text, string title )
        {
            InitializeComponent();

            lblHeader.Text = text;
            this.Text = title;
        }

        private void Cancel_Click( object sender, EventArgs e )
        {
            output = "#";
            this.Dispose();
        }

        private void Use_Click( object sender, EventArgs e )
        {
            if(tbxInput.Text == "")
            {
                output = "#";
            }
            else
            {
                output = tbxInput.Text;
            }
            this.Dispose();
        }
    }
}
