using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupEffect : ScriptableObject
{
    public abstract void Apply(GameObject target);
    //Victor and Zach made this after a bit of thinking to activate the other functions
}
