 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Nullable__Delegate__Exceptions_Practices
{
    internal class PracticeDelegate
    {

        #region Predicate


        //public delegate bool CheckNums(int num);

        //public bool ChechkNumByOdd(int number)
        //{
        //    return number % 2 == 1;
        //}
        //public bool CheckNumByEven(int number) => number % 2 == 0;

        //public bool CheckNumThanFive(int number) => number > 5;

        //public void CheckDelegate()
        //{
        //    List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };

        //    var res = nums.FindAll(m => m % 2 == 0 && m > 5).Sum(m => m);

        //    Console.WriteLine(SumOfListItems(m => m > 5, nums));


        //}





        //public int SumOfListItems(Predicate<int> func, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}




        //public int SumOfListByEven(List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}







        //static int SumOfListThanFive(List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;


        #endregion

        #region Action

        //public delegate void ChangeString(string str);

        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());
        //}

        //public void StringToLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());
        //}


        //public void CheckWord()
        //{
        //    //ShowWord(StringToUpper, "cavid");
        //    //ShowWord(StringToLower, "cavid");



        //    //ChangeString changeString = StringToUpper;
        //    //changeString += delegate (string str)
        //    //{
        //    //    Console.WriteLine(str.ToLower());
        //    //};
        //    //changeString("Qemlo");



        //    Action<string> action = StringToUpper;
        //    action += StringToLower;
        //    action("Qemdulla");
        //}



        //public void ShowWord(ChangeString func, string str)
        //{
        //    func(str);
        //}

        #endregion

        #region Func

        //public delegate int CheckString(string str);

        //public int GetStringLength(string word, int num)
        //{
        //    return word.Length + num;
        //}



        //public void ShowStringLength(Func<string, int, int> func, string text)
        //{
        //    Console.WriteLine(func(text, 10));
        //}

        //public void ShowString()
        //{
        //    //ShowStringLength(GetStringLength, "Masan");
        //    Func<string, int, int> func = GetStringLength;
        //    Console.WriteLine(func("Masan", 5));
        //}

        #endregion






    }



}


