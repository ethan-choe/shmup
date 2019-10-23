﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Set in Inspector: Enemy")]
    public float    speed = 10f;
    public float    fireRate = 0.3f;
    public float    health = 10;
    public int      score = 100;
    
    protected BoundsCheck bndCheck;

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }
    public Vector3 pos
    {
        get {
            return( this.transform.position );
        }
        set {
            this.transform.position = value;
        }
    }

    void Update()
    {
        Move();
        //Check to make sure it's gone off the bottom of the screen
        if (bndCheck != null && bndCheck.offDown)
        {
            // We're off the bottom, so destroy this GameObject
            Destroy(gameObject);
        }
    }

    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

    void OnCollisionEnter( Collision coll)
    {
        GameObject otherGO = coll.gameObject;
        switch (otherGO.tag)
        {
            case "ProjectileHero":
                Projectile p = otherGO.GetComponent<Projectile>();
                // If this Enemy is off screen, don't damage it
                if( !bndCheck.isOnScreen)
                {
                    Destroy( otherGO );
                    break;
                }
                // Hurt this Enemy
                // Get the damage amount from the Main WEAP_DICT.
                // health -= Main.GetWeaponDefinition(p.type).damageOnHit;

                health -= 5;
                if(health <= 0)
                {
                    Destroy(this.gameObject);
                }
                Destroy( otherGO );
                break;

                default:
                    print( "Enemy hit by non-ProjectileHero: " + otherGO.name);
                    break;
        }
    }
}
