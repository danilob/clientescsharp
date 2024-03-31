namespace Activity{
  class Client{
    public string name {get; set;}
    public string address {get; set;}
    public float value {get; protected set;}
    public float tax_value {get; protected set;}
    public float total {get; protected set;}

    public virtual void Tax_Pay(float v){
      this.value = v;
      this.tax_value = this.value * 0.1f;
      this.total = this.value + this.tax_value;
    }

    public virtual void Show_Info(){
      Console.WriteLine("Valor de Compra: " + this.value.ToString("C"));
      Console.WriteLine("Imposto........: " + this.tax_value.ToString("C"));
      Console.WriteLine("Total..........: " + this.total.ToString("C"));
    }
    
  }
}