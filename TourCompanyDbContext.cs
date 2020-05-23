using _20200415_Tour.Configurations;
using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour
{
    class TourCompanyDbContext : DbContext
    {
        public TourCompanyDbContext()
        : base("Server = .\\SQLEXPRESS; Database=TourCompany;Trusted_Connection=True")
        {
            Database.SetInitializer(new MyOwnInitializer());
        }

        public DbSet<Cicerone> Cicerones { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Tourist> Tourists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new TourConfiguration());
            modelBuilder.Configurations.Add(new TouristConfiguration());
            modelBuilder.Configurations.Add(new CiceroneConfiguration());
            modelBuilder.Configurations.Add(new PlaceConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new NationalityConfiguration());
        }
    }

    class MyOwnInitializer : DropCreateDatabaseIfModelChanges<TourCompanyDbContext>
    {
        protected override void Seed(TourCompanyDbContext context)
        {
            #region MyRegion
            Datas datas = new Datas();
            IList<Nationality> nationalities = datas.GetNations();
            IList<Country> countries = datas.GetCountries();
            IList<Place> places = datas.GetPlaces();
            IList<Cicerone> cicerones = datas.GetCicerones();

            context.Nationalities.AddRange(nationalities);
            context.Countries.AddRange(countries);
            context.Places.AddRange(places);
            context.Cicerones.AddRange(cicerones);
            context.SaveChanges();

            #region AddTourists
            IList<Tourist> tourists = new List<Tourist>();
            StreamReader reader = new StreamReader("veriler.txt");
            string allData = reader.ReadToEnd();
            string[] lines = allData.Split('\n');
            Tourist tourist;
            bool flag;

            foreach (string item in lines)
            {
                flag = true;
                string[] items = item.Split(';');
                tourist = new Tourist();
                tourist.Name = items[0].ToString();
                tourist.Surname = items[1].ToString();

                foreach (Tourist trs in tourists)
                {
                    if (trs.Name == tourist.Name && trs.Surname == tourist.Surname)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    tourist.Gender = items[2].ToString();
                    string[] birth = items[3].Split('.');
                    tourist.BirthDate = new DateTime(int.Parse(birth[0].ToString()), int.Parse(birth[1].ToString()), int.Parse(birth[2].ToString()));

                    string nation = items[4].ToString();
                    int nationID = (from n in context.Nationalities
                                    where n.Description == nation
                                    select n.NationalityID).First();
                    Nationality nationality = context.Nationalities.Find(nationID);
                    tourist.Nationality = nationality;

                    string cont = items[5].ToString();
                    int countryID = (from c in context.Countries
                                     where c.Name == cont
                                     select c.CountryID).First();
                    Country country = context.Countries.Find(countryID);
                    if (!tourist.Countries.Contains(country))
                    {
                        tourist.Countries.Add(country);
                    }

                    tourists.Add(tourist);
                }
            }

            context.Tourists.AddRange(tourists);
            context.SaveChanges();
            #endregion
            Tour tour;

            foreach (string item in lines)
            {

                tour = new Tour();
                string[] items = item.Split(';');

                #region Find Tour Tourist
                string touristName = items[0].ToString();
                string touristSurname = items[1].ToString();
                int touristID = context.Tourists
                    .Where(a => a.Name == touristName && a.Surname == touristSurname)
                    .Select(a => a.TouristID).FirstOrDefault();
                tour.Tourist = context.Tourists.Find(touristID);
                #endregion

                #region Find Tour Cicerone
                string ciceroneName = items[6].ToString();
                string ciceroneSurname = items[7].ToString();
                int ciceroneID = context.Cicerones
                    .Where(a => a.Name == ciceroneName && a.Surname == ciceroneSurname)
                    .Select(a => a.CiceroneID).FirstOrDefault();
                tour.Cicerone = context.Cicerones.Find(ciceroneID);
                #endregion

                #region Find Tour Place
                string placeName = items[10].ToString();
                int placeID = context.Places.Where(a => a.PlaceName == placeName).Select(a => a.PlaceID).FirstOrDefault();
                tour.Place = context.Places.Find(placeID);
                #endregion

                string[] date = items[9].Split('.');
                int tourYear = int.Parse(date[0].ToString());
                int tourMonth = int.Parse(date[1].ToString());
                int tourDay = int.Parse(date[2].ToString());

                tour.TourDate = new DateTime(tourYear, tourMonth, tourDay);
                context.Tours.Add(tour);
                context.SaveChanges();
                #endregion
            }

            reader.Close();
           
        }
    }
}
