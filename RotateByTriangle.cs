using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RotateByTriangle : MonoBehaviour
{
    public Button RotateByLeftButton;
    public Button RotateByRightButton;

    void Start()
    {
            RotateByLeftButton.onClick.AddListener(() => {
                StartCoroutine( Rotate(Vector3.up, 120, 0.25f));
            });

            RotateByRightButton.onClick.AddListener(() => {
                StartCoroutine( Rotate(Vector3.down, 120, 0.25f));
            }); 

    }

    IEnumerator Rotate( Vector3 axis, float angle, float duration = 1.0f)
   {
     Quaternion from = transform.rotation;
     Quaternion to = transform.rotation;
     to *= Quaternion.Euler( axis * angle );
    
     float elapsed = 0.0f;
     while( elapsed < duration )
     {
       transform.rotation = Quaternion.Slerp(from, to, elapsed / duration );
       elapsed += Time.deltaTime;
       yield return null;
     }
     transform.rotation = to;
   }
}
