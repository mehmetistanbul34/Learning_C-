using System;

class Metot{
	static int sayac=0;
	public Metot(){
		sayac ++;
		Console.WriteLine("Bu class'dan {0} tane instance oluşturuldu.",sayac);
	}
}

class AnaClass{
	public static void Main(){
			new Metot();
			new Metot();
			new Metot();
			new Metot();
			new Metot();
			new Metot();
			new Metot();
			new Metot();
			new Metot();
	}
}
