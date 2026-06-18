using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_Release
{
    public partial class DialogForm : Form
    {
        private TransferOfImpurities transferOfImpurities;
        private Label labelCount;
        public DialogForm(TransferOfImpurities transfer, Label label)
        {
            transferOfImpurities = transfer;
            labelCount = label;
            InitializeComponent();
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && (number != 8) && (number != 44) && (number != 45))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && (number != 8) && (number != 44) && (number != 45))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && (number != 8) && (number != 44) && (number != 45))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                transferOfImpurities.Sources.Add(TransferOfImpurities.NewSource(int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text), int.Parse(textBox3.Text)));

                labelCount.Text = transferOfImpurities.Sources.Count().ToString();

                this.Close();
            }
            else
                MessageBox.Show("Заполните все поля!");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
