namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int inputSum = 0;
           
           
                while (input.Count > 0)
                {
                    int index = int.Parse(Console.ReadLine());
                    
                    if (index < 0)
                    {
                        int num = input[0];
                        inputSum += num;
                        input[0] = input[input.Count - 1];
                        for (int j = 0; j < input.Count; j++)
                        {
                            if (input[j] <= num)
                            {
                                input[j] += num;
                            }
                            else
                            {
                                input[j] -= num;
                            }
                        }
                    }

                    else if (index >= input.Count)
                    {
                        
                        int num = input[input.Count - 1];
                        inputSum += num;
                        input[input.Count - 1] = input[0];
                        for (int j = 0; j < input.Count; j++)
                        {
                            if (input[j] <= num)
                            {
                                input[j] += num;
                            }
                            else
                            {
                                input[j] -= num;
                            }
                        }
                       
                        
                    }

                    else
                    {
                        
                        int num = input[index];
                        inputSum += num;
                        input.RemoveAt(index);
                        for (int j = 0; j < input.Count; j++)
                        {
                            if (num >= input[j])
                            {
                                input[j] += num;
                            }
                            else
                            {
                                input[j] -= num;

                            }
                        }
                        
                    }
                }
                Console.WriteLine(inputSum);




        }

            
        }
    }

