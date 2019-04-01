using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public GameObject[] team = new GameObject[5];

    public Pokemon GetPokemon(int slot) {
        return team[slot].GetComponent<Pokemon>();
    }
}
