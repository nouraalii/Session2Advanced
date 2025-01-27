using System.Collections;
using Microsoft.VisualBasic;

namespace Session2Demo
{
    internal class Program
    {

        public static void printArrayList(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (int item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        } 

        public static int SumArrayList(ArrayList list)
        {
            int sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i] is int)
                        sum += (int)list[i]; // UnBoxing [ReferenceType] to [Valuetype] - Unsafe
                }
                
            }
            return sum;

        }

        public static void PrintList<T>(List<T> values) 
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }

            }
            return Sum;
        }

        public static void PrintLinkedList(LinkedList<int> list)
        {
            Console.Write("null");

            foreach (int item in list)
            {
                Console.Write($"<- {item} ->");
            }
            Console.WriteLine("null");
            Console.WriteLine();
        }

        public static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region what is collection?
            //Collection:built-in Ds in c#
            //Array : container 

            //collections in c# 
            //lists
            //hashtables 



            //Generic - Non-Generic
            //Lists:
            //Non-Generic Lists : Array - stack - Queue
            //Generic Lists : Lists - linkedlist - stack - queue


            //Hashtables:
            //Non-Generic Hashtables: HashTable
            //Generic hashtables : Dictionary - sortedDictionary 
            #endregion


            #region ArrayList
            //Lists
            //Non-Generic Lists : ArrayList

            //ArrayList Like Array
            //Array Based
            //Index

            //Array indexed collection     : Fixed size 
            //Arraylist indexed collection : Dynamic size


            //Index : 0 1 2 3 4 5
            //items : 4 5 6 7 8 1
            //size:6

            //Arr[1]-->5

            //int[] Number = { 6, 5, 3, 2, 4, 7, 9 };

            //Console.WriteLine(Number[1]);

            //Number[1] =12;
            //Console.WriteLine(Number[1]);

            //ArrayList list = new ArrayList(6);

            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");

            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");

            //ArrayList list = new ArrayList();

            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");
            //list.Add(5);
            //list.Add(6);
            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");
            //list.Add(7);
            //list.Add(8);
            //list.Add(9);
            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list.AddRange(new[] {10,11,12});

            //printArrayList(list);

            //int Index = list.BinarySearch(2);

            //Console.WriteLine(Index);

            //Employee E01 = new Employee() { Id =1 , Name ="Noura" , Age = 29 , Salary =22000}; 
            //Employee E02 = new Employee() { Id =1 , Name ="Noura" , Age = 29 , Salary =22000}; 
            //Employee E03 = new Employee() { Id =1 , Name ="Noura" , Age = 29 , Salary =22000}; 
            //Employee E04 = new Employee() { Id =1 , Name ="Noura" , Age = 29 , Salary =22000}; 


            //ArrayList list1 = new ArrayList();
            //list1.AddRange(new Employee[] { E01, E02, E03, E04 });

            //int Index = list1.BinarySearch(new Employee() { Name = "Noura" }, new EmployeeComparerName());


            //Console.WriteLine("=====================");
            //foreach (var item in list) 
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);

            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");
            //list.Clear();
            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");

            //bool Flag = list.Contains(20);
            //Console.WriteLine(Flag);

            //int[] Arr = new int[4];

            //list.CopyTo(Arr,2);

            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //list.GetRange(0, 2);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int I =list.IndexOf(2);
            //Console.WriteLine(I);

            //list.Insert(0,100);
            //printArrayList(list);

            //list.InsertRange(0, new[] { 10 , 20 ,30 ,40});
            //printArrayList(list);

            //int I =list.LastIndexOf(5);
            //Console.WriteLine(I);

            //list.Remove(3);
            //list.RemoveAt(5);
            //list.RemoveRange(0,3);
            //list.Reverse();
            //list.SetRange(0, new[] { 10, 20, 30});
            //list.Sort();

            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");

            //list.TrimToSize(); // Delete /Release

            //Console.WriteLine($"listCount {list.Count} , capcity {list.Capacity}");

            //printArrayList(list); 
            #endregion

            #region Problem with Non-Generic Lists [ArrayList]
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //list.Add("Hello world");
            //list.Add(new Employee());
            //list.Add(2.3);


            //int Sum = SumArrayList(list);
            //Console.WriteLine(Sum);
            #endregion


            #region Generic Lists : Lists
            // Generic Lists : List
            // List : Version of Generic ArrayList

            //List<int> list = new List<int>(new int[] {1,2,3,4});
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add("Hello World"); // Compiler

            //PrintList(list);

            //int sum = SumList(list);
            //Console.WriteLine(sum);

            //list.AddRange(new int[] { 10, 20, 30, 40,50});

            //list.AsReadOnly();
            //int index= list.BinarySearch(20);

            //Console.WriteLine(index);

            //PrintList(list);

            //Employee E01 = new Employee() { Id = 1, Name = "Malak", Salary = 12000, Age = 29 };
            //Employee E02 = new Employee() { Id = 2, Name = "Mariam", Salary = 13000, Age = 30 };
            //Employee E03 = new Employee() { Id = 3, Name = "Noura", Salary = 15000, Age = 35 };
            //Employee E04 = new Employee() { Id = 4, Name = "Nada", Salary = 1000, Age = 32 };

            //List<Employee> employees = new List<Employee>(){ E01,E02,E03,E04} ;

            //int i = employees.BinarySearch(E01,new EmployeeComparerName());
            //Console.WriteLine(i);

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.EnsureCapacity(10);

            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //List<int> result = list.GetRange(0, 2);

            //PrintList(result);

            //list.Sort();
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            //list.TrimExcess();
            //Console.WriteLine($"Count : {list.Count} , Capacity : {list.Capacity}");

            #endregion


            #region Generic LinkedLists
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddFirst(2);

            //list.AddLast(1);
            //list.AddLast(2);

            //LinkedListNode<int> node = new LinkedListNode<int>(3);
            //list.AddLast(node);

            //list.AddAfter(node, 4);

            //LinkedListNode<int> result =list.Find(1);
            //list.AddBefore(result, 4);

            //Console.WriteLine(list.First.Value);
            //Console.WriteLine(list.Last.Value);

            //list.Clear();

            //Console.WriteLine(list.First.Next.Value);

            //list.Remove(list.First);
            //list.Remove(2);
            //list.RemoveLast();
            //list.Remove(list.Last);

            //PrintLinkedList(list); 
            #endregion


            #region Generic Stack
            // Generic Lists : Stack

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //int top=stack.Pop();
            //Console.WriteLine(top);

            //int top = stack.Peek();
            //Console.WriteLine(top);

            //stack.Peek();
            //bool flag = stack.TryPeek(out int top);
            //stack.Pop();
            //bool flag = stack.TryPop(out int top);

            //PrintStack(stack);

            //Console.WriteLine(top);

            //Undo:Ctrl+Z 
            #endregion


            #region Generic Queue
            // Generic Lists : Queue

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2); 
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //queue.Dequeue();

            //queue.Peek();

            //PrintQueue(queue); 
            #endregion
        }
    }
}
