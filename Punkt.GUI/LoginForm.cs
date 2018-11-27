using Punkt.Model.DAL;
using System;
using System.Windows.Forms;

namespace Punkt.GUI
{
    public partial class LoginForm : Form
    {

        SaleRepository _repo;
        bool _autoLogin;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Login(tbUser.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login_btnOk_Click");
            }
        }

        private void Login(string user, string pass)
        {
            this.Hide();

            try
            {
                _repo = new SaleRepository();
                var userObj = _repo.GetUser(user);
                if (userObj.Password == pass)
                {
                    Globals.LoggedAsId = userObj;
                    using (var dlg = new InputForm())
                    {
                        dlg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login_Method");
            }
            finally
            {
                if (_autoLogin)
                {
                    Application.Exit();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            try
            {
                var autoLoginString = System.Configuration.ConfigurationSettings.AppSettings.Get("AutoLogin");
                if (bool.TryParse(autoLoginString, out _autoLogin) && _autoLogin)
                {
                    var usr = System.Configuration.ConfigurationSettings.AppSettings.Get("User");
                    var pass = System.Configuration.ConfigurationSettings.AppSettings.Get("Password");

                    Login(usr, pass);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoginForm_Activated");
            }


#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
