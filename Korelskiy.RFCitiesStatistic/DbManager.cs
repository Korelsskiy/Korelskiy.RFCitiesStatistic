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
                    "(Name, FirstYear, SecondYear, FirstYearPopulation, SecondYearPopulation) VALUES " +
                    "(@Name, @FirstYear, @SecondYear, @FirstYearPopulation, @SecondYearPopulation)", connection);
                command.Parameters.AddWithValue("Name", city.Name);
                command.Parameters.AddWithValue("FirstYear", city.FirstYear);
                command.Parameters.AddWithValue("SecondYear", city.SecondYear);
                command.Parameters.AddWithValue("FirstYearPopulation", city.FirstYearPopulation);
                command.Parameters.AddWithValue("SecondYearPopulation", city.SecondYearPopulation);

                command.ExecuteNonQuery();
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
