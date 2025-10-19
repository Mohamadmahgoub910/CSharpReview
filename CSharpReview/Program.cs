namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            // main should br static { startup point of the program}
            // Console is a class in System namespace
            // CLR (Common Language Runtime) executes the program
            // CTS (Common Type System) Value Types and Reference Types
            // Value Types : int, float, double, bool, char, struct, enum
            // Reference Types : string, class, interface, array, delegate
            // class is a blueprint for creating objects
            // object is an instance of a class
            // namespace is a container for classes and other namespaces
            // Struct is a value type that can contain data members and function members
            // Difference between class and struct : class is a reference type and struct is a value type
            // Enum is a value type that defines a set of named constants
            // Difference between enum and const : enum is a value type and const is a compile-time constant
            // Ex : enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
            // Ex : const int MAX_VALUE = 100;
            // difference between enum and struct :
            // enum is a value type that defines a set of named constants,
            //  struct is a value type that can contain data members and function members
            // Public virtual String ToString(); ==> returns a string that represents the current object
            // public virtual int GetHashCode(); ==> returns a hash code for the object
            // public virtual bool Equals(object obj); ==> determines whether the specified object is equal to the current object
            // public Type GetType(); ==> gets the Type of the current instance
            // Object O1 = new Object ();
            // 1- Allocate Required # of Bytes in Heap Memory (Object Size + CLR Overhead Variables)
            // 2- Initialize the Object (Set Default Values to all Instance Variables)
            // 3- Return the Address of the Object to the Reference Variable O1
            // 4- Call the Constructor of the Object to perform Custom Initialization if exists
            // 5- Assign the Reference to newly created Object to the Reference Variable O1
            // Object O2 = new Object ();
            // O2 = O1; // Now both O1 and O2 are pointing to the same Object in Heap Memory
            #endregion Comments
            #region Basics
            //int x = 9;
            //int y;
            //y = x;
            //++x;
            // Object O1;
            //O1.GetHashCode(); // use unassigned of local o1
            //O1 = new object();
            // synatax sugar 
            //Object r = new();
            //var t = O1.GetHashCode();
            //Console.WriteLine(t); // 123456 the identity of the object clr gives it 
            //object O2 = new();
            //O2 = O1;
            //var t2 = O2.GetHashCode(); 
            //Console.WriteLine(t2); // print the same 
            //float c = 15.3f;
            //double d = 3.4;
            //decimal sd = 15.3m;
            //string e = 123.ToString("C");
            //Console.WriteLine(e);
            // difference between parse and convert ==> parse throws exception if null or invalid format , convert returns default value
            // $ "{}" ==> interpolated string
            // difference between switch and if-else ==> switch is used for discrete values , if-else is used for ranges and conditions
            // discrete values ==> int, char, string, enum
            // ranges and conditions ==> bool, float, double, decimal
            // who is faster switch or if-else ==> switch is faster for discrete values , if-else is faster for ranges and conditions
            //string[] arr = new string [] { "one", "two", "three" };
            // Derived : Base ==>  Not Valid 
            // ref to base = Derived ==>  Valid
            // ex : object o = "hello"; // valid
            //ex : string s = o; // valid

            #endregion Basics
            #region Task1 array get max distance between repeated elements
            //Console.WriteLine("Enter the size of the array:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            // Read array values 
            //for (int i = 0; i < size; i++)
            //{
            //Console.Write(arr[i] + " ");
            //}

            // find the distance between the repeated elements
            //int min = 0;
            //int max = arr.Length;
            //int distance = 0;
            //int maxDistance = 0;
            //int numberOfRepeats = 0;
            //for (int i=min; i<max; i++)
            //{
            //    for (int j=i+1; j<max; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            distance = (j-i)-1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                numberOfRepeats = arr[i];
            //            } 
            //        }
            //    }
            //}
            //Console.WriteLine($"\nThe longest distance is {maxDistance} for number {numberOfRepeats}");
            #endregion Task1
            #region Task2 Reverse a sentance
            //Console.WriteLine("Enter a Sentance..");
            //string str = Console.ReadLine();
            ////string strReserved = new string(str.Reverse().ToArray());
            //string reversed = string.Join(" ", str.Split(' ').Reverse());
            //Console.WriteLine($"String reveresd is {reversed}");


            #endregion Task2
        }

    }
}