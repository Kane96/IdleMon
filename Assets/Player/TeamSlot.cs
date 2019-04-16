using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamSlot : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite defaultSprite;
    private BoxCollider2D box;

    public ActivePokemon activePokemonPlayer;
    private UniquePokemon pokemon;

    void Start() {
        pokemon = GetComponent<UniquePokemon>();
        if (pokemon.GetPokemon() != null) {
            sprite.sprite = pokemon.GetPokemon().GetIcon();
        }

        box = GetComponent<BoxCollider2D>();
    }

    private void OnMouseDown() {
        if (pokemon.GetPokemon() != null) {
            activePokemonPlayer.SwapPokemon(pokemon);
        }
    }
}
