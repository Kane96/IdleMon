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
    public Text levelText;
    public Text expText;

    private UniquePokemon active;
    private int currentHitPoints;

    public SpawnPool currentRoute;

    public Animator anim;

    void Start() {
        if (player) {
            active = team.GetPokemon(0);
            sprite.sprite = active.GetPokemon().GetSpriteBack();
        } else {
            GetNewActive();
            sprite.sprite = active.GetPokemon().GetSpriteFront();
        }
        
        currentHitPoints = active.GetHitPoints();
        UpdateText();
    }

    public void TakeDamage(int damage) {
        if (currentHitPoints - damage < 0) {
            currentHitPoints = 0;
        }
        else if (currentHitPoints > 0) {
            currentHitPoints -= damage;
        }
        UpdateText();
    }

    public void UpdateText() {
        healthText.text = currentHitPoints.ToString();
        levelText.text = active.GetLevel().ToString();
        if (expText != null) {
            expText.text = active.GetExpToNextLevel().ToString();
        }
    }

    public UniquePokemon GetActive() {
        return active;
    }

    public void Faint() {
        anim.SetBool("Fainted", true);
    }

    private void GetNewActive() {
        // Called in animator
        active = currentRoute.GetSpawn();
        currentHitPoints = active.GetHitPoints();
        UpdateText();
        sprite.sprite = active.GetPokemon().GetSpriteFront();
        anim.SetBool("Fainted", false);
    }

    public int GetCurrentHitPoints() {
        return currentHitPoints;
    }

    public void SetCurrentHitPoints(int hitPoints) {
        currentHitPoints = hitPoints;
    }

    public bool IsPlayer() {
        return player;
    }

    public void SwapPokemon(UniquePokemon newPokemon) {
        if (newPokemon != active) {
            active = newPokemon;
            currentHitPoints = active.GetHitPoints();
            UpdateText();
            sprite.sprite = active.GetPokemon().GetSpriteBack();
        }
    }
}
