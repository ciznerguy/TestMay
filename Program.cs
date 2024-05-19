using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMay
{
    internal class Program
    {

        // פעולה המקבלת מערך של שלמים ומספר
        // הפעולה תחזיר מערך חדש ללא המספר
        public static int[] Filter(int[] arr, int num)
        {
            int length = 0;
            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i] != num)
                {
                    length++;
                }
            }

            int[] arrToReturn = new int[length];
            int index = 0;
            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i] != num)
                {
                    arrToReturn[index] = arr[i];
                    index++;
                }
            }
            return arrToReturn;
        }

        public static TriNum AddArr(TriNum[] arr)
        {
            int sum = 0;
            for (int i =0; i < arr.Length;i++)
            {
                sum += arr[i].ReturnNum();
            }
            return new TriNum(sum);
        }

        // הפעולה מקבלת מערך של קבוצות
        // הפעולה מחזירה את שם הקבוצה שאספה הכי הרבה סוללות
        // בסוף הפעולה המערך נותר ללא שינוי
        public static string MaxGroup(Group[] arrGroup)
        {
            int indexMax = 0;
            int sumBottles = 0;
            int sumBatteries = 0, countForAvg = 0;
            for (int i = 0; i < arrGroup.Length; i++ )
            {
                if (arrGroup[i].GetBatteries() > arrGroup[indexMax].GetBatteries())
                {
                    indexMax = i;
                }
                sumBottles += arrGroup[i].GetBottles();
                if (arrGroup[i].GetBatteries() != 0)
                {
                    sumBatteries += arrGroup[i].GetBatteries();
                    countForAvg++;
                }
            }
            double avg = (double) sumBatteries / countForAvg;
            Console.WriteLine(avg);
            Console.WriteLine(sumBottles);

            return arrGroup[indexMax].GetName();
        }
        static void Main(string[] args)
        {
        }
    }
}
