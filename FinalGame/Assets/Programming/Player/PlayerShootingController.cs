﻿//------------------------------------------------------------------------------
//
// File Name:	PlayerShootingController.cs
// Author(s):	Jeremy Kings (j.kings)
// Project:		Asteroids
// Course:		WANIC VGP
//
// Copyright © 2021 DigiPen (USA) Corporation.
//
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    public GameObject ProjectilePrefab = null;
    public GameObject ShootSpot;
    public float ShootDelay = 0.5f;
    public float ProjectileSpeed = 2.0f;
    public KeyCode ShootKey = KeyCode.Space;
    public int TotalProjectiles = 1;
    // If true, adds player move speed to projectile speed
    public bool AddPlayerMoveSpeed = true;

    private float shootTimer = 0.0f;
    private Transform mTransform = null;
    private Transform ShootPos = null;
    private Rigidbody2D mRigidbody = null;
    private StaticVars StaticVars;

    // Start is called before the first frame update
    void Start()
    {
        StaticVars = GetComponent<StaticVars>();
        if(StaticVars.TotalAttackSpeed <= 0)
        {
            StaticVars.TotalAttackSpeed = 0.01f;
        }
        ShootDelay = StaticVars.TotalAttackSpeed;
        shootTimer = ShootDelay;
        mTransform = GetComponent<Transform>();
        ShootPos = ShootSpot.GetComponent<Transform>();
        mRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(ShootKey) && shootTimer >= ShootDelay)
        {
            SpawnProjectile();
            shootTimer = 0.0f;
        }

        shootTimer += Time.deltaTime;

        ProjectileSpeed = StaticVars.TotalProjectileSpeed;
        TotalProjectiles = StaticVars.TotalProjectiles;


    }

    void SpawnProjectile()
    {
        var spawnPosition = ShootPos.position;
        // Nudge slightly ahead of ship
        var rotation = mTransform.eulerAngles.z * Mathf.Deg2Rad;
        var direction = new Vector3(Mathf.Cos(rotation), Mathf.Sin(rotation), 0.0f);
        spawnPosition += direction * (ShootPos.localScale.x / 2.0f
            + ProjectilePrefab.transform.localScale.x / 2.0f);
        for(int i = TotalProjectiles; i > 0; i--)
        {
            // Create object
            var projectile = GameObject.Instantiate(ProjectilePrefab, spawnPosition, mTransform.rotation);

            // Move object
            var body = projectile.GetComponent<Rigidbody2D>();
            body.velocity = direction * ProjectileSpeed;
            if (AddPlayerMoveSpeed)
                body.velocity += mRigidbody.velocity;
        }
    }
}
