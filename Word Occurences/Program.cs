using System;
using System.IO;
using System.Collections.Generic;
namespace Word_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int> { };
            string[] fileList = OpenFile();
            foreach (string file in fileList)
            {
                string data = file.ToLower().Replace("\n", null).Replace(",", null).Replace(".", null).Trim();
                if (dic.ContainsKey(data) == true)
                {
                    dic[data] ++;
                }
                else if (dic.ContainsKey(data) == false)
                {
                    dic[data] = 1;
                }
                Console.WriteLine(dic[data]);
                Console.WriteLine(data);
            }
            foreach (KeyValuePair<string, int> name in dic)
            {
                Console.WriteLine(name);
            }

        }
        static string[] OpenFile()
        {
            string file = File.ReadAllText($"Lorem Ipsum.txt");
            Console.WriteLine(file);
            string[] fileList = file.Trim().Split(" ");
            return fileList;
        }

    }
}
