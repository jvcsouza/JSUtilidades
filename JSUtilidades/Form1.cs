using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSUtilidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboMedidas_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMedidas.Focus();
            switch (cboMedidas.Text.ToLower())
            {
                case "kb":
                    txtgb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) / 1e+6);
                    txtkb.Text = txtMedidas.Text;
                    txtmb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) / 1000);
                    txttb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) / 1e+9);
                    lblGb.Text = "Gigabytes  ( Kb / 1e+6 )";
                    lblKb.Text = "Kilobytes  ( Kb )";
                    lblMb.Text = "Megabytes  ( Kb / 1000 )";
                    lblTb.Text = "Terabytes  ( Kb / 1e+9 )";
                    break;
                case "mb":
                    txtgb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) / 1000);
                    txtkb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) * 1000);
                    txtmb.Text = txtMedidas.Text;
                    txttb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) / 1e+6);
                    lblGb.Text = "Gigabytes  ( Mb / 1000 )";
                    lblKb.Text = "Kilobytes  ( Mb * 1000 )";
                    lblMb.Text = "Megabytes  ( Mb )";
                    lblTb.Text = "Terabytes  ( Mb / 1e+6 )";
                    break;
                case "gb":
                    txtgb.Text = txtMedidas.Text;
                    txtkb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) * 1e+6);
                    txtmb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) * 1000);
                    txttb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) / 1000);
                    lblGb.Text = "Gigabytes  ( Gb )";
                    lblKb.Text = "Kilobytes  ( Gb * 1e+6 )";
                    lblMb.Text = "Megabytes  ( Gb * 1000 )";
                    lblTb.Text = "Terabytes  ( Gb / 1000 )";
                    break;
                case "tb":
                    txtgb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) * 1000);
                    txtkb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) * 1e+9);
                    txtmb.Text = Convert.ToString(Convert.ToDouble(txtMedidas.Text) * 1e+6);
                    txttb.Text = txtMedidas.Text;
                    lblGb.Text = "Gigabytes  ( Tb * 1000 )";
                    lblKb.Text = "Kilobytes  ( Tb * 1e+9 )";
                    lblMb.Text = "Megabytes  ( Tb * 1e+6 )";
                    lblTb.Text = "Terabytes  ( Gb )";
                    break;
                default:
                    txtgb.Text = "0";
                    txtkb.Text = "0";
                    txtmb.Text = "0";
                    txttb.Text = "0";
                    lblGb.Text = "NULL";
                    lblKb.Text = "NULL";
                    lblMb.Text = "NULL";
                    lblTb.Text = "NULL";
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHr.Text = "    " + DateTime.Now;
        }

        private void txtMedidas_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMedidas.Text))
                txtMedidas.Text = "0";
            try { Int32.Parse(txtMedidas.Text); }
            catch (FormatException ex) { 
                txtMedidas.Text = txtMedidas.Text.Remove(txtMedidas.Text.Length -1);
                txtMedidas.Select(txtMedidas.Text.Length, txtMedidas.Text.Length);
            }
            cboMedidas_SelectedValueChanged(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMedidas.SelectedItem = "MB";
        }
    }
}
