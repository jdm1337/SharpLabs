using System.Collections;


namespace SharpLabs.Lb4;
public class MyList<T> : IEnumerable<T>
{
    public delegate void MyListHandler(string message);
    public event MyListHandler? Notify;
    public List<T> items;
    public MyList()
    {
        items = new List<T>();
    }
    public void Add(T item)
    {
        items.Add(item);
        Notify?.Invoke($"Element {item.ToString} has been added");
    }

    public void Insert(int index, T item)
    {
        if(index <= items.Count)
        {
            items[index] = item;
            Notify?.Invoke($"Element {item.ToString} with index {index} has been added");
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(MyList<T>));
        }
    }

    public void Remove(int index , T item)
    {
        if(index <= items.Count)
        {
            items.Remove(item);
            Notify?.Invoke($"Element {item.ToString} with index {index} has been removed");
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(MyList<T>));
        }
    }

    public void Clear()
    {
        items.Clear();
        Notify?.Invoke($"Clear all elements");
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return items.GetEnumerator();
    }
}

