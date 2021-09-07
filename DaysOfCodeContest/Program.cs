using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Program
    {
        
        static void Main()
        {
            #region INPUT
            //int age = 18;
            //int[] arr = new int[] { 1, 4, 3, 2 };
            //int[][] arr = new int[][] { new int[] { -1, -1,  0, -9, -2, -2 },
            //                            new int[] { -2, -1, -6, -8, -2, -5 },
            //                            new int[] { -1, -1, -1, -2, -3, -4 },
            //                            new int[] { -1, -9, -2, -4, -4, -5 },
            //                            new int[] { -7, -3, -3, -2, -9, -9 },
            //                            new int[] { -1, -3, -1, -2, -4, -5 } };

            #endregion INPUT

            #region OUTPUT
            //Node head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = insert(head, data);
            //}
            //display(head);

            //14    Loops.PrintNumbers(2);
            //LoopsReview.PrintChars();

            //string[] inputs = Console.ReadLine().Split();
            //string firstName = inputs[0];
            //string lastName = inputs[1];
            //int id = Convert.ToInt32(inputs[2]);
            //int numScores = Convert.ToInt32(Console.ReadLine());
            //inputs = Console.ReadLine().Split();
            //int[] scores = new int[numScores];
            //for (int i = 0; i < numScores; i++)
            //{
            //    scores[i] = Convert.ToInt32(inputs[i]);
            //}

            //Student s = new Student(firstName, lastName, id, scores);
            //s.printPerson();
            //Console.WriteLine("Grade: " + s.Calculate() + "\n");

            //String title = Console.ReadLine();
            //String author = Console.ReadLine();
            //int price = Int32.Parse(Console.ReadLine());
            //Book new_novel = new MyBook(title, author, price);
            //new_novel.display();

            //Convert.ToInt32(Console.ReadLine());
            //int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            //Difference d = new Difference(a);
            //d.computeDifference();
            //Console.Write(d.maximumDifference);

            //string S = Console.ReadLine();
            //ExceptionsStrToInt.Parsetointexception(S);

            //Calculator myCalculator = new Calculator();
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    string[] num = Console.ReadLine().Split();
            //    int n = int.Parse(num[0]);
            //    int p = int.Parse(num[1]);
            //    try
            //    {
            //        int ans = myCalculator.power(n, p);
            //        Console.WriteLine(ans);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

            //// read the string s.
            //string s = Console.ReadLine();
            //// create the Solution class object p.
            //QueuesAndStacks obj = new QueuesAndStacks();
            //// push/enqueue all the characters of string s to stack.
            //foreach (char c in s)
            //{
            //    obj.pushCharacter(c);
            //    obj.enqueueCharacter(c);
            //}
            //bool isPalindrome = true;
            //// pop the top character from stack.
            //// dequeue the first character from queue.
            //// compare both the characters.
            //for (int i = 0; i < s.Length / 2; i++)
            //{
            //    if (obj.popCharacter() != obj.dequeueCharacter())
            //    {
            //        isPalindrome = false;

            //        break;
            //    }
            //}
            //// finally print whether string s is palindrome or not.
            //if (isPalindrome)
            //{
            //    Console.Write("The word, {0}, is a palindrome.", s);
            //}
            //else
            //{
            //    Console.Write("The word, {0}, is not a palindrome.", s);
            //}

            //int n = Int32.Parse(Console.ReadLine());
            //AdvancedArithmetic myCalculator = new Calculator();
            //int sum = myCalculator.divisorSum(n);
            //Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);

            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            //BubbleSort.Sort(a);

            //Node2 root = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while ( T-- > 0 )
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    root = BSTLevelOrderSearch.insert(root, data);
            //}
            //BSTLevelOrderSearch.levelOrder(root);

            //Node root = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while ( T-- > 0 )
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    root = BST.Insert(root, data);
            //}
            //int height = BST.GetHeight(root);
            //Console.WriteLine();
            //Console.WriteLine(height);

            //DataTypes.PrintDataTypes();
            //Operators.Solve(12.00, 20, 8);
            //Conditionals.Condition(2);
            //Person p = new Person(age);
            //p.amIOld();
            //for ( int j = 0; j < 3; j++ )
            //{
            //    p.yearPasses();
            //}
            //p.amIOld();

            //Loops.PrintNumbers(3);
            //LoopsReview.PrintChars();
            //Arrays.PrintReverse(4, arr);
            //DictionariesAndMaps.PrintCellNumber();
            //Console.WriteLine(FactorialRec.Factorial(3));
            //BinaryNumbers.BinaryConvertion(5);
            //D2Arrays.MD2Arrays(arr);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] intArray = new int[n];
            //for ( int i = 0; i < n; i++ )
            //{
            //    intArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            ////n = Convert.ToInt32(Console.ReadLine());
            ////string[] stringArray = new string[n];
            ////for ( int i = 0; i < n; i++ )
            ////{
            ////    stringArray[i] = Console.ReadLine();
            ////}
            //Generics.PrintArray<Int32>(intArray);
            //Generics.PrintArray<String>(stringArray);

            //Node head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = MoreLinkedLists.insert(head, data);
            //}
            //head = MoreLinkedLists.removeDuplicates(head);
            //MoreLinkedLists.display(head);

            //int numtestCases = int.Parse(Console.ReadLine());
            //int[] testCases = new int[numtestCases];
            //for (int i = 0; i < numtestCases; i++)
            //{
            //    testCases[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int test in testCases)
            //{
            //    Console.WriteLine(RunningTimeandComplexity.IsPrime(test));
            //}

            //string[] firstDate = Console.ReadLine().Split();
            //string[] seconDate = Console.ReadLine().Split();
            //int actualDay     = int.Parse(firstDate[0]);
            //int actualMonth   = int.Parse(firstDate[1]);
            //int actualYear    = int.Parse(firstDate[2]);
            //int expectedDay   = int.Parse(seconDate[0]);
            //int expectedMonth = int.Parse(seconDate[1]);
            //int expectedYear  = int.Parse(seconDate[2]);
            //NestedLogic.FineCalculation(actualDay, expectedDay, 
            //                            actualMonth, expectedMonth, 
            //                            actualYear, expectedYear);

            //List<string> names = new List<string>();
            //int N = Convert.ToInt32(Console.ReadLine());
            //for (int NItr = 0; NItr < N; NItr++)
            //{
            //    string[] firstNameEmailID = Console.ReadLine().Split(' ');
            //    string firstName = firstNameEmailID[0];
            //    string emailID = firstNameEmailID[1];
            //    names.Add(RegExPatternsDB.GetName(firstName, emailID));
            //}
            //names.Sort();
            //names.RemoveAll(r => r == null);
            ////foreach (string nm in names)
            ////{
            ////        Console.WriteLine(nm);
            ////}
            //names.ForEach(n => Console.WriteLine(n));

            //List<int> bits = new List<int>();
            //int ts = Convert.ToInt32(Console.ReadLine());
            //for (int tItr = 0; tItr < ts; tItr++)
            //{
            //    string[] nk = Console.ReadLine().Split(' ');
            //    int n = Convert.ToInt32(nk[0]);
            //    int k = Convert.ToInt32(nk[1]);
            //    bits.Add(BitwiseAND.BiggestBitwise(n, k));
            //}
            //bits.ForEach(bi => Console.WriteLine(bi));


            #endregion OUTPUT


            //Stopping execution statements
            Console.WriteLine();
            Console.WriteLine("Please, hit any key to continue...");
            Console.ReadLine();
        }
    }
}
