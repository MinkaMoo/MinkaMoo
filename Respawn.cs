using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour {
    // Objects

    public static Rigidbody2D plr;

    // GetBody()

    void Awake() {
        plr = GetComponent<Rigidbody2D>();
    }

    // Respawn

    public static void respawnPlayer() {
        plr.transform.position = new Vector2(-11, -2);
        print("Player Respawned");
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            respawnPlayer();
        }
    }
}