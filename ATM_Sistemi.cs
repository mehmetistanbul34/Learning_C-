using System;

class Metotlar{
	public void girisBasarili(){
        Console.Clear();
		int bakiye = 1500,secim=-1;
		Console.WriteLine("\n<<<<<<<<<<<<<<< Bankamıza Hoşgeldiniz >>>>>>>>>>>>>>>");
		string girisBilgi = "################################################\n"+
							"\tBakiyenizi öğrenmek için 1\n"+
							"\tPara çekmek için 2\n"+
							"\tPara yatırmak için 3\n"+
							"\tÇıkış için 0'a basınız\n"+
							"################################################\n"+
							"Seçiminiz: ";
		while(secim != 0){
			Console.Write(girisBilgi);
			secim = Convert.ToInt32(Console.ReadLine());
			switch(secim){
				case 0:
					Console.WriteLine("\v>>>>>>>>>>>>>>> Bankadan Çıkılıyor <<<<<<<<<<<<<<<");
					break;
				case 1:
        			Console.Clear(); 
					Console.WriteLine("\vBakiyeniz: {0}\n",bakiye);
					break;
				case 2:
        			Console.Clear();
					Console.Write("Çekilecek miktarı giriniz: ");
					int ckMiktar = Convert.ToInt32(Console.ReadLine());
					if(ckMiktar < 1500){
						if(ckMiktar <= bakiye){
							bakiye -= ckMiktar; 
							Console.WriteLine("\vHesabınızdan "+ckMiktar+" tl çekmenizin sonucunda oluşan yeni bakiyeniz: "+bakiye+" tl'dir.\n");
						}
						else{
							Console.WriteLine("\n\t========> Üzgünüz, hesabınızda o kadar para yok. bakiyeniz: {0}\n",bakiye);
						}	
					}
					else{
						Console.WriteLine("\n\t========> Bir günde çekilebilecek miktar 1500'den daha az olmalıdır.\n");
					}
					break;
				case 3:
        			Console.Clear();
					Console.Write("Yatıracağınız miktarı giriniz: ");
					int ytMiktar = Convert.ToInt32(Console.ReadLine());
					if(ytMiktar <= bakiye){
						Console.Write("Alıcının adı: ");
						string alici = Console.ReadLine();
						bakiye -= ytMiktar; 
						Console.WriteLine("\vHesabınızdan "+alici+" kişisine "+ytMiktar+" tl gönderilmesi sonucunda oluşan yeni bakiyeniz: "+bakiye+" tl'dir.\n");
					}
					else{
						Console.WriteLine("\n\t========> Üzgünüz, hesabınızda o kadar para yok. bakiyeniz: {0}\n",bakiye);
					}
					break;
				default:
					break;
			}
		}
	}
}

class atm{
	public static void Main(){
		int sifre = 1453, girisHakki=3;
		while(true){
			Console.Write("Şifreniz: ");
			int sfr = Convert.ToInt32(Console.ReadLine());
			if(sifre == sfr){
				//Console.WriteLine(">>>>>> Giriş Başarılı <<<<<<<");
				Metotlar metotlar = new Metotlar();
				metotlar.girisBasarili();
				break;
			}
			else{
				girisHakki--;
				if(girisHakki>0){
        			Console.Clear();
					Console.WriteLine("Yanlış şifre. Kalan hakkınız: "+girisHakki);
				}
				else{
        			Console.Clear();
					Console.WriteLine("<<<<<<< Giriş Başarısız. Giriş hakkınız bitmiştir. Çıkış yapılıyor >>>>>>>");
					break;
				}
			}
		}
	}
}
