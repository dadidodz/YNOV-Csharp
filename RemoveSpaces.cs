namespace CSharpDiscovery.Quest01
{
    public class RemoveSpaces_Exercice
    {
        public static string RemoveSpaces(string str)
        {
            char[] arr;
            arr = str.ToCharArray(0, str.Length);
            string resultat ="";
            for (int i=0; i<arr.Length; i++){
                if(arr[i]!=' '){
                    resultat += Char.ToString(arr[i]);
                }
            }
            return resultat;
        }
    }
}