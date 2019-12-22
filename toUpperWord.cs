using System;

class Metotlar{
	public void myToUpperCase(string word){
		string kelime="";
		for(int i=0;i<word.Length;i++){
			int wordInt = Convert.ToInt32(word[i]);
			char wordUpper = (char)(wordInt-32);
			kelime += wordUpper;
		}
		Console.WriteLine(kelime);
	}
}

class AnaSınıf{
	public static void Main(){
		Metotlar metotlar = new Metotlar();

		Console.Write("Bir kelime giriniz: ");
		string word = Console.ReadLine();
		Console.Write("myToUpperCase(word): ");
		metotlar.myToUpperCase(word);

		Console.Write("Bir kelime daha giriniz: ");
		string word2 = Console.ReadLine();
		Console.Write("word.ToUpper: ");
		Console.WriteLine(word2.ToUpper());
	}
}
