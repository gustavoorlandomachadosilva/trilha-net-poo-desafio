using DesafioPOO.Models;
// FEITO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("SmartPhone Nokia:");
Nokia nokia = new Nokia("123456","Modelo 1","111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
System.Console.Write("\n");
System.Console.WriteLine("SmartPhone Iphone:");
Iphone iphone = new Iphone("654321","Modelo 2","222222",128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
