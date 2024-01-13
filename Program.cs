using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia smartNokia = new Nokia("082849124", "Nokia", "777777777", 70);
smartNokia.Ligar();

Iphone smartIphone = new Iphone("91637853", "Iphone", "627272713", 85);
smartIphone.ReceberLigacao();

smartNokia.InstalarAplicativo("GitHub");
smartIphone.InstalarAplicativo("Instagram");