namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        protected string modelo { get; }

        protected string IMEI { get; }

        protected int memoria { get; }

        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            this.modelo = modelo;
            IMEI = iMEI;
            this.memoria = memoria;
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