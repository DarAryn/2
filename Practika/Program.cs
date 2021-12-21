using System;
using System.Linq;
using Practika.Damain;

namespace Practika1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var population = new Population();
            var maria = new Person() { Name = "Maria", Daughter = nastya, Son = ivan, };
            var ivan = new Person() { Name = "Ivan", Mother = maria, Brother = nastya};
            var nastya = new Person() { Name = "Nastya", Mother = maria, Sister = ivan};
            var Kolya = new Person() { Name = "Kolya", FatherInLaw = ivan};
            
           // population.Peoples.Add(maria);
           // population.Peoples.Add(ivan);
           // population.Peoples.Add(new Person() { Name = "Elena", Mother = maria});

            //foreach (var people in population.Peoples.Where(i => i.Mother == null))
            {
              //  Console.WriteLine(people.Name);
            } 
        }
    }
}