using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVars : MonoBehaviour
{
    public static int TotalGold = 50;
    public static float TimePassed = 0f;
    public static float TurnSpeed = 100f;
    public static int TotalWaves = 0;
    public static float TotalAccelerationAmount = 5f;
    public static float TotalDecelerationAmount = 10f;

    // Connect these to player controller
    public static float TotalMoveSpeed = 5f;
    public static float TotalAttackSpeed = 0.3f;
    public static float TotalProjectileSpeed = 2f;
    //public static int TotalProjectiles = 1;
    public static int MoneyMultiplier = 1;
}
