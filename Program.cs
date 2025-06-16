using DesafioPOO.Models;

//Testando Nokia
Nokia nokia = new Nokia("92222-2222", "HMD Fusion X1", "000000-00-000000-0", 6);

string oldNumber = nokia.Numero;
nokia.Numero = "93838-3838";
Console.WriteLine($"{nokia.Modelo} -\nNúmero antigo: {oldNumber}\nNúmero novo: {nokia.Numero}\n");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Velha");
Console.WriteLine("\n");

//Testando iPhone

Iphone iphone = new Iphone("92372-2883", "iPhone 13", "000000-00-000000-2", 4);
oldNumber = iphone.Numero;
iphone.Numero = "93923-0634";
Console.WriteLine($"{iphone.Modelo} -\nNúmero antigo: {oldNumber}\nNúmero novo: {iphone.Numero}\n");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Red Dead Redemption 2");
Console.WriteLine("\n");