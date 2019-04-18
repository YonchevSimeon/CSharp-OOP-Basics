using System.Collections.Generic;

public class MyList<T> : IMyList<T>
{
    private List<T> data;
    private int used;

    public MyList()
    {
        this.data = new List<T>();
        this.Used = 0;
    }

    public int Used { get; set; }

    public int Add(T element)
    {
        this.data.Insert(0, element);
        this.Used++;
        return 0;
    }

    public T Remove()
    {
        T removed = this.data[0];
        this.data.RemoveAt(0);
        this.Used--;
        return removed;
    }
}
