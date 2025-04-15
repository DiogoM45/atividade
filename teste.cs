using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devesaoDF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiro.Clear();
            txtSegundo.Clear();
            txtResult.Clear();
            txtPrimeiro.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           double num1, num2, result;
            
            num1 = Convert.ToDouble(txtPrimeiro.Text);
            num2 = Convert.ToDouble(txtSegundo.Text);
            result = num1 / num2;

            txtResult.Text = result.ToString();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
