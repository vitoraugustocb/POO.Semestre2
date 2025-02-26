class Pessoa 
{
    public string Nome;
    public int Idade;
    public string Sexo;
    public double Altura;
   


public void ExebirIformacoes()
{
    Console.WriteLine ($"Nome: {Nome}\n Idade: {Idade}\n Sexo: {Sexo}\n Altura: {Altura}\n");

}


}

class Program {

static void Main()
{
        Pessoa pessoa1 = new Pessoa();        
        pessoa1.Nome = "Safira";
        pessoa1.Idade = 22;
        pessoa1.Sexo = "Feminino";
        pessoa1.Altura = 1.60;
        
        pessoa1.ExebirIformacoes();



        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Jeffinho";
        pessoa2.Idade = 10;
        pessoa2.Sexo = "Masculino";
        pessoa2.Altura = 0.50;

        pessoa2.ExebirIformacoes();


        
       

}



}