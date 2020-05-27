using System;

public class Potwory{
  public string name;
  public Znak sign;
  public Olej oil;
  
  public Potwory(string nazwa, Znak znak, Olej olej){
  this.name = nazwa;
  this.sign = znak;
  this.oil = olej;
  }



  public void Porada(){

    Console.WriteLine($"Aby pokonać {name} warto nałożyć na miecz {oil.nazwa}, a w walce użyć znaku {sign.nazwa}.");

  }
    

}