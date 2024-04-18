using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EredmenyekCLI
{
    class Eredmeny
    {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Targy { get; set; }
            public int Szazalek { get; set; }
            public static int Eredmenyy
            {
            get
            {
                if (Szazalek <= 24)
                {
                    return 1;
                }
                else if (Szazalek <= 39)
                {
                    return 2;
                }
                else if (Szazalek <= 59)
                {
                    return 3;
                }
                else if (Szazalek <= 79)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }; set { };
              }

            public override string ToString()
            {
                return $"Eredmeny <{Firstname} {Lastname} : {Eredmenyy}>";
            }

            public static Eredmeny CreateFromLine(string line, char separator = ',')
            {
                string[] values = line.Split(separator);

                return new Eredmeny()
                {
                    Id = int.Parse(values[0]),
                    Firstname = values[1],
                    Lastname = values[2],
                    Targy = values[3],
                    Szazalek = int.Parse(values[4]),
                    Eredmeny = int.Parse(values[5])
                };
            }
        }
}
