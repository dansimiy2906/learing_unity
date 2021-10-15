using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunrigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    public float movespeed = 1.0f;
    public float turnSpeed = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKey("a")){
    		this.transform.position = this.transform.position + Vector3.forward * movespeed;
    	}
    	if(Input.GetKey("s")){
    		Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
    		Destroy(myPrefab,3);

    	}
        
    }
}
