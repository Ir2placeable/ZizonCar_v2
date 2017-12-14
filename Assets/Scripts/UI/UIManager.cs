using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    bool lTurnLeft = false;
    bool lTurnRight = false;

    bool rTurnLeft = false;
    bool rTurnRight = false;

    bool lSkill = false;
    bool rSkill = false;

    public DrivingModule firstVehicle = null;
    public DrivingModule secondVehicle = null;  // 초기값 설정

    private void Start()
    {

    }
    private void Update()
    {
        if (firstVehicle == null)
            firstVehicle = GameManager.Instance().spawnedVehicles[0].GetComponent<DrivingModule>(); // firstVehicle에 스폰된 첫번째 차량을 넣는다.

        if (secondVehicle == null)
            secondVehicle = GameManager.Instance().spawnedVehicles[1].GetComponent<DrivingModule>();    // secondVehicle에 스폰된 두번째 차량을 넣는다.

        firstVehicle.TurnLeft(lTurnLeft);   // firstVehicle의 TurnLeft함수에 lTurnLeft값을 넣는다. lTurnLeft 값에 따라 TurnLeft가 동작할지 말지를 결정한다.
        firstVehicle.TurnRight(lTurnRight); // firstVehicle의 TurnRight함수에 lTurnRight값을 넣는다.

        secondVehicle.TurnLeft(rTurnLeft);
        //secondVehicle.turnLeft = rTurnLeft;
        secondVehicle.TurnRight(rTurnRight);

        firstVehicle.UseSkill(lSkill);
        secondVehicle.UseSkill(rSkill);
    }

    public void LleftPressed()
    {
        lTurnLeft = true;   //LleftPressed() : 1P(왼쪽)의 왼쪽으로 가는 버튼이 눌렸을 때 lTurnLeft값이 true이다. 차량이 왼쪽으로 회전한다.
    }

    public void LleftReleased()
    {
        lTurnLeft = false;
    }

    public void LrightPressed()
    {
        lTurnRight = true;
    }

    public void LrightReleased()
    {
        lTurnRight = false;
    }

    public void RleftPressed()
    {
        rTurnLeft = true;
    }

    public void RleftReleased()
    {
        rTurnLeft = false;
    }

    public void RrightPressed()
    {
       rTurnRight = true;
    }

    public void RrightReleased()
    {
        rTurnRight = false;
    }

    public void LskillPressed()
    {
        lSkill = true;
    }

    public void LskillReleased()
    {
        lSkill = false;
    }

    public void RskillPressed()
    {
        rSkill = true;
    }

    public void RskillReleased()
    {
        rSkill = false;
    }
}
