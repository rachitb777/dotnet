using System;

namespace basicStack
{
    class Program
    {
        static void Main(string[] args)
        {
	    Stack stk = new Stack(5);
	    try
	    {
		stk.Push(1);
		Console.WriteLine(stk.Peek());
		stk.Push(2);
		Console.WriteLine(stk.Peek())	;	
		stk.Push(3);
		Console.WriteLine(stk.Peek());		
		stk.Push(4);
		Console.WriteLine(stk.Peek());		
		stk.Push(5);
		Console.WriteLine(stk.Peek());		

		for(int i=0; i < 6; i++)
		    Console.WriteLine(stk.Pop());
		
	    }
	    catch (Exception ex)
	    {
		Console.WriteLine(ex.Message);
	    }
        }
    }

    public class Stack
    {
	int []data;
	int top;
	int size; 

	public Stack(int size)
	{
	    this.size = size;
	    this.data = new int[size];
	    this.top = -1;
	}

	public void Push(int val)
	{
	    if (top == size - 1)
	    {
		throw new Exception("Stack is full");
	    }
	    data[++top] = val;
	}

	public int Pop()
	{
	    if (top == -1)
	    {
		throw new Exception("Stack is empty");
	    }
	    return data[top--];
	}

	public int Peek()
	{
	    if (top == -1)
	    {
		throw new Exception("Stack is empty");
	    }
	    return data[top];
	}
    }
}
