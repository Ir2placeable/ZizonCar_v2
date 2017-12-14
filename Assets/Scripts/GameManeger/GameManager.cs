using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum GamePhase
{
    None,
    BeforeStarting,
    Countdown,
    BattleStart,
    BattleEnd,
    GameEnd
};

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

    [SerializeField]
    private int _p1WinCount = 0;
    public int p1WinCount
    {
        get
        {
            return _p1WinCount;
        }
        set
        {
            _p1WinCount += value;
            currentPhase = GamePhase.BattleEnd;
            //if (p1WinCount == winCondition)
            // gameSet
        }
    }

    [SerializeField]
    private int _p2WinCount = 0;
    public int p2WinCount
    {
        get
        {
            return _p2WinCount;
        }
        set
        {
            _p2WinCount += value;
            currentPhase = GamePhase.BattleEnd;
            //if (p1WinCount == winCoundtion)
            // gameSet
        }
    }

    [SerializeField]
    GamePhase _currentPhase = GamePhase.None;
    GamePhase currentPhase
    {
        set
        {
            if (_currentPhase != value)
            {
                _currentPhase = value;
                GamePhaseChanged(value);
                
            }
        }

        get
        {
            return _currentPhase;
        }
    }

    public VehicleSpawn vehicleSpawn = null;
    public GameObject[] spawnedVehicles = null;

    // Use this for initialization
    void Start () {
        if (vehicleSpawn == null)
            vehicleSpawn = GameObject.FindObjectOfType<VehicleSpawn>();

        currentPhase = GamePhase.BeforeStarting;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void GamePhaseChanged(GamePhase nextPhase)
    {
        //if (nextPhase == GamePhase.BeforeStarting)
        //{

        //}
        //else if (nextPhase == GamePhase.Countdown)
        //{

        //}

        switch (nextPhase)
        {
            case GamePhase.BeforeStarting:
                vehicleSpawn.Spawn();
                
                currentPhase = GamePhase.Countdown;
                break;

            case GamePhase.Countdown:
                currentPhase = GamePhase.BattleStart;
                break;

            case GamePhase.BattleStart:
                break;

            case GamePhase.BattleEnd:
                Debug.Log("BattleEnd");

                if ((p1WinCount >= winCondition) || (p2WinCount >= winCondition))
                {
                    currentPhase = GamePhase.GameEnd;
                    Debug.Log("GameEnd");
                }
                else
                {
                    Debug.Log("Reset");
                    vehicleSpawn.DeleteAll();
                    vehicleSpawn.Spawn();

                    currentPhase = GamePhase.Countdown;
                }
            
                break;

            case GamePhase.GameEnd:
                Debug.Log("Battle Ended");
                break;

        }
    }
}
