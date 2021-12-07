using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemy : MonoBehaviour
{

    [SerializeField]
    public float speed = 100f;

    [SerializeField]
    public float lifeTime = 3f;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bullet")
            ScoreScript.ScoreValue += 10;
        

        Destroy(gameObject);



    }

    public void awake()
        {
            Invoke("DestroySelf", lifeTime);
        }
    public void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);
    }










}


