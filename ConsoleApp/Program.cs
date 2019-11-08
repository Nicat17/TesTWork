using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IBook<out T>
    {
        T Read();
    }
    interface INoteBook<in T>
    {
        void Write<T>(T arg) where T : class, new();
    }

    class Book<T> : IBook<T>
    {
        public T Read()
        {
            T obj = (T)Activator.CreateInstance(typeof(T));
            return obj;
        }
    }



    class NewsPaper<T> : INoteBook<T>
    {
        public void Write<T>(T arg) where T : class, new()
        {
            
        }
    }

    class CopyBook<T> : INoteBook<T>
    {
        public void Write<T>(T arg) where T :class,new()
        {
            
        }
    }

    class Paper
    {

    }
    class Sheet : Paper
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            //INoteBook<Sheet> noteBook = new CopyBook<Paper>();

            Sheet sheet = (new Paper()) as Sheet;

            Console.ReadLine();
        }
    }
}
