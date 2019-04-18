using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string element)
    {
        data.Add(element);
    }

    public string Pop()
    {
        string result = string.Empty;
        if (!IsEmpty())
        {
            result = Peek();
            data.RemoveAt(data.Count - 1);
        }
        return result;
    }

    public string Peek()
    {
        string result = string.Empty;
        if (!IsEmpty())
        {
            result = data[data.Count - 1];
        }
        return result;
    }

    public bool IsEmpty()
    {
        return data.Count == 0;
    }
}