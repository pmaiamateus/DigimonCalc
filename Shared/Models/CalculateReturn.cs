namespace DigimonCalcWeb.Shared.Models;

public class CalculateReturn
{
    public Digimon Digimon { get; set; }
    public int Score { get; set; }
    public int CarriedOverStat { get; set; }
    public int CarriedOverCount { get; set; }
}
