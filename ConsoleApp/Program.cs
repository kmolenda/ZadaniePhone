using ClassLibrary;
using System;

var telefon = new Phone("K. Molenda", "123456789");

telefon.AddContact("Nowak", "987654321");

Console.WriteLine( telefon.Call("Nowak") );

