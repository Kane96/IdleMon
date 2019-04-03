using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public float cooldown;
    private float count;

    public ActivePokemon player, opponent;

    void Update() {
        count += Time.deltaTime;
        if (count > cooldown) {
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
