using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    public TMP_Text enemyDisplay;
    public GameObject[] asteroids;

    void Update()
    {
        asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
        enemyDisplay.text = string.Format("Enemies: {000}", asteroids.Length);
    }
}
