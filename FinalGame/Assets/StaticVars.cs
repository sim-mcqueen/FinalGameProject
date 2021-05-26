using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVars : MonoBehaviour
{
    public static int TotalGold = 0;
    public static float TimePassed = 0f;
    public static float TurnSpeed = 100f;
    public static int TotalWaves = 0;
    public static float TotalAccelerationAmount = 5f;
    public static float TotalDecelerationAmount = 10f;

    // Connect these to player controller
    public static float TotalMoveSpeed;
    public static float TotalAttackSpeed;
    public static float TotalProjectileSpeed;
    public static int TotalProjectiles;
    public static float MoneyMultiplier;
}
