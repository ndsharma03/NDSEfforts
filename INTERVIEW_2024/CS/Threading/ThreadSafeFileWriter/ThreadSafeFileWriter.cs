using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafeFileWriter
{
    public class ThreadSafeFileWriter
    {
        public string ThreadSafeFileReader(string filePath)
        {
            string content = "";
            bool hasHandle = false;
            using (Mutex mutex = new Mutex(false, filePath.Replace("\\", "")))
            {
                try
                {

                    if (!File.Exists(filePath)) return content!;
                    hasHandle= mutex.WaitOne(10000, false);
                    content = File.ReadAllText(filePath);
                    return content;



                }
                catch (Exception ex){ Console.WriteLine(ex.Message); }
                finally { if (hasHandle) mutex.ReleaseMutex(); } 
            }
            return content;
        }
        public void WriteToFile_Unsafe(string content, string filePath)
{
    // Writing to file without any threadsafe construct.
    // will throw execcption while used by multiple threads
    try
    {
        using (StreamWriter w = File.AppendText(filePath))
        {
            w.WriteLine(content);
        }
    }
    catch (Exception ex)
    {
        Console.Write(ex.Message);
    }

}

        //Thread safe file writing with Mutex.
        public void WriteToFile(string content, string filePath)
{
    using (Mutex mutex = new Mutex(false, filePath.Replace("\\", "")))
    {
        bool hasHandle = false;
        try
        {

            hasHandle = mutex.WaitOne(Timeout.Infinite, false);
            using (StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(content);
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
        finally
        {
            if (hasHandle)
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
    }
}
