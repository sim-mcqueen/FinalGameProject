using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnim : MonoBehaviour
{
    public GameObject projectile;
    public GameObject shootPoint;

    private Animator shootAnimator;

    // Start is called before the first frame update
    void Start()
    {
        shootAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    public void PlayShoot()
    {
        shootAnimator.Play("Shoot", -1, 0);
        GameObject proj = Instantiate(projectile, shootPoint.transform.position, Quaternion.identity) as GameObject;
        var body = proj.GetComponent<Rigidbody2D>();
        body.velocity = new Vector3(1, 0, 0) * 10f;

        Destroy(proj, 4f);
    }


}
