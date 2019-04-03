using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public UniquePokemon[] team = new UniquePokemon[5];

    public UniquePokemon GetPokemon(int slot) {
        return team[slot].GetComponent<UniquePokemon>();
    }
}
