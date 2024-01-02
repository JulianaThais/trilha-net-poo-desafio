namespace DesafioPOO.Models
{
    //  Herdado da classe "Smartphone"
    public class Iphone : Smartphone
    {
       public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
       {

       }
     
        //  Sobrescrevido o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}