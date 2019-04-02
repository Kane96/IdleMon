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

    public Sprite getSpriteFront() {
        return spriteFront;
    }

    public Sprite getSpriteBack() {
        return spriteBack;
    }

    public int getBaseHitPoints() {
        return baseHitPoints;
    }

    public int getBaseAttack() {
        return baseAttack;
    }

    public int getBaseDefence() {
        return baseDefence;
    }

    public int getBaseSpeed() {
        return baseSpeed;
    }
}
