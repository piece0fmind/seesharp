using System;
/* the 'using' directive is used to specify that this program uses the System namespace.
    

    */

namespace numbers
{ /* namespaces help manage program by classifying 
    classes of same types in a single area.
    A program can have multiple namespaces. 
    They can also be nested.
        */

    class Number{ 
        
        void add(int a, int b){ //a method that takes two parameters and doesnt return anything
            int x,y,d;

            x=a;//the parameter value passed through object is assigned to this local variable
            y=b;

            d = x+y;
            Console.WriteLine("The sum of x and y is " + d);
        }

        static void Main(string[] args){ 
            /* every program must have the static main method. 
             This is the entry point for execution*/

            var n= new Number(); //an object of the class Number
            // var nn=new Number(); is also an object. One class can have many objects
            n.add(2,3); //this n object calls the add method and passes 2 and 3 for a and b as parameters
            n1.add(6,6);// this passes 6 and 6. any desired value can be passed.
            


        }
    }
}