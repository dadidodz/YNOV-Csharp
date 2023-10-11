namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string,string> SecretSantaDraw(HashSet<string> people)
        {
         if (people == null || !people.Any())
            {
                throw new ArgumentException("People can't be null or empty");
            }
            List<string> shuffledPeople = people.ToList();
            Random randomNum = new();
            
            for (int i = shuffledPeople.Count - 1; i > 0; i--){
                int j = randomNum.Next(0, i + 1);
                string temp = shuffledPeople[i];
                shuffledPeople[i] = shuffledPeople[j];
                shuffledPeople[j] = temp;
            }
            Dictionary<string, string> dicPeople = new Dictionary<string, string>();
            for (int i = 0; i < shuffledPeople.Count - 1; i++)
            {
                dicPeople[shuffledPeople[i]] = shuffledPeople[i + 1];
            }

            dicPeople[shuffledPeople[^1]] = shuffledPeople[0];
            return dicPeople;
        }
    }
}