using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace LearnPrograms
{
    class ADClass
    {

        public List<string> GetComputers(string directoryEntry)
        {
            List<string> ComputerNames = new List<string>();

            DirectoryEntry entry = new DirectoryEntry("LDAP://"+directoryEntry);
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            mySearcher.Filter = ("(objectClass=computer)");
            mySearcher.SizeLimit = int.MaxValue;
            mySearcher.PageSize = int.MaxValue;

            foreach (SearchResult resEnt in mySearcher.FindAll())
            {
                //"CN=SGSVG007DC"
                string ComputerName = resEnt.GetDirectoryEntry().Name;
                if (ComputerName.StartsWith("CN="))
                    ComputerName = ComputerName.Remove(0, "CN=".Length);
                ComputerNames.Add(ComputerName);
            }

            mySearcher.Dispose();
            entry.Dispose();

            return ComputerNames;
        }

    }
}
