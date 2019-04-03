using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniquePokemon : MonoBehaviour
{
    public bool initialised;

    public Pokemon pokemon;
    public int level;

    public int hitPoints;
    public int attack;
    public int defence;
    public int speed;

    void Awake() {
        if (!initialised) {
            hitPoints = GenerateStat(pokemon.GetBaseHitPoints());
            attack = GenerateStat(pokemon.GetBaseAttack());
            defence = GenerateStat(pokemon.GetBaseDefence());
            speed = GenerateStat(pokemon.GetBaseSpeed());

            initialised = true;
        }
    }

    public int GenerateStat(int baseStatValue) {
        int stat = 0;
        int multiplier = 2;
        int floor = 5;

        stat = (multiplier * baseStatValue) * level;
        stat /= 100;
        stat += floor;

        return stat;
    }

    public Pokemon GetPokemon() {
        return pokemon;
    }

    public int GetLevel() {
        return level;
    }

    public int GetHitPoints() {
        return hitPoints;
    }

    public int GetAttack() {
        return attack;
    }

    public int GetDefence() {
        return defence;
    }

    public int GetSpeed() {
        return speed;
    }
}
