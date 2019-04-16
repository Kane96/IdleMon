using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamSlot : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite defaultSprite;
    private UniquePokemon pokemon;

    void Start() {
        pokemon = GetComponent<UniquePokemon>();
        if (pokemon.GetPokemon() != null) {
            sprite.sprite = pokemon.GetPokemon().GetIcon();
        }
    }

    void Update()
    {
        
    }
}
