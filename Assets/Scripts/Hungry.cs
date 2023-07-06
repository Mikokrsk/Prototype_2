using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hungry : MonoBehaviour
{
    public int hungry = 3;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Slider>(); 
        slider.maxValue = hungry;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hungry;
        if(hungry<=0)
        {
            Destroy(gameObject);
        }        
    }
}
