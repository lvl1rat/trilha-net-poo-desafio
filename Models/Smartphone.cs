namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
       
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Modelo
        {
            get => _modelo;
        }
        public string Imei
        {
            get => _imei;
        }
        public int Memoria
        {
            get => _memoria;
        }
        
        public Smartphone(string numero, string modelo, string imei, int memoria)//Original apenas o string numero
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
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