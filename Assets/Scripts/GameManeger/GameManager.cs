using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public int winCondition = 0;
    public int p1WinCount
    {
        get
        {
            return p1WinCount;
        }
        set
        {
            p1WinCount += value;
            //if (p1WinCount == winCondition)
                // gameSet
        }
    }
    public int p2WinCount
    {
        get
        {
            return p2WinCount;
        }
        set
        {
            p2WinCount += value;
            //if (p1WinCount == winCoundtion)
                   // gameSet
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
