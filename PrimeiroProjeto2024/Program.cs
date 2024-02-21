namespace PrimeiroProjeto2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vinicius";
            int idade = 17;
            string cidade = "Campos do Jordão";

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua cidade:");
            cidade = Console.ReadLine();


            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0} anos", idade);
            Console.WriteLine("Cidade: {0}", cidade);
            //Console.WriteLine("Nome: {0} \n Idade: {1} anos \n Cidade: {2}", nome, idade, cidade);
        }
    }
}
