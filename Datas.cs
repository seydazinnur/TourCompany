using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour
{
    class Datas
    {
        public IList<Nationality> GetNations()
        {
            StreamReader reader = new StreamReader("veriler.txt");
            string datas = reader.ReadToEnd();
            string[] lines = datas.Split('\n');
            IList<Nationality> nationalities = new List<Nationality>();
            Nationality nationality;
            bool nationFlag;

            foreach (string item in lines)
            {
                nationFlag = true;

                string[] items = item.Split(';');
                nationality = new Nationality();
                nationality.Description = items[4].ToString();

                foreach (Nationality nat in nationalities)
                {
                    if (nat.Description == nationality.Description)
                    {
                        nationFlag = false;
                        break;
                    }
                }

                if (nationFlag)
                {
                    nationalities.Add(nationality);
                }
            }
            reader.Close();
            return nationalities;
        }

        public IList<Country> GetCountries()
        {
            IList<Country> countries = new List<Country>();
            StreamReader reader = new StreamReader("veriler.txt");
            string datas = reader.ReadToEnd();
            string[] lines = datas.Split('\n');
            Country country;
            bool flag;

            foreach (string item in lines)
            {
                flag = true;
                string[] items = item.Split(';');
                country = new Country();
                country.Name = items[5].ToString();


                foreach (Country coun in countries)
                {
                    if (coun.Name == country.Name)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    countries.Add(country);
                }
            }
            reader.Close();
            return countries;
        }

        public IList<Place> GetPlaces()
        {
            IList<Place> places = new List<Place>();
            StreamReader reader = new StreamReader("veriler.txt");
            string datas = reader.ReadToEnd();
            string[] lines = datas.Split('\n');
            Place place;
            bool flag;

            foreach (string item in lines)
            {
                flag = true;
                string[] items = item.Split(';');
                place = new Place();
                place.PlaceName = items[10].ToString();


                foreach (Place pl in places)
                {
                    if (pl.PlaceName == place.PlaceName)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    places.Add(place);
                }
            }
            reader.Close();
            return places;
        }

        public IList<Cicerone> GetCicerones()
        {
            IList<Cicerone> cicerones= new List<Cicerone>();
            StreamReader reader = new StreamReader("veriler.txt");
            string datas = reader.ReadToEnd();
            string[] lines = datas.Split('\n');
            Cicerone cicerone;
            bool flag;

            foreach (string item in lines)
            {
                flag = true;
                string[] items = item.Split(';');
                cicerone = new Cicerone();
                cicerone.Name = items[6].ToString();
                cicerone.Surname = items[7].ToString();
                cicerone.PhoneNumber = items[8].ToString();


                foreach (Cicerone cice in cicerones)
                {
                    if (cice.Name == cicerone.Name && cice.Surname == cice.Surname)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    cicerones.Add(cicerone);
                }
            }
            reader.Close();
            return cicerones;
        }
        
    }
}
