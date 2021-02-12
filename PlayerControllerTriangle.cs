using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTriangle : MonoBehaviour
{
    public float speed;

    void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    public void SpeedZero() {
        speed = 0f;
    }
    public void SpeedOne() {
        speed = 7f;
    }

}
