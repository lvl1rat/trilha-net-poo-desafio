namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia através de processos Nokialescos.");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine($"\n{nomeApp} instalado com sucesso.");
        }
    }
}