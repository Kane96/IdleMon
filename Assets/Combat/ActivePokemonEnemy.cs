using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePokemonEnemy : MonoBehaviour
{
    public Team team;
    public SpriteRenderer sprite;

    private void Start() {
        Pokemon active = team.GetPokemon(0);
        sprite.sprite = active.getSpriteFront();
    }
}
