using System;
using DesafioPOO.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "456789", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}