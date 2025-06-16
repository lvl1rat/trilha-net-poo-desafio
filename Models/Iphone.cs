namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone através de processos Iphonescos.");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine($"\n{nomeApp} instalado com sucesso.");
        }
    }
}