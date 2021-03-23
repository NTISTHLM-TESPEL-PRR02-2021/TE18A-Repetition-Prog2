using System;
using System.Collections.Generic;


namespace Repetition
{
  class Program
  {
    static void Main(string[] args)
    {

      List<int> numbers = new List<int>();

      Queue<int> könummer = new Queue<int>();

      könummer.Enqueue(67);

      int nextNumber = könummer.Dequeue();
      
      /*
       x Objektorienterat tänkande
       x Klasser, instanser
       x Arv
       - Klassdiagram
       x Synlighet (public/private/protected)
       x Metoder i klasser
       x Generiska klasser
       + Polymorfism
       x Inkapsling
      */

      // int heroHp = 100;
      // int heroX = 10;
      // int heroY = 10;

      Hero captainAmerica = new Hero();
      Hero ironMan = new Hero();

      captainAmerica.Move();

      ironMan.Move();

      captainAmerica.Hp = -900;


      // captainAmerica.hp -= 1000;
      // if (captainAmerica.hp < 0)
      // {
      //   captainAmerica.hp = 0;
      // }

      // captainAmerica.hp = 800;

      // Hero ironMan = captainAmerica;

      // ironMan.hp = 900;

      // Console.WriteLine(captainAmerica.hp);

      Console.ReadLine();
    }
  }
}
