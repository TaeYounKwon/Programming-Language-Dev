using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Backpack
{
    private double mainPocketWeight = 0;
    private double leftPocketWeight = 0;
    private double rightPocketWeight = 0;

    public double totalWeight;
    public
    //MAIN POCKET
     double InsertItemsInMainPocket(double firstWeight)
    {
        Console.WriteLine("You put {0}pounds in the main pocket.\n\n",firstWeight);

        if (firstWeight + mainPocketWeight <= 10)
        {
            mainPocketWeight = mainPocketWeight + firstWeight;
        }
        else
        {
            Console.WriteLine("You put too much weight in the main pocket!");
            Console.WriteLine(" The current main pocket weight is {0}pounds.\n\n",mainPocketWeight);
        }
        return mainPocketWeight;
    }
    public
    //RIGHT POCKET
    double InsertItemsInRightPocket(double secondWeight)
    {
        Console.WriteLine( "You put {0}pounds in the right pocket.\n\n",secondWeight);
        if (secondWeight + rightPocketWeight <= 5)
        {
            rightPocketWeight = rightPocketWeight + secondWeight;
        }
        else
        {
            Console.WriteLine ("You put too much weight into the right pocket!");
            Console.WriteLine("The current right pocket weight is {0}pounds.\n\n", rightPocketWeight);
        }
        return rightPocketWeight;
    }

    //LEFT POCKET
    public
    double InsertItemsInLeftPocket(double thirdWeight)
    {
        Console.WriteLine("You put {0}pounds in the left pocket.\n\n",thirdWeight);
        if (thirdWeight + leftPocketWeight <= 5)
        {
            leftPocketWeight = leftPocketWeight + thirdWeight;
        }
        else
        {
            Console.WriteLine("You put too much weight into the left pocket!");
            Console.WriteLine("The current main pocket weight is {0}pounds.\n\n",leftPocketWeight);
        }
        return leftPocketWeight;
    }
    //TOTAL WEIGHT
    public
    double GetTotalWeight()
    {
        totalWeight =  mainPocketWeight + leftPocketWeight + rightPocketWeight;
        Console.WriteLine("The current pocket weights are {0}, {1}, {2}.",mainPocketWeight,leftPocketWeight,rightPocketWeight);
        Console.WriteLine("The total Weight of 3 pockets is {0}.\n\n", totalWeight);
        return totalWeight;
    }

    public double RemoveItemsFromMainPocket(double removeWeight)
    {
        if (mainPocketWeight - removeWeight <= 10 && 0 <= mainPocketWeight - removeWeight)
        {
            mainPocketWeight = mainPocketWeight - removeWeight;
            Console.WriteLine("Now you have {0}pounds in the main pocket.\n\n", mainPocketWeight);
        }
        else if (mainPocketWeight - removeWeight < 0)
        {
            Console.WriteLine("You cannot take away {0}weight from the main pocket.",removeWeight);
            Console.WriteLine("The current main pocket weight is {0}pounds.\n\n", mainPocketWeight);
        }
        else
        {
            Console.WriteLine("Wrong input! Please try again!!\n\n" );
        }
        return mainPocketWeight;
    }

    public double RemoveItemsFromRightPocket(double removeWeight)
    {
        if (rightPocketWeight - removeWeight <= 5 && 0 <= rightPocketWeight - removeWeight)
        {
            rightPocketWeight = rightPocketWeight - removeWeight;
            Console.WriteLine("Now you have {0}pounds in the right pocket.\n\n", rightPocketWeight);
        }
        else if (rightPocketWeight - removeWeight < 0)
        {
            Console.WriteLine("You cannot take away {0}weight from the right pocket.", removeWeight);
            Console.WriteLine("The current right pocket weight is {0}pounds.\n\n", rightPocketWeight);
        }
        else
        {
            Console.WriteLine("Wrong input! Please try again!!\n\n");
        }
        return rightPocketWeight;
    }

    public double RemoveItemsFromLeftPocket(double removeWeight)
    {
        if (leftPocketWeight - removeWeight <= 5 && 0 <= leftPocketWeight - removeWeight)
        {
            leftPocketWeight = leftPocketWeight - removeWeight;
            Console.WriteLine("Now you have {0}pounds in the left pocket.\n\n", leftPocketWeight);
        }
        else if (leftPocketWeight - removeWeight < 0)
        {
            Console.WriteLine("You cannot take away {0}weight from the left pocket.",removeWeight);
            Console.WriteLine("The current left pocket weight is {0}pounds.\n\n", leftPocketWeight);
        }
        else
        {
            Console.WriteLine("Wrong input! Please try again!!\n\n");
        }
        return leftPocketWeight;
    }
};






