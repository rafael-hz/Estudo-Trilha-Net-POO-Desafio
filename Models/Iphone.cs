using System.Reflection.Metadata.Ecma335;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Iphone(string ddd, string numero, string modelo, string imei, int memoriaROM) : base(ddd, numero, modelo, imei, memoriaROM) { }

        public string AppleStore()
        {
            string appEscolhido = string.Empty;
            Console.Clear();
            Console.WriteLine($"Escolha um app para instalar no seu {Modelo}:\n");
            Console.WriteLine("1 - WhatsApp\n2 - Instagram\n3 - Facebook\n4 - SnapChat\n5 - League of legends - Wild Rift\n\n");
            Console.Write(">> ");
            int opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    appEscolhido = "WhatsApp";
                    break;

                case 2:
                    appEscolhido = "Instagram";
                    break;

                case 3:
                    appEscolhido = "Facebook";
                    break;

                case 4:
                    appEscolhido = "SnapChat";
                    break;

                case 5:
                    appEscolhido = "League of legends - Wild Rift";
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    break;

            }

            return appEscolhido;
        }

        public void MostrarAplicativos()
        {
            Console.WriteLine("\nAplicativos Instalados:\n");

            for (int i = 0; i < Aplicativos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Aplicativos[i]}");
            }

            Console.ReadKey();
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine();
            switch (nomeApp)
            {
                case "WhatsApp":

                    if (VerificarAppInstalado(nomeApp))
                    {
                        Console.WriteLine($"Você já possui o {nomeApp} instalado no seu {Modelo}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Aplicativos.Add(nomeApp);
                        Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
                        Console.ReadKey();
                    }
                    break;


                case "Instagram":

                    if (VerificarAppInstalado(nomeApp))
                    {
                        Console.WriteLine($"Você já possui o {nomeApp} instalado no seu {Modelo}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Aplicativos.Add(nomeApp);
                        Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
                        Console.ReadKey();
                    }
                    break;

                case "Facebook":

                    if (VerificarAppInstalado(nomeApp))
                    {
                        Console.WriteLine($"Você já possui o {nomeApp} instalado no seu {Modelo}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Aplicativos.Add(nomeApp);
                        Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
                        Console.ReadKey();
                    }
                    break;

                case "SnapChat":
                    nomeApp = "SnapChat";

                    if (VerificarAppInstalado(nomeApp))
                    {
                        Console.WriteLine($"Você já possui o {nomeApp} instalado no seu {Modelo}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Aplicativos.Add(nomeApp);
                        Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
                        Console.ReadKey();
                    }
                    break;

                case "League of legends - Wild Rift":

                    if (VerificarAppInstalado(nomeApp))
                    {
                        Console.WriteLine($"Você já possui o {nomeApp} instalado no seu {Modelo}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Aplicativos.Add(nomeApp);
                        Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
                        Console.ReadKey();
                    }
                    break;
            }

        }

        bool VerificarAppInstalado(string nomeApp)
        {
            if (Aplicativos == null)
            {
                return false;
            }

            foreach (var item in Aplicativos)
            {
                if (nomeApp == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}