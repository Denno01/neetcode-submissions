public class DynamicArray
{

    private int[] arr;
    private int size = 0;

    public DynamicArray(int capacity)
    {

        if (capacity > 0)
        {
            arr = new int[capacity];
        }
    }

    public int Get(int i)
    {
        return arr[i];
    }

    public void Set(int i, int n)
    {
        arr[i] = n;
    }

    public void PushBack(int n)
    {

        if (GetSize() == 0)
        {
            Set(size, n);
            size++;
        }
        else if (!this.IsFull())
        {
            Set(size, n);
            size++;
        }
        else
        {
            Resize();
            Set(size, n);
            size++;
        }

    }

    public int PopBack()
    {
        int i = arr[size-1];
        arr[size-1] = 0; 
        size--;
        return i;
    }

    private void Resize()
    {
        int[] newarr = new int[GetCapacity() * 2];
        Array.Copy(arr, newarr, GetSize());
        arr = newarr;
    }

    public int GetSize()
    {
        return size;
    }

    public int GetCapacity()
    {
        return arr.Length;
    }

    public bool IsFull()
    {
        if (GetCapacity() == GetSize())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}