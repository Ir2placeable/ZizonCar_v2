using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private static GameManager m_Instance = null;

    public static GameManager Instance()
    {
        if (m_Instance == null)
        {
            m_Instance = GameObject.FindObjectOfType(typeof(GameManager)) as GameManager;
            if (m_Instance == null)
            {
                Debug.LogError("There needs to be one active GameManager script on a GameObject in your scene.");
            }
        }

        return m_Instance;
    }

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
