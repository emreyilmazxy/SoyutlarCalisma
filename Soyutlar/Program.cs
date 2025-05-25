using System;

namespace Soyutlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SoftwareDeveloper developer = new SoftwareDeveloper
            {
                Name = "Emre",
                Surname = "Yıldız",
                Department = "Yazılım Geliştirme"
            };

            
            SoftwareTester tester = new SoftwareTester
            {
                Name = "Zeynep",
                Surname = "Koç",
                Department = "Yazılım Geliştirme"
            };

          
            ScrumMaster scrumMaster = new ScrumMaster
            {
                Name = "Hasan",
                Surname = "Çıldırmış",
                Department = "Yazılım Geliştirme"
            };

          
            developer.Work();
            tester.Work();
            scrumMaster.Work();

           
        }
    }
}
