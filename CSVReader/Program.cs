using System;
using System.IO;
using System.Collections.Generic;

namespace CSVReader
{
    class Program
    {
        /// <summary>
        /// A list of Domain's, including all their properties
        /// </summary>
        private static List<Domain> _domains;
        static void Main()
        {
            _domains = GetDomainList($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\uptime.csv");

            Console.ReadKey(true);
        }

        private static List<Domain> GetDomainList(string filePath, bool skipHeader = true)
        {
            List<Domain> domains = new List<Domain>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                if (skipHeader)
                {
                    reader.ReadLine();
                }

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    // Add a new domain if it doesn't already exist
                    bool exist = false;
                    foreach (Domain domain in domains)
                    {
                        if (domain.DomainName.Equals(values[0]))
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        domains.Add(new Domain(values[0]));
                    }

                    // Add the attributes to the domain
                    domains[domains.Count - 1].AddAttribute(new DomainAttribute(Convert.ToInt64(values[1]), values[2], values[3], Convert.ToInt32(values[4]), Convert.ToInt32(values[5]), values[6]));
                }
            }

            return domains;
        }
    }
}
