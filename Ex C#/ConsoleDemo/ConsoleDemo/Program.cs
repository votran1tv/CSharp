using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Thuake
{
    class Person
    {
        //Nhập trường
        public String Name;
        public int Year;
        public string PlaceOfBrith;

        //Chỉ định tên, năm sinh, nơi sinh
        public Person(String Name, int Year, string PlaceOfBrith)
        {
            this.Name = Name;
            this.Year = Year;
            this.PlaceOfBrith = PlaceOfBrith;
        }
        public Person(String Name, int Year)
        {
            this.Name = Name;
            this.Year = Year;
        }
    }
     
    class PersonDemo
    {
        static void Main(string[]args)
        {
            Person edison = new Person("Thomas", 1847);

            Console.WriteLine("Info:");
            Console.WriteLine("Name:" + edison.Name);
            Console.WriteLine("Year:" + edison.Year);
            Console.WriteLine("Place Of Brith" + edison.PlaceOfBrith);

            Person galaxy = new Person("galaxy", 1990, "Namdinh");
            Console.WriteLine("Info:");
            Console.WriteLine("Name:" + galaxy.Name);
            Console.WriteLine("Year:" + galaxy.Year);
            Console.WriteLine("Place:" + galaxy.PlaceOfBrith);

            Console.ReadLine();
        }
    }
    public abstract class Animal
    {
        public string Name;

        public Animal()
        {
            Console.WriteLine("Dongvat");
        }

        public Animal(string Name)
        {
            this.Name = Name;
            Console.WriteLine("-Animal(string)");
        }
        public virtual void Aciton()
        {
            Console.WriteLine("Animal Move");

        }
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
    public class Cat:Animal
    {
        public int Tuoi;
        public int Cao;

        public Cat(string name,int Tuoi, int Cao)
            :base(name)
        {
            this.Tuoi = Tuoi;
            this.Cao = Cao;
            Console.WriteLine("-CAt(string, int,int)");
        }

        public Cat(int Tuoi, int Cao)
            :base()
        {
            this.Tuoi = Tuoi;
            this.Cao = Cao;
            Console.WriteLine("-Cat,int, int");

        }
        public void Say()
        {
            Console.WriteLine("Meo");

        }
        public override void Aciton()
        {
            Console.WriteLine("Cat Move");
        }
    }
    public class mouse:Animal
    {
        private int CanNang;
        public mouse()
            :this(100)
        {

        }
        public mouse(int CanNang)
        {
            this.CanNang = CanNang;
        }
        public mouse(string name,int CanNang)
            :base(name)
        {
            this.CanNang = CanNang;
        }
        public int getweight()
        {
            return CanNang;
        }
        public void setweight(int canNang)
        {
            this.CanNang = canNang;
        }
    }
    class CatTest
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Create Cat object from cat(string,int,int)");

            Cat tom = new Cat("Tom", 3, 20);

            Console.WriteLine("Name={0}", tom.Name);
            Console.WriteLine("Tuoi={0}", tom.Tuoi);
            Console.WriteLine("Cao={0}", tom.Cao);

            tom.Sleep();

            tom.Say();
            Console.ReadLine();
        }
    }

    class IsOperatorDemo
    {
        static void Main(string[]args)
        {
            Animal check = new Cat("Check", 4, 10);
            Console.WriteLine("AnimalChekCat");

            check.Sleep();

            bool isMouse = check is mouse;
            Console.WriteLine("check mouse" + isMouse);

            bool isCat = check is Cat;
            Console.WriteLine("check cat" + isCat);

            bool isAnimal = check is Animal;
            Console.WriteLine("check animal" + isAnimal);
            Console.ReadLine();
        }
    }

    
}