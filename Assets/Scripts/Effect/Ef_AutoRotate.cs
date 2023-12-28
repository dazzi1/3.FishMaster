using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_AutoRotate : MonoBehaviour
{

    public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
	}
}
