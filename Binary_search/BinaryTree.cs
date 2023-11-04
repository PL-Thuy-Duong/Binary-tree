using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }
        public void BalanceTree()
        {
            Root = BalanceTreeRec(Root);
        }

        private Node BalanceTreeRec(Node root)
        {
            if (root == null)
                return root;

            // Cân bằng cây con bên trái
            root.Left = BalanceTreeRec(root.Left);

            // Cân bằng cây con bên phải
            root.Right = BalanceTreeRec(root.Right);

            // Tính cân bằng tại nút hiện tại
            int balance = GetBalance(root);

            // Thực hiện phép xoay nếu cần
            if (balance > 1 && GetBalance(root.Left) >= 0)
                return RightRotate(root);

            if (balance > 1 && GetBalance(root.Left) < 0)
            {
                root.Left = LeftRotate(root.Left);
                return RightRotate(root);
            }

            if (balance < -1 && GetBalance(root.Right) <= 0)
                return LeftRotate(root);

            if (balance < -1 && GetBalance(root.Right) > 0)
            {
                root.Right = RightRotate(root.Right);
                return LeftRotate(root);
            }

            return root;
        }

        private Node LeftRotate(Node root)
        {
            Node newRoot = root.Right;
            root.Right = newRoot.Left;
            newRoot.Left = root;
            return newRoot;
        }

        private Node RightRotate(Node root)
        {
            Node newRoot = root.Left;
            root.Left = newRoot.Right;
            newRoot.Right = root;
            return newRoot;
        }

        private int GetBalance(Node node)
        {
            if (node == null)
                return 0;

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return leftHeight - rightHeight;
        }

        private int GetHeight(Node node)
        {
            if (node == null)
                return 0;

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        
    }
}
