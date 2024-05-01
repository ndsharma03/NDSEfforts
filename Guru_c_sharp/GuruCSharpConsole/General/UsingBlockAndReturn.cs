using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharpConsole.General
{
    public class ABCTest
    {
        int K { get; set; }
    }

    public class DisposableClass : IDisposable
    {
        public string name { get; set; }
        public FileStream fileTowork { get; set; }
        public void Dispose()
        {
            name = null;
            fileTowork.Dispose();

        }
    }
    class UsingBlockAndReturn
    {
        #region Using Test
        /// <summary>
        /// We can return from using block 
        /// but what ever objects(unmanaged/managed) we use in dipose() will be null and not accessible.
        /// </summary>
        
            
            //public static void Main()
            //{


            //    #region Connection
            //    DisposableClass objDisposable = GetDispableClass();
            //    Console.WriteLine(objDisposable.name);

            //    #endregion
            //    #region File --> Using
            //    //Exception --> File is already closed
            //    FileStream f = GetStram();
            //    Console.Write(f.CanRead);
            //    f.Write(new byte[] { 33 }, 0, 1);
            //    #endregion
            //}


            public static DisposableClass GetDispableClass()
            {
                using (DisposableClass dip = new DisposableClass())
                {
                    dip.fileTowork = File.Create("P:\\Abc.txt");
                    dip.name = "Niranjan";
                    return dip;
                }
            }
            public static FileStream GetStram()
            {
                using (FileStream f = File.Create("P:\\Abc.txt"))
                {
                    bool b = f.CanWrite;
                    return f;
                }
            }
            public static SqlConnection GetConnection()
            {
                using (SqlConnection con = new SqlConnection("Server=.;database=ABCD;uid=sa;password=sa"))
                {
                    con.Open();
                    return con;
                }
            }

        }
    
}
        #endregion