using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using AMRConnector;

namespace Hotel
{
    public partial class FormLogin : Form
    {
        DbConnector db;
        public FormLogin()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Mostrar Senha");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Esconder Senha");

        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool check = db.hotel(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Por favor preencha todos os campos.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (check)
                {
                    FormDashboard fd = new FormDashboard();
                    fd.Username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    fd.Show();
                }
                else
                    MessageBox.Show("Usuário ou senha inválidos.", "Usuário ou senha inválidos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
