using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{
    Player player;

    void Start(){
        player = GameObject.FindObjectOfType<Player>();
    }
    void OnTriggerEnter2D(Collider2D other) {
        while (other.CompareTag("ground")){
            player.onFloor();
        }
    }
}
