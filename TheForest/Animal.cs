using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForest;
class Animal
{
    public int Weight { get; set; }
    public bool Nocturnal { get; set; }


    public Animal(int weight, bool nocturnal)
    {
        Weight = weight;
        Nocturnal = nocturnal;
    }
    public virtual void Move(bool day)
    {
        Console.WriteLine("Det okända djuret" + (day == true && Nocturnal == false ? " springer omkring" : " sover"));
    }


}


class Owl : Animal
{
    public int Wingspan { get; set; }

    public Owl(int weight, bool nocturnal, int wingspan) : base(weight, nocturnal)
    {
        //Weight = weight;
        //Nocturnal = nocturnal;
        Wingspan = wingspan;
        
    }

    public override void Move(bool day)
    {
        if(Nocturnal && day == false)
        {
            Console.WriteLine("Ugglan flyger i skogen, och letar mat.");
        }
        else
        {
            Console.WriteLine("Ugglan sover i ett träd.");
        }
    }
}

class Horse : Animal
{
    public int HayPerDay { get; set; }

    public Horse(int weight, bool nocturnal, int hayPerDay) : base(weight, nocturnal) 
    {
        HayPerDay = hayPerDay;
    }

    public override void Move(bool day)
    {
        if(Nocturnal == false && day == true)
        {
            Console.WriteLine("Hästen travar runt u skogen och letar efter hö.");
        }
        else
        {
            Console.WriteLine("Hästen sover sött under en gran.");
        }
    }
}

class Dolphine : Animal
{
    public int DistancePerDay { get; set; }

    public Dolphine(int weight, bool nocturnal, int distancePerDay) : base(weight, nocturnal) 
    {
        DistancePerDay = distancePerDay;
    }

    public override void Move(bool day)
    {
        if (Nocturnal == false && day == true)
        {
            Console.WriteLine("Delfinen simmar i sjön, och letar efter fisk.");
        }
        else
        {
            Console.WriteLine("Delfinen sover i vattenbrynet.");
        }
    }
}