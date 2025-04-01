namespace TheForest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> forest = new List<Animal>();

            forest.Add(new Animal(1234, true));
            forest.Add(new Owl(7, true, 34));
            forest.Add(new Horse(700, false, 70));
            forest.Add(new Dolphine(430, false, 95));
            forest.Add(new Owl(9, true, 19));

            bool day = true;

            while (true)
            {
                foreach (Animal animal in forest)
                {
                    Console.WriteLine(animal.GetType().Name + " Vikt: " + animal.Weight + " kg, " + "sömnvanor: " + (animal.Nocturnal ? "Nattdjur" : "dagdjur"));
                    if(animal is Owl)
                    {
                        Console.WriteLine("En Uggla med vingbredden " + ((Owl)animal).Wingspan + " Cm");
                    }
                    else if(animal is Horse)
                    {
                        Console.WriteLine("En häst som äter " + ((Horse)animal).HayPerDay + " Kg per dag ");
                    }
                    else if(animal is Dolphine){
                        Console.WriteLine("En delfin som simmar " + ((Dolphine)animal).DistancePerDay + "Km per dag" ) ;
                    }

                    animal.Move(day);
                    Console.WriteLine("--------------------------------------");
                }

                string key = Console.ReadKey().Key.ToString();
                Console.Clear();
                switch (key)
                {
                    case "D":
                        day = true;
                        Console.WriteLine("Nu är det dag");
                        break;
                    case "N":
                        day = false;
                        Console.WriteLine("Nu är det natt");
                        break;
                  

                }
            }
        }
    }
}
