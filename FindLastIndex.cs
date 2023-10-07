namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if (tab == null || tab.Length == 0  ){
                throw new System.ArgumentNullException(nameof(tab), "is null");
            } else  if (Array.LastIndexOf(tab, a)<0){
                return null;
            }
            else
            {
                return Array.LastIndexOf(tab, a);
            } 

           
    
                    
        }
    }
}