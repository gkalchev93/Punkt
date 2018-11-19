using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Punkt.Model.DAL
{
    public class SaleRepository
    {
        SQLiteConnection m_dbConnection;

        public SaleRepository(string filePath = "SaleDb")
        {
            if (!File.Exists(filePath + ".sqlite"))
                SQLiteConnection.CreateFile(filePath + ".sqlite");

            m_dbConnection = new SQLiteConnection(string.Format("Data Source={0}.sqlite;Version=3;", filePath));

            CheckTables();
        }

        private void CheckTables()
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);

            if (!CheckTableExist(cmd, "Employees"))
            {
                cmd.CommandText = QueryRepo.CreateEmployeeTable;
                cmd.ExecuteNonQuery();
            }

            if (!CheckTableExist(cmd, "Owners"))
            {
                cmd.CommandText = QueryRepo.CreateOwnerTable;
                cmd.ExecuteNonQuery();
            }

            if (!CheckTableExist(cmd, "Cars"))
            {
                cmd.CommandText = QueryRepo.CreateCarTable;
                cmd.ExecuteNonQuery();
            }

            if (!CheckTableExist(cmd, "Sales"))
            {
                cmd.CommandText = QueryRepo.CreateSaleTable;
                cmd.ExecuteNonQuery();
            }

            m_dbConnection.Close();
        }

        private bool CheckTableExist(SQLiteCommand cmd, string tableName)
        {
            cmd.CommandText = string.Format(QueryRepo.CheckTableExist, tableName);
            var res = cmd.ExecuteScalar();
            return res != null;
        }

        public void AddOrUpdate(Sale entity)
        {
            m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);

            if (entity.Id == 0)
            {
                cmd.CommandText = QueryRepo.CreateSale;
                AddParameter(cmd, "@CreatedOn", "10/10/2018");
                AddParameter(cmd, "@Note", entity.Note);
                AddParameter(cmd, "@Price", entity.Price);
                AddParameter(cmd, "@CreatedBy", entity.CreatedBy);
                AddParameter(cmd, "@CarId", entity.CarId);
            }
            else
            {
                cmd.CommandText = QueryRepo.UpdateSale;
            }

            cmd.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private void AddParameter(SQLiteCommand cmd, string parameterName, object parameterValue)
        {
            var parameter = new SQLiteParameter(parameterName, parameterValue);
            cmd.Parameters.Add(parameter);
            //cmd.Parameters["@Created"].Value = parameterValue;
        }

        public void AddOrUpdate(Car entity)
        {

        }
        public void AddOrUpdate(Owner entity)
        {

        }
        public void AddOrUpdate(Employee entity)
        {

        }

        public List<Sale> GetSales()
        {
            var retCollection = new List<Sale>();

            m_dbConnection.Open();
            var cmd = new SQLiteCommand(QueryRepo.SelectSale, m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    var sale = new Sale();
                    sale.Id = int.Parse(dataReader["Id"].ToString());
                    sale.CreatedOn = DateTime.Parse(dataReader["CreatedOn"].ToString());
                    if (!string.IsNullOrEmpty(dataReader["UpdatedOn"].ToString()))
                    {
                        sale.UpdatedOn = DateTime.Parse(dataReader["UpdatedOn"].ToString());
                    }

                    sale.Note = dataReader["Note"].ToString();
                    sale.Price = Decimal.Parse(dataReader["Price"].ToString());
                    sale.CreatedBy = int.Parse(dataReader["CreatedBy"].ToString());
                    sale.CarId = int.Parse(dataReader["CarId"].ToString());
                    retCollection.Add(sale);
                }
            }
            m_dbConnection.Close();

            return retCollection;
        }
    }
}
