using System;

namespace basicQ
{
    class Program
    {
        static void Main(string[] args)
        {
	    Queue q = new Queue(5);
	    try
	    {
		q.Push(1);
		q.Print();
		q.Push(2);
		q.Print();
		q.Push(3);
		q.Print();
		q.Push(4);
		q.Print();
		q.Push(5);
	    }
	    catch (Exception ex)
	    {
		Console.WriteLine(ex.Message);
	    }
        }
    }

    public class Queue
    {
	int []data;
	int back;
	int size;
	public Queue(int size)
	{
	    this.back = -1;
	    this.size = size;
	    data = new int[size];
	}

	public void Push(int val)
	{
	    if (back == size - 1)
	    {
		throw new Exception("The Queue is full");
	    }
	    data[++back] = val;
	}

	public int Pop()
	{
	    if (back == -1)
	    {
		throw new Exception("The Queue is empty");
	    }
	    int returnVal = data[0];
	    for (int i = 0; i < back ; i++)
	    {
		data[i] = data[i+1];
	    }
	    back--;
	    return returnVal;
	}

	public int Front()
	{
	    if (back == -1)
	    {
		throw new Exception("Queue is empty");
	    }
	    return data[0];
	}

	public void Print()
	{
	    for(int i = 0; i <= back; i++)
	    {
		Console.Write(data[i] + "\t");
	    }
	    Console.WriteLine();
	}
    }
}
