using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200415_Tour
{
    public partial class Form1 : Form
    {
        TourCompanyDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new TourCompanyDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1) En çok gezilen yer/ yerler neresidir ?
            #region
            #endregion

            //2) Ağustos ayında en çok çalışan rehber/ rehberler kimdir / kimlerdir ?
            #region
            #endregion

            //3) Kadın turistlerin gezdiği yerleri, toplam ziyaret edilme sayılarıyla beraber listeleyinç
            #region
            #endregion

            //4) İngiltere’den gelip de Kız Kulesi’ni gezen turistler kimlerdir?
            #region
            #endregion

            //5) Gezilen yerler hangi yılda kaç defa gezilmiştir ?
            #region
            #endregion

            //6) 2’den fazla tura rehberlik eden rehberlerin en çok tanıttıkları yerler nelerdir ?
            #region
            #endregion

            //7) İtalyan turistler en çok nereyi gezmiştir?
            #region
            #endregion

            //8) Kapalı Çarşı’yı gezen en yaşlı turist kimdir?
            #region
            #endregion

            //9) Linda Callahan’ın rehberlik ettiği turistler kimlerdir ?
            #region
            //var query = (from t in db.Tours
            //             join c in db.Cicerones on t.CiceroneID equals c.CiceroneID
            //             join tr in db.Tourists on t.TouristID equals tr.TouristID
            //             where c.Name == "Linda" && c.Surname == "Callahan"
            //             select new
            //             {
            //                 Turist = tr.Name + " " + tr.Surname
            //             }).Distinct().ToList();
            #endregion

            //10) Yunanistan’dan gelen Finlandiyalı turistin gezdiği yerler nerelerdir ?
            #region
            #endregion

            //11) Dolmabahçe Sarayı’na en son giden turistler ve rehberi listeleyin.
            #region

            #endregion

            //dgv.DataSource = query;
        }
    }
}
