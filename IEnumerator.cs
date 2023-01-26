using System;
namespace IteratorWeekMateo
{
    public interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }

}

