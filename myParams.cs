using System;

class metots{
	public static int myParams(params int[] value){	//Overloading yapmak yerine params kullanmak çok daha mantıklıdır.
		int total=0;
		foreach(int sayi in value){
			total += sayi;
		}
		return total;
	}
}

class deneme{
	public static void Main(){
		int s0 = metots.myParams();
		int s1 = metots.myParams(9);
		int s2 = metots.myParams(1,5);
		int s3 = metots.myParams(10,15,19);
		
		Console.WriteLine("s0: {0}",s0);
		Console.WriteLine("s1: {0}",s1);
		Console.WriteLine("s2: {0}",s2);
		Console.WriteLine("s3: {0}",s3);
	}
}
