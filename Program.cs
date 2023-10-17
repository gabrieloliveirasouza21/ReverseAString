internal class Program {
    private static void Main(string[] args) {
        void ReverterString(string word) {

            char[] Cword = word.ToCharArray();
            string resultante = "";
            for (int i = Cword.Length - 1; i >= 0; i--) {
                resultante += Cword[i].ToString();
            }

            Console.WriteLine(resultante);

        }

        ReverterString("teste de inversão de string");
    }
}