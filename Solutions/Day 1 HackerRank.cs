using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        double doble = 5.35;
        char charact = 'a';
        bool bolean = false;
        int interger = 100;
        string cadena ="I am a code monkey" ;
        bool otrobool = true;
        double otrodoble = 17.3;
        char otrochar = 'c';
        string otrocadena = "derp";

        Console.WriteLine("Primitive : " + doble.GetType().Name.ToLower());
        Console.WriteLine("Primitive : "+ charact.GetType().Name.ToLower());
        Console.WriteLine("Primitive : "+ bolean.GetType().Name.ToLower());
        if(interger == 100)
        Console.WriteLine("Primitive : int");
        Console.WriteLine("Referenced : "+ cadena.GetType().Name);
        Console.WriteLine("Primitive : "+ otrobool.GetType().Name.ToLower());
        Console.WriteLine("Primitive : "+ otrodoble.GetType().Name.ToLower());
        Console.WriteLine("Primitive : "+ otrochar.GetType().Name.ToLower());
        Console.WriteLine("Referenced : "+ otrocadena.GetType().Name);

    }
}
