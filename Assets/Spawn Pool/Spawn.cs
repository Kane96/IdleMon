using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public UniquePokemon pokemon;
    public int levelMin;
    public int levelMax;
    public int spawnChancePercentageFloor;
    public int spawnChancePercentageCeil;

    public UniquePokemon GetPokemon() {
        pokemon.SetLevel(Random.Range(levelMin, levelMax));
        pokemon.Initialise();
        return pokemon;
    }

    public int GetLevelMin() {
        return levelMin;
    }

    public int GetLevelMax() {
        return levelMax;
    }

    public int GetSpawnChancePercentageFloor() {
        return spawnChancePercentageFloor;
    }

    public int GetSpawnChancePercentageCeil() {
        return spawnChancePercentageCeil;
    }
}
