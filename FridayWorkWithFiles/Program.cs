using System;
using System.IO;

namespace FridayWorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Help Me!");
            Console.WriteLine("What file do you want to move to fruit folder ?");
            string userInput = Console.ReadLine();
            MoveFileFruit(userInput);
            Console.WriteLine("What file do you want to move to vegetables folder ?");
            string userInput2 = Console.ReadLine();
            MoveFileVegetables(userInput2);
            FileDeleteCheese();
            FileDeleteToiletPaper();
        }
        public static void MoveFileFruit(string Name)
        {
            string sourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = $"{Name}.txt";
            
            if(File.Exists(Path.Combine(sourceDirectory, fileName)))
            {
               File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
                Console.WriteLine("File moved.");
            }else
            {
                Console.WriteLine("File not found.");
            }
            
            

            
        }
        public static void MoveFileVegetables(string Name)
        {
            string sourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName = $"{Name}.txt";

            if (File.Exists(Path.Combine(sourceDirectory, fileName)))
            {
                File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
                Console.WriteLine("File moved.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            
            

            
        }
        public static void FileDeleteCheese()
        {
            string rootPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName = "cheese.txt";
            if(File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("Cheese has been deleted.");
            }else
            {
                Console.WriteLine("Cheese has not been found.");
            }

        }
        public static void FileDeleteToiletPaper()
        {
            string rootPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = "toiletPaper.txt";
            if(File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("Toilet paper has been deleted.");
            }else
            {
                Console.WriteLine("Toilet paper has not been found.");
            }
        }
    }
}
