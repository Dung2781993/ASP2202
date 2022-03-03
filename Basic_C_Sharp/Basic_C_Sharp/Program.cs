using Basic_C_Sharp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_C_Sharp
{
    internal class Program
    {
        static List<List<int>> Permutes = new List<List<int>>();
        static void Main(string[] args)
        {
            //int[] inputArr = new int[] { 12, 3, 4, 1, 6, 9, 8, 13, -1  };
            //int sum = 24; 
            //var result = findThreeTriplet(inputArr, sum);


            //foreach (var item in result)
            //{
            //    foreach (var element in item)
            //    {
            //        Console.Write("{0} ", element);
            //    }

            //}

            var arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            var result2 = rotateArr(arrInt, k);
            Console.WriteLine(result2);

            /*
             *  $test = [];
             *  
             */
            var stringArr = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };

            //permutation
            var intArr = new int[] { 1, 2, 3 };
            //int to Roman
            var input = 10;
            var result = IntToRoman(input);
            Console.WriteLine(result);
            Console.ReadKey();

            //Create a new bank account

            var account = new BankAccount("Test1", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");


            //Encapsulation exercise
            var user = new User("Test1", "Test2");
            Console.WriteLine(user);
            

            //Photobook exercise
            PhotoBook myAlbum1 = new PhotoBook();
            Console.WriteLine(myAlbum1.GetNumberPages());

            PhotoBook myAlbum2 = new PhotoBook(24);
            Console.WriteLine(myAlbum2.GetNumberPages());

            SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());


            //Inheritance of objects Excercise
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }

        public static int[] rotateArr(int[] nums, int k)
        {
            int[] output = new int[nums.Length];
            int length = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                var index = (i + k) % nums.Length;
                output[index] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = output[i];
            }
            return nums;
        } 

        public static bool isValidAnagram(String s1, String s2)
        {
            if (s1 == null || s2 == null) return false;
            if (s1.Length != s2.Length) return false;

            var arr1 = s1.ToCharArray();
            var arr2 = s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for(var i = 0; i<arr1.Length; i++)
            {
                if(arr1[i] != arr2[i]) return false;
            }
            return true;
        }

        public static int MissingNumber(int[] nums)
        {
            // [3,0,1 ] => 2
            Array.Sort(nums); //[0,1,3]

            for(var i = 0; i<nums.Length; i++)
            {
                if(nums[i] != i)
                {
                    return i;
                }
            }
            return -1;
        }

        static void exampleArrayList()
        {
            var arrayList1 = new ArrayList();
            var arrayList2 = new ArrayList();

            arrayList1.Add("Item 1");
            arrayList1.Add("Item 2");
            arrayList1.Add("Item 3");
            arrayList1.Add("Item 4"); //Item 1, Item 2, Item 3, Item 4
            arrayList2.Add("Item ArrayList 2"); //Item ArrayList 2
            arrayList1.AddRange(arrayList2); // Item 1, Item 2, Item 3, Item 4, Item ArrayList 2
            arrayList1.Insert(2, "New Item"); // Item 1, Item 2, "New Item" ,Item 3, Item 4, Item ArrayList 2
            for (var i = 0; i < arrayList1.Count; i++)
            {
                Console.WriteLine(arrayList1[i]);
            }
        }

        static void exampleHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Key1", "Value1");
            hashtable.Add("Key2", "Value2");

            Console.WriteLine(hashtable["Key1"]);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("Key: {0} - Value: {1}", item.Key, item.Value);
            }

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("Key: {0} ", key);
            }
        }

        static void exampleSortedList()
        {
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            // Displays the properties and values of the SortedList.
            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");

            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < mySL.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", mySL.GetKey(i), mySL.GetByIndex(i));
            }
        }

        static void exampleStack()
        {
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
                Console.Write("    {0}", obj);

            //Count: 3
            //Values: !World    Hello
        }

        static void exampleQueue()
        {
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myQ)
                Console.Write("    {0}", obj);

            /*
            This code produces the following output.

            myQ
                Count:    3
                Values:    Hello    World    !
            */
        }

        static List<List<int>> Permute(int[] nums)
        {
            GetPermute(new List<int>(), nums);

            return Permutes;
        }

        static void GetPermute(List<int> list, int[] nums)
        {
            List<int> tempList = null;

            if (list.Count != nums.Length)
            {
                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    if (!list.Contains(nums[i]))
                    {
                        tempList = new List<int>(list);
                        tempList.Add(nums[i]);
                        GetPermute(tempList, nums);
                    }
                }
            }
            else
            {
                Permutes.Add(list);
            }
                
        }

        public static int findLongestString(string[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            var result = 0;

            foreach (var item in arr)
            {
                var element = item.Split(' ');

                if (element.Length > result)
                {
                    result = element.Length;
                }   
            }
            return result;
        }

        public static int checkExistedItem(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return -1;
            
            for(var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k) return i;
            }
            return -1;
        }

        static string IntToRoman(int num)
        {
            var hashtable = new Hashtable();
            hashtable.Add(1000, "M");
            hashtable.Add(900, "CM");
            hashtable.Add(500, "D");
            hashtable.Add(400, "CD");
            hashtable.Add(100, "C");
            hashtable.Add(90, "XC");
            hashtable.Add(50, "L");
            hashtable.Add(40, "XL");
            hashtable.Add(10, "X");
            hashtable.Add(9, "IX");
            hashtable.Add(5, "V");
            hashtable.Add(4, "IV");
            hashtable.Add(1, "I");

            var keys = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var output = new StringBuilder();

            foreach (int key in keys)
            {
                if (num / key > 0)
                {
                    for (int i = num / key; i > 0; i--)
                    {
                        output.Append(hashtable[key]);
                    }
                    num %= key;
                }
            }

            return output.ToString();
        }

        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                    dict[c] += 1;
                else
                    dict.Add(c, 1);
            }

            for (int i = 0; i < s.Length; i++)
                if (dict[s[i]] == 1)
                    return i;

            return -1;
        }


        static string findTheLongestString(string[] strArr)
        {
            if (strArr.Length == 0) return null;

            var result = strArr[0];
            foreach(var item in strArr)
            {
                if(item.Length > result.Length)
                {
                    result = item;
                }
            }
            return result;
        }

        public int[] MoveZeroes(int[] nums)
        {
            var result = new List<int>(); 
            // [1,3,0,2,0] => [1,3,2,0,0]
            for(var i = 0; i<nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    result.Add(nums[i]); //1,3,2
                }
            }

            for(var i = result.Count; i < nums.Length; i++)
            {
                result.Add(0);
            }

            return result.ToArray();
        }

        static bool isValidPassword(string password)
        {
            var rgx = new Regex("[^A-Za-z0-9]");
            return rgx.IsMatch(password);
        }
        

        static List<List<string>> GroupAnagrams(string[] strs)
        {
            var res = new List<List<string>>();
            var dic = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] arr = str.ToCharArray();
                Array.Sort(arr);
                var key = new string(arr); 

                if (dic.ContainsKey(key))
                    dic[key].Add(str);
                else
                    dic.Add(key, new List<string>() { str });
            }

            foreach (var kv in dic)
                res.Add(kv.Value);

            return res;
        }

        static List<int[]> findThreeTriplet(int[]arr, int sum)
        {
            var result = new List<int[]>();
            for (var i = 0; i< arr.Length -2; i++) // O(n)
            {
                for (var j = i+1; j < arr.Length -1; j++) // O (k)
                {
                    for(var k = j+1; k < arr.Length; k++) // O (h)
                    {
                        if( arr[i] + arr[j] + arr[k] == sum)
                        {
                            var subList = new int[3] { arr[i], arr[j], arr[k]};
                            result.Add(subList);
                        }
                    }
                }
            }


            return result;
        }

        static List<int> leastFrequent(int[] arr)
        {
            Array.Sort(arr);
            
            var dict = new Dictionary<int, int>(); 
            
            for(var i = 0; i<arr.Length; i++)
            {
                //kiem tra xem gia tri key da ton tai trong dictionary chua, neu chua co thi them vao, neu co roi thi cong them so lan xuat hien
                if(dict.ContainsKey(arr[i])) {
                    dict[arr[i]]++;
                } else
                {
                    dict.Add(arr[i], 1);
                }
            }

            var sortDictByKey = dict.OrderBy(x => x.Value);
            var result = new List<int>();

            var firstValue = sortDictByKey.First();

            foreach (var item in sortDictByKey)
            {
                //Lay gia tri cua key voi count giong nhau
                if(item.Value == firstValue.Value)
                {
                    result.Add(item.Key);
                }
            }

            return result;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public int IComparer<T>() { return 0; }
        public delegate bool Predicate<T>(T item);
        public struct Nullable<T> where T : struct { /*...*/ }





        class Book
        {
            public string Name { get; set; }

            public int Page { get; set; }
        }
        class Author
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
        interface IBaseRepository<T>
        {
            List<T> getAll();

            T Save(T item);
        }
        class BaseRepository<T> : IBaseRepository<T>
        {
            public List<T> getAll()
            {
                return new List<T>();
            }

            public T Save(T item)
            {
                return item;
            }
        }
        static void test()
        {
            BaseRepository<Book> bookRepository = new BaseRepository<Book>();
            BaseRepository<Author> authorRepository = new BaseRepository<Author>();
            Book book = bookRepository.Save(new Book { Name = "Book1", Page = 100 });
            Author author = authorRepository.Save(new Author { Name = "Author1", Age = 50 });

            Console.WriteLine("Book: {0} - page: {1}", book.Name, book.Page);
            Console.WriteLine("Name: {0} - age: {1}", author.Name, author.Age);


            Console.ReadLine();
        }


        static int Compare<T>(T first, T second)
        {
            if (first.Equals(second))
            {
                return 0;
            }

            return 1;
        }

        static void test2()
        {
            int result1 = Compare(2, 2);
            int result2 = Compare("abc", "def");

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
