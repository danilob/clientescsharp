using System;
using Activity;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    
    float val_pag;
    Console.WriteLine("Informar nome: ");
    string var_name = Console.ReadLine();
    Console.WriteLine("Informar endereço: ");
    string var_addr = Console.ReadLine();
    Console.WriteLine("Pessoa física (f) ou jurídica (j)?: ");
    string var_type = Console.ReadLine();
    if(var_type == "f"){
      //pessoa física
      FisicalPerson pf = new FisicalPerson();
      pf.name = var_name;
      pf.address = var_addr;
      Console.WriteLine("Informar CPF: ");
      pf.cpf = Console.ReadLine();
      Console.WriteLine("Informar RG: ");
      pf.rg = Console.ReadLine();
      Console.WriteLine("Informar valor da compra: ");
      val_pag = float.Parse(Console.ReadLine());
      pf.Tax_Pay(val_pag);
      pf.Show_Info();
    }
    if(var_type == "j"){
      //pessoa física
      LegalPerson pj = new LegalPerson();
      pj.name = var_name;
      pj.address = var_addr;
      Console.WriteLine("Informar CNPJ: ");
      pj.cnpj = Console.ReadLine();
      Console.WriteLine("Informar IE: ");
      pj.ie = Console.ReadLine();
      Console.WriteLine("Informar valor da compra: ");
      val_pag = float.Parse(Console.ReadLine());
      pj.Tax_Pay(val_pag);
      pj.Show_Info();
    }

  }
}


