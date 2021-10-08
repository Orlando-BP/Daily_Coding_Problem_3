using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Coding_Problem_3
{
    class Node
    {
        string val;
        Node left;
        Node right;
        public Node(string val,Node left= null, Node right = null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public string get_val()
        {
            return val;
        }
        public Node get_left()
        {
            return left;
        }
        public Node get_right()
        {
            return right;
        }
        public void set_left(Node left)
        {
            this.left = left;
        }
        public void set_right(Node right)
        {
            this.right = right;
        }
    }
}
