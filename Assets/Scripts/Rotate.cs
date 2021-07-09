using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{


    [SerializeField, Range(0, 30)]
    float speedY =0, speedX = 0, speedZ = 0;

    void Update() 
    {
       transform.Rotate(speedX, speedY, speedZ, Space.World );
    }
}
