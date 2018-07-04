using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Utils;

namespace TextTree
{
    class Solution
    {
        public static void A_ReadInputFromFile(string filename, out string[] lines)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                lines = File.ReadAllLines(filename);
            }
        }
        public static void B_ReadInputFromFile(string filename, out Tree tree)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                tree = new Tree();
                tree.MakeTree(lines);
            }
        }
        public static void C_WriteWordsIntoFile(string filename, List<string> lines)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < lines.Count; i++)
                    sw.WriteLine(lines[i]);
            }
        }
        public static void Sln(string[] lines, Tree tree, string filename)
        {
            List<string> Out = new List<string>();
            for (int i = 0; i < lines.Length; i++)
                if (!tree.FindTheFollowing(lines[i]))
                    Out.Add(lines[i]);
            C_WriteWordsIntoFile(filename, Out);
        }
    }
}
