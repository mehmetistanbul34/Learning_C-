using System;

class Metro{
	public static void Main(){
		int yolcuSayisi = 1;
		Console.WriteLine("1. Duraktaki yolcu sayısı: {0}",yolcuSayisi);
		for(int i=2;i<100;i++){
			yolcuSayisi += i;
			Console.WriteLine(i+". Duraktaki yolcu sayısı: {0}",yolcuSayisi);
		}
		Console.WriteLine("100. Duraktaki toplam yolcu sayısı: {0}",yolcuSayisi);
	}
}
