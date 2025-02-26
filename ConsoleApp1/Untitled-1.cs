

class  Celular 
{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public int Memoria;


public void ExebirIformacoes()
{
    Console.WriteLine ($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Cor: {Cor}, Memoria: {Memoria}");

}

public void Ligar()
{
    System.Console.WriteLine($"{Modelo} está ligando...");


}

public void Desligar()
{
    System.Console.WriteLine($"{Modelo} está desligando...");

}

}

class Program {

static void Main()
{
        Celular meuCelular = new Celular();
        meuCelular.Marca = "Apple";
        meuCelular.Modelo = "IPhone 15";
        meuCelular.Ano = 2024;
        meuCelular.Cor = "Azul";
        meuCelular.Memoria = 256;

        meuCelular.ExebirIformacoes();

        meuCelular.Ligar();
        meuCelular.Desligar();



}



}