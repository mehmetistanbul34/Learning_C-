using System;

class myClass{
	public myClass():this(0){
		Console.WriteLine("Boş constructor çağırıldı");
	}
	public myClass(int s1):this(0,s1){
		Console.WriteLine("Tek parametreli constructor çağırıldı");	
	}
	public myClass(int s1, int s2):this(0,s1,s2){
		Console.WriteLine("İki parametreli constructor çağırıldı");		
	}
	public myClass(int s1, int s2, int s3):this(0,s1,s2, s3){
		Console.WriteLine("Üç parametreli constructor çağırıldı");
	}
	public myClass(int s1, int s2, int s3, int s4){
		Console.WriteLine("Dört parametreli constructor çağırıldı");
	}
}

class myMain{
	public static void Main(){
		/*new myClass();
		new myClass(5);
		new myClass(10,11);
		new myClass(111,15,26);
		new myClass(55,44,88,77);*/

		/*	Bunların hepsinin yerine işimizi tek bir satirda da hall edebiliriz. Nasıl mı işte burda imdadımıza this sözcüğü yetişiyor. 
			Deneyip görelim.*/
		new myClass();
	}
}
