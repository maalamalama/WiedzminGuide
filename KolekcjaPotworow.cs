using System;
using System.Collections.Generic;

public class KolekcjaPotworow {

  public List<Potwory> mojePotwory = new List<Potwory>();


  public void Wkladanie(){
    Console.WriteLine("Podaj nazwę potwora");
    string temp = "";
    temp = Console.ReadLine();

    Potwory znaleziony = null;

    foreach (Potwory potwor in mojePotwory) {
      if (potwor.name == temp) {
        znaleziony = potwor;
      }
    }

    znaleziony.Porada();
  }

}