using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tb_usuario.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tb_senha.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process IniciarLink = new System.Diagnostics.Process();
            IniciarLink.StartInfo = 
                new System.Diagnostics.ProcessStartInfo(@"http://www.facebook.com");
            IniciarLink.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process IniciarLink = new System.Diagnostics.Process();
            IniciarLink.StartInfo =
                new System.Diagnostics.ProcessStartInfo(@"http://www.instagram.com");
            IniciarLink.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process IniciarLink = new System.Diagnostics.Process();
            IniciarLink.StartInfo =
                new System.Diagnostics.ProcessStartInfo(@"https://www.whatsapp.com/?lang=pt_BR");
            IniciarLink.Start();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String user, senha, userDigitado, senhaDigitada;
            user = "alpha";
            senha = "123";

            userDigitado = tb_usuario.Text;
            senhaDigitada = tb_senha.Text;

            if(user.Equals(userDigitado)& senha.Equals(senhaDigitada))
            {
                this.Visible = false;
                TelaPrincipal telaInicial = new TelaPrincipal();
                telaInicial.Show();
                
            }
            else
            {
                tb_status.Text = "Login ou senha incorreta";
            }
          
        }

        private void tb_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                String user, senha, userDigitado, senhaDigitada;
                user = "alpha";
                senha = "123";

                userDigitado = tb_usuario.Text;
                senhaDigitada = tb_senha.Text;

                if (user.Equals(userDigitado) & senha.Equals(senhaDigitada))
                {
                    this.Visible = false;
                    TelaPrincipal telaInicial = new TelaPrincipal();
                    telaInicial.Show();

                }
                else
                {
                    tb_status.Text = "Login ou senha incorreta";
                }
            }
        }
    }
}
