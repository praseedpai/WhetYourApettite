import java.lang.*;

class bubble3 {
	
	
	interface IComparatorStrategy<T>
	{ int Execute(T a, T b); }

	static class IntComparator implements IComparatorStrategy<Integer> 
	{
		public int Execute(Integer a, Integer b) 
		{
			return a > b ? 1 : (b > a ) ? -1 : 0;
		}
	}
	
	static class DoubleComparator implements IComparatorStrategy<Double> 
	{
		public int Execute(Double a, Double b)
		{
			return a > b ? 1 : (b > a) ? -1 : 0;
		}
	}
	
	public static <T> void bubbleSort(T [] arr, IComparatorStrategy<T> cmp ){
		
		int n = arr.length;
		for(int i = 0; i<n; ++i)
			for (int j = 0; j < n-i-1; j++)
				if (cmp.Execute(arr[j], arr[j + 1]) > 0 )
				{
					T temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}
		
		
	}
	
	public static void main(String [] args) 
	{
		int len = args.length;
		if(len==0)
		{
			System.out.println("No args");
			return; 
		}
		Integer [] arr=new Integer[len];
		
		for(int j=0;j<len;j++)
		{
			
			arr[j]= Integer.parseInt(args[j]);
		}
		
		bubbleSort(arr,new IntComparator());
		
		for(Integer item: arr)
		{
			System.out.println("Arr" + item);
		}
	}

}