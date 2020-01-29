using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCF_Cars
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CarService.svc or CarService.svc.cs at the Solution Explorer and start debugging.
    public class CarService : ICarService
    {
        DatbaseConnection dbConnection = new DatbaseConnection();

        public void DoWork()
        {
        }

        public void AddCar(Car car, string guid)
        {
           
            string connectionString = "server=localhost;user id=root;database=cars";
            MySqlConnection connection = new MySqlConnection(connectionString);

            lock (Host.loggedIn)
            {
                if (Host.loggedIn.Contains(guid))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = connection;

                        command.CommandText = "INSERT INTO CarsTable (brand,type, plate_number,age) VALUES ( @Brand, @Type, @PlateNumber, @Age)";
                        command.Parameters.AddWithValue("Brand", car.Brand.ToString());
                        command.Parameters.AddWithValue("Type", car.Tpye.ToString());
                        command.Parameters.AddWithValue("PlateNumber", car.PlateNumber.ToString());
                        command.Parameters.AddWithValue("Age", car.Age);

                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        throw new Exception("Hiba történt: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            

        }

        public void DeleteCar(int Id, string guid)
        {
            string connectionString = "server=localhost;user id=root;database=cars";
            MySqlConnection connection = new MySqlConnection(connectionString);

            lock (Host.loggedIn)
            {
                if (Host.loggedIn.Contains(guid))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = connection;

                        command.CommandText = "DELETE FROM CarsTable WHERE id = @id";
                        command.Parameters.AddWithValue("Id", Id);

                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        throw new Exception("Hiba történt: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        
        public List<Car> GetAllCar(string guid)
        {
            List<Car> CarsList = new List<Car>();
            string connectionString = "server=localhost;user id=root;database=cars";
            MySqlConnection connection = new MySqlConnection(connectionString);

            lock (Host.loggedIn)
            {
                if (Host.loggedIn.Contains(guid))
                {
                    try
                    {
                        connection.Open();

                        string sqlString = "SELECT * FROM CarsTable";
                        MySqlCommand cmd = new MySqlCommand(sqlString, connection);
                        cmd.ExecuteNonQuery();
                        MySqlDataReader rdr = cmd.ExecuteReader();

                        List<Car> list = new List<Car>();
                        while (rdr.Read())
                        {
                            Car c = new Car();

                            c.Id = int.Parse(rdr[0].ToString());
                            c.Brand = rdr[1].ToString();
                            c.Tpye = rdr[2].ToString(); ;
                            c.PlateNumber = rdr[3].ToString(); ;
                            c.Age = int.Parse(rdr[4].ToString());

                            list.Add(c);
                        }

                        return list;
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Hiba: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }


           
        }

        public Car SearchCarById(int id, string guid)
        {
            string connectionString = "server=localhost;user id=root;database=cars";
            MySqlConnection connection = new MySqlConnection(connectionString);

            lock (Host.loggedIn)
            {
                if (Host.loggedIn.Contains(guid))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = connection;

                        command.CommandText = "SELECT * FROM CarsTable WHERE Id= @Id";
                        command.Parameters.AddWithValue("Id", id);

                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();

                        Car returnCar = new Car();
                        MySqlDataReader rdr = command.ExecuteReader();
                        while (rdr.Read())
                        {
                            returnCar.Id = int.Parse(rdr[0].ToString());
                            returnCar.Brand = rdr[1].ToString();
                            returnCar.Tpye = rdr[2].ToString();
                            returnCar.PlateNumber = rdr[3].ToString();
                            returnCar.Age = int.Parse(rdr[4].ToString());
                        }

                        return returnCar;

                    }
                    catch (Exception e)
                    {
                        throw new Exception("Hiba történt: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    throw new Exception();
                }

            }
        }
        
        public Car YoungestCar(string guid)
        { 
            string connectionString = "server=localhost;user id=root;database=cars";
            MySqlConnection connection = new MySqlConnection(connectionString);

            lock (Host.loggedIn)
            {
                if (Host.loggedIn.Contains(guid))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = connection;

                        command.CommandText = "SELECT * FROM `carstable` WHERE age = (SELECT MIN(age) FROM carstable)";


                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();

                        Car returnCar = new Car();
                        MySqlDataReader rdr = command.ExecuteReader();
                        while (rdr.Read())
                        {
                            returnCar.Id = int.Parse(rdr[0].ToString());
                            returnCar.Brand = rdr[1].ToString();
                            returnCar.Tpye = rdr[2].ToString();
                            returnCar.PlateNumber = rdr[3].ToString();
                            returnCar.Age = int.Parse(rdr[4].ToString());
                        }

                        return returnCar;

                    }
                    catch (Exception e)
                    {
                        throw new Exception("Hiba történt: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public Car OldestCar(string guid)
        {
            string connectionString = "server=localhost;user id=root;database=cars";
            MySqlConnection connection = new MySqlConnection(connectionString);

            lock (Host.loggedIn)
            {
                if (Host.loggedIn.Contains(guid))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = connection;

                        command.CommandText = "SELECT * FROM `carstable` WHERE age = (SELECT MAX(age) FROM carstable)";

                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();

                        Car returnCar = new Car();
                        MySqlDataReader rdr = command.ExecuteReader();
                        while (rdr.Read())
                        {
                            returnCar.Id = int.Parse(rdr[0].ToString());
                            returnCar.Brand = rdr[1].ToString();
                            returnCar.Tpye = rdr[2].ToString();
                            returnCar.PlateNumber = rdr[3].ToString();
                            returnCar.Age = int.Parse(rdr[4].ToString());
                        }

                        return returnCar;

                    }
                    catch (Exception e)
                    {
                        throw new Exception("Hiba történt: " + e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }   
        }

        public string Login(string username, string password)
        {
           try
            {
                if ((username == "admin" && password == "admin") || (username == "root" && password == "root"))
                {
                    string str = Guid.NewGuid().ToString();
                    lock (Host.loggedIn)
                    {
                        Host.loggedIn.Add(str);
                    }
                    return str;
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Logout(string guid)
        {
            try
            {
                if (GuidHas(guid))
                {
                    lock (Host.loggedIn)
                    {
                        if (Host.loggedIn.Contains(guid))
                        {
                            Host.loggedIn.Remove(guid);
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool GuidHas(string guid)
        {
            try
            {
                if (Host.loggedIn.Contains(guid))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GuidReturn()
        {
            string help = "";
            try
            {
                if (Host.loggedIn.Count != 0)
                {
                    return Host.loggedIn[0];
                }
                
                else return help;
            } 
            catch (Exceptions.NotLoggedIn ex)
            {
                throw new Exceptions.NotLoggedIn("Lépj be" + ex.Message);
            }
        }
        


    }
}
