using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("219999-9999", "Flip", "45468798798798", 16);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");

Iphone i1 = new Iphone("219999-5555", "11 Pro", "698798654656546", 256);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Candy Crush");
