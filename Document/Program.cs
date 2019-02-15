using System;
using System.IO;
namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document ");
            Console.WriteLine("Please give a name for the document");
            string w = Console.ReadLine();
            Console.WriteLine("Please write the content for the document");
            string c = Console.ReadLine();
            try
            {
                StreamWriter sw = new StreamWriter(w+".txt");
                sw.WriteLine(c);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine(w + " is was successfully saved. The document contains {0} characters",c.Length);
            }
        }
    }
}
