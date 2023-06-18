using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker
{
    public partial class PC
    {
        //Компьютеры, от 0 до 5. (для формы DNS)
        public static int[] NullPC = new int[6] { 0, 0, 0, 0, 0, 0 };

        public static int[] AnyPC = new int[6] { 0, 1, 2, 3, 4, 5};

        public static int[] FirstPC = new int[6] { 1, 1, 1, 1, 1, 1 };

        public static int[] SecondPC = new int[6] { 2, 2, 2, 2, 2, 2 };

        public static int[] ThirdPC = new int[6] { 3, 3, 3, 3, 3, 3 };

        public static int[] FourthPC = new int[6] { 4, 4, 4, 4, 4, 4 };

        public static int[] FifthPC = new int[6] { 5, 5, 5, 5, 5, 5 };

        //Метод для проверки массивов. (для формы DNS)
        public static bool Equals(int[] arr1, int[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
