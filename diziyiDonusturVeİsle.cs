using System;

class Donustur{
	public int[] Inte(Array dizi){
		int[] gecici = new int[dizi.Length];
		for(int i=0;i<dizi.Length;i++){
			gecici[i] = Convert.ToInt32(dizi.GetValue(i));
		}
		return gecici;
	}

	public string[] Stringe(Array dizi){
		string[] gecici = new string[dizi.Length];
		for(int i=0;i<dizi.Length;i++){
			gecici[i] = dizi.GetValue(i).ToString();
		}
		return gecici;
	}

	public void yaz(int[] dizi){
		for(int i=0;i<dizi.Length;i++){
			Console.Write(dizi[i]+" , ");
		}
		Console.WriteLine();
	}

	public void yaz(string[] dizi){
		for(int i=0;i<dizi.Length;i++){
			Console.Write(dizi[i]+" , ");
		}
		Console.WriteLine();
	}

	public void topla(int[] dizi,int[] arr){
		for(int i=0;i<dizi.Length;i++){
			Console.Write(dizi[i]+arr[i]+" , ");
		}
		Console.WriteLine();
	}

	public void topla(string[] dizi, int[] arr){
		for(int i=0;i<dizi.Length;i++){
			Console.Write(dizi[i]+arr[i]+" , ");
		}
		Console.WriteLine();
	}
}

class MyMain{
	public static void Main(){
		Donustur donustur = new Donustur();
		string[] Str_dizi = {"2","5","7","9"};
		int[] Int_dizi = new int[] {22,55,77,99};
		int[] Strden_Inte_dizi = donustur.Inte(Str_dizi);

		Console.Write("Str dizi = ");
		donustur.yaz(Str_dizi);

		Console.Write("İnt dizi = ");
		donustur.yaz(Int_dizi);

		Console.Write("Str + int = ");
		donustur.topla(Str_dizi,Int_dizi);

		Console.Write("Str'den_inte_kest + int = ");
		donustur.topla(Strden_Inte_dizi,Int_dizi);
	}
}
