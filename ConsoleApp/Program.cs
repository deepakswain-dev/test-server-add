using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate a, b, c;
            a = new TestDelegate(Method1);
            a = Method1;

            a("hello");
            b = Method2;

            c = a + b;
            c(" word");

            var number = Enumerable.Range(0, 99);
            var evenNumber = number.Where(new Func<int, bool>(Number));
        }

        static bool Number(int number)
        {
            return number % 2 == 0;
        }

        static void Method1(string test)
        {
            Console.WriteLine("Method1" + test);
        }

        static void Method2(string test)
        {
            Console.WriteLine("Method2" + test);
        }

    }

    internal delegate void TestDelegate(string test);

    

    class A
    {
        public virtual string AMethod()
        {
            return "A class AMethod Called";
        }


        public async Task metho1dName()
        {
            throw new NotImplementedException();
        }


        public async Task methodName()
        {
            throw new NotImplementedException();
        }

    }

    class B : A
    {
        public override string AMethod()
        {
            return "Derive method called";
        }
    }


    internal static class EnumerableExtention
    {

        public static T SingleExtention<T>(this IEnumerable<T> sequence, Func<T, bool> predecate, Func<IEnumerable<T>, Exception> exception)
        {
            var matchedItem = new List<T>();

            foreach (var item in sequence)
            {
                if (predecate(item))
                {
                    matchedItem.Add(item);
                }
            }

            if (matchedItem.Count == 1)
            {
                return matchedItem[0];
            }

            else
            {
                throw exception(matchedItem);
            }
        }

    }

    [Serializable]
    public class MyException : Exception
    {
       //Test exception
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    class MyClass
    {

    }


}
