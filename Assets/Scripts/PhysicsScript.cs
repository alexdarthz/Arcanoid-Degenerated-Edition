using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    private Rigidbody2D rigbody;
    int hrts;
    GameObject heartcn;
    private void Start() 
    {
        heartcn = GameObject.Find("Lives");
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        rigbody = GetComponent<Rigidbody2D>();
        if(collision.gameObject.name == "Board")
        {
            rigbody.AddForceAtPosition(Vector2.up * 900f, Vector2.right * 800f);
        }
        if(collision.gameObject.name == "brick")
        {
            Destroy(collision.gameObject);
        }
        if(collision.transform.name == "border-down")
        {
            hrts = heartcn.transform.childCount;
            for(int i = hrts-1; i > -1; i--)
            {
                Destroy(heartcn.transform.GetChild(i).gameObject);
            }
        }
    }
}
