namespace Primeira_Questao
{
    public static class PrimeiraQuestao
    {
        public static int PrimeiraPergunta()
        {
            int indice = 12;
            int soma = 0;
            int k = 1;
            int result = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
                Console.WriteLine($"{soma}");
                result = soma;
            }
            return result;
        }
    }
}
