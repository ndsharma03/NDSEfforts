namespace ThreadSafeFileWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Parallel.Invoke( ()=>WriteToFileWitMutex(), ()=> ReadFromFile());


        }
        public static void ReadFromFile()
        {
            Action[] actions = new Action[] {
                () => {

                    ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
                    Console.WriteLine(tsf.ThreadSafeFileReader("C:\\temp\\TestFile.txt"));
                },
                () => {
                    ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();

                    Console.WriteLine(tsf.ThreadSafeFileReader("C:\\temp\\TestFile.txt"));
                },
                () => {
                    ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
                    Console.WriteLine(tsf.ThreadSafeFileReader("C:\\temp\\TestFile.txt"));
                }
            };
            Parallel.Invoke(actions);
        }


        //Thread SAFE.
        public static void WriteToFileWitMutex()
        {
            //Creating array of Actions to Write to file using Parallel lib.

            Action[] actions = new Action[] {
                ()=>{

            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");

                    Console.WriteLine( "Thread1 execued");
                },
                    ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                        Console.WriteLine( "Thread2 execued");
                },
                        ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread3 execued");
                },
                                 ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread4 execued");
                },
                                          ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread5 execued");
                },
                                                   ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread6 execued");
                },
                                                            ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread7 execued");
                },
               ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread8 execued");
                },
                ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread9 execued");
                }
            };
            Parallel.Invoke(actions);
        }
        public static void WriteToFileWithoutMutex()
        {
            //Creating array of Actions to Write to file using Parallel lib.

            Action[] actions = new Action[] {
                ()=>{

            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");

                    Console.WriteLine( "Thread1 execued");
                },
                    ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                        Console.WriteLine( "Thread2 execued");
                },
                        ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread3 execued");
                },
                                 ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread4 execued");
                },
                                          ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread5 execued");
                },
                                                   ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread6 execued");
                },
                                                            ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread7 execued");
                },
               ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread8 execued");
                },
                ()=>{
            ThreadSafeFileWriter tsf = new ThreadSafeFileWriter();
            tsf.WriteToFile_Unsafe("Hello", "C:\\temp\\TestFile.txt");
                            Console.WriteLine( "Thread9 execued");
                }
            };
            Parallel.Invoke(actions);
        }
    }
}