using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{

    public GameObject asteroidPS;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Explode();
    }


    void Explode()
    {
        GameObject asteroid = Instantiate(asteroidPS, transform.position, Quaternion.identity);
        asteroid.GetComponent<ParticleSystem>().Play();
        Destroy(asteroid, 4);
    }
}
