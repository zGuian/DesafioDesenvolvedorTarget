namespace Segunda_Questao
{
    public class SegundaQuestao
    {
        public static void SubQuestaoA()
        {
            int[] valor = new int[5];

            valor[0] = 1;

            for (int i = 1; i < valor.Length; i++)
            {
                valor[i] = valor[i - 1] + 2;
            }

            foreach (var valorAtual in valor)
            {
                Console.Write($"{valorAtual} ");
            }            
        }

        public static void SubQuestaoB()
        {
            int[] valor = new int[7];
            valor[0] = 2;

            for (int i = 1; i < valor.Length; i++)
            {
                valor[i] = valor[i - 1] * 2;
            }

            foreach (var valorAtual in valor)
            {
                Console.Write($"{valorAtual} ");
            }
        }

        public static void SubQuestaoC()
        {
            int[] valor = new int[8];

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = i * i;
            }

            foreach (var valorAtual in valor)
            {
                Console.Write($"{valorAtual} ");
            }
        }

        public static void SubQuestaoD()
        {
            int[] valor = new int[5];
            int par = 2;

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = par * par;
                par += 2;
            }

            foreach (var valorAtual in valor)
            {
                Console.Write($"{valorAtual} ");
            }
        }

        public static void SubQuestaoE()
        {
            int[] valor = new int[7];
            valor[0] = 1;
            valor[1] = 1;

            for (int i = 2; i < valor.Length; i++)
            {
                valor[i] = valor[i - 1] + valor[i - 2];
            }

            foreach (var valorAtual in valor)
            {
                Console.Write($"{valorAtual} ");
            }
        }

        public static void SubQuestaoF()
        {
            int[] valor = [2, 10, 12, 16, 17, 18, 19, 20];
            foreach (var valorAtual in valor)
            {
                Console.Write($"{valorAtual} ");
            }
        }
    }
}