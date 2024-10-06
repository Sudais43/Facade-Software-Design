using System;
namespace Facade.Structural
{
    /// <summary> 
    /// Facade Design Pattern 
    /// </summary> 
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            // Wait for user 
            Console.ReadKey();
        }
    }

    /// <summary> 
    /// The 'Subsystem ClassA' class 
    /// </summary> 

    public class HardDisk
    {
        public void Bootup()
        {
            Console.WriteLine(" HardDisk run.......");
        }

        public void ShutDown()
        {
            Console.WriteLine("HardDisk Shutting Down........");
        }
    }

    /// <summary> 
    /// The 'Subsystem ClassB' class 
    /// </summary> 

    public class CPU
    {
        public void BootUp()
        {
            Console.WriteLine(" CPU Boot........");
        }
        public void ShutDown()
        {
            Console.WriteLine("CPU Shutting Down.......");
        }
    }

    /// <summary> 
    /// The 'Subsystem ClassC' class 
    /// </summary> 

    public class RAM
    {
        public void BootUP()
        {
            Console.WriteLine(" RAM runing.......");
        }

        public void ShutDown()
        {
            Console.WriteLine("RAM Shutting Down.......");
        }
    }

    /// <summary> 
    /// The 'Subsystem ClassD' class 
    /// </summary> 

  

    /// The 'Facade' class 
    public class Facade
    {
        HardDisk one;
        CPU two;
        RAM three;
       
        public Facade()
        {
            one = new HardDisk();
            two = new CPU();
            three = new RAM();
            
        }
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.Bootup();
            two.BootUp();
            three.BootUP();
        }
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            one.ShutDown();
            three.ShutDown();
            two.ShutDown();
        }
    }
}