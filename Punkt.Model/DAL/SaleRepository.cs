using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Punkt.Model.DAL
{
    public class SaleRepository
    {
        SQLiteConnection m_dbConnection;
        private bool _notConnected
        {
            get
            {
                return m_dbConnection.State == System.Data.ConnectionState.Closed;
            }
        }

        public SaleRepository(string filePath = "SaleDb")
        {
            if (!File.Exists(filePath + ".sqlite"))
                SQLiteConnection.CreateFile(filePath + ".sqlite");

            m_dbConnection = new SQLiteConnection(string.Format("Data Source={0}.sqlite;Version=3;", filePath));

            CheckTables();
        }

        private void CheckTables()
        {
            if (_notConnected)
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
            if (_notConnected)
                m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);

            if (entity.Id == 0)
            {
                cmd.CommandText = QueryRepo.CreateSale;
                AddParameter(cmd, "@CreatedOn", entity.CreatedOn);
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

        public int AddOrUpdate(Car entity)
        {
            var objId = 0;
            if (_notConnected)
                m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);

            if (entity.Id == 0)
            {
                cmd.CommandText = QueryRepo.CreateCar;
                AddParameter(cmd, "@CreatedOn", DateTime.Now);
                AddParameter(cmd, "@NumberPlate", entity.NumberPlate);
                AddParameter(cmd, "@Category", entity.Category);
                AddParameter(cmd, "@OwnerId", entity.OwnerId);
            }
            else
            {
                cmd.CommandText = QueryRepo.UpdateSale;
            }

            cmd.ExecuteNonQuery();
            objId = (int)m_dbConnection.LastInsertRowId;
            m_dbConnection.Close();

            return objId;
        }
        public int AddOrUpdate(Owner entity)
        {
            var objId = 0;
            if (_notConnected)
                m_dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);

            if (entity.Id == 0)
            {
                cmd.CommandText = QueryRepo.CreateOwner;
                AddParameter(cmd, "@CreatedOn", DateTime.Now);
                AddParameter(cmd, "@FirstName", entity.FirstName);
                AddParameter(cmd, "@LastName", entity.LastName);
                AddParameter(cmd, "@Telephone", entity.Telephone);
            }
            else
            {
                cmd.CommandText = QueryRepo.UpdateSale;
            }

            cmd.ExecuteNonQuery();
            objId = (int)m_dbConnection.LastInsertRowId;
            m_dbConnection.Close();

            return objId;
        }
        public void AddOrUpdate(Employee entity)
        {

        }

        public List<Sale> GetSales()
        {
            var retCollection = new List<Sale>();

            if (_notConnected)
                m_dbConnection.Open();

            var cmd = new SQLiteCommand(QueryRepo.SelectSale, m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    var sale = new Sale();
                    GetBaseEntityProperties(dataReader, sale);
                    sale.Note = dataReader["Note"].ToString();
                    sale.Price = Decimal.Parse(dataReader["Price"].ToString());
                    sale.CreatedBy = int.Parse(dataReader["CreatedBy"].ToString());
                    sale.CarId = int.Parse(dataReader["CarId"].ToString());
                    sale.Car = GetCarById(sale.CarId, false);
                    retCollection.Add(sale);
                }
            }
            m_dbConnection.Close();

            return retCollection;
        }

        public List<string> GetNumbers()
        {
            var retList = new List<string>();
            if (_notConnected)
                m_dbConnection.Open();

            var cmd = new SQLiteCommand(QueryRepo.SelectNumbers, m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    retList.Add(dataReader["NumberPlate"].ToString());
                }
            }

            m_dbConnection.Close();
            return retList;
        }

        public Car GetCarByNumber(string number)
        {
            Car retObj = new Car();
            if (_notConnected)
                m_dbConnection.Open();

            var cmd = new SQLiteCommand(string.Format(QueryRepo.SelectCarWithNum, number), m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    GetBaseEntityProperties(dataReader, retObj);
                    retObj.NumberPlate = dataReader["NumberPlate"].ToString();
                    retObj.Category = dataReader["Category"].ToString();
                    retObj.OwnerId = (int.Parse(dataReader["OwnerId"].ToString()));
                    retObj.Owner = GetOwnerById(retObj.OwnerId, true);
                }
            }

            m_dbConnection.Close();
            return retObj;
        }

        public Car GetCarById(int id, bool closeConnection = true)
        {
            Car retObj = new Car();
            if (_notConnected)
                m_dbConnection.Open();

            var cmd = new SQLiteCommand(string.Format(QueryRepo.SelectCarWithId, id), m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    GetBaseEntityProperties(dataReader, retObj);
                    retObj.NumberPlate = dataReader["NumberPlate"].ToString();
                    retObj.Category = dataReader["Category"].ToString();
                    retObj.OwnerId = (int.Parse(dataReader["OwnerId"].ToString()));
                    retObj.Owner = GetOwnerById(retObj.OwnerId, false);
                }
            }

            if (closeConnection)
                m_dbConnection.Close();
            return retObj;
        }

        public Owner GetOwnerById(int ownerId, bool closeConnection = true)
        {
            Owner retObj = new Owner();
            if (_notConnected)
                m_dbConnection.Open();

            var cmd = new SQLiteCommand(string.Format(QueryRepo.SelectOwnerWithId, ownerId), m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    GetBaseEntityProperties(dataReader, retObj);
                    retObj.FirstName = dataReader["FirstName"].ToString();
                    retObj.LastName = dataReader["LastName"].ToString();
                    retObj.Telephone = dataReader["Telephone"].ToString();
                }
            }

            if (closeConnection)
                m_dbConnection.Close();
            return retObj;
        }

        public void GetBaseEntityProperties(SQLiteDataReader reader, BaseEntity entity)
        {
            entity.Id = (int.Parse(reader["Id"].ToString()));
            var t = reader["CreatedOn"].ToString();
            entity.CreatedOn = DateTime.Parse(reader["CreatedOn"].ToString());
            if (!string.IsNullOrEmpty(reader["UpdatedOn"].ToString()))
            {
                entity.UpdatedOn = DateTime.Parse(reader["UpdatedOn"].ToString());
            }
        }

        public Employee GetUser(string userName, bool closeConnection = true)
        {
            Employee retObj = new Employee();
            if (_notConnected)
                m_dbConnection.Open();

            var cmd = new SQLiteCommand(string.Format(QueryRepo.SelectEmployeeWithName, userName), m_dbConnection);
            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    GetBaseEntityProperties(dataReader, retObj);
                    retObj.Name = dataReader["Name"].ToString();
                    retObj.Password = dataReader["Pass"].ToString();
                    retObj.Location = dataReader["Location"].ToString();
                    retObj.Roles = dataReader["Roles"].ToString();
                }
            }

            if (closeConnection)
                m_dbConnection.Close();
            return retObj;
        }
    }
}
