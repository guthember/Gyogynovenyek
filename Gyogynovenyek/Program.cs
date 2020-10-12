using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyogynovenyek
{
  class Program
  {
    static List<Noveny> novenyek = new List<Noveny>();
    static Dictionary<string, int> reszek = new Dictionary<string, int>();

    static void Beolvas()
    {
      StreamReader file = new StreamReader("noveny.csv");

      while (!file.EndOfStream)
      {
        novenyek.Add(new Noveny(file.ReadLine()));
      }

      file.Close();
    }

    static void ElsoFeladat()
    {
      Console.WriteLine("1. feladat: Növények száma: {0}",
        novenyek.Count);
    }

    static void MasodikFeladat()
    {
      Console.WriteLine("\n2. feladat: Gyűjthető részek:");
      foreach (var n in novenyek)
      {
        if (!reszek.ContainsKey(n.Resz))
        {
          reszek.Add(n.Resz, 0);
        }
      }

      foreach (var n in novenyek)
      {
        reszek[n.Resz]++;
      }

      foreach (var r in reszek)
      {
        Console.WriteLine($"{r.Key}: {r.Value}");
      }

    }

    static void HarmadikFeladat()
    {
      Console.Write("\n3. feladat: Legtöbb idő amíg gyűjthető: ");
      int max = 0;

      foreach (var n in novenyek)
      {
        if (max < n.Idotartam)
        {
          max = n.Idotartam;
        }
      }

      Console.WriteLine(max);
      Console.WriteLine("Növény(ek):");
      foreach (var n in novenyek)
      {
        if (n.Idotartam == max)
        {
          Console.WriteLine(n.Nev);
        }
      }


    }

    static void NegyedikFeladat()
    {
      double szum = 0;
      foreach (var n in novenyek)
      {
        szum += n.Idotartam;
      }

      Console.WriteLine("\n4. feladat: Átlagos gyűjthető időtartam: {0:N2}",
        szum / novenyek.Count
        );
    }


    static void Main(string[] args)
    {

      Beolvas();
      ElsoFeladat();
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();

      Console.ReadLine();
    }
  }
}
