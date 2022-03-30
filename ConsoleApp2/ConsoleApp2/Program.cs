using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse horse1 = new Horse();
            horse1.Name = "At1";
            Horse horse2 = new Horse();
            horse2.Name = "At2";
            Sheep sheep1 = new Sheep();
            sheep1.Name = "Qoyun1";
            Sheep sheep2 = new Sheep();
            sheep2.Name = "Qoyun2";
            Farm SarvaninFermasi = new Farm();
            SarvaninFermasi.AddAnimal(sheep1);
            SarvaninFermasi.AddAnimal(sheep2);
            SarvaninFermasi.AddAnimal(horse2);

            foreach (var item in SarvaninFermasi.Animals)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
