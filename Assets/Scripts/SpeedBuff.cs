using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]

public class SpeedBuff : PowerupEffect
{
    //Victor was the one who made the actual effects of the powerup
    //Victor spent some time figuring out how to program it and Zach suggested turning Duck yellow to show it
    //Victor discovered a way to freely make power ups from unity using this code
    public float amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerController>().speed += amount;
        target.GetComponent<SpriteRenderer>().color = Color.yellow;
    }

}