namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            string resultat= "";
            char[] arr;
            arr = str.ToCharArray(0, str.Length);
            for (int i=arr.Length-1; i>=0; i--){
                resultat += arr[i];
            }
            return resultat;
        }
    }
}