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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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









        public List<City> GetCitiesFromDb()
        {
            List<City> cities = new DbManager().GetCities();

            return cities;
        }
        public void AddCityToDb(City city)
        {
            new DbManager().AddCity(city);
        }
    }
}
