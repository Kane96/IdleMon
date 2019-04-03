using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivePokemon : MonoBehaviour
{
    public Team team;
    public SpriteRenderer sprite;
    public bool player;
    public Text healthText;

    private UniquePokemon active;

    private int currentHitPoints; 

    private void Start() {
        active = team.GetPokemon(0);
        if (player) {
            sprite.sprite = active.GetPokemon().GetSpriteBack();
        } else {
            sprite.sprite = active.GetPokemon().GetSpriteFront();
        }
        
        currentHitPoints = active.GetHitPoints();
        healthText.text = currentHitPoints.ToString();
    }

    private void UpdateText() {
        healthText.text = currentHitPoints.ToString();
    }

    public UniquePokemon GetActive() {
        return active;
    }

    public void TakeDamage(int damage) {
        if (currentHitPoints > 0) {
            currentHitPoints -= damage;
            UpdateText();
        }
    }
}
