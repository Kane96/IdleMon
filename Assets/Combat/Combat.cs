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
        Pokemon wamps = attacker.GetActive();
        int damage = wamps.getBaseAttack();
        target.TakeDamage(damage - target.GetActive().getBaseDefence());
    }

}
