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

        AutoCompleteStringCollection autoCompleteStrings;
        public InputForm()
        {
            try
            {
                InitializeComponent();
                saleRepo = new SaleRepository();
                RefreshGrid();

                GetSuggestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void GetSuggestions()
        {
            autoCompleteStrings = new AutoCompleteStringCollection();
            foreach (var num in saleRepo.GetNumbers())
            {
                autoCompleteStrings.Add(num);
            }
            tbNumber.AutoCompleteCustomSource = autoCompleteStrings;
        }

        private void RefreshGrid()
        {
            salesList = saleRepo.GetSalesWhere("date(CreatedOn)", "date('now')");
            dgSales.Rows.Clear();

            foreach (var s in salesList)
            {
                dgSales.Rows.Add(s.CreatedOn.ToShortDateString(), s.CreatedOn.ToShortTimeString(), s.Car.NumberPlate, s.Car.Owner.FullName, s.Car.Owner.Telephone, s.Note, s.Car.Category, s.Price);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                var sale = new Sale()
                {
                    CreatedOn = DateTime.Now,
                    Note = tbNote.Text,
                    Price = Decimal.Parse(tbPrice.Text),
                    Car = new Car()
                    {
                        NumberPlate = tbNumber.Text,
                        Category = tbCategory.Text,
                        Owner = new Owner()
                        {
                            FullName = tbName.Text,
                            Telephone = tbPhone.Text
                        }
                    }
                };

                sale.Car.OwnerId = saleRepo.AddOrUpdate(sale.Car.Owner);
                sale.CarId = saleRepo.AddOrUpdate(sale.Car);
                sale.CreatedBy = Globals.LoggedAsId.Id;
                saleRepo.AddOrUpdate(sale);
                RefreshGrid();
                ClearGui();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void ClearGui()
        {
            tbNumber.Text = string.Empty;
            tbName.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbNote.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbCategory.Text = string.Empty;
        }

        private void tbNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var car = saleRepo.GetCarByNumber(tbNumber.Text);
                tbName.Text = car.Owner.FullName;
                tbPhone.Text = car.Owner.Telephone;
                tbCategory.Text = car.Category;
            }
        }
    }
}
