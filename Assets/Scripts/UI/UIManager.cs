using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public void LeftClick()
    {
        GetComponent("DrivingModule").FixedUpdate();
    }

    public void RightClick()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Pressed RightArrow");
        }
    }

    public void SkillClick()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed Skill");
        }
    }
}