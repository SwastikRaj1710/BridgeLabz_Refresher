using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    internal class UnorderedList
    {
        public void FileModification()
        {
            //Read from File
            Console.WriteLine("Enter the filename");
            string filename = Console.ReadLine();
            string sentence = ReadfromFile(filename);

            //Convert to List
            LinkedList<string> list = StringtoList(sentence);

            //Modify List 
            Console.WriteLine("Enter the word to be searched");
            string searchWord = Console.ReadLine();
            list = ModifyList(list, searchWord);

            //Write to File
            WritetoFile(list);
        }

        public string ReadfromFile(string filename)
        {
            string filePath = Path.Combine("D:\\BridgeLabz\\BridgeLabz_Refresher\\DataStructurePrograms\\", filename);
            StreamReader sr = new StreamReader(filePath);
            string sentence = "";
            string line = sr.ReadLine();
            sentence += line;
            while (line != null)
            {
                line = sr.ReadLine();
                sentence += line;
            }
            sr.Close();
            return sentence;
        }

        public void WritetoFile(LinkedList<string> list)
        {
            StreamWriter sw = new StreamWriter("D:\\BridgeLabz\\BridgeLabz_Refresher\\DataStructurePrograms\\File2.txt");
            for (LinkedListNode<string> node = list.First; node != null; node = node.Next)
            {
                sw.Write(node.Value + " ");
                Console.Write(node.Value + " ");
            }
            sw.Close();
        }

        public LinkedList<string> StringtoList(string sentence)
        {
            LinkedList<string> list = new LinkedList<string>();
            sentence = sentence + " ";
            string word = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    word += sentence[i];
                }
                else
                {
                    if (list.Count == 0)
                    {
                        list.AddFirst(word);
                    }
                    else
                    {
                        list.AddLast(word);
                    }
                    word = "";
                }
            }
            return list;
        }

        public LinkedList<string> ModifyList(LinkedList<string> list, string searchWord)
        {
            if (list.Contains(searchWord))
            {
                list.Remove(searchWord);
            }
            else
            {
                list.AddLast(searchWord);
            }
            return list;
        }
    }
}
