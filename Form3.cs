using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string TheCount
        {
            get { return txtCount.Text; }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
           // Form form2 = obj as Form;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }
    }
}
