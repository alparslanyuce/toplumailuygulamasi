using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Udemy.TopluMail.Core.Helper;
using Udemy.TopluMail.Core.Repository;
using Udemy.TopluMail.Entities;

namespace Udemy.TopluMail.WinServis
{
    public partial class TopluMailUygulamaServisi : ServiceBase
    {

        Timer t;

        public TopluMailUygulamaServisi()
        {
            InitializeComponent();
            t = new Timer(120000);
            t.Elapsed += t_elapsed;
        }

        private void t_elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            using (MusteriRepository musterirepo = new MusteriRepository())
            {
                List<Musteri> musteriListele = musterirepo.TumListe();
                for (int i = 0; i < musteriListele.Count; i++)
                {
                    if (string.IsNullOrEmpty(musteriListele[i].KuponKOD))
                    {
                        musteriListele[i].KuponKOD = musterirepo.MusteriKuponUret();
                        musteriListele[i].KuponDurum = false;
                        musterirepo.MusteriKuponAta(musteriListele[i]);





                        //eposta gönderme işlemi
                        string MailIcerik = string.Empty;
                        MailIcerik += "<div>";
                        MailIcerik += "<p> Merhaba </p>";
                        MailIcerik += "<p>" + musteriListele[i].Ad + "" + musteriListele[i].Soyad + " </p>";
                        MailIcerik += "<p>" + DateTime.Now.ToShortDateString() + "  tarihinde mağazamız tarafından kullanabilmeniz için bir indirim kuponu oluşturulmuştur.</p>";
                        MailIcerik += "<p> ilgili indirim kuponunuzu aktif etmek için <a href = 'http://www.alparslanyuce.com/Home/KuponOnay? KuponKod=" + musteriListele[i].KuponKOD + "'> Tıklayınız </a></p>";
                        MailIcerik += "<div>";

                        EpostaIslemleri.emailGonder(musteriListele[i].Ad + " " + musteriListele[i].Soyad, musteriListele[i].EmailAdres, "İndirim kuponu", MailIcerik);




                        //string mailIcerik = string.Empty;


                        //mailIcerik += "<div>";
                        //mailIcerik += "<p>Merhaba</p>";
                        //mailIcerik += "<p>" + musteriListele[i].Ad + " " + musteriListele[i].Soyad + "</p>";
                        //mailIcerik += "<p>" + DateTime.Now.ToShortDateString() + "tarihinde mağazamız tarafından kullanabilmeniz için bir indirim kuponu oluşturulmuştur.</p>";
                        //mailIcerik += "<p> ilgili indirim kuponunuzu aktif etmek için <a href='http://www.alparslanyuce.com/Home/KuponOnay/KuponKod=" + musteriListele[i].KuponKOD + "'Tıklayınız</a></p>";
                        //mailIcerik += "<div>";


                    }
                }
            }
        }   

        protected override void OnStart(string[] args)
        {
            t.Start();
        }

        protected override void OnStop()
        {
            t.Stop();
        }

        protected override void OnContinue()
        {
            t.Start();
        }

        protected override void OnPause()
        {
            t.Stop();
        }

        protected override void OnShutdown()
        {
            t.Stop();
        }
    }
}
