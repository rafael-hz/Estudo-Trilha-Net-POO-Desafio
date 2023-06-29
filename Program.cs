using DesafioPOO.Models;

Nokia celular1 = new Nokia("81", "98963-6598", "Nokia NKO32 5.4", "954863251698694", 4);
Iphone celular2 = new Iphone("11", "96598-4587", "Iphone 8 Pro Max", "365426985695532", 6);

bool exibirMenu = true;


Console.WriteLine("Seja Bem-vindo!\n\n");
Console.WriteLine("Informe o celular que você usa:\n\n1 - Nokia\n2 - Iphone");
int escolha = Convert.ToInt16(Console.ReadLine());
Console.Clear();

switch (escolha)
{
    case 1:
        while (exibirMenu)
        {
            Console.WriteLine("Selecione uma opção válida para realizar uma ação:\n");
            Console.WriteLine("1 - Ligar\n2 - Receber ligação\n3 - Instalar Aplicativo\n4 - Mostrar Aplicativos\n5 - Sair\n\n");
            Console.Write(">> ");
            int opcao = Convert.ToInt16(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    celular1.Ligar();
                    break;

                case 2:
                    celular1.ReceberLigacao();
                    break;

                case 3:
                    celular1.InstalarAplicativo(celular1.PlayStore());
                    break;

                case 4:
                    celular1.MostrarAplicativos();
                    break;

                case 5:
                    exibirMenu = false;
                    break;
            }

            Console.Clear();
        }
        break;
    case 2:
        while (exibirMenu)
        {
            Console.WriteLine("Selecione uma opção válida para realizar uma ação:\n");
            Console.WriteLine("1 - Ligar\n2 - Receber ligação\n3 - Instalar Aplicativo\n4 - Mostrar Aplicativos\n5 - Sair\n\n");
            Console.Write(">> ");
            int opcao = Convert.ToInt16(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    celular2.Ligar();
                    break;

                case 2:
                    celular2.ReceberLigacao();
                    break;

                case 3:
                    celular2.InstalarAplicativo(celular2.AppleStore());
                    break;

                case 4:
                    celular2.MostrarAplicativos();
                    break;

                case 5:
                    exibirMenu = false;
                    break;
            }

            Console.Clear();
        }
        break;
}



// TODO: Realizar os testes com as classes Nokia e Iphone