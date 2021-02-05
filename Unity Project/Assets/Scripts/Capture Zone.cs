using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureZone : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float CaptureAmmount;
    GameObject CaptureBar;
    void Start()
    {
        CaptureBar.SetActive(false);
        rb = GetComponent<Rigidbody2D>();

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        while (col.gameObject.name.Equals("Player"))
            CaptureBar.SetActive(true);
            
    }
}
