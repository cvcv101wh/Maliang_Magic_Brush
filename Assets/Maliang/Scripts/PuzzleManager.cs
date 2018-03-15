using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public float Timer = 5.00f;
    public bool startCountingDown = false;
    public float PercentThreshold = 0.8f;
    public List<Transform> nodeSequence;
    public bool[] isActivatedList;
    public GameObject instantiatedObject;
    public GameObject visualEffect;

    public float calPercent()
    {
        float activatedPercentage = 0;
        int actiCount = 0;
        for (int i = 0; i < isActivatedList.Length; i++)
        {
            if (isActivatedList[i])
                actiCount++;
        }

        activatedPercentage = actiCount / (float)isActivatedList.Length;

        return activatedPercentage;
    }

    public bool checkPuzzle()
    {
        if (calPercent() >= PercentThreshold)
        {
            visualEffect.SetActive(true);
            instantiatedObject.SetActive(true);
            return true;
        }
        return false;
    }

    public bool timeOut()
    {
        Timer = 5.00f;
        startCountingDown = false;
        for (int i = 0; i < isActivatedList.Length; i++)
        {
            isActivatedList[i] = false;
            nodeSequence[i].gameObject.GetComponent<puzzleInteraction>().changeToOriginal();
            
           
        }

            return true;
    }

    // Use this for initialization

    void Awake()
    {
        nodeSequence = new List<Transform>();
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            nodeSequence.Add(gameObject.transform.GetChild(i));
        }
        isActivatedList = new bool[nodeSequence.Count];
    }


        void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        if (startCountingDown)
        {
            Timer -= Time.deltaTime;

            if (Timer <= 0)
            {
                timeOut();
            }


        
        }
    }
}
