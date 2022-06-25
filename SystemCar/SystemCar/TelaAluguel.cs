using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemCar {
    public partial class TelaAluguel : Form {
        public TelaAluguel() {
            InitializeComponent();
        }

        private void TelaAluguel_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int num1, num2, num3, resultado;
            num1 = Convert.ToInt32(textBox2.Text);
            num2 = Convert.ToInt32(textBox1.Text);
            num3 = Convert.ToInt32(textBox3.Text);            

            resultado = num1 + (num2 * num3);
            MessageBox.Show("Valor total a pagar: R$ " + resultado,"VALOR TOTAL",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DialogResult resposta =  MessageBox.Show("Deseja alugar o carro?", "DECISÃO", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes) {
                MessageBox.Show("Carro Alugado com sucesso !!");
            }
            else {
                MessageBox.Show("Obrigado !!");
            };

           

            
        }
    }
}
