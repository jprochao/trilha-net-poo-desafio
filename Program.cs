using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone("9988-9999", "Iphone14", "35/990233", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Facetime");

Smartphone nokia = new Nokia("9987-8998", "Nokia Xpiria", "36/990344", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("YoutubeMusic");