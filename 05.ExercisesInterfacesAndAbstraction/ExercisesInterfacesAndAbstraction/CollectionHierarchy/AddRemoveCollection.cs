using System.Collections.Generic;

public class AddRemoveCollection<T> :  IAddRemoveCollection<T>
{
    private List<T> data;

    public AddRemoveCollection()
    {
        this.data = new List<T>();
    }

    public int Add(T element)
    {
        this.data.Insert(0, element);
        return 0;
    }

    public T Remove()
    {
        int lastIndex = data.Count - 1;
        T removed = this.data[lastIndex];
        this.data.RemoveAt(lastIndex);
        return removed;
    }
}
