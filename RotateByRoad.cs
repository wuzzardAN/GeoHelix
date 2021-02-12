using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotateByRoad : MonoBehaviour
{
    public Button RotateByLeftButton;
    public Button RotateByRightButton;

    void Start()
    {
            RotateByLeftButton = GameObject.FindGameObjectWithTag("LeftButton").GetComponent<Button>();
            RotateByLeftButton.onClick.AddListener(() => {
                iTween.RotateBy(this.gameObject, iTween.Hash(
                    "z", 0.25f,
                    "speed", 300f,
                    "easetype", iTween.EaseType.easeInOutSine
                ));
            });
            
            RotateByRightButton = GameObject.FindGameObjectWithTag("RightButton").GetComponent<Button>();
            RotateByRightButton.onClick.AddListener(() => {
                iTween.RotateBy(this.gameObject, iTween.Hash(
                    "z", -0.25f,
                    "speed", 300f,
                    "easetype", iTween.EaseType.easeInOutSine
                ));
            }); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
