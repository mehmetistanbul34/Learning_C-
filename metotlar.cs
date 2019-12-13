using System;

class Fonksiyonlar{
	public void metot1(){
		Console.WriteLine("Metot 1");
	}

	public static void metot2(){
		Console.WriteLine("Metot 2");
	}
}

class Onemsizdir{
	public void metot3(){
		Console.WriteLine("Metot 3");
	}

	public static void metot4(){
		Console.WriteLine("Metot 4");
	}
	
	public static void Main(){
		Fonksiyonlar fonksiyonlar = new Fonksiyonlar();
		fonksiyonlar.metot1();	 // Static olmayan metotlar farklı classlarda ise zaten instance olmadan ulaşamayız.
		
		Fonksiyonlar.metot2();	// Farklı classa ait static metotlar için instance'a gerek yoktur. 
								//Doğrudan className.metotName şeklinde de çağırılabilir.	

		Onemsizdir onemsizdir = new Onemsizdir();
		onemsizdir.metot3(); // Static olmayan metotlar aynı classda olsa bile instance'a gerek vardır.

		metot4();	// Kendi classına ait static metotlar için instance'a gerek yoktur.
	}
}
