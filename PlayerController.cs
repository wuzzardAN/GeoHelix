using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    void Update() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void SpeedZero() {
        speed = 0f;
    }
    public void SpeedOne() {
        speed = -7f;
    }

}
