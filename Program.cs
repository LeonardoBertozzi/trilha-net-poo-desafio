using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "989234", modelo: "Azul", imei: "123456", memoria: 5);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Cobrinha");
nokia.Configuracoes();
Console.WriteLine("\n");
Smartphone iphone = new Iphone(numero: "876543", modelo: "Prata", imei: "654321", memoria: 25);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");
iphone.Configuracoes();
