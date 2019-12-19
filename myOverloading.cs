using System;

class Overloading{
	int toplam;
	public void topla(){
		Console.WriteLine("Toplam = "+toplam);
	}
	public void topla(int s1){
		toplam = s1;
		Console.WriteLine("Toplam = "+toplam);
	}
	public void topla(int s1, int s2){
		toplam = s1+s2;
		Console.WriteLine("Toplam = "+toplam);
	}
	public void topla(int s1, int s2, int s3){
		toplam = s1+s2+s3;
		Console.WriteLine("Toplam = "+toplam);
	}
	public void topla(int s1, int s2, int s3, int s4){
		toplam = s1+s2+s3+s4;
		Console.WriteLine("Toplam = "+toplam);
	}
}

class myMain{
	public static void Main(){
		Overloading overdoading = new Overloading();
		overdoading.topla();
		overdoading.topla(5);
		overdoading.topla(15,20);
		overdoading.topla(10,20,30);
		overdoading.topla(40,50,60,70);
	}
}
