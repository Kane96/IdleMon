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

    private Pokemon active;

    private int currentHP;

    private void Start() {
        active = team.GetPokemon(0);
        sprite.sprite = active.getSpriteFront();

        currentHP = active.getBaseHitPoints();
        healthText.text = currentHP.ToString();
    }

    private void UpdateText() {
        healthText.text = currentHP.ToString();
    }

    public Pokemon GetActive() {
        return active;
    }

    public void TakeDamage(int damage) {
        if (currentHP > 0) {
            currentHP -= damage;
            UpdateText();
        }
    }
}
