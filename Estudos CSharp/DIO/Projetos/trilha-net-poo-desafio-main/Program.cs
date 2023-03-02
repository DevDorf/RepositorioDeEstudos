using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone NOKIA: ");
Smartphone nokia = new Nokia(numero: "1234567",modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

Console.WriteLine("Smartphone IPHONE: ");
Smartphone iphone = new Iphone(numero: "1234567",modelo: "Modelo 1", imei: "111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");