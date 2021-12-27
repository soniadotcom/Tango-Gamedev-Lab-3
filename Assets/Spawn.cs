using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //private GameObject inst_obj;
    public GameObject wolf;
    // Start is called before the first frame update
    void Start()
    {
        wolf=Instantiate(wolf, wolf.transform.position, Quaternion.identity) as GameObject;
        wolf.transform.localScale=new Vector3(0.15f,0.2f,1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
