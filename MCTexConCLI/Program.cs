using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCTexCon;

namespace MCTexConCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the path to the existing texture map image file.");
            //string imageInPath = Console.ReadLine();
            //Console.WriteLine("Please enter the path to save the new file to.");
            //string imageOutPath = Console.ReadLine();
            //Console.WriteLine("Please enter the path to the FROM texture map json file.");
            //string mapInPath = Console.ReadLine();
            //Console.WriteLine("Please enter the path to the TO texture map json file.");
            //string mapOutPath = Console.ReadLine();

            string imageInPath = @"C:\Users\nheri\Desktop\MCTexConTest\InImage.png";
            string imageOutPath = @"C:\Users\nheri\Desktop\MCTexConTest\OutImage.png";
            string mapInPath = @"C:\Users\nheri\Desktop\MCTexConTest\MapIn.json";
            string mapOutPath = @"C:\Users\nheri\Desktop\MCTexConTest\MapOut.json";

            MCTexCon.MCTexCon converter = new MCTexCon.MCTexCon(imageInPath, imageOutPath, mapInPath, mapOutPath);
            converter.SaveToFile();

            //Console.ReadLine();
        }
    }
}
