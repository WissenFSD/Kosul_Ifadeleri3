// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// koşul ifadeleri ikiye ayrılır
// 1 : if , else if else
// 2 : swich case

//Console.WriteLine("Sayı Giriniz");

//int sayi = Convert.ToInt32(Console.ReadLine());

//switch (sayi)
//{
//	// else if(sayi==0)
//	case 0:Console.WriteLine("girdiniz sayı 0");
//		break;

//	//else if(sayi==1)
//	case 1:Console.WriteLine("girdiğin sayı 1");
//		break;

//}



// Tek sayı çift sayı örneği

//Console.WriteLine("lütfen bir sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());

//switch (sayi%2==0)
//{
//	case true: Console.WriteLine("sayı çift");
//		break;
//	case false: Console.WriteLine("sayı tek");
//		break;	
//}

//switch (sayi % 2)
//{
//    case 0:
//        Console.WriteLine("sayı çift");
//        break;
//    case 1:
//        Console.WriteLine("sayı tek");
//        break;
//}


// ay girerek mevsim göstermek

Console.WriteLine("Lütfen 1-12 arası bir sayı giriniz");

int sayi = Convert.ToInt32(Console.ReadLine());



// swich case örneğinde, aynı sonucu verecek caseler ortak yazılabilir. Bu şekilde hem daha anlaşılır olur hemde daha profesyonel olacaktır.
//switch (sayi)
//{
//    case 1:
//    case 2:
//    case 3:
//    case 12:
//        Console.WriteLine("Kış");
//        break;
//    case 4:
//    case 5:
//        Console.WriteLine("İlkBahar");
//        break;
//    case 6:
//    case 7:
//    case 8:
//    case 9:
//    case 10:
//        Console.WriteLine("Yaz");
//        break;

//    case 11:
//    case 13:
//        Console.WriteLine("Son Bahar");
//        break;
//    default: Console.WriteLine("yanlış ay girdiniz.");
//        break;

//}


// basit hesap makinasını swich case ile yazınız


#region Hesap makinası 
//Console.WriteLine("Lütfen 1. sayıyı giriniz");

//int sayi1 = Convert.ToInt32(Console.ReadLine());    
//Console.WriteLine("Lütfen 2. sayıyı giriniz");
//int sayi2= Convert.ToInt32(Console.ReadLine()); 
//Console.WriteLine("İşlem giriniz  +,*,-,/");


//char islem = Convert.ToChar(Console.ReadLine());

//switch (islem)
//{
//	case '+': Console.WriteLine("{0}+{1}={2}", sayi1, sayi2, sayi1 + sayi2);
//		break;

//    case '-':
//        Console.WriteLine("{0}-{1}={2}", sayi1, sayi2, sayi1 - sayi2);
//        break;

//    case '*':
//        Console.WriteLine("{0}*{1}={2}", sayi1, sayi2, sayi1 * sayi2);
//        break;

//    case '/':
//        bool isok = sayi2 == 0;

//        switch (isok)
//        {
//            case true:
//                Console.WriteLine("Bölen 0 olamaz");
//                break;
//            case false:
//                Console.WriteLine("{0}*{1}={2}", sayi1, sayi2, sayi1 * sayi2);
//                break;

//        }
//        break;
        

//}
#endregion


// ilk plaka numarası girip ilin adını yazan bir uygulama yapın

  // 01 adana 06 ankara 34 istanbul 81 düzce 35 izmir 10 balıkesir


