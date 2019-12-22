using System;

class anaClass{
	public static void Main(){
		Console.Write("satır sayısını giriniz: ");
		int satir = int.Parse(Console.ReadLine());
		int sayac=0;
		for(int i=1;i<=satir;i++){
			for(int j=0;j<i;j++){
				sayac++;
				Console.Write(sayac+", ");
			}
			Console.WriteLine();
		}
	}
}
