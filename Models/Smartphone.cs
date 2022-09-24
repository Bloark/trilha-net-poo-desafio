namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        //OK
        protected string Modelo { get; set; }    
        protected string Imei { get; set; }    
        protected string Memoria{ get; set; }    

        public Smartphone(string numero, string modelo,string imei, string memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            //OK
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

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