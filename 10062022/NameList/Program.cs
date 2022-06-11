using System;

namespace NameList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[0];
            string secim;
            do
            {
                Console.WriteLine("1. Ad elave edin");
                Console.WriteLine("2. Adlara baxmaq");
                Console.WriteLine("0. Menudan cixmaq");

                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Ad daxil et:");
                        string name = Console.ReadLine();

                        if (CheckName(name))
                        {
                            Array.Resize(ref names, names.Length + 1);
                            names[names.Length - 1] = ToCapitalize(name);
                        }
                        else
                        {
                            Console.WriteLine("Ad yanlisdir");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Adlar:");
                        foreach (var item in names)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "0":
                        Console.WriteLine("Menudan cixacam");
                        break;
                    default:
                        Console.WriteLine("Sehv daxil edilib");
                        break;
                }
            } while (secim != "0");
            

        }

        static bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                foreach (var chr in name)
                {
                    if (Char.IsLetter(chr)==false)
                        return false;
                }
                return true;
            }
            return false;
        }

        static string ToCapitalize(string name)
        {
            string newStr = "";
            if (!string.IsNullOrWhiteSpace(name))
            {
                newStr += Char.ToUpper(name[0]);

                for (int i = 1; i < name.Length; i++)
                {
                    newStr += Char.ToLower(name[i]);
                }

                name = newStr;
            }
            return name;
        }
    }
}
