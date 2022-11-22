using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_func : MonoBehaviour
{
    public GameObject current_checkPoint;
    public GameObject next_checkPoint;
    checkpoint_manager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("check_M").GetComponent<checkpoint_manager>();
        
    }

    
    void OnTriggerEnter()
    {
        current_checkPoint.SetActive(false);
        next_checkPoint.SetActive(true);
        manager.hit_checkpoint();
    }
}
