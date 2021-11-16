using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЕnglishBreakfast
{
    class Program
    {
        static void Main(string[] args)
        {
            BreakfastSetUp(1000000, 1000000, 1000000);
            Console.ReadKey();
        }

       static void BreakfastSetUp(int MushroomsCount, int SlicesCount, int EggsCount)
        {
            Console.WriteLine("Start to cook breakfest!");
            CutMushrooms(MushroomsCount);
            FryAsync(SlicesCount, EggsCount, MushroomsCount).Wait();
            Console.WriteLine("Breakfeast ready! Have a nice meal");
       }
        static void CutMushrooms(int MushroomsCount)
        {
            Console.WriteLine($"{MushroomsCount} Mushrooms are ready to be Fried");
        }
        #region Fry

        static async Task FryAsync(int SlicesCount, int EggsCount, int MushroomsCount)
        {
            await Task.Run(() => FryObject(SlicesCount, "Slices"));
            await Task.Run(() => FryObject(EggsCount, "Eggs"));
            await Task.Run(() => FryObject(MushroomsCount, "Mushrooms"));
        }

        static void FryObject(int SlicesCount, string ObjectName)
        {
            Console.WriteLine($"{SlicesCount} {ObjectName} are ready");
        }

        #endregion
        
    }
}
