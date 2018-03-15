using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDoor : MonoBehaviour {
    public Vector3 target;
    public float speed;
    public GameObject door1;
    public GameObject door2;
    public GameObject board;
    public GameObject gear1;
    public GameObject hint;

    public float boardTimer;
    private bool hasNotOpenTheBoard = true;
    // Use this for initialization
    public float slamTimer;
    private bool hasNotSlamTheBoard = true;


    void Start () {
       
        target = new Vector3(2.584f, 0.232f, 0.489f);
        door1.GetComponent<Animator>().SetTrigger("Cross");
        door2.GetComponent<Animator>().SetTrigger("Cross");



        gear1.GetComponent<Animator>().SetBool("Looping",true);
        hint.SetActive(false);
        GameObject.Find("theBadGuy").GetComponent<villain>().theDoorIsClosed = true;
        
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        boardTimer -= Time.deltaTime;
        slamTimer -= Time.deltaTime;

        if (slamTimer <= 0 & hasNotSlamTheBoard)
        {
            
            gameObject.GetComponent<AudioSource>().Play();
            hasNotSlamTheBoard = false;
        }

        if (boardTimer<=0 & hasNotOpenTheBoard)
        {
            board.GetComponent<Animator>().SetTrigger("Slide");
            board.GetComponent<AudioSource>().Play();
            hasNotOpenTheBoard = false;
        }
    }
}
