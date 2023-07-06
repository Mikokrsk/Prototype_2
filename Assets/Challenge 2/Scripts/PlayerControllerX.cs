using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool spam = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spam)
        {
            spam = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("Spam",1f);
        }
    }
    private void Spam()
    {
        spam = true;   
    }   
}
