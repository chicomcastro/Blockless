﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime = 10.0f;

    private void Start() {
        Destroy(this.gameObject, lifeTime);
    }

    void FixedUpdate()
    {
        transform.position += speed * -transform.right * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            print("Have hitted player");
            Destroy(this.gameObject);
            LifeManager.instance.Die();
        }
    }
}
