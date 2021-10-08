using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daily_Coding_Problem_3
{
    class Program
    {
        const string NullNode = "?";
        static void Main(string[] args)
        {
            /* Given the root to a binary tree, 
             * implement serialize(root), 
             * which serializes the tree into a string, 
             * and deserialize(s), 
             * which deserializes the string back into the tree.
             * (Read the file README.md for more information)
             */
            Node node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
            if (deserialize(serialize(node)).get_left().get_left().get_val() == "left.left")
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
        public static string serialize(Node node)
        {
            if (node == null)
                return NullNode + '/';

            StringBuilder SB = new StringBuilder();

            SB.Append(node.get_val() + '/');
            SB.Append(serialize(node.get_left()));
            SB.Append(serialize(node.get_right()));

            return SB.ToString();
        }
        public static Node deserialize(string serialization)
        {
            string[] nodes = serialization.Split('/', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var queue = new Queue<string>(nodes);
            var node = LoadNode(queue);

            return node;
        }

        private static Node LoadNode(Queue<string> nodes)
        {
            if (nodes.Peek() != null)
            {
                string nextNode = nodes.Dequeue();
                if (nextNode == NullNode)
                    return null;

                Node node = new Node(nextNode);
                node.set_left(LoadNode(nodes));
                node.set_right(LoadNode(nodes));
                return node;
            }
            return null;
        }
    }
}
