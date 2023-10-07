namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (Array.LastIndexOf(tab, a)<0 || tab==null){
                return null;
            } else {
                return Array.LastIndexOf(tab, a);
            }
          
        }
    }
}