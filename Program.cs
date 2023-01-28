using DesafioPOO.Models;

Nokia nokia = new Nokia("123", "Tijolão", "31415", 2);

nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("\n");

Iphone iphone = new Iphone("456", "500s", "27182", 32);

iphone.Ligar();
iphone.InstalarAplicativo("AppleStore");