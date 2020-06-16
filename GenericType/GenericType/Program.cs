using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic type custom class
            //Mylist intList = new Mylist();
            //GenericList<int> intList = new GenericList<int>();
            //intList.SetIndex(10);
            //Console.WriteLine(intList.GetIndex(0));


            //Mylist1 strList = new Mylist1();
            GenericList<string,object> strList = new GenericList<string,object>();
            strList.SetIndex("Kamran");
            //Console.WriteLine(strList.GetIndex(0));

            Person p1 = new Person("Seynur");
            Person p2 = new Person("Eli");
            Person p3 = new Person("Javidan");
            //Mylist2 personList = new Mylist2();
            GenericList<Developer,object> personList = new GenericList<Developer, object>();
            //personList.SetIndex(p1);
            //personList.SetIndex(p2);
            //personList.SetIndex(p3);
            //Console.WriteLine(personList.GetIndex(0));

            GenericList<bool,object> boolList = new GenericList<bool,object>();

            #endregion

            #region Generic type method
            //ReturnType(5);
            //ReturnType("Zahid");
            //ReturnType<int>(5);
            //ReturnType<string>("Zahid");
            //GenericMeth<int,string>(5,"word");
            #endregion

            #region ArrayList
            //ArrayList arrList = new ArrayList();
            //arrList.Add(5);
            //arrList.Add(true);
            //arrList.Add("Seynur");
            //arrList.Add(new int[] { 1, 2, 3 });
            //arrList.Add(5);
            //arrList.Clear();
            //arrList.Remove("Seynur");
            //arrList.RemoveAt(3);
            //Console.WriteLine(arrList.Contains(16)); 
            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            //List<int> intList = new List<int>();
            //List<string> sList = new List<string>();
            //List<Person> pList = new List<Person>();
            //intList.Add(4);
            //intList.Add(40);
            //intList.Add(400);
            //intList.Add(4000);
            //Console.WriteLine(intList[0]);
            //sList.Add("Kamil");
            #endregion

            #region Dictionary
            Dictionary<string, string> phone = new Dictionary<string, string>();
            phone.Add("Kamran", "0512373434");
            phone.Add("Seynur", "0552373434");
            phone.Add("Javidan", "0702373434");
            phone.Add("Eli", "0502373434");
            //phone.Clear();
            //Console.WriteLine(phone.ContainsValue("Seynur"));
            //Console.WriteLine(phone["Kamran"]);
            //foreach (var item in phone)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            #endregion

            #region Queue - FIFO-first in first out
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Kamran");
            //queue.Enqueue("Seynur");
            //queue.Enqueue("Eli");
            ////Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Novbedekiler:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack- LIFO - last in first out
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Kamran");
            //stack.Push("Seynur");
            //stack.Push("Eli");
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("Novbedekiler:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
        #region Generic type method
        //public static U GenericMeth<T,U>(T n,U s)
        //{
        //    return s;
        //}
        //public static string NonGenericMeth(int n,string str)
        //{
        //    return str;
        //}

        //public static int NonGenericMeth(bool n, int str)
        //{
        //    return str;
        //}
        //public static T ReturnType<T, U>(T n) where T : U
        //public static T ReturnType<T>(T n) where T : struct
        //{
        //    return n;
        //}
        //public static T ReturnType<T>(T n)
        //{
        //    return n;
        //}
        //public static int ReturnType(int n)
        //{
        //    return n;
        //}

        //public static string ReturnType(string n)
        //{
        //    return n;
        //}

        //public static bool ReturnType(bool n)
        //{
        //    return n;
        //}

        //public static Person ReturnType(Person n)
        //{
        //    return n;
        //}

        #endregion
    }
    #region Generic type custom class
    //class GenericList<T> where T : struct
    class GenericList<T,U> where T:U
    {
        private T[] _list;
        public GenericList()
        {
            _list = new T[0];
        }

        public void SetIndex(T n)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = n;
        }

        public T GetIndex(int index)
        {
            return _list[index];
        }
    }

    //class Mylist
    //{
    //    private int[] _list;
    //    public Mylist()
    //    {
    //        _list = new int[0];
    //    }

    //    public void SetIndex(int n)
    //    {
    //        Array.Resize(ref _list, _list.Length+1);
    //        _list[_list.Length - 1] = n;
    //    }

    //    public int GetIndex(int index)
    //    {
    //        return _list[index];
    //    }
    //}

    //class Mylist1
    //{
    //    private string[] _list;
    //    public Mylist1()
    //    {
    //        _list = new string[0];
    //    }

    //    public void SetIndex(string n)
    //    {
    //        Array.Resize(ref _list, _list.Length + 1);
    //        _list[_list.Length - 1] = n;
    //    }

    //    public string GetIndex(int index)
    //    {
    //         return _list[index];
    //    }
    //}

    //class Mylist2
    //{
    //    private Person[] _list;
    //    public Mylist2()
    //    {
    //        _list = new Person[0];
    //    }

    //    public void SetIndex(Person n)
    //    {
    //        Array.Resize(ref _list, _list.Length + 1);
    //        _list[_list.Length - 1] = n;
    //    }

    //    public Person GetIndex(int index)
    //    {
    //        return _list[index];
    //    }
    //}


    class Person
    {
        public string Name { get; set; }
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    class Developer : Person
    {

    }
    #endregion
}
