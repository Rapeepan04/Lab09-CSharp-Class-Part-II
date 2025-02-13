﻿var a1 = new AAA();  
var a2 = new AAA();  

a1.b1 = 10;
a1.b2 = 20;  
a2.b1 = 30;
a2.b2 = 40;  

    System.Console.WriteLine($"a1.b1 = {a1.b1}");  
    System.Console.WriteLine($"a1.b2 = {a1.b2}");  
    System.Console.WriteLine($"a2.b1 = {a2.b1}");  
    System.Console.WriteLine($"a2.b2 = {a2.b2}");  

class AAA
{
    public int b1;
    public int b2;
}