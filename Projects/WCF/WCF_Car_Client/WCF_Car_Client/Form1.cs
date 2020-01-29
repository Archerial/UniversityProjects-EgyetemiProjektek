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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient HelperClient = new CarServiceClient();
            string guid = HelperClient.GuidReturn();

            if (HelperClient.GuidHas(guid))
            {
                try
                {
                    Car c = new Car();

                    c.Brand = textBoxBrand.Text.ToString();
                    c.Tpye = textBoxType.Text.ToString();
                    c.PlateNumber = textBoxPlateNumber.Text.ToString();
                    c.Age = int.Parse(textBoxAge.Text.ToString());

                    localClient.AddCar(c, guid);

                    MessageBox.Show("Hozzáadva!");

                    textBoxBrand.Text = String.Empty.ToString();
                    textBoxType.Text = String.Empty.ToString();
                    textBoxPlateNumber.Text = String.Empty.ToString();
                    textBoxAge.Text = String.Empty.ToString();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    localClient.Close();
                }
            }
            else MessageBox.Show("A használatához előbb jelentkezz be!!!");




        }

        private void buttonListAllCar_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Brand", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Plate number", typeof(string));
            table.Columns.Add("Age", typeof(int));

            

            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient HelperClient = new CarServiceClient();
            string guid = HelperClient.GuidReturn();

            if (HelperClient.GuidHas(guid))
            {
                localClient.Open();

                try
                {
                    List<Car> currentCars;
                    currentCars = localClient.GetAllCar(guid).ToList();
                    for (int i = 0; i < currentCars.Count; i++)
                    {
                        DataRow dr = table.NewRow();
                        dr["Id"] = currentCars[i].Id;
                        dr["Brand"] = currentCars[i].Brand;
                        dr["Type"] = currentCars[i].Tpye;
                        dr["Plate number"] = currentCars[i].PlateNumber;
                        dr["Age"] = currentCars[i].Age;

                        table.Rows.Add(dr);
                    }

                    dataGridView.DataSource = table;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    localClient.Close();
                }
            }
            else MessageBox.Show("A használatához előbb jelentkezz be!!!");



        }

        private void buttonSearchCarById_Click(object sender, EventArgs e)
        {
            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient HelperClient = new CarServiceClient();
            string guid = HelperClient.GuidReturn();

            if (HelperClient.GuidHas(guid))
            {
                try
                {
                    localClient.Open();

                    Car theCar = localClient.SearchCarById(int.Parse(textBoxId.Text.ToString()), guid);
                    textBoxId.Text = theCar.Id.ToString();
                    textBoxBrand.Text = theCar.Brand;
                    textBoxType.Text = theCar.Tpye;
                    textBoxPlateNumber.Text = theCar.PlateNumber;
                    textBoxAge.Text = theCar.Age.ToString();

                    textBoxId.Text = String.Empty.ToString();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    localClient.Close();
                }
            }
            else MessageBox.Show("A használatához előbb jelentkezz be!!!");



        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient HelperClient = new CarServiceClient();
            string guid = HelperClient.GuidReturn();

            if (HelperClient.GuidHas(guid))
            {
                try
                {
                    localClient.Open();
                    localClient.DeleteCar(int.Parse(textBoxId.Text.ToString()), guid);
                    MessageBox.Show("Sikeres törlés!");
                    textBoxId.Text = String.Empty.ToString();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    localClient.Close();
                }
            }
            else MessageBox.Show("A használatához előbb jelentkezz be!!!");



        }

        private void buttonYoungest_Click(object sender, EventArgs e)
        {
            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient HelperClient = new CarServiceClient();
            string guid = HelperClient.GuidReturn();

            if (HelperClient.GuidHas(guid))
            {

                try
                {
                    localClient.Open();

                    Car theCar = localClient.YoungestCar(guid);
                    textBoxBrand.Text = theCar.Brand;
                    textBoxType.Text = theCar.Tpye;
                    textBoxPlateNumber.Text = theCar.PlateNumber;
                    textBoxAge.Text = theCar.Age.ToString();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    localClient.Close();
                }
            }
            else MessageBox.Show("A használatához előbb jelentkezz be!!!");

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient HelperClient = new CarServiceClient();
            string guid = HelperClient.GuidReturn();

            if (HelperClient.GuidHas(guid))
            {
                try
                {
                    localClient.Open();

                    Car theCar = localClient.OldestCar(guid);
                    textBoxBrand.Text = theCar.Brand;
                    textBoxType.Text = theCar.Tpye;
                    textBoxPlateNumber.Text = theCar.PlateNumber;
                    textBoxAge.Text = theCar.Age.ToString();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    localClient.Close();
                }
            }
            else MessageBox.Show("A használatához előbb jelentkezz be!!!");



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Text = String.Empty.ToString();
            textBoxBrand.Text = String.Empty.ToString();
            textBoxType.Text = String.Empty.ToString();
            textBoxPlateNumber.Text = String.Empty.ToString();
            textBoxAge.Text = String.Empty.ToString();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            CarServiceClient localClient = new CarServiceClient();
            CarServiceClient localClient2 = new CarServiceClient();
            string guid = localClient2.GuidReturn();
            if (localClient2.GuidHas(guid))
            {
                localClient.Logout(guid);
                textBoxId.Text = String.Empty.ToString();
                textBoxBrand.Text = String.Empty.ToString();
                textBoxType.Text = String.Empty.ToString();
                textBoxPlateNumber.Text = String.Empty.ToString();
                textBoxAge.Text = String.Empty.ToString();
                dataGridView.Columns.Clear();
            
                MessageBox.Show("Sikeres kilépés");
                //this.Hide();
                //LoginForm loginForm = new WCF_Car_Client.LoginForm();
                //loginForm.Show();
            }
            else MessageBox.Show("Sikertelen kilépés!!");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new WCF_Car_Client.LoginForm();
            loginform.Show();
        }

    }
}
