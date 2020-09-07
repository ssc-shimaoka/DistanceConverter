using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 1 && args[0] == "-tom")
            {
                printFeelToMeterList(1, 10);
            }
            else
            {
                printMeterToFeelList(1, 10);
            }

            Console.ReadKey();
        }

        //**********************************************
        // フィートからメートルに変換する関数
        //**********************************************
        static void printFeelToMeterList(int start, int stop)
        {
            for(int feet = start; feet <= stop; feet++)
            {
                double meter = FeetConverter.ToMeter(feet);

                // 画面表示
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        //**********************************************
        // メートルからフィートに変換する関数
        //**********************************************
        static void printMeterToFeelList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = FeetConverter.FromMeter(meter);

                // 画面表示
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
