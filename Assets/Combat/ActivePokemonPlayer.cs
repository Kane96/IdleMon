using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePokemonPlayer : MonoBehaviour
{
    public Team team;
    public SpriteRenderer sprite;

    public Pokemon active;

    private void Start() {
        active = team.GetPokemon(0);
        sprite.sprite = active.getSpriteBack();
    }

    public Pokemon GetActive() {
        return active;
    }
}
