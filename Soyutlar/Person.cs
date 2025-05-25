using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlar
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }


        public abstract void Work();



    }

    public class SoftwareDeveloper : Person
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {Surname}. şirketin {Department} departmanında Yazılım Geliştirici olarak çalışıyorum.");
        }
    }
    public class SoftwareTester : Person
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {Surname}. şirketin {Department} departmanında QA Engineer olarak çalışıyorum.");
        }
    }
    public class ScrumMaster : Person
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {Surname}.  şirketin {Department} departmanında takım kordinatörü olarak çalışıyorum.");
        }
    }
}

