namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab==null){
                throw new ArgumentNullException ("Empty array.");
            }
            
            if (Array.LastIndexOf(tab, a)<0){
                return null;
            }else {
                return Array.LastIndexOf(tab, a);
            }
        }
    }
}