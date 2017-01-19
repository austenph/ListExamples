using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myfirstlist = new List<int>();
            myfirstlist.Add(1);
            myfirstlist.Add(2);
            myfirstlist.Add(3);
            myfirstlist.Add(6);
            myfirstlist.Add(8);

            Console.WriteLine(myfirstlist.Count);//how many items are in the list (5), property called Count 
            foreach (int number in myfirstlist)
            {
                Console.Write(number);//print out the elements in a list 
            }
                myfirstlist.Clear();//method to clear elements in a list

                int[] myArray = { 1, 2, 3, 6, 8, 9, 10 };
                List<int> arrayList = new List<int>(myArray);
                Console.WriteLine(arrayList.Count);
            int[] array = new int[3];
            List<int> list = new List<int>(array);
            int[] convertList = list.ToArray();//create an array from list

            //list.Add();
            //list.Remove();

            //PUTTING IT ALL TOGETHER!
            List<int> birthdays = new List<int>();//created list
            birthdays.Add(14);//added data
            birthdays.Add(24);//added data
            birthdays.Add(14);//added data  
            birthdays.Add(18);//added data
            birthdays.Add(30);//added data
            Console.WriteLine(birthdays.Count);//prints the number of elements in the list (5)
            birthdays.Clear();//clears all the data in the list
            int[] randomArray = { 1, 2, 3, 4, 5, 6, 7 };//created a random array
            birthdays = randomArray.ToList<int>();//converted randomArray to my birthdays list
            birthdays.Remove(5);//removed the data "5"
            birthdays.RemoveAt(0);//removed whatever was at index 0
            Console.WriteLine(birthdays[4]);//prints out what is at index 4 ("7) because we removed two data points
            Console.WriteLine(birthdays[birthdays.IndexOf(2)]);//prints the instance of the data "2", starts at beginning
           randomArray = birthdays.ToArray();//converted the list back to the array called randomArray

            //Class example from slides: Create a list of strings containing your top 5 favorite animals. use a foreach loop to print out all elements
            List<string> favoriteAnimals = new List<string>();
            favoriteAnimals.Add("lion");
            favoriteAnimals.Add("turtle");
            favoriteAnimals.Add("dog");
            favoriteAnimals.Add("dragon");
            favoriteAnimals.Add("lizard");
            foreach(string animal in favoriteAnimals)
            {
                Console.Write(animal + " ");
            }



            }

        }
    }


