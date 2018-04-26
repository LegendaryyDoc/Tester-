﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour {

    public float MaxHealth = 100;

    public float CurrentHealth;

    public float damage;


	// Use this for initialization
	void Start () {
        CurrentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            Debug.Log("Dead");
        }
	}

    public void TakeDamage(float DamageAmount)
    {
        CurrentHealth -= DamageAmount;
    }
}