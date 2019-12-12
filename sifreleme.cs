using System;

class deneme{
	static string sifrele(string sfr){
		string str = "";
		for(int i=0;i<sfr.Length;i++){
			int aski = (int)sfr[i];
			aski++;
			char c=(char)aski;
			str += c;			
		}
		return str;
	}

	static string sifreCoz(string sfr){
		string str = "";
		for(int i=0;i<sfr.Length;i++){
			int aski = (int)sfr[i];
			aski--;
			char c=(char)aski;
			str += c;			
		}
		return str;
	}

	public static void Main(){
		Console.Write("Şifreyi giriniz : ");
		string sfr = Console.ReadLine();
		string gelenStr = sifrele(sfr);
		Console.WriteLine("Şifrelenen şifre: "+gelenStr);
		string gelenStr2 = sifreCoz(gelenStr);
		Console.WriteLine("Şifresi çözülmüş şifre: "+gelenStr2);
	}
}
