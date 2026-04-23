using System.Runtime.CompilerServices;

namespace lab_2_2
{
    internal class Structures
    {
        private static Random _rnd;
        
        static Structures() 
        {
            _rnd = new Random();
        }
        public static List<int> MakeListInt(uint n)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < n; ++i)
            {
                res.Add(_rnd.Next() % 1_000 - 500 + 1);
            }
            return res;
        }
        public static List<int> Task6(List<int> list)
        {
            List<int> res = new List<int>(list.Count * 2);
            foreach (int elem in list)
            {
                res.Add(elem);
                res.Add(elem);
            }
            return res;
        }
        public static string ListIntToString(List<int> list)
        {
            string res = "";
            for (int i = 0; i < list.Count - 1; ++i)
            {
                res += list[i].ToString() + ' ';
            }
            res += list[list.Count - 1];
            return res;
        }
        public static LinkedList<int> MakeLinkedListInt(uint n)
        {
            LinkedList<int> res = new LinkedList<int>();
            for (int i = 0; i < n; ++i)
            {
                res.AddLast(_rnd.Next() % 1_000 - 500 + 1);
            }
            return res;
        }
        public static string LinkedListIntToString(LinkedList<int> list)
        {
            if (list.Count == 0)
            {
                return "[]";
            }
            string res = list.First.Value.ToString();
            for (LinkedListNode<int> elem = list.First.Next; elem != null; elem = elem.Next)
            {
                res += ' ' + elem.Value.ToString();
            }
            return res;
        }
        public static LinkedList<int> Task7(LinkedList<int> oldList)
        {
            LinkedList<int> list = new LinkedList<int>(oldList);
            if (list.Count == 0)
            {
                return list;
            }
            LinkedListNode<int> max = list.First;
            LinkedListNode<int> min = list.First;
            int maxI = 0;
            int minI = 0;
            int i = 1;

            for (LinkedListNode<int> elem = list.First.Next; elem != null; elem = elem.Next, ++i)
            {
                if (elem.Value > max.Value)
                {
                    max = elem;
                    maxI = i;
                }
                else if (elem.Value < min.Value)
                {
                    min = elem;
                    minI = i;
                }
            }
            Console.WriteLine("Min: " + min.Value);
            Console.WriteLine("Max: " + max.Value);
            LinkedListNode<int> l;
            LinkedListNode<int> r;
            int lI;
            int rI;
            int buffer;

            if (minI < maxI)
            {
                l = min.Next;
                r = max.Previous;
                lI = minI + 1;
                rI = maxI - 1;
            }
            else
            {
                l = max.Next;
                r = min.Previous;
                lI = maxI + 1;
                rI = minI - 1;
            }
            while (lI < rI)
            {
                buffer = r.Value;
                r.Value = l.Value;
                l.Value = buffer;
                l = l.Next;
                r = r.Previous;
                ++lI;
                --rI;
            }
            return list;
        }
        public static KeyValuePair<int, SortedList<int, int>> ReadFile(string filename)
        {
            StreamReader stream = new StreamReader(filename);
            
            int n = int.Parse(stream.ReadLine());
            SortedList<int, int> list = new SortedList<int, int>();
            string line;
            int score;

            while ((line = stream.ReadLine()) != null)
            {
                score = int.Parse(line.Split(' ')[3]);
                if (list.ContainsKey(score))
                {
                    ++list[score];
                }
                else
                {
                    list.Add(score, 1);
                }
            }
            return new KeyValuePair<int, SortedList<int, int>>(n, list);
        }
        public static int Task10(KeyValuePair<int, SortedList<int, int>> pair)
        {
            int n = pair.Key;
            SortedList<int, int> list = pair.Value;

            int desired = (int)(n * 0.2);
            int score;
            int lastScore = -1;
            int count;
            int studentsCounted = 0;

            for (int i = list.Count - 1; i >= 0; --i)
            {
                score = list.Keys[i];
                count = list.Values[i];

                if (studentsCounted + count == desired)
                {
                    return score;
                }
                else if (studentsCounted + count > desired)
                {
                    if (lastScore == -1)
                    {
                        return score;
                    }
                    else
                    {
                        return lastScore;
                    }
                }
                studentsCounted += count;
                lastScore = score;
            }
            return -1;
        }
    }
}
