using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class ENumerable
    {
        public static void GenericEnum()
        {
            var enumerable = Enumerable.Range(1, 10).GetEnumerator();
            try
            {

                while (true)
                {
                    var result = enumerable.MoveNext();
                    Console.WriteLine(enumerable.Current);
                    if (result == false)
                    {
                        break;
                    }
                }
            }
            finally
            {
                if (enumerable is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            }
        }
    }
