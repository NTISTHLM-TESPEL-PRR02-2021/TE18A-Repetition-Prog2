using System;
using System.Collections.Generic;

namespace Repetition
{
  public class Hero
  {
    public static Random generator = new Random();
    public static List<Hero> heroes = new List<Hero>();

    public int X { get; set; }

    public int Hp {
      get
      {
        return hp;
      }
      set
      {
        hp = value;
        if (hp < 0)
        {
          hp = 0;
        }
      }
    }

    protected int hp;

    // public int x;
    public int y;

    public void SetHp(int value)
    {
      hp = value;
      if (hp < 0)
      {
        hp = 0;
      }
    }

    public int GetHp()
    {
      return hp;
    }

    public Hero()
    {
      hp = 900;
      X = 10;
      y = 9;

      heroes.Add(this);
    }

    public void Move()
    {
      X += 5;

      if (y < 0)
      {
        hp = 0;
      }
    }

  }
}
