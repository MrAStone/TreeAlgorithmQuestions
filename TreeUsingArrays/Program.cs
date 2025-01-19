namespace TreeUsingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q2();


        }
        static void Q1()
        {
            char[] Data = new char[7] { 'C', 'I', 'E', 'H', 'B', 'Y', 'Q' };
            int[] Dir1 = new int[7] { 1, 2, -1, -1, 5, -1, -1 };
            int[] Dir2 = new int[7] { 4, 3, -1, -1, 6, -1, -1 };
            Traversal(0, Data, Dir1, Dir2);
        }

        static void Traversal(int startNode, char[] Data, int[] Dir1, int[] Dir2)
        {
            int current = startNode;
            int pos = 0;
            int[] stack = new int[4];
            stack[pos] = current;
            while (pos != -1)
            {
                current = stack[pos];
                pos--;
                Console.WriteLine(Data[current]);
                if (Dir2[current] != -1)
                {
                    pos++;
                    stack[pos] = Dir2[current];
                }
                if (Dir1[current] != -1)
                {
                    pos++;
                    stack[pos] = Dir1[current];
                }

            }
        }
        static void Q2()
        {
            char[] A = new char[] { '+', '4', '*', '9', '6' };
            int[] B = new int[] { 1, -1, 3, -1, -1 };
            int[] C = new int[] { 2, -1, 4, -1, -1 };
            Travers(0, A, B, C);

        }
        static void Travers(int pos, char[] A, int[] B, int[] C)
        {
            if (B[pos] !=-1)
            {
                Travers(B[pos], A, B, C);
            }
            if (C[pos] !=-1)
            {
                Travers(C[pos], A, B, C);
            }
            Console.WriteLine(A[pos]);
        }
    }
}
