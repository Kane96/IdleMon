using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniquePokemon : MonoBehaviour
{
    public bool initialised;
    public bool ownedByPlayer;

    public Pokemon pokemon;
    private ActivePokemon active;

    public int level;
    public int experience;
    public int expToNextLevel;

    public int hitPoints;
    public int attack;
    public int defence;
    public int speed;

    void Awake() {
        if (!initialised) {
            Initialise();
        }

        if (ownedByPlayer) {
            active = GameObject.Find("Active Pokemon Player").GetComponent<ActivePokemon>();
        }
    }

    void Update() {
        if (experience >= expToNextLevel) {
            LevelUp();
        }
    }

    public void GainExp(int exp) {
        experience += exp;
    }

    public void LevelUp() {
        active.SetCurrentHitPoints(active.GetCurrentHitPoints() - hitPoints);
        level++;
        expToNextLevel = (level + 1) * (level + 1) * (level + 1);
        GenerateStats();
        active.SetCurrentHitPoints(active.GetCurrentHitPoints() + hitPoints);
        active.UpdateText();
    }

    public int CalculateExperienceReward() {
        int exp = 0;
        exp = 80 * level;
        exp /= 7;
        return exp;
    }

    public void CalculateCurrentExp() {
        experience = level * level * level;
        expToNextLevel = (level + 1) * (level + 1) * (level + 1);
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

    public void GenerateStats() {
        hitPoints = GenerateStat(pokemon.GetBaseHitPoints());
        attack = GenerateStat(pokemon.GetBaseAttack());
        defence = GenerateStat(pokemon.GetBaseDefence());
        speed = GenerateStat(pokemon.GetBaseSpeed());
    }

    public void Initialise() {
        GenerateStats();
        if (ownedByPlayer) {
            CalculateCurrentExp();
        }
        initialised = true;
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

    public void SetLevel(int newLevel) {
        level = newLevel;
    }
}
