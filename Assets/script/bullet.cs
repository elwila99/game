using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{


    [SerializeField]
    public float speed = 100f;

    [SerializeField]
    public float lifeTime = 3f;

    internal void DestroySelf()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
  
    

        public void Awake()
    {
        Invoke("DestroySelf", lifeTime);
    }

    public void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
      

    }
    
    
    public void OnCollisionEnter2D(Collision2D collision)
    {

        

        if (collision.transform.tag == "ennemy")

           


        DestroySelf();
    }
   
}



