using System;

namespace conversao

{
    class Program

    {
        static void Main(string[] args)

        {

            double meuDouble = 9.78;
            int meuInteiro = (int)meuDouble; // conversão manual

            Console.WriteLine(meuInteiro); // saida 9
            Console.WriteLine(meuDouble); // saida 9.78
            Console.ReadKey();
            Console.Clear();

            int meuInt02 = 10;
            double meuDouble02 = 9.85;
            bool meuBool02 = true;

            Console.WriteLine(Convert.ToString(meuInt02));    // converte int para string
            Console.WriteLine(Convert.ToDouble(meuInt02));    // converte int para double
            Console.WriteLine(Convert.ToInt32(meuDouble02));  // converte double para int
            Console.WriteLine(Convert.ToString(meuBool02));   // converte bool para string


        }
    }
}