namespace BackPack_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack SYSTEM=new Backpack();
            char options;
            int optionsAdd, optionsReduce;
            double fWeight, sWeight, tWeight, r1Weight, r2Weight, r3Weight;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\nWelcome to the Pocket Weight Systyem!");
                    Console.WriteLine("Please enter the letter to operate the menu below.");
                    Console.WriteLine("a. Add the weight in the pocket.");
                    Console.WriteLine("r. Reduce the weight in the pocket.");
                    Console.WriteLine("t. Total pocket weight.");
                    Console.WriteLine("e. Exit the program.");
                    Console.Write("Select the Menu : ");
                    string input = Console.ReadLine();
                    options = char.Parse(input);
                    Console.WriteLine("\n");
                    switch (options)
                    {   //Adding option
                        case 'a':
                            while (true)
                            {
                                Console.WriteLine("Thanks for choosing adding option!");
                                Console.WriteLine("Which pocket do you want to add the weight?");
                                Console.WriteLine("1. Main Pocket");
                                Console.WriteLine("2. Right Pocket");
                                Console.WriteLine("3. Left Pocket");
                                Console.WriteLine("4. If you want to quite type any other key.");
                                Console.Write("Select the pocket : ");
                                string input2 = Console.ReadLine();
                                optionsAdd = int.Parse(input2);
                                Console.WriteLine("\n");
                                if (optionsAdd == 1)
                                {
                                    Console.Write("Please type the amount of the weight that you want to put in the main pocket: ");
                                    string input3 = Console.ReadLine();
                                    fWeight = double.Parse(input3);
                                    SYSTEM.InsertItemsInMainPocket(fWeight);
                                    break;
                                }
                                else if (optionsAdd == 2)
                                {
                                    Console.Write("Please type the amount of the weight that you want to put in the right pocket: ");
                                    string input4 = Console.ReadLine();
                                    sWeight = double.Parse(input4);
                                    SYSTEM.InsertItemsInRightPocket(sWeight);
                                    break;
                                }
                                else if (optionsAdd == 3)
                                {
                                    Console.Write("Please type the amount of the weight that you want to put in the left pocket: ");
                                    string input5 = Console.ReadLine();
                                    tWeight = double.Parse(input5);
                                    SYSTEM.InsertItemsInLeftPocket(tWeight);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You type wrong value, Please type again!\n\n");
                                    break;
                                }
                            }
                            break;
                        //Reducing option
                        case 'r':
                            Console.WriteLine("\nThanks for choosing Reducing option!");
                            Console.WriteLine("Which pocket do you want to reduce the weight?");
                            Console.WriteLine("1. Main Pocket");
                            Console.WriteLine("2. Right Pocket");
                            Console.WriteLine("3. Left Pocket");
                            Console.WriteLine("4. If you want to quite type any other key.");
                            Console.Write("Select the pocket : ");
                            string input6 = Console.ReadLine();
                            optionsReduce = int.Parse(input6);
                            Console.WriteLine("\n");
                            if (optionsReduce == 1)
                            {
                                Console.Write("Please put the value that you want to remove from the main pocket: ");
                                string input7 = Console.ReadLine();
                                r1Weight = double.Parse(input6); 
                                SYSTEM.RemoveItemsFromMainPocket(r1Weight);
                                break;
                            }
                            else if (optionsReduce == 2)
                            {
                                Console.Write("Please put the value that you want to remove from the right pocket: ");
                                string input8 = Console.ReadLine();
                                r2Weight = double.Parse(input8);
                                SYSTEM.RemoveItemsFromRightPocket(r2Weight);
                                break;
                            }
                            else if (optionsReduce == 3)
                            {
                                Console.Write("Please put the value that you want to remove from the left pocket: ");
                                string input9 = Console.ReadLine();
                                r3Weight = double.Parse(input9);
                                SYSTEM.RemoveItemsFromLeftPocket(r3Weight);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You type wrong value, Please type again!\n\n");
                                break;
                            }
                        //Get total Value
                        case 't':
                            Console.WriteLine("\nWelcome to total weight menu!");
                            SYSTEM.GetTotalWeight();
                            break;
                        //Quite the program
                        case 'e':
                            goto EXIT;
                        default:
                            Console.WriteLine("You entered the wrong value, Please type again!\n\n");
                            break;
                    }
                }
            }
        EXIT:
            Console.WriteLine("Thanks for using my program!");
        }
    }
}