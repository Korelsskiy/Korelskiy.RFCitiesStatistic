using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korelskiy.RFCitiesStatistic
{
    public class DbManager
    {
        private readonly SqlConnection connection;

        public DbManager()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CitiesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public void AddCity(City city)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Cities " +
                    "(Name, FirstYear, SecondYear, FirstYearPopulation, SecondYearPopulation, NumberOfYears, FullChange, OneYearChange) VALUES " +
                    "(@Name, @FirstYear, @SecondYear, @FirstYearPopulation, @SecondYearPopulation, @NumberOfYears, @FullChange, @OneYearChange)", connection);
                command.Parameters.AddWithValue("Name", city.Name);
                command.Parameters.AddWithValue("FirstYear", city.FirstYear);
                command.Parameters.AddWithValue("SecondYear", city.SecondYear);
                command.Parameters.AddWithValue("FirstYearPopulation", city.FirstYearPopulation);
                command.Parameters.AddWithValue("SecondYearPopulation", city.SecondYearPopulation);
                command.Parameters.AddWithValue("NumberOfYears", city.NumbersOfYears);
                command.Parameters.AddWithValue("FullChange", Math.Round(city.FullChange,3));
                command.Parameters.AddWithValue("OneYearChange", Math.Round(city.OneYearChange,3));

                command.ExecuteNonQuery();

                MessageBox.Show("Город добавлен в базу данных");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<City> GetCities()
        {
            List<City> cities = new List<City>();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Cities", connection);

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    City city = new City();

                    city.Id = Convert.ToInt32(dataReader["Id"]);
                    city.Name = dataReader["Name"].ToString();
                    city.FirstYear = Convert.ToInt32(dataReader["FirstYear"]);
                    city.SecondYear = Convert.ToInt32(dataReader["SecondYear"]);
                    city.FirstYearPopulation = Convert.ToInt32(dataReader["FirstYearPopulation"]);
                    city.SecondYearPopulation = Convert.ToInt32(dataReader["SecondYearPopulation"]);
                    city.NumbersOfYears = Convert.ToInt32(dataReader["NumberOfYears"]);
                    city.FullChange = Convert.ToDouble(dataReader["FullChange"]);
                    city.OneYearChange = Convert.ToDouble(dataReader["OneYearChange"]);

                    cities.Add(city);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return cities;
        }
    }
}
