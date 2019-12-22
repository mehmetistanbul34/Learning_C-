using System;

class Metots{
	public void sirala(int[] dizi){
		Metots metots = new Metots();
		int temp;

		for(int i=0;i<dizi.Length;i++){
			for(int j=0;j<dizi.Length-1;j++){
				if(dizi[j]>dizi[j+1]){
					temp = dizi[j];
					dizi[j] = dizi[j+1];
					dizi[j+1] = temp;
				}
			}

		}
	}

	public void yaz(int[] dizi){
		for(int i=0;i<dizi.Length;i++){
			if(i==dizi.Length-1){
				Console.WriteLine(dizi[i]);
			}else{
				Console.Write(dizi[i]+", ");
			}
		}
	}
}

class onemsizdir{
	public static void Main(){
		Metots metots = new Metots();
		int[] dizi = new int[] {9,5,1,3,7,4,8,6,2,0};
		
		Console.Write("Sıralanmamış dizi: ");
		metots.yaz(dizi);
		metots.sirala(dizi);
		Console.Write("Sıralanmış dizi: ");	
		metots.yaz(dizi);	
	}
}
