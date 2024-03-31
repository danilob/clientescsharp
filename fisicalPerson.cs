namespace Activity{
  class FisicalPerson: Client{
    public string cpf {get; set;}
    public string rg {get; set;}

    public override void Show_Info(){
      Console.WriteLine("--------- Pessoa Física ---------");
      Console.WriteLine("Nome...........: " + this.name);
      Console.WriteLine("Endereço.......: " + this.address);
      Console.WriteLine("CPF............: " + this.cpf);
      Console.WriteLine("RG.............: " + this.rg);
      base.Show_Info();
      
    }
  }
}