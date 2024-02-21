namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
        



        string nome = "matheus";
            int idade = 16;
            string cidade = "cdj";


            Console.WriteLine("digite o seu nome");  nome = Console.ReadLine();
            Console.WriteLine("digite a sua idade"); idade = int.Parse (Console.ReadLine());
            Console.WriteLine("digite a sua cidade"); cidade = Console.ReadLine();

            Console.WriteLine("Nome : {0}", nome);
            Console.WriteLine("Idade : {0}", idade);
            Console.WriteLine("Cidade: {0}", cidade);
            Console.WriteLine("Nome: {0} \n Idade: {1} anos \n Cidade: {2}", nome, idade, cidade);
        }
    }
}


        

