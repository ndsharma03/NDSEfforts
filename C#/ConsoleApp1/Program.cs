using System.Threading.Tasks;

using System;
using System.Threading;
namespace GuruCSharpConsole.Threads
{
    public delegate void ErrorHandler(string errorMessage);
    //instead of string as input param we can also use Exception type as input param in delegate to get complete //exception details.

    class PassExceptionToMainThread
    {
       ////// public static ErrorHandler errorHandler;

        //////public static void Main()
        //////{
        //////    errorHandler += new ErrorHandler(ShowErrorMessage);

        //////    for (int i = 0; i < 50; i++)
        //////    {
        //////        Thread t = new Thread(() => { DivideByZero(5, 0, errorHandler); }); //Passing delegate to each thread.
        //////        t.Start();

        //////    }
        //////    Console.Read();
        //////}

        public static void DivideByZero(int a, int b, ErrorHandler eHandler)
        {
            try
            {
                double r = a / b;
                Console.WriteLine(" Result from thread {0} ={1}", Thread.CurrentThread.ManagedThreadId, r);
            }
            catch (Exception ex)
            {
                if (eHandler != null)
                {
                    eHandler("Thread=" + Thread.CurrentThread.ManagedThreadId + ex.Message);
                }
            }
        }

        public static void ShowErrorMessage(string err)
        {
            //MessageBox.Show(err);
            Console.WriteLine(err);
        }
    }
}