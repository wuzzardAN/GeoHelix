using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollisionControl : MonoBehaviour
{


    void OnCollisionEnter (Collision collision) {

        if (collision.collider.tag == "Obstacle") {
            Debug.Log("Obstacle");
            Destroy(collision.gameObject);
            FindObjectOfType<GameManager>().EndGame();

        }
    }

}
