using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    internal class Program
    {
        static bool IsUniq(int?[] arr, int elem)
        {
            if (arr[0] == null)
            {
                return true;
            }
            foreach (var item in arr)
            {
                if (item == elem)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsUniq(int[] arr, int elem)
        {
            foreach (var item in arr)
            {
                if (item == elem)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //int chet = 0, nochet = 0, uniq = 0;
            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 5);
            //}
            //int?[] temp = new int?[10];
            //for (int i = 0;i < temp.Length; i++) 
            //{
            //    temp[i] = null;
            //}
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //    if (item % 2 == 0)
            //    {
            //        chet++;
            //    }
            //    else
            //    {
            //        nochet++;
            //    }
            //    if (IsUniq(temp, item) == true)
            //    {
            //        for (int i = 0; i < temp.Length; i++)
            //        {
            //            if (temp[i] == null)
            //            {
            //                temp[i] = item;
            //                break;
            //            }
            //        }

            //    }
            //}
            //Console.Write("Array: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("amount chet: " + chet);
            //Console.WriteLine("amount nechet: " + nochet);
            //Console.Write("uniq: ");
            //foreach (var item in temp)
            //{
            //    Console.Write(item + " ");
            //    if (item != null)
            //    {
            //        uniq++;
            //    }                
            //}
            //Console.WriteLine();
            //Console.WriteLine("amount uniq: " + uniq);

            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 2);
            //}
            //Console.Write("Array: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //int grade;
            //Console.Write("Enter Num: ");
            //Int32.TryParse(Console.ReadLine(), out grade);
            //foreach (var item in arr) 
            //{
            //    if (item < grade)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //string str = "";
            //string sequence = "";
            //int count_sequence = 0;
            //Console.Write("Enter sequence: ");
            //sequence = Console.ReadLine();
            //for (int i = 0; i < arr.Length - sequence.Length + 1; i++)
            //{
            //    for (int j = 0; j < sequence.Length; j++)
            //    {
            //        str += arr[i + j].ToString();
            //    }
            //    if (str == sequence)
            //    {
            //        count_sequence++;
            //    }
            //    str = "";
            //}
            //Console.WriteLine(count_sequence);
            //int M = 10;
            //int N = 10;
            //int[] arr = new int[M];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 5);
            //}
            //Console.Write("Array: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int[] arr2 = new int[N];
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = random.Next(0, 5);
            //}
            //Console.Write("Array: ");
            //foreach (var item in arr2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int?[] arr3 = new int?[Math.Max(M,N)];
            //for (int i = 0;i < arr3.Length; i++) 
            //{
            //    arr3[i] = null;
            //}

            //for (int i = 0; i < arr3.Length; i++) 
            //{
            //    if (M > N)
            //    {
            //        if (!IsUniq(arr2, arr[i]) && IsUniq(arr3, arr[i]))
            //        {
            //            for (int j = 0; j < arr3.Length; j++)
            //            {
            //                if (arr3[j] == null)
            //                {
            //                    arr3[i] = arr[i];
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    else 
            //    {
            //        if ((!IsUniq(arr, arr2[i])) && IsUniq(arr3, arr2[i]))
            //        {
            //            for (int j = 0; j < arr3.Length; j++)
            //            {
            //                if (arr3[j] == null)
            //                {
            //                    arr3[j] = arr2[i];
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            //foreach (var item in arr3)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //int[,] array = new int[,]
            //{
            //    {5, 10, 15},
            //    {20, 25, 30},
            //    {35, 40, 45}
            //};

            //int rows = array.GetLength(0);
            //int cols = array.GetLength(1);

            //int min = array[0, 0];
            //int max = array[0, 0];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        if (array[i, j] < min)
            //        {
            //            min = array[i, j];
            //        }

            //        if (array[i, j] > max)
            //        {
            //            max = array[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("MIN: " + min);
            //Console.WriteLine("MAX: " + max);
            //Console.Write("Enter sentenses:");
            //string input = Console.ReadLine();

            //input = input.Trim();

            //int wordCount = 0;
            //bool isWord = false;

            //foreach (char c in input)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        if (!isWord)
            //        {
            //            wordCount++;
            //            isWord = true;
            //        }
            //    }
            //    else
            //    {
            //        isWord = false;
            //    }
            //}

            //Console.WriteLine("Word count: " + wordCount);
            //Console.Write("Enter sentenses: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //string reversedSentence = "";

            //foreach (string word in words)
            //{
            //    char[] charArray = word.ToCharArray();
            //    Array.Reverse(charArray);
            //    string reversedWord = new string(charArray);
            //    reversedSentence += reversedWord + " ";
            //}

            //Console.WriteLine("Before reverse: " + reversedSentence.Trim());
            //Console.Write("Enter sentenses: ");
            //string input = Console.ReadLine();

            //int vowelCount = 0;
            //string vowels = "aeiouAEIOUуёеыаоэяиюУЕЁАОЭЯИЮ";

            //foreach (char c in input)
            //{
            //    if (vowels.Contains(c))
            //    {
            //        vowelCount++;
            //    }
            //}

            //Console.WriteLine("Count vowel: " + vowelCount);
            //Console.Write("Enter string:");
            //string inputString = Console.ReadLine();

            //Console.WriteLine("Enter word for search: ");
            //string searchWord = Console.ReadLine();

            //int count = 0;
            //int index = inputString.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase);

            //while (index != -1)
            //{
            //    count++;
            //    index = inputString.IndexOf(searchWord, index + searchWord.Length, StringComparison.OrdinalIgnoreCase);
            //}

            //Console.WriteLine($"Count enter word \"{searchWord}\" in string: {count}");
        }
    }    
}
