using System.Collections;
using System.Collections.Generic;

public class Lake : IEnumerable<int>
{
    private IList<int> stones;

    public Lake(IList<int> stonesNumbers)
    {
        this.stones = stonesNumbers;
    }

    public IEnumerator<int> GetEnumerator()
    {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }

            var reverseStartPoint = this.stones.Count - 1;

            if (this.stones.Count % 2 != 0)
            {
                reverseStartPoint = this.stones.Count - 2;
            }

            for (int i = reverseStartPoint; i > 0; i -= 2)
            {
                yield return this.stones[i];
            }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
