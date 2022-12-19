
namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            // Primeiro animal
            Console.WriteLine("Controle de animais");
            Console.Write("Informa o nome do primeiro animal:  ");
            a1.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal, gato, cachorro ou paixe: ");
            a1.Tipo = Console.ReadLine();

            if (a1.Tipo == "Cachorro") tlCachorro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPeixe++;

            // Segundo animal
            Console.WriteLine("Controle de animais");
            Console.Write("Informa o nome do segundo animal:  ");
            a2.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal, gato, cachorro ou peixe: ");
            a2.Tipo = Console.ReadLine();

            if (a2.Tipo == "Cachorro") tlCachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPeixe++;

            // Terceiro animal
            Console.WriteLine("Controle de animais");
            Console.Write("Informa o nome do terceiro animal:  ");
            a3.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal, gato, cachorro ou peixe: ");
            a3.Tipo = Console.ReadLine();

            if (a3.Tipo == "Cachorro") tlCachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPeixe++;

            // Quarto animal
            Console.WriteLine("Controle de animais");
            Console.Write("Informa o nome do quarto animal:  ");
            a4.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal, gato, cachorro ou peixe: ");
            a4.Tipo = Console.ReadLine();

            if (a4.Tipo == "Cachorro") tlCachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPeixe++;

            // Quinto animal
            Console.WriteLine("Controle de animais");
            Console.Write("Informa o nome do quinto animal:  ");
            a5.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do animal, gato, cachorro ou peixe: ");
            a5.Tipo = Console.ReadLine();

            if (a5.Tipo == "Cachorro") tlCachorro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlPeixe++;

            //Resultado
            Console.WriteLine("Ta aí ó");
            Console.WriteLine("Cachorros: "+tlCachorro+ "\nGatos: "+tlGato+ "\nPeixe: "+tlPeixe);
            Console.ReadKey();

            

        }





    }

}