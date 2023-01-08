namespace MyApp
{
	public class SimpleStack<T>
	{
		private readonly T[] items;
		private int currentIndex = -1;
		public SimpleStack()
		{
			items = new T[10];
		}
		public int Count
		{
			get
			{
				return currentIndex + 1;
			}
		}
		public void Push(T item)
		{
			items[++currentIndex] = item;
		}
		public T Pop()
		{
			T value = items[currentIndex--];
			return value;
		}
	}
}
