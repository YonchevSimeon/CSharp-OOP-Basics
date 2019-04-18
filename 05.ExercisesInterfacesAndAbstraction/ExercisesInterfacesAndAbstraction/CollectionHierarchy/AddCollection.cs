using System.Collections.Generic;

public class AddCollection<T> : IAddCollection<T>
{
    private List<T> data;

    public AddCollection()
    {
        this.data = new List<T>();
    }

    public int Add(T element)
    {
        this.data.Add(element);
        return this.data.Count - 1;
    }
}
