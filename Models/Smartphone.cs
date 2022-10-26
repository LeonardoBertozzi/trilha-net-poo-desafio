namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        // IMPLEMENTADO
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // IMPLEMENTADO
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        
        public void Configuracoes()
        {
            Console.WriteLine($"O numero deste telefone eh {Numero}, modelo {Modelo}, IMEI {IMEI} e tem {Memoria} GB de memoria");

        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}