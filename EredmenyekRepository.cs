using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EredmenyekCLI
{
    class EredmenyekRepository
    {

            public static string Path { get; set; }

            public static bool skipHeader { get; set; }
            public static char Separator { get; set; } = ',';
            public static List<Eredmeny> FindAll()
            {
                using (StreamReader reader = new StreamReader(Path))
                {
                    if (skipHeader)
                    {
                        reader.ReadLine(); //fejléc eldobása
                    }
                    List<Eredmeny> people = new List<Eredmeny>();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                    Eredmeny person = Eredmeny.CreateFromLine(line, Separator);
                        people.Add(person);
                    }
                    return people;
                }
            }

            public static List<Eredmeny> FindAllBySearch(string firstName, string lastname, string targy, int szazalek, int eredmeny)
            {
                List<Eredmeny> people = new List<Eredmeny>();
                foreach (Eredmeny person in FindAll())
                {
                    if (!person.Firstname.ToLower().Contains(firstName.ToLower().Trim()))
                    {
                        continue;
                    }

                    else if (!person.Lastname.ToLower().Contains(lastname.ToLower().Trim()))
                    {
                        continue;
                    }
                    /*else if (!person.Targy.ToLower().Contains(email.ToLower().Trim()))
                    {
                        continue;
                    }
                    else if (person.Szazalek)
                    {
                        continue;
                    }
                    else if (Eredmeny != "" && person.Eredmeny !=)
                    {
                        continue;
                    }

                    people.Add(person);
                }*/

                return people;
            }
        }

