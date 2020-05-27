using System;

public class Olej {

public string nazwa;
public string opis;

public Olej (string naz, string op){
nazwa = naz;
opis = op;
}
public static void OpisOleju (Olej olej){
  Console.WriteLine(olej.opis);
}
}