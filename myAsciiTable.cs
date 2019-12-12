using System;

class onemsizdir{
	public static void Main(){
		
		Console.WriteLine("--------------------------------------");
			Console.WriteLine("| char  |  İnteger | CHAR  | İnteger |");
		for(char c='a';c<='z';c++){
			int i = (int)c;
			int j = i;
			j -= 32;
			char cc = (char)j;
			Console.WriteLine("--------------------------------------");
			if(i<100){
				Console.WriteLine("|  {0}    |    {1}    |   {2}   |    {3}   |",c,i,cc,j);
			}else{
				Console.WriteLine("|  {0}    |    {1}   |   {2}   |    {3}   |",c,i,cc,j);
			}
		}
		Console.WriteLine("--------------------------------------");
	}
}

