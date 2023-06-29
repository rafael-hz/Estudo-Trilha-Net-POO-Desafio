namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string DDD { get; set; }
        protected List<string> Aplicativos = new List<string>();
        protected string Modelo;
        private int MemoriaROM;
        private string IMEI;

        public Smartphone(string ddd, string numero, string modelo, string imei, int memoriaROM)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades

            DDD = ddd;
            Modelo = modelo;
            IMEI = imei;
            MemoriaROM = memoriaROM;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}