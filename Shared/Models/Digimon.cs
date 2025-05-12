using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonCalcWeb.Shared.Models;

public class Digimon
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = "";
    public int Type { get; set; } = 0;
    public int HP { get; set; } = 0;
    public int MP { get; set; } = 0;
    public int Offense { get; set; } = 0;
    public int Defense { get; set; } = 0;
    public int Speed { get; set; } = 0;
    public int Brains { get; set; } = 0;
    public int Caremistakes { get; set; } = 0;
    public string Caredirection { get; set; } = "";
    public int WeightMin { get; set; } = 0;
    public int WeightMax { get; set; } = 0;
    public int Happiness { get; set; } = 0;
    public int Discipline { get; set; } = 0;
    public int Battles { get; set; } = 0;
    public string BattlesDirection { get; set; } = "";
    public int Techniques { get; set; } = 0;
    public List<string> EvolvesFrom { get; set; } = new();
    public List<string> EvolvesTo { get; set; } = new();
}
