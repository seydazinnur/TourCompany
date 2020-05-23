namespace _20200415_Tour.Migrations
{
    using _20200415_Tour.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_20200415_Tour.TourCompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_20200415_Tour.TourCompanyDbContext context)
        {
            #region MyRegion
            //Datas datas = new Datas();
            //IList<Nationality> nationalities = datas.GetNations();
            //IList<Country> countries = datas.GetCountries();
            //IList<Place> places = datas.GetPlaces();
            //IList<Cicerone> cicerones = datas.GetCicerones();

            //context.Nationalities.AddRange(nationalities);
            //context.Countries.AddRange(countries);
            //context.Places.AddRange(places);
            //context.Cicerones.AddRange(cicerones);
            //context.SaveChanges();

            //#region AddTourists
            //IList<Tourist> tourists = new List<Tourist>();
            //StreamReader reader = new StreamReader("veriler.txt");
            //string allData = reader.ReadToEnd();
            //string[] lines = allData.Split('\n');
            //Tourist tourist;
            //bool flag;

            //foreach (string item in lines)
            //{
            //    flag = true;
            //    string[] items = item.Split(';');
            //    tourist = new Tourist();
            //    tourist.Name = items[0].ToString();
            //    tourist.Surname = items[1].ToString();

            //    foreach (Tourist trs in tourists)
            //    {
            //        if (trs.Name == tourist.Name && trs.Surname == tourist.Surname)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if (flag)
            //    {
            //        tourist.Gender = items[2].ToString();
            //        string[] birth = items[3].Split('.');
            //        tourist.BirthDate = new DateTime(int.Parse(birth[0].ToString()), int.Parse(birth[1].ToString()), int.Parse(birth[2].ToString()));

            //        string nation = items[4].ToString();
            //        int nationID = (from n in context.Nationalities
            //                        where n.Description == nation
            //                        select n.NationalityID).First();
            //        Nationality nationality = context.Nationalities.Find(nationID);
            //        tourist.Nationality = nationality;

            //        string cont = items[5].ToString();
            //        int countryID = (from c in context.Countries
            //                         where c.Name == cont
            //                         select c.CountryID).First();
            //        Country country = context.Countries.Find(countryID);
            //        if (!tourist.Countries.Contains(country))
            //        {
            //            tourist.Countries.Add(country);
            //        }

            //        tourists.Add(tourist);
            //    }
            //}
            //reader.Close();
            //context.Tourists.AddRange(tourists);
            //context.SaveChanges();
            //#endregion 
            #endregion
        }
    }
}
