namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            List<int> listOfNumbers = new List<int>();
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("P print numbers\nA add a number \nM display mean of numbers\nS display the smallest number\nL display the largest number\nF find a number\nC cleaner the whole list\nAS sort asc\nDS sort des\nSW swap\nQ quit");
                Console.WriteLine("------------------------");
                string choise = Console.ReadLine().ToLower();

                switch (choise)
                {
                    case "p":
                        if (listOfNumbers.Count == 0)
                        {
                            Console.WriteLine(" [] The List Of Numbers is Empty");
                            break;
                        }
                        else { 
                              Console.Write("[ ");
                              for (int i = 0; i < listOfNumbers.Count; i++)
                              {
                                 Console.Write($"{listOfNumbers[i]} ");
                               }
                               Console.WriteLine("]");
                               break; }
                    case "a":
                        Console.WriteLine("Enter The number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        bool inList = false;
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (num == listOfNumbers[i])
                            {
                                inList = true;
                            }
                        }
                        if (inList)
                        {
                            Console.WriteLine($"{num} is already in the list");
                        }
                        else
                        {
                            listOfNumbers.Add(num);
                            Console.WriteLine($"{num} Added");
                        }
                        break;
                    case "m":
                        if (listOfNumbers.Count == 0)
                        {
                            Console.WriteLine($"The List Of Numbers is Empty");
                        }
                        else
                        {
                            double sum = 0;
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                sum += listOfNumbers[i];
                            }
                            Console.WriteLine($"{sum / listOfNumbers.Count}");
                        }
                        break;
                    case "s":
                        if (listOfNumbers.Count == 0)
                        {
                            Console.WriteLine($"The List Of Numbers is Empty");
                        }
                        else
                        {
                            int smallNumber = listOfNumbers[0];
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] < smallNumber)
                                {
                                    smallNumber = listOfNumbers[i];
                                }
                            }
                            Console.WriteLine($"Smallest Number Is : {smallNumber}");
                        }
                        break;
                    case "l":
                        if (listOfNumbers.Count == 0)
                        {
                            Console.WriteLine($"The List Of Numbers is Empty");
                        }
                        else
                        {
                            int largeNumber = listOfNumbers[0];
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] > largeNumber)
                                {
                                    largeNumber = listOfNumbers[i];
                                }
                            }
                            Console.WriteLine($"Largest Number Is : {largeNumber}");
                        }
                        break;
                    case "f":
                        Console.WriteLine("Enter The number");
                        int findNumber = Convert.ToInt32(Console.ReadLine());
                        bool isFound = false;
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (listOfNumbers[i] == findNumber)
                            {
                                Console.WriteLine($"Needed number in index : {i}");
                                isFound = true;
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine($"The number {findNumber} is not in the list");
                        }
                        
                        break;
                    case "c":
                        listOfNumbers.Clear();
                        Console.WriteLine("The List Of Numbers is Cleared");
                        break;
                    case "as":
                        for (int i = 0; i < listOfNumbers.Count - 1; i++)
                        {
                            for (int k = 0; k < listOfNumbers.Count - i - 1; k++)
                            {
                                if (listOfNumbers[k] > listOfNumbers[k + 1])
                                {
                                    int temp = listOfNumbers[k];
                                    listOfNumbers[k] = listOfNumbers[k + 1];
                                    listOfNumbers[k + 1] = temp;
                                }
                            }
                        }
                        Console.Write("[ ");
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            Console.Write($"{listOfNumbers[i]} ");
                        }
                        Console.WriteLine("]");

                        break;
                    case "ds":
                        for (int i = 0; i < listOfNumbers.Count - 1; i++)
                        {
                            for (int k = 0; k < listOfNumbers.Count - i - 1; k++)
                            {
                                if (listOfNumbers[k] < listOfNumbers[k + 1])
                                {
                                    int temp = listOfNumbers[k];
                                    listOfNumbers[k] = listOfNumbers[k + 1];
                                    listOfNumbers[k + 1] = temp;
                                }
                            }
                        }
                        Console.Write("[ ");
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            Console.Write($"{listOfNumbers[i]} ");
                        }
                        Console.WriteLine("]");
                        break;
                    case "sw":
                        if (listOfNumbers.Count == 0)
                        {
                            Console.WriteLine("The List Of Numbers is Empty");
                            break;
                        }
                        else if (listOfNumbers.Count == 1)
                        {
                            Console.WriteLine("The List Of Numbers has only one element, no swap possible");
                            break;
                        }
                        else
                        {
                            string swapInput;
                            Console.WriteLine("Enter the first index to swap:");
                            int firstIndex = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the second index to swap:");
                            int secondIndex = Convert.ToInt32(Console.ReadLine());
                            bool isValidFirstIndex = false;
                            bool isValidSecondIndex = false;
                            for (int i = 0; i < listOfNumbers.Count; i++)
                            {
                                if (listOfNumbers[i] == firstIndex)
                                {
                                    isValidFirstIndex = true;
                                    for (int j = 0; j < listOfNumbers.Count; j++)
                                    {
                                        if (listOfNumbers[j] == secondIndex)
                                        {
                                            isValidSecondIndex = true;
                                            int tempSwap = listOfNumbers[i];
                                            listOfNumbers[i] = listOfNumbers[j];
                                            listOfNumbers[j] = tempSwap;
                                            firstIndex = listOfNumbers[i];
                                            secondIndex = listOfNumbers[j];
                                            break;
                                        }
                                    }
                                    if (!isValidSecondIndex)
                                    {
                                        Console.WriteLine($"The second index {secondIndex} is not valid");
                                        break;
                                    }
                                }
                            }
                            if (!isValidFirstIndex)
                            {
                                Console.WriteLine($"The first index {firstIndex} is not valid");
                                break;
                            }
                            Console.WriteLine($"Swapped elements at indices {firstIndex} and {secondIndex}");


                            break;
                        }
                    case "q":
                        Console.WriteLine("quit");
                        isQuit = true;
                        break;
                    default:
                        Console.WriteLine("Invaliad Choise");
                        break;
                }
            } while (!isQuit);
        }
    }
}
