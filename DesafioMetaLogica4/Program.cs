using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] barras = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int aguaRetida = 0;
        Console.WriteLine(String.Format("O cálculo da quantidade de retenção de água será feito no array: {0}", String.Join(", ", barras)));
        for (int andar = 0; andar < barras.Max() - 1; andar++)
        {
            for (int nBarra = 1; nBarra < barras.Length - 1; nBarra++)
            {
                int proximaBarra = barras.ToList().FindIndex(nBarra + 1, ar => ar > andar);
                int quantidade = proximaBarra - nBarra - 1;
                if (barras[nBarra] > andar && quantidade > 0)
                {
                    Console.WriteLine(String.Format("{0}º andar: entre a barra {1} e a barra {2} há {3} bloco(s) de água retida",  andar + 1, nBarra, proximaBarra, quantidade));
                    aguaRetida += quantidade;
                    nBarra = proximaBarra - 1;
                }
            }
        }
        Console.WriteLine(String.Format("A quantidade total de água retida é de {0}", aguaRetida));
        Console.ReadKey();
    }
}
