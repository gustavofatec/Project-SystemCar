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
    public partial class TelaDeCadastro : Form {
        Thread nt2;
        
        public TelaDeCadastro() {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Cliente cadastrado com sucesso !!","Cadastro");
            this.Close();
            nt2 = new Thread(FormAluguel);
            nt2.SetApartmentState(ApartmentState.STA);
            nt2.Start();
        }

        private void FormAluguel() {
            Application.Run(new TelaAluguel());
        }
    }
}
