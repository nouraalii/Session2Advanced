using System.Collections;

namespace Session2Assignment
{
    internal class Program
    {
        #region Question2
        public static bool IsPalindrome(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Question3
        public static void ReverseQueueUsingStack(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        public static void PrintQueue(Queue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question4
        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        #endregion

        #region Question5
        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqueList = new List<int>();

            foreach (int num in arr)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }
            return uniqueList.ToArray();
        }
        #endregion

        #region Question6
        public static void RemoveOddNumbers(ArrayList arrList)
        {
            for (int i = arrList.Count - 1; i >= 0; i--)
            {
                if ((int)arrList[i] % 2 != 0)
                {
                    arrList.RemoveAt(i);
                }
            }
        }
        #endregion

        #region Question8
        public static void SearchTargetInStack(Stack<int> stack, int target)
        {
            int count = 0;

            Stack<int> tempStack = new Stack<int>();

            while (stack.Count > 0)
            {
                int current = stack.Pop();
                count++;

                if (current == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }
                tempStack.Push(current);
            }
            Console.WriteLine("Target was not found");

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
        }
        #endregion

        #region Question9
        public static List<int> FindIntersection(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);

            List<int> result = new List<int>();

            int i = 0, j = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] == array2[j])
                {
                    result.Add(array1[i]);
                    i++;
                    j++;
                }
                else if (array1[i] < array2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result;
        }
        #endregion

        #region Question10
        public static List<int> FindSubarrayWithTargetSum(List<int> arrayList, int targetSum)
        {
            int start = 0;
            int currentSum = 0;

            for (int end = 0; end < arrayList.Count; end++)
            {
                currentSum += arrayList[end];

                while (currentSum > targetSum && start <= end)
                {
                    currentSum -= arrayList[start];
                    start++;
                }

                if (currentSum == targetSum)
                {
                    List<int> subarray = new List<int>();
                    for (int i = start; i <= end; i++)
                    {
                        subarray.Add(arrayList[i]);
                    }
                    return subarray;
                }
            }

            return new List<int>();
        }
        #endregion

        #region Question11
        public static Queue<int> ReverseFirstKElements(Queue<int> queue, int K)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < K; i++)
            {
                if (queue.Count > 0)
                    stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remainingElements = queue.Count - K;
            for (int i = 0; i < remainingElements; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
        } 
        #endregion
        static void Main(string[] args)
        {
            #region Question1
            ////Question1
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of queries:");
            //int q = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter Array Elements");
            //    arr[i] = int.Parse(Console.ReadLine());  
            //}

            //int[] results = new int[q];

            //for (int i = 0; i < q; i++)
            //{
            //    Console.WriteLine($"Enter Query Elements");
            //    int x = int.Parse(Console.ReadLine());

            //    int count = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (arr[j] > x)
            //        {
            //            count++;
            //        }
            //    }

            //    results[i] = count;
            //}

            //Console.WriteLine("Output:");
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region Question2
            ////Question2
            //Console.WriteLine("Enter the Array size");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter Array Elements");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //if (IsPalindrome(arr))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //} 
            #endregion

            #region Question3
            ////Question3
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine("Original Queue:");
            //PrintQueue(queue);

            //ReverseQueueUsingStack(queue);

            //Console.WriteLine("\nReversed Queue:");
            //PrintQueue(queue); 
            #endregion

            #region Question4
            ////Question4
            //Console.WriteLine("Enter a string of parentheses:");
            //string input = Console.ReadLine();

            //if (IsBalanced(input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Unbalanced");
            //} 
            #endregion

            #region Question5
            ////Question5
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter Array Elements");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int[] uniqueArray = RemoveDuplicates(arr);

            //Console.WriteLine("Array without duplicates:");
            //foreach (int num in uniqueArray)
            //{
            //    Console.Write(num + " ");
            //} 
            #endregion

            #region Question6
            ////Question6
            //Console.WriteLine("Enter the size of the array list:");
            //int n = int.Parse(Console.ReadLine());
            //ArrayList arrList = new ArrayList();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter elements:");
            //    arrList.Add(int.Parse(Console.ReadLine()));
            //}

            //RemoveOddNumbers(arrList);

            //Console.WriteLine("ArrayList after removing odd numbers:");
            //foreach (var item in arrList)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

            #region Question7
            ////Question7
            //Queue queue = new Queue();

            //queue.Enqueue(1);            
            //queue.Enqueue("Apple");     
            //queue.Enqueue(5.28);        

            //Console.WriteLine("Items in the queue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question8
            ////Question8
            //Console.WriteLine("Enter the number of integers to push onto the stack:");
            //int n = int.Parse(Console.ReadLine());

            //Stack<int> stack = new Stack<int>();

            //Console.WriteLine("Enter the integers:");
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    stack.Push(num);
            //}

            //Console.WriteLine("Enter the target:");
            //int target = int.Parse(Console.ReadLine());

            //SearchTargetInStack(stack, target); 
            #endregion

            #region Question9
            ////Question9
            //Console.WriteLine("Enter the size of the first array:");
            //int n1 = int.Parse(Console.ReadLine()); 

            //Console.WriteLine("Enter the size of the second array:");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter elements of the first array:");
            //int[] array1 = new int[n1];
            //for (int i = 0; i < n1; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements of the second array:");
            //int[] array2 = new int[n2];
            //for (int i = 0; i < n2; i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //List<int> intersection = FindIntersection(array1, array2);

            //Console.WriteLine("Intersection:");
            //Console.WriteLine("[" + string.Join(",", intersection) + "]"); 
            #endregion

            #region Question10
            ////Question10
            //Console.WriteLine("Enter the number of elements in the array:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the elements of the array:");
            //List<int> arrayList = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    arrayList.Add(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("Enter the target sum:");
            //int targetSum = int.Parse(Console.ReadLine());

            //List<int> result = FindSubarrayWithTargetSum(arrayList, targetSum);

            //if (result.Count > 0)
            //{
            //    Console.WriteLine("Subarray with target sum:");
            //    Console.WriteLine("[" + string.Join(", ", result) + "]");
            //}
            //else
            //{
            //    Console.WriteLine("No subarray with the given sum was found.");
            //} 
            #endregion

            #region Question11
            ////Question11
            //Console.WriteLine("Enter the number of elements in the queue:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the elements of the queue:");
            //Queue<int> queue = new Queue<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    queue.Enqueue(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("Enter the value of K:");
            //int k = int.Parse(Console.ReadLine());

            //queue = ReverseFirstKElements(queue, k);

            //Console.WriteLine("Modified Queue: ");
            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion
        }
    }
}
