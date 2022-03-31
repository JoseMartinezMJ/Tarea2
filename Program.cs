using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas_Interfaces
{
    internal class Program
    {
        //Declaracion de funcion Principal
        static void Main(string[] args)
        {
            int var;
            CelularBaseAbstracta CelularSamsung = new ClaseSamsung("Samsung A30s", "SAMSUNG", "Android 9", 32, 290);
            CelularBaseAbstracta CelularApple = new ClaseApple("iPhone 13 Pro Max", "iPhone", "iOS 15", 256, 1200);
            CelularBaseAbstracta CelularXiaomi = new ClaseXiaomi("Xiaomi Poco X3 GT", "Xiaomi", "Android", 256, 429);
            CelularBaseAbstracta CelularHuawei = new ClaseHuawei("Nova 8i", "Huawei", "Android", 128, 389);

            //----------------------------------------------------------------------------------------------------

            Console.WriteLine("\t---------- CATALOGO DE CELULARES ----------");
            Console.WriteLine("\tVer informacion de celulares (Presione 1)");
            Console.WriteLine("\tSALIR (Presione 0)");
            var = int.Parse(Console.ReadLine());
             switch (var)
             {
                 case 1:
                     Console.Clear();
                     Console.WriteLine("----- PRODUCTO # 1-----");
                     Console.WriteLine("NOMBRE: "+CelularSamsung.Nombre);
                     Console.WriteLine("MARCA: "+CelularSamsung.Marca);
                     Console.WriteLine("SISTEMA: "+CelularSamsung.Software);
                     Console.WriteLine("ALMACENAMIENTO: "+CelularSamsung.Almacenamiento+" GB");
                     Console.WriteLine("PRECIO: $"+CelularSamsung.Precio+"\n");
                     Console.WriteLine("----- PRODUCTO # 2-----");
                     Console.WriteLine("NOMBRE: "+CelularApple.Nombre);
                     Console.WriteLine("MARCA: "+CelularApple.Marca);
                     Console.WriteLine("SISTEMA: "+CelularApple.Software);
                     Console.WriteLine("ALMACENAMIENTO: "+CelularApple.Almacenamiento+" GB");
                     Console.WriteLine("PRECIO: $"+CelularApple.Precio+"\n");
                     Console.WriteLine("----- PRODUCTO # 3-----");
                     Console.WriteLine("NOMBRE: " + CelularXiaomi.Nombre);
                     Console.WriteLine("MARCA: " + CelularXiaomi.Marca);
                     Console.WriteLine("SISTEMA: " + CelularXiaomi.Software);
                     Console.WriteLine("ALMACENAMIENTO: " + CelularXiaomi.Almacenamiento + " GB");
                     Console.WriteLine("PRECIO: $" + CelularXiaomi.Precio + "\n");
                     Console.WriteLine("----- PRODUCTO # 4-----");
                     Console.WriteLine("NOMBRE: " + CelularHuawei.Nombre);
                     Console.WriteLine("MARCA: " + CelularHuawei.Marca);
                     Console.WriteLine("SISTEMA: " + CelularHuawei.Software);
                     Console.WriteLine("ALMACENAMIENTO: " + CelularHuawei.Almacenamiento + " GB");
                     Console.WriteLine("PRECIO: $" + CelularHuawei.Precio + "\n");
                    break;
                 case 0:
                     Environment.Exit(0);
                     break;

                 default:
                     Console.WriteLine("Error");
                     break;

             }
            Console.ReadKey();  
        }
    }
}
