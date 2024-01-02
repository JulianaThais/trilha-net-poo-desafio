using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
﻿using DesafioPOO.Models;

Console.WriteLine("Telefone Nokia: ");
Smartphone nokia = new Nokia(numero:"345678", modelo:"nokia 25", imei:"789536", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Telefone Iphone: ");
Smartphone iphone = new Iphone(numero: "234564", modelo: "iphone 10", imei: "2536987", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");