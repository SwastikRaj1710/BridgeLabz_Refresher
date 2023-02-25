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
            LinkedListUtility list = StringtoList(sentence);

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

        public LinkedListUtility StringtoList(string sentence)
        {
            LinkedListUtility list = new LinkedListUtility();
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
                    if (list.NodeCount() == 0)
                    {
                        list.InsertFirst(word);
                    }
                    else
                    {
                        list.InsertLast(word);
                    }
                    word = "";
                }
            }
            return list;
        }

        public LinkedListUtility ModifyList(LinkedListUtility list, string searchWord)
        {
            if (list.ContainsNode(searchWord))
            {
                list.DeleteNodebyKey(searchWord);
            }
            else
            {
                list.InsertLast(searchWord);
            }
            return list;
        }

        public void WritetoFile(LinkedListUtility list)
        {
            StreamWriter sw = new StreamWriter("D:\\BridgeLabz\\BridgeLabz_Refresher\\DataStructurePrograms\\File2.txt");
            for (Node1 node = list.GetFirstNode(); node != null; node = node.next)
            {
                sw.Write(node.data + " ");
                Console.Write(node.data + " ");
            }
            sw.Close();
        }
    }
}
