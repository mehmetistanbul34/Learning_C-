using System;

class MyMetots{
	public void copyDegistir(int copySayi){
		copySayi = 0;
	}
	public void originDegistir(ref int originSayi){
		originSayi = 0;
	}
}

class className{
	public static void Main(){
		MyMetots metots = new MyMetots();
		int sayi = 50;
		metots.copyDegistir(sayi);
		Console.WriteLine("Copyası gönderilen sayı için işlemin sonucu: "+sayi);
		metots.originDegistir(ref sayi);	//out ile göderip yakalarasan ilk değere ihtiyaç duyamaz ama ref ilk değere ihtiyaç duyar
		Console.WriteLine("Originali (ref || out) gönderilen sayı için işlemin sonucu: "+sayi);
	}
}
