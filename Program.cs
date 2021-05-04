using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TopluMail.Core.Helper;
using Udemy.TopluMail.Core.Repository;
using Udemy.TopluMail.Entities;

namespace Udemy.TopluMail.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string MailIcerik = string.Empty;
            //    < div >
            //< p > Merhaba </ p >
            //< p > Isim Soyisim </ p >

            //   < p > 03.05.2021 tarihinde mağazamız tarafından kullanabilmeniz için bir indirim kuponu oluşturulmuştur.</ p >

            //      < p > ilgili indirim kuponunuzu aktif etmek için < a href = "http://www.alparslanyuce.com/Home/KuponOnay? KuponKod=2313213" > Tıklayınız </ a ></ p >

            //      </ div >

            Musteri m = new Musteri();


            MailIcerik += "<div>";
            MailIcerik += "<p> Merhaba </p>";
            MailIcerik += "<p>"+m.Ad+""+m.Soyad+" </p>";
            MailIcerik += "<p>" +DateTime.Now.ToShortDateString()+"  tarihinde mağazamız tarafından kullanabilmeniz için bir indirim kuponu oluşturulmuştur.</p>";
            MailIcerik += "<p> ilgili indirim kuponunuzu aktif etmek için <a href = 'http://www.alparslanyuce.com/Home/KuponOnay? KuponKod=" +m.KuponKOD+"'> Tıklayınız </a></p>";
            MailIcerik += "<div>";

            Console.ReadLine();



        }
    }
}
