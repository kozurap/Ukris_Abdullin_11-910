using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumTests;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace TestGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = args[0];
            int count = Convert.ToInt32(args[1]);
            string filename = args[2];
            string format = args[3];
            if (type == "accounts")
            {
                GenerateForAccounts(count, filename, format);
            }
            else
            {
                System.Console.Out.Write("Unrecognized type of data" + type);
            }
        }

        static void GenerateForAccounts(int count, string filename, string format)
        {
            List<AccountData> accounts = new List<AccountData>();
            for (int i = 0; i < count; i++)
            {
                AccountData item = new AccountData()
                {
                    Username = TestBase.GenerateRandomString(20),
                    Password = TestBase.GenerateRandomString(20)
                };
                accounts.Add(item);
            }
            StreamWriter writer = new StreamWriter(filename);
            if (format == "xml")
            {
                WriteGroupsToXmlFile(accounts, writer);
            }
            else
            {
                System.Console.Out.Write("Unrecognized format" + format);
            }
            writer.Close();
        }

        static void WriteGroupsToXmlFile(List<AccountData> groups, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<AccountData>)).Serialize(writer, groups);
        }
    }
}
