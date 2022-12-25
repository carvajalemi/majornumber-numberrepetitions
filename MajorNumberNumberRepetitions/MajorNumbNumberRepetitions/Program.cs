using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Por favor ingrese el numero:");
    string MayorString= Console.ReadLine();
    int MayorInt = Int32.Parse(MayorString);
    int cantidad=1;
    int NumeroInt=0;
    do
    {
      Console.WriteLine ("Por favor ingrese otro numero:");
      string NumeroString= Console.ReadLine();
      NumeroInt = Int32.Parse(NumeroString);
      if (NumeroInt > MayorInt)
      {
        MayorInt=NumeroInt;
        cantidad=1;        
      }
      else if (NumeroInt==MayorInt)
      {       
        cantidad=cantidad+1;        
      } 
    }while (NumeroInt!=0);
      
    Console.WriteLine ("El numero mayor es:" +MayorInt+ " con repeticiones:" +cantidad);
  }
}
