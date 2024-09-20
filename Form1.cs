using System;
using System.Windows.Forms;

namespace MaquinaAdecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string machineCode = txtMachineCode.Text.Trim();
                    string[] tokens = machineCode.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string resultado = "";

                    foreach (string token in tokens)
                    {
                        if (token.Length % 2 != 0) continue; 
                        int value = Convert.ToInt32(token, 16); 
                        resultado += $"{token} -> {value}\n"; 
                    }

                    lblResultado.Text = resultado; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); 
                }
            }
        }
    }
}
