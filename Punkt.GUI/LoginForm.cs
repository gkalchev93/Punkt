using Punkt.Model.DAL;
using System;
using System.Windows.Forms;

namespace Punkt.GUI
{
    public partial class LoginForm : Form
    {

        SaleRepository _repo;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //_repo = new SaleRepository();
                this.Hide();
                using (var dlg = new InputForm())
                {
                    dlg.ShowDialog();
                }
                this.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
