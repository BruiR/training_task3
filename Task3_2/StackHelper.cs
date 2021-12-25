public static class StackHelper
{
    public static IStack<T> Reverse<T>(this IStack<T> stack)
    {
        IStack<T> reversedStack = new Stack<T>();
        IStack<T> copiedStack = new Stack<T>();
        while (!stack.IsEmpty())
        {
            T tmp = stack.Pop();
            reversedStack.Push(tmp);
            copiedStack.Push(tmp);
        }            
        while (!copiedStack.IsEmpty())
        {
            stack.Push(copiedStack.Pop());
        }   
        return reversedStack;
    }
}

