using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killing : MonoBehaviour
{
    private GameObject inst_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
