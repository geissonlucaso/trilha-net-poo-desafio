using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Smartphone sp = new Smartphone();        // Erro.
System.Console.WriteLine($"Nokia");
Nokia n = new Nokia("1234-1234", "4100", "123", 4);
n.Ligar();
n.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("--------------------");

System.Console.WriteLine($"Iphone");
Iphone i = new Iphone("5678-5678", "X", "456", 16);
i.ReceberLigacao();
i.InstalarAplicativo("Instragram");
