using DesafioPOO.Models;

Console.WriteLine("celular Nokia");

Nokia nokia = new Nokia(numero:"923893",modelo:"Nokia pro",imei:"232137897987",memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("whatsaap");

Console.WriteLine("\n");

Console.WriteLine("celular iphone");
Iphone iphone = new Iphone(numero:"32138393",modelo:"iphone XR",imei:"3163892137",memoria:64);
nokia.ReceberLigacao();

iphone.Ligar();
iphone.InstalarAplicativo(" ");