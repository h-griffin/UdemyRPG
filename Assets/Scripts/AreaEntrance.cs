﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;

    // Start is called before the first frame update
    void Start()
    {
        if(transitionName == PlayerController.instance.areaTransitionName)
        {
            //player position   =    position of script is attached to /enterance
            PlayerController.instance.transform.position = transform.position; 
        }

        UIFade.instance.FadeFromBlack();
        //GameManager.instance.fadeingBetweenAreas = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
