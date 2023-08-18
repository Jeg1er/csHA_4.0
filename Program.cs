namespace FRTH_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var firstNum = Int64.Parse(Console.ReadLine());
                var secondNum = Int64.Parse(Console.ReadLine());
                var thirdNum = Int64.Parse(Console.ReadLine());
                var result = WhichOfNumsIsTHeBiggest(firstNum, secondNum, thirdNum);
                Console.WriteLine(result);
            }
        }
        public static Int64 WhichOfNumsIsTHeBiggest(Int64 firstNum, Int64 secondNum, Int64 thirdNum)
        {
            if (firstNum != secondNum)
            {
                if (firstNum != thirdNum)
                {
                    if (firstNum > secondNum && firstNum > thirdNum)
                    {
                        return 1;
                    }
                    else if (firstNum < secondNum && firstNum < thirdNum)
                    {
                        if (secondNum > thirdNum)
                        {
                            return 2;
                        }
                        else if (secondNum < thirdNum)
                        {
                            return 3;
                        }
                    }

                }
                else if (firstNum == thirdNum)
                {
                    if (secondNum > thirdNum)
                    {
                        return 2;
                    }
                    else if (secondNum < thirdNum)
                    {
                        return 13;
                    }
                }

            }
            else if (firstNum == secondNum)
            {
                if (firstNum != thirdNum)
                {
                    if (secondNum > thirdNum)
                    {
                        return 12;
                    }
                    else if (secondNum < thirdNum)
                    {
                        return 3;
                    }
                }
                else if (firstNum == thirdNum)
                {
                    return 123;
                }
            }
            else if (secondNum != thirdNum)
            {
                if (secondNum != thirdNum)
                {
                    if (secondNum > thirdNum && secondNum > firstNum)
                    {
                        return 2;
                    }
                    else if (secondNum < thirdNum && secondNum < firstNum)
                    {
                        if (thirdNum > firstNum)
                        {
                            return 3;
                        }
                        else if (thirdNum < firstNum)
                        {
                            return 1;
                        }
                    }
                }
                else if (secondNum == thirdNum)
                {
                    if (secondNum > firstNum)
                    {
                        return 23;
                    }
                    else if (secondNum < firstNum)
                    {
                        return 1;
                    }
                }

            }
            else if (thirdNum == secondNum)
            {
                if (secondNum != firstNum)
                {
                    if (secondNum > firstNum)
                    {
                        return 12;
                    }
                    else if (secondNum < firstNum)
                    {
                        return 3;
                    }
                }
                else if (secondNum == firstNum)
                {
                    return 123;
                }
            }
            // -------
            else if (firstNum != thirdNum)
            {
                if (thirdNum != secondNum)
                {
                    if (thirdNum > secondNum && thirdNum > firstNum)
                    {
                        return 3;
                    }
                    else if (thirdNum < secondNum && thirdNum < firstNum)
                    {
                        if (secondNum > firstNum)
                        {
                            return 2;
                        }
                        else if (secondNum < firstNum)
                        {
                            return 1;
                        }
                    }

                }
                else if (thirdNum == secondNum)
                {
                    if (thirdNum > firstNum)
                    {
                        return 23;
                    }
                    else if (thirdNum < firstNum)
                    {
                        return 1;
                    }
                }

            }
            else if (firstNum == thirdNum)
            {
                if (secondNum != thirdNum)
                {
                    if (secondNum > thirdNum)
                    {
                        return 2;
                    }
                    else if (secondNum < thirdNum)
                    {
                        return 13;
                    }
                }
                else if (secondNum == thirdNum)
                {
                    return 123;
                }
            }
            //----
            else if (thirdNum != secondNum)
            {
                if (firstNum != thirdNum)
                {
                    if (thirdNum > secondNum && firstNum < thirdNum)
                    {
                        return 3;
                    }
                    else if (thirdNum < secondNum && firstNum >thirdNum)
                    {
                        if (secondNum > firstNum)
                        {
                            return 2;
                        }
                        else if (secondNum < firstNum)
                        {
                            return 1;
                        }
                    }

                }
                else if (firstNum == thirdNum)
                {
                    if (secondNum > thirdNum)
                    {
                        return 2;
                    }
                    else if (secondNum < thirdNum)
                    {
                        return 13;
                    }
                }

            }
            else if (thirdNum == secondNum)
            {
                if (firstNum != thirdNum)
                {
                    if (secondNum > firstNum)
                    {
                        return 32;
                    }
                    else if (secondNum < firstNum)
                    {
                        return 1;
                    }
                }
                else if (firstNum == thirdNum)
                {
                    return 123;
                }
            }
            return 23;
        }
    }
}