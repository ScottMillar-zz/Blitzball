using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private Stat[] _stat;
    private string playerName;
    

    public bool inPossession = false;
    public string name;

    //stats
    public int level;
    public int healthPoints;
    public int speed;
    public int endurance;
    public int attack;
    public int passing;
    public int blocking;
    public int shooting;
    public int catching;

    public enum Stats
    {
        Level,
        HP,
        SP,
        EN,
        AT,
        PA,
        BL,
        SH,
        CA
    }

    public Player ()
    {
        playerName = name;

        _stat = new Stat[9];        

        _stat[(int)Stats.Level] = new Stat("Level", "Level of the player", level);
        _stat[(int)Stats.HP] = new Stat("HP", "Health Points: Number of health points", healthPoints);
        _stat[(int)Stats.SP] = new Stat("SP", "Speed: Speed of the player", speed);
        _stat[(int)Stats.EN] = new Stat("EN", "Endurance: amount of damage a player can take from opposition players when they has the ball ", endurance);
        _stat[(int)Stats.AT] = new Stat("AT", "Attack: How much damage a player deals when tackling", attack);
        _stat[(int)Stats.PA] = new Stat("PA", "Passing: How far and fast a player can pass the ball", passing);
        _stat[(int)Stats.BL] = new Stat("BL", "Blocking: Chance that a player will block shots and passes", blocking);
        _stat[(int)Stats.SH] = new Stat("SH", "Shooting: Power and pace of the shot towards goal", shooting);
        _stat[(int)Stats.CA] = new Stat("CA", "Catching: Determines if the Goalkeeper will save the shot", catching);

    }
}
