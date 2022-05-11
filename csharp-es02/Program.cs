using System;           //riferimento alla libreria di base
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            /*
            * Un semplice calcolatore
            * Realizzare un programma che chiede all'utente che tipo di operazione intende
            * svolgere (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
            * e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato 
            * chiede un solo valore e se media chiede 10 valori.
            * Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input
            * Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.
            * Opzionale:  dato un vettore trovare il massimo e il minimo
            * 
            */

            Console.WriteLine("Inserisci un opzione");
            Console.WriteLine("0-somma");
            Console.WriteLine("1-prodotto");
            Console.WriteLine("2-divisione");
            Console.WriteLine("3-sottrazione");
            Console.WriteLine("4-quadrato");
            Console.WriteLine("5-media");
            //bonus
            Console.WriteLine("6-potenza");
            Console.WriteLine("7-Massimo e minimo");




            switch (Console.ReadLine())
            {
                case "0":
                    Console.WriteLine("Questa operazione fa la somma");
                    Console.WriteLine("inserisci primo numero");
                    float numSomma1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("inserisci secondo numero");
                    float numSomma2 = float.Parse(Console.ReadLine());
                    float sum;
                    sum = numSomma1 + numSomma2;
                    Console.WriteLine("la somma dei due numeri è  {0}",sum);
                    break;

                case "1":
                    Console.WriteLine("Questa operazione fa il prodotto");
                    Console.WriteLine("inserisci primo numero");
                    float numProdotto1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("inserisci secondo numero");
                    float numProdotto2 = float.Parse(Console.ReadLine());
                    float prodotto;
                    prodotto = numProdotto1 * numProdotto2;
                    Console.WriteLine("il prodotto dei due numeri è  {0}", prodotto);
                    break;
                case "2":
                    Console.WriteLine("Questa operazione fa  la divisione");
                    Console.WriteLine("inserisci primo numero");
                    float numDivisione1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("inserisci secondo numero");
                    float numDivisione2 = float.Parse(Console.ReadLine());
                    float divisione;
                    divisione = numDivisione1 / numDivisione2;
                    Console.WriteLine("la divisione dei due numeri è  {0}", divisione);
                    break;
                case "3":
                    Console.WriteLine("questa operzione fa la sottrazione");
                    Console.WriteLine("inserisci primo numero");
                    float numSottrazione1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("inserisci secondo numero");
                    float numSottrazione2 = float.Parse(Console.ReadLine());
                    float sottrazione = numSottrazione1 - numSottrazione2;
                    Console.WriteLine("la sottrazione dei due numeri è  {0}", sottrazione);
                    break;

                case "4":
                    Console.WriteLine("questa operzione fa il quadrato di un numero");
                    Console.WriteLine("inserisci valore");
                    int numQuadrato = int.Parse(Console.ReadLine());
                    double quadrato = Math.Pow(numQuadrato, 2);
                    Console.WriteLine("il quadrato del numero è {0}", quadrato);
                    break;
                case "5":
                    Console.WriteLine("questa operazione fa la media dei numeri");
                    //Console.Write("Inserisci numeri di cui intendi calcolare la media, separati da spazi vuoti, tutti sulla stessa riga: ");
                    //numeri per la media
                    //string numMedia = Console.ReadLine();
                    //if (numMedia == null)
                    //{
                    //    Console.WriteLine("Non hai fornito numeri!!");
                    //    Environment.Exit(0);
                    //}
                    //string[] ArrayDiNumeri = numMedia.Split(' ');
                    //double media = 0.0;
                    //int sommaNumeri = 0;
                    //foreach (string snum in ArrayDiNumeri)
                    //{
                    //    double num;
                    //    if (double.TryParse(snum, out num))
                    //    {
                    //        media += num;
                    //        sommaNumeri++;
                    //    }
                    //}
                    //media /= sommaNumeri;  
                    //Console.WriteLine("La media dei numeri  è: {0}", media);
                    Console.WriteLine("Inserisci 10 numeri");
                    int[] ArrayDiNumeri = new int[10];
                    for (int i = 0; i < ArrayDiNumeri.Length; i++)
                    {
                        Console.WriteLine("inserisci numero {0}", i);
                        ArrayDiNumeri[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    float fmedia = 0;

                    fmedia = CalcolaMedia(ArrayDiNumeri);
                    Console.WriteLine("media {0}", fmedia);
                    break;
                case "6":
                    Console.WriteLine("questa operazione fa la potenza");
                    Console.WriteLine("inserisci valore da cui fare la potenza");
                    int numPotenza1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("eleva per...");
                    int numPontenza2 = int.Parse(Console.ReadLine());   
                    double potenza = Math.Pow(numPotenza1,numPontenza2);
                    Console.WriteLine("la potenza è {0}", potenza);
                    break;

                case "7":
                    int max, min;
                    Console.WriteLine("questa operazione fa il massimo e il minimo");
                    int[] arraySearch = new int[100];
                    Console.WriteLine("inserisci grandezza array");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("elemento - {0} : ", i);
                        Console.WriteLine("Scrivi elementi dell' array");
                        arraySearch[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    max = arraySearch[0];
                    min = arraySearch[0];

                    for (int i = 1; i < n; i++)
                    {
                        if (arraySearch[i] > max)
                        {
                            max = arraySearch[i];
                        }


                        if (arraySearch[i] < min)
                        {
                            min = arraySearch[i];
                        }
                    }
                    Console.WriteLine("Elemento massimo  {0}", max);
                    Console.WriteLine("Elemento minimo : {0}", min);
                    break;
                default:
                    Console.WriteLine("Non è un opzione disponibile");
                    break;
            }
        }
        public static float CalcolaMedia(int[] vVettoreInteri)
        {
            int iNumElementi = vVettoreInteri.Length;
            float media = 0;
            float somma = 0;
            for (int i = 0; i < iNumElementi; i++)
            {
                somma += vVettoreInteri[i];
            }
            media = somma / (float)iNumElementi;
            return media;
        }
    }
}