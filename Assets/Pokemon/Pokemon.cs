using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    public Sprite spriteFront;
    public Sprite spriteBack;

    public Sprite getSpriteFront() {
        return spriteFront;
    }

    public Sprite getSpriteBack() {
        return spriteBack;
    }
}
