using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Car_Client.MyCarService;

namespace WCF_Car_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string logged;
            CarServiceClient localClient = new CarServiceClient();
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();

            logged = localClient.Login(username, password);
            
            if (localClient.GuidHas(logged))
            {
                MessageBox.Show("Sikeres belépés!");
                this.Hide();
                Form1 form = new WCF_Car_Client.Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Sikertelen belépés!");
            }
            
        }
    }
}
