using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPool : MonoBehaviour
{
    public Spawn[] spawnPool;

    void Start() {
        ValidateSpawnChance();
    }

    public UniquePokemon GetSpawn() {
        int random = Random.Range(1, 100);

        foreach (Spawn spawn in spawnPool) {
            if (random >= spawn.GetSpawnChancePercentageFloor() && random <= spawn.GetSpawnChancePercentageCeil()) {
                return spawn.GetPokemon();
            }
        }

        print("ERROR: Could not return a Pokemon.");
        return null;
    }

    private void ValidateSpawnChance() {
        int count = 0;
        foreach (Spawn spawn in spawnPool) {
            count += spawn.GetSpawnChancePercentageCeil();
        }

        if (count > 100) {
            Debug.Log("ERROR: Total spawn chance cannot be above 100.");
        }
    }
}

