using System;

class Set_And_Get{
	int sayi;
	
	public int sahteOzellik{
		set{
			if(value < 0){ sayi = 0;}else{sayi = value;}
		}
		get{
			if(sayi > 100){ return sayi%100;}else{return sayi;}	
		}
	}
}

class myMain{
	public static void Main(){
		Set_And_Get set_and_get = new Set_And_Get();
		set_and_get.sahteOzellik = -45;
		Console.WriteLine("set_and_get.sahteOzellik için -45 = "+set_and_get.sahteOzellik);
		set_and_get.sahteOzellik = 145;
		Console.WriteLine("set_and_get.sahteOzellik için 145 = "+set_and_get.sahteOzellik);
	}
}
