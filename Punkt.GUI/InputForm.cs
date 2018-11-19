using Punkt.Model;
using Punkt.Model.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Punkt.GUI
{
    public partial class InputForm : Form
    {
        SaleRepository saleRepo;
        List<Sale> salesList;
        public InputForm()
        {
            InitializeComponent();
            saleRepo = new SaleRepository();
            salesList = saleRepo.GetSales();
        }

        private void RefreshGrid()
        {
            saleRepo.GetSales();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var sale = new Sale()
            {
                CreatedOn = DateTime.Now,
                Note = tbNote.Text,
                Price = Decimal.Parse(tbPrice.Text),
                CarId = 1,
                CreatedBy = 1
            };

            saleRepo.AddOrUpdate(sale);
        }
    }
}
