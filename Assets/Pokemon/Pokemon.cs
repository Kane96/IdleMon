using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public Sprite spriteFront;
    public Sprite spriteBack;

    public int baseHitPoints;
    public int baseAttack;
    public int baseDefence;
    public int baseSpeed;

    public Sprite GetSpriteFront() {
        return spriteFront;
    }

    public Sprite GetSpriteBack() {
        return spriteBack;
    }

    public int GetBaseHitPoints() {
        return baseHitPoints;
    }

    public int GetBaseAttack() {
        return baseAttack;
    }

    public int GetBaseDefence() {
        return baseDefence;
    }

    public int GetBaseSpeed() {
        return baseSpeed;
    }
}
