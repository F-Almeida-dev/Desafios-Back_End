namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public int DiasDeAtraso;
        public string Devedor = "";
        public string Credor = "";
        public double Valor;
        private float Juros = 0.10f;

        public Fatura(string dev, string cred, double valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valFat;
            DiasDeAtraso = qtdAtraso;
        }

        public void Imprimir()
        {
            System.Console.WriteLine($@"Credor: {Credor}
            Devedor: {Devedor}
            Dias de atraso: {DiasDeAtraso} dias
            Jusros: {Valor * DiasDeAtraso}
            Total de juros: {DiasDeAtraso * Juros}");
        }
        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }

    
        }
    }
}

