using System;

class Metotlar{
	public static void isAquel(string password, string againPassword){
		int sorgu = string.Compare(password,againPassword);
		if(sorgu == 0){
			Console.WriteLine("Welcome to main package");
		}else{
			Console.WriteLine("Sorry, passwords not aquel");
		}
	}
}

class AnaSinif{
	public static void Main(){
		Console.Write("Enter to password: ");
		string password = Console.ReadLine();
		Console.Write("Enter to password again: ");
		string againPassword = Console.ReadLine();
		
		Metotlar.isAquel(password,againPassword);
	}
}
