using System;

public class Znak {

public string nazwa;
public string opis;

public Znak (string naz, string op){
nazwa = naz;
opis = op;
}
public static void OpisZnaku (Znak znak){
  Console.WriteLine(znak.opis);
}
}