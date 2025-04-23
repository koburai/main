using Microsoft.EntityFrameworkCore;

[Keyless]
public class State
{
    public string StateName { get; set; }
    public string StateFlagDesc { get; set; }
    public string StateFlower { get; set; }
    public string StateBird { get; set; }
    public string StateColors { get; set; }
    public string LargeCityOne { get; set; }
    public string LargeCityTwo { get; set; }
    public string LargeCityThree { get; set; }
    public string Capital { get; set; }
    public int MedIncom { get; set; }
    public int CompJobs { get; set; }
}
