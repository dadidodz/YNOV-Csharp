namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
            int resultat = str.Length;
            if(resultat==null){
                return 0;
            }
            return str.Length;
        }
    }
}