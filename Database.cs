using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    internal class Database
    {

        public static string connectionString = "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=TESLA CAR INVENTORY MANAGEMENT;Password=shayan;";

        //USERS

        public static bool AddUser(Users U)
        {

            string query = @"INSERT INTO USERS (USERID, USERNAME, PASSWORD, USERTYPE, EMAIL, PHONENUMBER)
                      VALUES (:id, :username, :password, :usertype, :email, :phone)";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", Convert.ToInt32(U.UserId));
                cmd.Parameters.Add(":username", U.UserName);
                cmd.Parameters.Add(":password", U.Password);
                cmd.Parameters.Add(":usertype", U.UserType);
                cmd.Parameters.Add(":email", U.Email);
                cmd.Parameters.Add(":phone", U.PhoneNumber);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }

        public static bool UpdateUser(Users U)
        {
            string query = @"UPDATE USERS SET USERNAME = :username, PASSWORD = :password, USERTYPE = :usertype, EMAIL = :email, PHONENUMBER = :phone WHERE USERID = :id";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                
                cmd.Parameters.Add(":username", U.UserName);
                cmd.Parameters.Add(":password", U.Password);
                cmd.Parameters.Add(":usertype", U.UserType);
                cmd.Parameters.Add(":email", U.Email);
                cmd.Parameters.Add(":phone", U.PhoneNumber);
                cmd.Parameters.Add(":id", Convert.ToInt32(U.UserId));
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
        }
        public static bool UpdateUserProfile(Users user)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            string query = @"UPDATE USERS 
                 SET USERNAME = :username, EMAIL = :email, PHONENUMBER = :phone, PASSWORD = :password
                 WHERE USERID = :userid";

            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":username", user.UserName);
            cmd.Parameters.Add(":email", user.Email);
            cmd.Parameters.Add(":phone", user.PhoneNumber);
            cmd.Parameters.Add(":password", user.Password);
            cmd.Parameters.Add(":userid", user.UserId);
            conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
        }
       
        public static Users GetUserById(int id)
        {
            string query = "SELECT * FROM USERS WHERE USERID = :id";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", id);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Users user = new Users(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5)
                    );
                    return user;
                }
                conn.Close();
            }
            return null;
        }

        public static int GetUniqueID(string tableName)
        {
            using(OracleConnection con = new OracleConnection(connectionString))
            {
                tableName = tableName.ToLower();
                string query;
                if (tableName == "users")
                {
                    query = "SELECT MAX(USERID) + 1 FROM USERS";
                }
                else if(tableName == "suppliers")
                {
                     query = "SELECT MAX(SUPPLIERID) + 1 FROM SUPPLIERS";
                }
                else if (tableName == "cars")
                {
                    query = "SELECT MAX(CARID) + 1 FROM CARS";
                }
                else if (tableName == "car_sales")
                {
                    query = "SELECT MAX(SALEID) + 1 FROM CAR_SALES";
                }
                else
                {
                    query = "SELECT MAX(ID) + 1 FROM " + tableName.ToUpper();
                }

                con.Open();
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    object val = r[0];
                    if (val != DBNull.Value && int.TryParse(val.ToString(), out int result))
                    {
                        return result;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 1;
                }
            }
        }

        public static List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            string query = "SELECT * FROM USERS";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5)
                    );
                    users.Add(user);
                }
                conn.Close();
            }
            return users;
        }
        

        public static DataTable SearchByUsername(string username)
        {
            string query = "SELECT * FROM USERS WHERE USERNAME LIKE '%' || :username || '%'";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(":username", username);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
        }





        //SUPPLIERS


        public static bool AddSupplier(Suppliers s)
        {
            string query = @"INSERT INTO SUPPLIERS (SUPPLIERID, SUPPLIERNAME, PHONENUMBER, ADDRESS, EMAIL)
                     VALUES (:id, :name, :phone, :address, :email)";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", s.SupplierId);
                cmd.Parameters.Add(":name", s.SupplierName);
                cmd.Parameters.Add(":phone", s.PhoneNumber);
                cmd.Parameters.Add(":address", s.Address);
                cmd.Parameters.Add(":email", s.Email);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                return rows > 0;
            }
        }

        public static bool UpdateSupplier(Suppliers s)
        {
            string query = @"UPDATE SUPPLIERS SET SUPPLIERNAME = :name, PHONENUMBER = :phone, ADDRESS = :address, EMAIL = :email WHERE SUPPLIERID = :id";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":name", s.SupplierName);
                cmd.Parameters.Add(":phone", s.PhoneNumber);
                cmd.Parameters.Add(":address", s.Address);
                cmd.Parameters.Add(":email", s.Email);
                cmd.Parameters.Add(":id", s.SupplierId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                return rows > 0;
            }
        }

        public static List<Suppliers> GetSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            string query = "SELECT * FROM SUPPLIERS";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Suppliers(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3), 
                    reader.GetString(4)
                    ));
                }
                conn.Close();
            }
            return suppliers;
        }

        public static List<Suppliers> SearchSuppliersByName(string name)
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            string query = "SELECT * FROM SUPPLIERS WHERE SUPPLIERNAME LIKE '%' || :name || '%'";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":name", name);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Suppliers(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                    ));
                }
                conn.Close();
            }
            return suppliers;
        }



        //CARS


        public static DataTable SearchCarBymodel(string model)
        {
            string query = "SELECT * FROM CARS WHERE MODELNAME LIKE '%' || :model || '%'";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(":model", model);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static bool AddCar(Cars car)
        {
            string query = @"INSERT INTO CARS (CARID, MODELNAME, ENGINENUMBER, YEARMANUFACTURED, BATTERYCAPACITY, PRICE, STATUS, STOCK, COLOR, CARIMAGE, SUPPLIERID)
                             VALUES (:carid, :modelname, :enginenumber, :yearmanufactured, :batterycapacity, :price, :status, :stock, :color, :carimage, :supplierid)";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":carid", Convert.ToInt32(car.CarId));
                cmd.Parameters.Add(":modelname", car.ModelName);
                cmd.Parameters.Add(":enginenumber", car.EngineNumber);
                cmd.Parameters.Add(":yearmanufactured", car.YearManufactured);
                cmd.Parameters.Add(":batterycapacity", car.BatteryCapacity);
                cmd.Parameters.Add(":price", car.Price);
                cmd.Parameters.Add(":status", car.Status);
                cmd.Parameters.Add(":stock", car.Stock);
                cmd.Parameters.Add(":color", car.Color);
                cmd.Parameters.Add(":carimage", car.CarImage ?? (object)DBNull.Value);
                cmd.Parameters.Add(":supplierid", car.SupplierId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }


        public static byte[] GetCarImage(int carId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT CARIMAGE FROM CARS WHERE CARID = :id";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", carId);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    return (byte[])reader["CARIMAGE"];
                }
            }
            return null;
        }
        public static bool UpdateCar(Cars car)
        {
            string query = @"UPDATE CARS SET MODELNAME = :modelname, ENGINENUMBER = :enginenumber, YEARMANUFACTURED = :yearmanufactured, 
                             BATTERYCAPACITY = :batterycapacity, PRICE = :price, STATUS = :status, STOCK = :stock, COLOR = :color, 
                             CARIMAGE = :carimage, SUPPLIERID = :supplierid WHERE CARID = :carid";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":modelname", car.ModelName);
                cmd.Parameters.Add(":enginenumber", car.EngineNumber);
                cmd.Parameters.Add(":yearmanufactured", car.YearManufactured);
                cmd.Parameters.Add(":batterycapacity", car.BatteryCapacity);
                cmd.Parameters.Add(":price", car.Price);
                cmd.Parameters.Add(":status", car.Status);
                cmd.Parameters.Add(":stock", car.Stock);
                cmd.Parameters.Add(":color", car.Color);
                cmd.Parameters.Add(":carimage", car.CarImage ?? (object)DBNull.Value);
                cmd.Parameters.Add(":supplierid", car.SupplierId);
                cmd.Parameters.Add(":carid", Convert.ToInt32(car.CarId));
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
        }
        

        public static bool DeleteCar(int carid)
        {
            string query = @"DELETE FROM CARS WHERE CARID = :carid";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":carid", Convert.ToInt32(carid));
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
        }
        public static List<Cars> GetCars()
        {
            List<Cars> cars = new List<Cars>();
            string query = "SELECT * FROM CARS";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cars car = new Cars(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        reader.GetDecimal(5),
                        reader.GetString(6),
                        reader.GetInt32(7),
                        reader.GetString(8),
                        reader.IsDBNull(9) ? null : (byte[])reader[9],
                        reader.GetInt32(10)
                    );
                    cars.Add(car);
                }
                conn.Close();
            }
            return cars;
        }



        //CAR SALES

        public static List<Car_Sales> GetTransactionsByUser(int userId)
        {
            List<Car_Sales> transactions = new List<Car_Sales>();
            string query = "SELECT SALEID, DATESOLD, CARID, USERID FROM CAR_SALES WHERE USERID = :userId";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":userId", userId);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car_Sales t = new Car_Sales(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetDateTime(3)
                    );
                    transactions.Add(t);
                }
                conn.Close();
            }
            return transactions;
        }

        //loads sold cars in grid
        public static List<(int SaleId, int UserId, int CarId, string ModelName, string Color, int YearManufactured, decimal Price, DateTime DateSold)> GetCarSales()
        {
            var sales = new List<(int, int, int, string, string, int, decimal, DateTime)>();
            string query = @"SELECT cs.SALEID, cs.USERID, cs.CARID, c.MODELNAME, c.COLOR, c.YEARMANUFACTURED, c.PRICE, cs.DATESOLD
                            FROM CAR_SALES cs
                            JOIN CARS c ON cs.CARID = c.CARID";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sales.Add((
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetInt32(5),
                        reader.GetDecimal(6),
                        reader.GetDateTime(7)
                    ));
                }
                conn.Close();
            }
            return sales;
        }

        public static DataTable SearchCarSalesByCarId(string carIdPart)
        {
            string query = "SELECT * FROM CAR_SALES WHERE TO_CHAR(CARID) LIKE :carId";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(":carId", "%" + carIdPart + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchCarSalesByUserId(string userIdPart)
        {
            string query = "SELECT * FROM CAR_SALES WHERE TO_CHAR(USERID) LIKE :userId";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(":userId", "%" + userIdPart + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchCarSalesByDateSold(string dateSoldPart)
        {
            string query = "SELECT * FROM CAR_SALES WHERE TO_CHAR(DATESOLD, 'YYYY-MM-DD') LIKE :dateSold";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.Add(":dateSold", "%" + dateSoldPart + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static bool DecreaseStock (int carId, int userid)
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            OracleTransaction transaction = conn.BeginTransaction();

           
                string updateStockQuery = "UPDATE CARS SET STOCK = STOCK - 1 WHERE CARID = :carId AND STOCK > 0";
                using (OracleCommand cmd1 = new OracleCommand(updateStockQuery, conn))
                {
                    cmd1.Transaction = transaction;
                    cmd1.Parameters.Add("carId", carId);

                    int rowsAffected = cmd1.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("This car is out of stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return false;
                    }
                }

                string insertSaleQuery = $"INSERT INTO CAR_SALES (SALEID, CARID, USERID, DATESOLD) VALUES ({GetUniqueID("Car_Sales")}, :carId, :userId, SYSDATE)";
                using (OracleCommand cmd2 = new OracleCommand(insertSaleQuery, conn))
                {
                    cmd2.Transaction = transaction;
                    cmd2.Parameters.Add("carId", carId);
                    cmd2.Parameters.Add("userId", userid);
                    cmd2.ExecuteNonQuery();
                }

                transaction.Commit();
                
                return true;
                
            
        }
    }
}
