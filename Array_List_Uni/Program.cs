using System.Collections;
using System.Net.Http.Headers;

namespace Array_List_Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array

            int[] nums = new int[] { 5, 6, 7, 8, 9 };
            // 0 1 2 3 4
            int[] nums2 = new int[5];
            nums2[0] = 5;
            nums2[1] = 6;
            nums2[2] = 7;
            nums2[3] = 8;
            nums2[4] = 9;

            for (int i = 0; i < nums2.Length; i++)
            {
               // Console.WriteLine(nums2[i]);
            }

            int[] nums3 = { 5, 6, 8, 155, -54 };

            var words = new object[5];


            #endregion

            #region Dimensional And Jugged Array
            
            int[,] matrix = new int[3,4];
            int number2 = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = number2;
                    number2++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   // Console.Write(matrix[i,j] + " ");
                }
                //Console.WriteLine();
            }

            ///Jugged
            string[][] words2 = new string[3][];
            words2[0] = new string[] { "Azerbaycan", "Turkiye", "Ingiltere" };
            words2[1] = new string[] { "Hi", "Goodbye"};
            words2[2] = new string[] { "Leman", "Hesen", "Emil", "Mehdi" };

         //   Console.WriteLine("Words2 length : {0}", words2.Length);
            for (int i = 0; i < words2.Length; i++)
            {
                foreach (var item in words2[i])
                {
                   // Console.Write(item + @", ");
                }
              //  Console.WriteLine();
            }

            #endregion


            #region List

            List<int> nums4 = new List<int>();

            int number = 4;
            for (int i = 0; i < 10; i++)
            {
                nums4.Add(number);
                number += 4;
            }

            nums4.Add(89);
            nums4.Add(100);
            nums4.Add(-569);

            for (int i = 0; i < nums4.Count; i++)
            {
                //Console.WriteLine(nums4[i]);
            }

            List<int> nums5 = new List<int>() { 89, 100, -569, 1, 2, 3 };
            List<int> nums6 = new();

            #endregion

            #region ArrayList

            ArrayList arr = new ArrayList() { -895.54m, 89.54f, 0, false, "Goodbye" };
            arr.Add(5);
            arr.Add("hello");
            arr.Add(true);

            #endregion

            #region Queue

            Queue<int> que = new Queue<int>();

            //FIFO -first in first out

            #endregion

            #region Stack

            //LIFO - last in first out

            Stack<int> sta = new Stack<int>();
            sta.Push(5);
            sta.Push(10);
            sta.Push(25);

            foreach (var item in sta)
            {
               // Console.WriteLine(sta.Peek());
            }


            #endregion

            Console.ReadLine();

        }
    }
}