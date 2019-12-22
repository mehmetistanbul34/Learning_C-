using System;

class anaClass{
	public static void Main(){
		Console.Write("Satir sayısını giriniz: ");
		int row = Convert.ToInt32(Console.ReadLine());
		int star=1,bosluk=row/2;
		for(int i=0;i<row;i++){
			if(i<row/2){
				for(int j=0;j<bosluk;j++){
					Console.Write(" ");
				}
				for(int k=0;k<star;k++){
					if(k==0 || k==star-1){
						Console.Write("1");
					}else{
						Console.Write("0");
					}
				}
				Console.WriteLine();
				bosluk--;
				star += 2;
			}else{
				bosluk++;
				star -= 2;
				for(int j=0;j<bosluk;j++){
					Console.Write(" ");
				}
				for(int k=0;k<star;k++){
					if(k==0 || k==star-1){
						Console.Write("0");
					}else{
						Console.Write("1");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
