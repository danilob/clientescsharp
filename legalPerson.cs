namespace Activity{
  class LegalPerson: Client{
    public string cnpj {get; set;}
    public string ie {get; set;}

    public override void Tax_Pay(float v){
      this.value = v;
      this.tax_value = this.value * 0.2f;
      this.total = this.value + this.tax_value;
    }

    public override void Show_Info(){
      Console.WriteLine("--------- Pessoa Jurídica ---------");
      Console.WriteLine("Nome...........: " + this.name);
      Console.WriteLine("Endereço.......: " + this.address);
      Console.WriteLine("CNPJ...........: " + this.cnpj);
      Console.WriteLine("IE.............: " + this.ie);
      base.Show_Info();

    }
    
  }
}