namespace aula19._5
{
    internal class Program
    {
        static void Main(){

            int[] num = new int[10];

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = 0;
            }

            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Valor de num na pos {0}: {1}", i, num[i]);
            }
        }
    }
}