namespace Week4ChallengeLab2
{
    internal class Program
    {
        static Dictionary<int, int> _selectionCount = new Dictionary<int, int>();  //instanitated dictionary and assigned variable(the dictionary) toi selectionCount.. can be anything
        static void Main(string[] args)                                //key has to be primitive data types and value can be anything.. objects..
        {
            int[] elementsArray = { 1, 1, 2, 2, 9};

            foreach (int e in elementsArray)
            {
                AddElement(e);
            }

            foreach (KeyValuePair<int, int> pair in _selectionCount)                //pair can be anything.. its a variable
            {
                Console.WriteLine(format: "{0} occurs {1} times", pair.Key, pair.Value);
            }

        }

        static public void AddElement(int element) 
        {
            if (_selectionCount.ContainsKey(element))                                   //my dictionary is now selection count bc we assigned it
            {
                _selectionCount[element]++;
            }
            else
            {
                _selectionCount.Add(element, 1);
            }
        }
    }
}
