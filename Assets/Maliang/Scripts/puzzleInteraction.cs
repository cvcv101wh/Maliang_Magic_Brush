using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleInteraction : MonoBehaviour {
    public Material originalMaterial;
    public Material activatedMaterial;
    public GameObject righthand;
  

    private ControllerGrabObject rightHnadGrab;
    private PuzzleManager parentPuzzleManager;
    private bool isActivated = false;

    public void changeToOriginal()
    {
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }

    public void changeToActivated()
    {
        gameObject.GetComponent<MeshRenderer>().material = activatedMaterial;
    }



    public bool GetIsActivate
    {
        get { return isActivated; }
    }


    void Awake()
    {
        //parentPuzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
        parentPuzzleManager = transform.parent.gameObject.GetComponent<PuzzleManager>();
        //rightHnadGrab = GameObject.FindGameObjectWithTag("RighthandController").GetComponent<ControllerGrabObject>();
        rightHnadGrab = righthand.GetComponent<ControllerGrabObject>();
    }

        // Use this for initialization
        void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
        
        
	}

    public void OnTriggerStay(Collider other)
    {
        

        if (rightHnadGrab.isDown)
        {
            if (other.tag == "Brush")
            {
                if (!parentPuzzleManager.startCountingDown)
                {
                    parentPuzzleManager.startCountingDown = true;
                }
                else
                {
                    Debug.Log(parentPuzzleManager.checkPuzzle());
                }
                changeToActivated();
                parentPuzzleManager.isActivatedList[parentPuzzleManager.nodeSequence.IndexOf(gameObject.transform)] = true;

            }
        }
    }
}
