namespace EnumerableManipulation
{
    internal static class EnumerableExtensions
    {
        public static T GetMiddleElement<T>(this IEnumerable<T> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            
            IEnumerator<T> enumerator = collection.GetEnumerator();

            if (!enumerator.MoveNext()) throw new ArgumentException($"{nameof(collection)} has no elements");

            enumerator.Reset();


            int length = 0;
            bool secondIteration = false;
            int i = 0;
            T middleElement = default!;
            bool found = false;

            while (!found)
            {
                if (enumerator.MoveNext())
                {
                    if (secondIteration)
                    {
                        if (i == length / 2)
                        {
                            middleElement = enumerator.Current;
                            found = true;
                        }
                        i++;
                    }
                    else
                    {
                        length++;
                    }
                }
                else
                {
                    secondIteration = true;
                    enumerator.Reset();
                }
            }

            return middleElement;
        }
    }
}
