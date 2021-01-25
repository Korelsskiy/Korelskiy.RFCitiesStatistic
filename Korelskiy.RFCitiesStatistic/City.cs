using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korelskiy.RFCitiesStatistic
{
    public class City
    {
        private string name;
        private int firstYear;
        private int secondYear;
        private int firstYearPopulation;
        private int secondYearPopulation;
        private int id;
        private int numbersOfYears;
        private double fullChange;
        private double oneYearChange;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (value == "Подзалупинск")
                {
                    MessageBox.Show("Запрещенное наименование. Отправка в бд невозможна.");
                }
                else
                {
                    name = value;
                }   
            }
        }
        public int FirstYear
        {
            get { return firstYear; }
            set { firstYear = value; }
        }
        public int SecondYear
        {
            get { return secondYear; }
            set { secondYear = value; }
        }
        public int FirstYearPopulation
        {
            get { return firstYearPopulation; }
            set { firstYearPopulation = value; }
        }
        public int SecondYearPopulation
        {
            get { return secondYearPopulation; }
            set { secondYearPopulation = value; }
        }
        public int NumbersOfYears
        {
            get { return numbersOfYears; }
            set { numbersOfYears = value; }
        }
        public double FullChange
        {
            get { return fullChange; }
            set { fullChange = value; }
        }
        public double OneYearChange
        {
            get { return oneYearChange; }
            set { oneYearChange = value; }
        }

        public List<City> GetCitiesFromDb()
        {
            List<City> cities = new DbManager().GetCities();

            return cities;
        }
        public void AddCityToDb(City city)
        {

            if (city.Name != null)
                new DbManager().AddCity(city);
        }
    }
}
