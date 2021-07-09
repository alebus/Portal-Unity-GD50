using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGoal : MonoBehaviour
{
    public Text endText;
    public RawImage finalImage;
    private void OnTriggerEnter(Collider other) {


        Debug.Log("entered the trigger");
        
        endText.color = new Color(255, 255, 255, 255);
        finalImage.color = new Color(255, 255, 255, 255);

    }
}