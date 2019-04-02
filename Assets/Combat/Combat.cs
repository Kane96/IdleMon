using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public float cooldown;
    private float count;

    public ActivePokemonPlayer player;
    public ActivePokemonEnemy enemy;

    void Update() {
        count += Time.deltaTime;
        if (count > cooldown) {
            AttackTarget(player, enemy);
            count = 0;
        }
    }

    private void AttackTarget(ActivePokemonPlayer attacker, ActivePokemonEnemy target) {
        Pokemon wamps = attacker.GetActive();
        int damage = wamps.getBaseAttack();
        target.TakeDamage(damage - target.GetActive().getBaseDefence());
    }

}
