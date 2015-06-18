using System;
using System.IO;
using System.Xml;

namespace XPathReplacer
{
    class Program
    {
        static void Main(string[] args) {

            if(args.Length!=3){
                Console.WriteLine("Arguments are not valid this requires 3 arguments:");
                Console.WriteLine("1. Filepath for the file to be modified");
                Console.WriteLine("2. Xpath expression for the value to be replaced");
                Console.WriteLine("3. New value");
                Console.ReadLine();
            }
            else{
                if(!File.Exists(args[0])){
                    Console.WriteLine("File does not exists");
                    Console.ReadLine();
                }


                var doc = new XmlDocument();
                doc.Load(args[0]);
                XmlNodeList nodes = doc.SelectNodes(args[1]);
                foreach (XmlNode node in nodes){
                    node.InnerText = args[2];
                }
                doc.Save(args[0]);
            }

           
        }
    }
}
