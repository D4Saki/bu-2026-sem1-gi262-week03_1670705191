using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity
{
    public int healpotion = 20;
    public override void Hit()
    {
        mapGenerator.player.Heal(healpotion);
        Debug.Log("You got "+ Name + " : "+ healpotion);
        mapGenerator.mapdata[positionX, positionY] = mapGenerator.empty;
        Destroy(gameObject);
    }
}