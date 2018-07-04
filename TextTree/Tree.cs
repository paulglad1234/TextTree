using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTree
{
    class Tree
    {
        Node Root;
        public Tree()
        {
            Root = null;
        }
        public void MakeTree(string[] lines)
        {
            int len = lines.Length;
            if (len != 0)
            {
                Root = new Node(lines[0]);
                for (int i = 1; i < len; i++)
                    Root.AddTheLeaf(lines[i]);
            }
        }
        public bool FindTheFollowing(string word)
        {
            return Root.FindTheFollowing(word);
        }
    }
}
