namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string resultat = "";
            for (int i=0; i<str.Length;i++){
                resultat+=str[i];
           }
           return resultat;
        }
    }
}