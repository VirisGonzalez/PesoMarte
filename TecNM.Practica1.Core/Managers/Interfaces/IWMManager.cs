using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Managers.Interfaces;

public interface IWMManager{
    WM GetWM(Person person);
}