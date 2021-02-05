using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

  
    void Update()
    {
        localScale.x = PlayerControl.healthAmmount;
        transform.localScale = localScale;
    }

}
