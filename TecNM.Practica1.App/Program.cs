using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;

public static class Program {
    
    public static void  Main(string[] args){
        float WMPesoM = 0;
        float weight = 0;

        System.Console.WriteLine("Please enter the Weight: ");
        Single.TryParse(System.Console.ReadLine(), out weight);


        var person = new Person{Weight = weight};

        var service = new WMService();
        var manager = new WMManager(service);

        WM wm = manager.GetWM(person);

        System.Console.WriteLine($"Your weight on mars is :  {wm.PesoM}");
    }
}