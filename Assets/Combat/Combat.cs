using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public float cooldown;
    private float count;

    public ActivePokemon player, opponent;

    private float playerSpeed;

    void Start() {
        playerSpeed = (float)player.GetActive().GetSpeed();
        playerSpeed /= 1000;
    }

    void Update() {

        if (opponent.GetCurrentHitPoints() > 0) {
            count += Time.deltaTime;
        }
        if (count > cooldown - playerSpeed * 4) {
            AttackTarget(player, opponent);
            count = 0;
        }
    }

    private void AttackTarget(ActivePokemon attacker, ActivePokemon target) {
        UniquePokemon pokemonAttacker = attacker.GetActive();
        UniquePokemon pokemonTarget = target.GetActive();
        int attackerLevel = pokemonAttacker.GetLevel();
        int attackerAttackStat = pokemonAttacker.GetAttack();
        int targetDefenceStat = pokemonTarget.GetDefence();

        int damage = CalculateDamage(attackerLevel, attackerAttackStat, targetDefenceStat);

        target.TakeDamage(damage);
        if (target.GetCurrentHitPoints() == 0) {
            target.Faint();
            if (attacker.IsPlayer()) {
                pokemonAttacker.GainExp(pokemonTarget.CalculateExperienceReward());
            }
        }
    }

    private int CalculateDamage(int attackerLevel, int attackerAttackStat, int targetDefenceStat) {
        int power = 40;

        int damage = 0;
        damage = (attackerLevel * 2) / 5 + 2;
        damage *= power;
        damage += attackerAttackStat / targetDefenceStat;
        damage /= 50;
        damage += 2;
        return damage;
    }
}
