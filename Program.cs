using DesafioPOO.Models;


Console.WriteLine("Teste num nokia");
Smartphone nokia = new Nokia(numero:"986961922", modelo:"z04", imei:"1111111", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");
nokia.ExibirDados();

Console.WriteLine("Teste num iphone");
Smartphone iphone = new Iphone(numero:"974235689", modelo:"13 pro", imei:"12122222", memoria:256);
iphone.Ligar();
iphone.InstalarAplicativo("twitter");
iphone.ExibirDados();