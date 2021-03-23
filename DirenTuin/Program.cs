using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirenTuin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Ex = false;
            do
            {
                Ex = false;
                List<Dier> Dieren = new List<Dier>();
            string[] DirenSelectie = new string[] { "Hond", "Kat", "Bij" ,"Schaap"};
            do
            {
                switch (SelectMenu("WAt voor dieren moeten toegevooegd worden?", "Druk op Q om verder te gaan.",DirenSelectie))
                {
                    case 1:
                        if (!Dieren.Contains(new Hond()))
                            Dieren.Add(new Hond());
                        DirenSelectie[0] = "Hond (Toegevoegd)";
                        break;
                    case 2:
                        if (!Dieren.Contains(new Kat()))
                            Dieren.Add(new Kat());
                        DirenSelectie[1] = "Kat (Toegevoegd)";
                        break;
                    case 3:
                        if (!Dieren.Contains(new Bij()))
                            Dieren.Add(new Bij());
                        DirenSelectie[2] = "Bij (Toegevoegd)";
                        break;
                    case 4:
                        if (!Dieren.Contains(new Schaap()))
                            Dieren.Add(new Schaap());
                        DirenSelectie[3] = "Schaap (Toegevoegd)";
                        break;
                    case -1:
                        Ex = true;
                        break;
                }

            } while (!Ex);
                DirenSelectie = new string[Dieren.Count];
                for (int i = 0; i < Dieren.Count; i++)
                {
                    DirenSelectie[i] = Dieren[i].ToString();
                }
                do
                {
                    Ex = false;
                    switch (SelectMenu("", "", "Dier verwijderen", "Diergewicht gemeddelde", "Dier praten", "Opnieuw beginnen"))
                    {
                        case 1:
                            do
                            {
                                switch (SelectMenu("WAt voor dieren moeten verwijderd worden?", "Druk op Q om trug te gaan.", DirenSelectie))
                                {
                                    case 1:
                                        for (int i = 0; i < Dieren.Count; i++)
                                            if (Dieren[i].Equals(new Hond()))
                                                Dieren.RemoveAt(i);
                                        DirenSelectie[0] = "Hond (verwijderd)";
                                        break;
                                    case 2:
                                        for (int i = 0; i < Dieren.Count; i++)
                                            if (Dieren[i].Equals(new Kat()))
                                                Dieren.RemoveAt(i);
                                        DirenSelectie[1] = "Kat (verwijderd)";
                                        break;
                                    case 3:
                                        for (int i = 0; i < Dieren.Count; i++)
                                            if (Dieren[i].Equals(new Bij()))
                                                Dieren.RemoveAt(i);
                                        DirenSelectie[2] = "Bij (verwijderd)";
                                        break;
                                    case 4:
                                        for (int i = 0; i < Dieren.Count; i++)
                                            if (Dieren[i].Equals(new Schaap()))
                                                Dieren.RemoveAt(i);
                                        DirenSelectie[3] = "Schaap (verwijderd)";
                                        break;
                                    case -1:
                                        Ex = true;
                                        break;
                                }

                            } while (!Ex);
                           
                            break;
                        case 2:
                            double totalgewicht = 0;
                            foreach (var item in Dieren)
                            {
                                totalgewicht += item.Gewicht;
                            }
                            Ex = true;
                            Console.WriteLine(totalgewicht / Dieren.Count);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            foreach (var item in Dieren)
                                item.Zegt();
                            Ex = true;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            Ex = false;
                            break;
                    }
                    
                } while (Ex);
            } while (true);
        }
        static int SelectMenu(string titel,string einde, params string [] menu)
        {
          bool exit = false;
            Console.SetCursorPosition(0, 1);
            Console.CursorVisible = false;
            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected&&!exit)
            {
                Console.WriteLine(titel);
                for (int i = 0; i < menu.Length; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.WriteLine((i + 1) + ": " + menu[i]);
                    Console.ResetColor();
                }
                Console.WriteLine(einde);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Q:
                        exit = true;
                        
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);
                Console.SetCursorPosition(0, 1);
            }

            Console.Clear();
            Console.CursorVisible = true;
            if (exit) return -1;
            else
            return selection;
        }



    }
}
