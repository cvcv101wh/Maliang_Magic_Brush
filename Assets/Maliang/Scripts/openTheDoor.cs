using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTheDoor : MonoBehaviour {
    private Vector3 target = new Vector3(7.98f,0, 38.49f);
    public float speed = 1.0f;
    public bool openTheDoorFlag = false;
    // Use this for initialization
    

    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (openTheDoorFlag)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);

        }
    }
}
