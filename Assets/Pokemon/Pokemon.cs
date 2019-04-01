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

    public int getHitPoints() {
        return baseHitPoints;
    }

    public int getHitAttack() {
        return baseAttack;
    }

    public int getHitDefence() {
        return baseDefence;
    }

    public int getHitSpeed() {
        return baseSpeed;
    }
}
