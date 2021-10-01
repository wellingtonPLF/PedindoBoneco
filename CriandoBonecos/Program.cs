using System;
using System.Collections.Generic;
using ExibiçãoDePedidos.modelo;
using ExibiçãoDePedidos.director;
using ExibiçãoDePedidos.builders;

namespace CriandoBonecos
{
    class Program
    {
        static void Main(string[] args)
        {
            Boneco toy;
            Director director = new Director();
            BonecoBuilder builder = new BonecoBuilder();
            List<Boneco> pedidoExtra = new List<Boneco>();
            int numeroDeCopias;

            Console.Write("Que tipo de boneco você deseja?" +
                "\n 1 - Padrão " +
                "\n 2 - Estilizado\n\n Resp => ");
            string x = Console.ReadLine();
            if (x == "1")
            {
                toy = new BonecoNull(); //Spy
            }
            else
            {
                Console.Write("Qual Boneco você deseja?" +
                    "\n 1 - Samurai" +
                    "\n 2 - Ninja" +
                    "\n 3 - Lutador" +
                    "\n 4 - CowBoy" +
                    "\n 5 - Fuzileiro\n\n Resp: ");
                string opcao = Console.ReadLine();
                if(opcao == "1")
                {
                    director.constructSamurai(builder);
                }
                else if (opcao == "2")
                {
                    director.constructNinja(builder);
                }
                else if (opcao == "3")
                {
                    director.constructLutador(builder);
                }
                else if (opcao == "4")
                {
                    director.constructCowBoy(builder);
                }
                else
                {
                    director.constructFuzileiro(builder);
                }

                toy = builder.getResult();
            };
            Console.WriteLine(toy);
            Console.Write("Deseja copias do mesmo boneco?\n 1 - Sim\n 2 - Não\n\n Resp: ");
            string resposta = Console.ReadLine();

            if(resposta == "1")
            {
                Console.Write("\nDeseja quantas copias do mesmo boneco? Resp: ");
                numeroDeCopias = int.Parse(Console.ReadLine());

                for (var i = 0; i<numeroDeCopias; i++)
                {
                    pedidoExtra.Add(toy.Clone());
                }
                Console.WriteLine("#        Copias        #");
                for (var i = 0; i < pedidoExtra.Count; i++)
                {
                    Console.WriteLine(pedidoExtra[i]);
                }
                Console.WriteLine("#                      #\n");
            }
            Console.WriteLine("Enviando Pedido!");
            Console.Read();
        }
    }
}
