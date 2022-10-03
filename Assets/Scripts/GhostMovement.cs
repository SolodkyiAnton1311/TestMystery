using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GhostMovement : MonoBehaviour
{
    private float speed;
  
    private void Awake()
    {
        speed = Random.Range(0.1f, 0.3f);
    }

    private void OnEnable()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ClickOnGhost);
    }


    private void FixedUpdate()
    {
        if (transform.position.y < Screen.height/200)
        {
            
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
           return;
        }
        Destroy(gameObject);
    }


    private void ClickOnGhost()
    {
        Destroy(gameObject);
        UnitSpawn.Instance.AddScore();
    }

    
}
