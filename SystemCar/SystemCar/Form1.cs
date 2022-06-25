using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SystemCar {
    public partial class Form1 : Form {
        Thread nt;        
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "gustavo" && textBox2.Text == "1234") {
                MessageBox.Show("Bem vindo ao sistema !!");
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            else {
                MessageBox.Show("Login ou senha invalidos !!");
            };
        }

        private void novoForm() {
            Application.Run(new TelaDeCadastro());
        }
    }
}
