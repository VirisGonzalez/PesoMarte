using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class WMManager : IWMManager{
    private readonly IWMService _service;

    public WMManager(IWMService service){
        _service = service;
    }

    public WM GetWM(Person person){
        return _service.ProcessWM(person);
    }
}