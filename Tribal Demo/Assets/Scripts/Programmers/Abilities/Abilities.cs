﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilityState { Normal, HighJump, AcidSpit, OwlSight, MouseShrink};

public class Abilities : IAbilities
{
    public static AbilityState Ability = AbilityState.Normal;
    public Vector3 Direction { get; set; }
    public Rigidbody rigidbody { get; set;}
}
