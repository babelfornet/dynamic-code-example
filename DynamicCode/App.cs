using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCode
{
    internal class App
    {
        #region Demo Code
        [Obfuscation(Feature = "msil encryption:id=feature1;source=demo;internal=true;password=1234", Exclude = false)]
        public void Feature1Demo()
        {
            Console.WriteLine("Feature1 Demo");
            Feature2Demo();
        }

        [Obfuscation(Feature = "msil encryption:id=feature2;source=demo;internal=true;password=1234", Exclude = false)]
        public static void Feature2Demo()
        {
            Console.WriteLine("Feature2 Demo");
        }

        #endregion

        #region Retail Code 
        [Obfuscation(Feature = "msil encryption:id=feature1;source=retail;internal=true;password=4567", Exclude = false)]
        public static void Feature1Retail()
        {
            Console.WriteLine("Feature1 Retail");
            Feature2Retail();
        }

        [Obfuscation(Feature = "msil encryption:id=feature2;source=retail;internal=true;password=4567", Exclude = false)]
        public static void Feature2Retail()
        {
            Console.WriteLine("Feature2 Retail");
        }

        #endregion

        #region Special Code
        [Obfuscation(Feature = "msil encryption:id=feature1;source=special;internal=false;password=0000", Exclude = false)]
        public static void Feature1Special()
        {
            Console.WriteLine("Feature1 Special");
            Feature2Special();
        }

        [Obfuscation(Feature = "msil encryption:id=feature2;source=special;internal=false;password=0000", Exclude = false)]
        public static void Feature2Special()
        {
            Console.WriteLine("Feature2 Special");
        }

        #endregion
    }
}
