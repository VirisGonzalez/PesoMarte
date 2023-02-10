using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class WMService : IWMService{
    public WM ProcessWM(Person person){

        var wm = new WM();
        wm.PesoM = person.Weight / 9.81 * (3.711);


        return wm;
    }
}