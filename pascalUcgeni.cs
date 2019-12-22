using System;

class onemsizdir{
	public static void Main(){
		int bosluk=5,sayi=1;
		for(int i=1;i<=5;i++){
			for(int j=0;j<bosluk;j++){
				Console.Write(" ");
			}
			for(int j=0;j<sayi;j++){
				if(j==0 || j==sayi-1){
					Console.Write(1);
				}else{
					if(j%2 != 0){
						Console.Write(" ");
					}else{
						Console.Write(j);
					}
				}
			}
			Console.WriteLine();
			bosluk--;
			sayi +=2;
		}
	}
}
