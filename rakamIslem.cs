using System;

class anaSayfa{
	public static void Main(){
		Console.Write("Bir sayı giriniz: ");
		int sayi = int.Parse(Console.ReadLine());
		int sabit = sayi;
		int kareleriToplami=0,birlerBasamagi=0,kareleri=0;
		do{
			birlerBasamagi = sayi%10;
			kareleri = birlerBasamagi*birlerBasamagi;
			kareleriToplami += kareleri;
			sayi = sayi/10; 		
		}while(sayi>0);
		Console.WriteLine("Girilen {0} sayısının rakamlarının kareleri toplamı = {1}'dir.",sabit,kareleriToplami);
	}
}
