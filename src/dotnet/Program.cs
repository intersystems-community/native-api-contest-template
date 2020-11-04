using System;

using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

public class IRISNative
{
   
    public static void Main(String[] args)
    {
        try
        {
            // open connection to InterSystems IRIS instance using connection string
            IRISConnection conn = new IRISConnection();
            
            // edit this ConnectionString to match your environment
            conn.ConnectionString = "Server=localhost; Port=1972; Namespace=User; Password=SYS; User ID=_system; SharedMemory=false; logfile=./dbnative.log";
            conn.Open();
            
            
            // create IRIS Native object
            IRIS iris = IRIS.CreateIRIS(conn);

            Console.WriteLine("[1. Setting and getting a global]");
            
            // setting and getting a global
            // ObjectScript equivalent: set ^testglobal("1") = 8888
            iris.Set(8888, "^testglobal", "1");

            // ObjectScript equivalent: set globalValue = $get(^testglobal("1"))
            Int16? globalValue = iris.GetInt16("^testglobal", "1");

            Console.WriteLine("The value of ^testglobal(1) is " + globalValue);
            Console.WriteLine();

            
            Console.WriteLine("[2. Iterating over a global]");

            // modify global to iterate over
            // ObjectScript equivalent: set ^testglobal("1") = 8888
            // ObjectScript equivalent: set ^testglobal("2") = 9999
            iris.Set(8888, "^testglobal", "1");
            iris.Set(9999, "^testglobal", "2");

            // iterate over all nodes forwards
            Console.WriteLine("walk forwards");
            IRISIterator subscriptIter = iris.GetIRISIterator("^testglobal");
            foreach (var node in subscriptIter)
            {
                Console.WriteLine("subscript=" + subscriptIter.CurrentSubscript + ", value=" + node);
            }
            Console.WriteLine();
            

            Console.WriteLine("[3. Calling a class method]");

            // calling a class method
            // ObjectScript equivalent: set returnValue = ##class(%Library.Utility).Date(5)
            String returnValue = iris.ClassMethodString("%Library.Utility", "Date", 5);
            Console.WriteLine(returnValue);

            Console.WriteLine();

            IRISReference freeMB = new IRISReference(0); // set inital value to 0
            String dir = "C:/InterSystems/IRIS/mgr/iristemp"; // directory to be tested
            Object status = null;

            Console.Write("\n\nCalling %SYS.DatabaseQuery.GetDatabaseFreeSpace()... ");
            status = iris.ClassMethodObject("%SYS.DatabaseQuery","GetDatabaseFreeSpace",dir,freeMB);
            Console.WriteLine("\nFree space in " + dir + " = " + freeMB.value + "MB");

            // close IRIS object and connection
            iris.Close();
            conn.Close();
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}