using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class parallax : MonoBehaviour
{
    [SerializeField] private float movespeed = 1f;
    [SerializeField] private float offset;

    private Vector2 startposition;
    private float newxposition;


    void Start()
    {
        startposition = transform.position;
    }

    void Update()
    {
        newxposition = Mathf.Repeat(Time.time * -movespeed, offset);

        transform.position = startposition + Vector2.right * newxposition;

        }
       


         
    }

