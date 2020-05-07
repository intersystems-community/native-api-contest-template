import java.sql.DriverManager;

import com.intersystems.jdbc.IRISConnection;
import com.intersystems.jdbc.IRIS;
import com.intersystems.jdbc.IRISIterator;


public class IRISNative {

    protected static int superserverPort = 51773;
    protected static String namespace = "USER";
    protected static String username = "_SYSTEM";
    protected static String password = "SYS";

    public static void main(String[] args) {
        try {
            // open connection to InterSystems IRIS instance using connection string
            IRISConnection conn = (IRISConnection) DriverManager.getConnection("jdbc:IRIS://localhost:"+superserverPort+"/"+namespace,username,password);
            // create IRIS Native object
            IRIS iris = IRIS.createIRIS(conn);


            System.out.println("[1. Setting and getting a global]");

            // setting and getting a global
            // ObjectScript equivalent: set ^testglobal("1") = 8888
            iris.set(8888,"^testglobal","1");
            // ObjectScript equivalent: set globalValue = $get(^testglobal("1"))
            Integer globalValue = iris.getInteger("^testglobal","1");

            System.out.println("The value of ^testglobal(1) is " + globalValue);
            System.out.println();



            System.out.println("[2. Iterating over a global]");

            // modify global to iterate over
            // ObjectScript equivalent: set ^testglobal("1") = 8888
            // ObjectScript equivalent: set ^testglobal("2") = 9999
            iris.set(8888,"^testglobal","1");
            iris.set(9999,"^testglobal","2");

            // iterate over all nodes forwards
            IRISIterator subscriptIter = iris.getIRISIterator("^testglobal");
            System.out.println("walk forwards");
            while (subscriptIter.hasNext()) {
                String subscript = subscriptIter.next();
                System.out.println("subscript="+subscript+", value="+subscriptIter.getValue());
            }

            System.out.println();

            System.out.println("[3. Calling a class method]");

            // calling a class method
            // ObjectScript equivalent: set returnValue = ##class(%Library.Utility).Date(5)
            String returnValue = iris.classMethodString("%Library.Utility","Date",5);
            System.out.println(returnValue);

            System.out.println();

            // close connection and IRIS object
            iris.close();
            conn.close();

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }

}
