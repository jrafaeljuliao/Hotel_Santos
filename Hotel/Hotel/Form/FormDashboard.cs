using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Você deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
            buttonReservas.Hide();
            buttonDashboard.Hide();

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();

        }
        private void buttonQuartos_Click(object sender, EventArgs e)
        {
            MovePanel(buttonQuartos);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Clear();
            userControlRoom1.Show();
        }
        private void buttonReservas_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservas);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void userControlRoom1_Load(object sender, EventArgs e)
        {

        }
    }
}
