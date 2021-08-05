using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoByTwo : MonoBehaviour
{
    // Update is called once per frame
    public AIgenerated2 AI;
    public string StartingDotAI = "";
    public string EndingDotAI = "";
    public bool HasDrawnLine = false;
    int Line_To_Delete = 0;
    int LineCounter = 0;
    public GameObject Player;
    public LineRenderer[] Line;
    public GameObject[] Dots;
    bool IsAIGameState = true;
    public bool[] isLineActive;
    public bool isOnelineActive = false;
    public bool HasPlaced = false;
    public float Axis = 2;
    public int pp = 0;
    int sec = 3;
    public int PlayerCount = 0;
    public GameObject EndCondition;
    public string[] EndingDots;
    public string[] StartingDots;
    public string CurrentStartingDot = "";
    public GameObject PrefabTrail;
    public Text WhatIsGoingOn;
    public string[] TheInstructions;
    public int Round = 1;
    public bool EndGame = false;
    public int LinesAtATime = 2;
    public GameObject pause;
    public GameObject[] DotSelected;
    public void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        isLineActive = new bool[4];
        // Dots = new GameObject[9];
        IsAIGameState = true;
        EndingDots = new string[300];
        StartingDots = new string[300];
        AI.pp();
        WhatIsGoingOn.text = "Round 1";
        TheInstructions = new string[300];
        for (int p = 0; p < AI.Instruction.Length; p++)
        {
            TheInstructions[p] = AI.Instruction[p];
        }
    }
    public void Restart()
    {
        IsAIGameState = true;
        TheInstructions = new string[300];
        isLineActive = new bool[4];
        EndingDots = new string[300];
        StartingDots = new string[300];
        HasDrawnLine = false;
        isOnelineActive = false;
        EndingDotAI = "";
        PlayerCount = 0;
        pp = 0;
        AI.pp();
        EndGame = false;
        for (int p = 0; p < AI.Instruction.Length; p++)
        {
            TheInstructions[p] = AI.Instruction[p];
        }
        for (int a = 0; a < Line.Length; a++)
        {
            Line[a].enabled = false;
        }
        GameObject.Find("EndCondition").SetActive(false);
        DotSelected[0].SetActive(false);
        DotSelected[1].SetActive(false);
        DotSelected[2].SetActive(false);
        DotSelected[3].SetActive(false);
        Round = 1;
    }
    public void activatePause()
    {
        pause.SetActive(false);
        Time.timeScale = 0;

    }
    public void deactivatePause()
    {
        pause.SetActive(true);
        Time.timeScale = 1;

    }
    IEnumerator WaitThing()
    {
        switch (StartingDotAI)
        {
            case "Dot01":
                switch (EndingDotAI)
                {
                    case "Dot02":
                        GameObject Clone = Instantiate(PrefabTrail, Line[0].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = Axis;
                        Clone.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot03":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[0].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        Clone2.GetComponent<ExampleClass>().YDistance = -Axis;
                        break;
                    case "Dot04":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[0].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = Axis;
                        Clone3.GetComponent<ExampleClass>().YDistance = -Axis;
                        break;
                }
                break;
            case "Dot02":
                switch (EndingDotAI)
                {
                    case "Dot01":
                        GameObject Clone = Instantiate(PrefabTrail, Line[1].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -Axis;
                        Clone.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot03":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = -Axis;
                        Clone2.GetComponent<ExampleClass>().YDistance = -Axis;
                        break;
                    case "Dot04":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = 0;
                        Clone3.GetComponent<ExampleClass>().YDistance = -Axis;
                        break;
                }
                break;
            case "Dot03":
                switch (EndingDotAI)
                {
                    case "Dot02":
                        GameObject Clone = Instantiate(PrefabTrail, Line[2].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = Axis;
                        Clone.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                    case "Dot01":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        Clone2.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                    case "Dot04":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = Axis;
                        Clone3.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                }
                break;
            case "Dot04":
                switch (EndingDotAI)
                {
                    case "Dot02":
                        GameObject Clone = Instantiate(PrefabTrail, Line[3].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = 0;
                        Clone.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                    case "Dot03":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = -Axis;
                        Clone2.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot01":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = -Axis;
                        Clone3.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                }
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(1f);
        // HasDrawnLine = false;
        // pp++;
        // EndingDotAI = "";
        StopCoroutine(WaitThing());
    }
    void Update()
    {
        if (EndGame == true)
        {
            return;
        }
        if (IsAIGameState == true)
        {
            if (!HasDrawnLine)
            {
                if (pp < AI.Instruction.Length * Round)
                {
                   // print(pp);
                    StartingDotAI = TheInstructions[pp].Substring(0, TheInstructions[pp].IndexOf("_"));
                    StartingDots[pp] = StartingDotAI;
                        //print(AI.Instruction[pp].Length);
                    for (int i = 6; i < TheInstructions[pp].Length; i++)
                    {
                        EndingDotAI += TheInstructions[pp][i];
                    }
                    EndingDots[pp] = EndingDotAI;
                //    print(EndingDotAI);
                    HasDrawnLine = true;
                    StartCoroutine(WaitThing());
                }
                else
                {
                    HasDrawnLine = true;
                    IsAIGameState = false;
                   // WhatIsGoingOn.text = "Draw Lines!";

                    /* for (int a = 0; a < Line.Length; a++)
                     {
                         Vector3[] EndingPos1 = new Vector3[2];
                         Line[a].SetPositions(EndingPos1);
                     }*/
                }
            }

        }
        else if (IsAIGameState == false)
        {
            if (!isOnelineActive)
            {
                if (StartingDots[PlayerCount] == "Dot01")
                {
                    DotSelected[0].SetActive(true);
                }
                else if (StartingDots[PlayerCount] == "Dot02")
                {
                    DotSelected[1].SetActive(true);
                }
                else if (StartingDots[PlayerCount] == "Dot03")
                {
                    DotSelected[2].SetActive(true);
                }
                else if (StartingDots[PlayerCount] == "Dot04")
                {
                    DotSelected[3].SetActive(true);
                }
                if (Input.GetMouseButton(0) || Input.touchCount > 0)
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                    if (hit.collider == null)
                    {
                        return;
                    }
                    switch (hit.collider.name)
                    {
                        case "Dot01":
                            if (StartingDots[PlayerCount] == "Dot01")
                            {
                                Vector3[] EndingPos1 = new Vector3[2];
                                Line[0].SetPositions(EndingPos1);
                                Line[0].enabled = true;
                                isLineActive[0] = true;
                                isOnelineActive = true;
                                CurrentStartingDot = "Dot01";
                                DotSelected[0].SetActive(true);
                            }
                            break;
                        case "Dot02":
                            if (StartingDots[PlayerCount] == "Dot02")
                            {
                                Vector3[] EndingPos12 = new Vector3[2];
                                Line[1].SetPositions(EndingPos12);
                                Line[1].enabled = true;
                                isLineActive[1] = true;
                                isOnelineActive = true;
                                CurrentStartingDot = "Dot02";
                                DotSelected[1].SetActive(true);
                            }
                            break;
                        case "Dot03":
                            if (StartingDots[PlayerCount] == "Dot03")
                            {
                                Vector3[] EndingPos123 = new Vector3[2];
                                Line[2].SetPositions(EndingPos123);
                                Line[2].enabled = true;
                                isLineActive[2] = true;
                                isOnelineActive = true;
                                CurrentStartingDot = "Dot03";
                                DotSelected[2].SetActive(true);
                            }
                            break;
                        case "Dot04":
                            if (StartingDots[PlayerCount] == "Dot04")
                            {
                                Vector3[] EndingPos124 = new Vector3[2];
                                Line[3].SetPositions(EndingPos124);
                                Line[3].enabled = true;
                                isLineActive[3] = true;
                                isOnelineActive = true;
                                CurrentStartingDot = "Dot04";
                                DotSelected[3].SetActive(true);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < isLineActive.Length; i++)
                {
                    if (isLineActive[i] == true)
                    {
                        if (!HasPlaced)
                        {
                            Vector3[] PP = new Vector3[2];
                            PP[0] = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - Dots[i].transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - Dots[i].transform.position.y, 0);
                            Line[i].SetPositions(PP);
                            Line[i].GetComponent<LineCollision>().TestCollision(Dots[i].name);
                            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                          //  DotSelected[i].SetActive(true);
                            if (hit.collider != null)
                            {
                                switch (i)
                                {
                                    case 0:
                                        if (hit.collider.name == "Dot02")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot02" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(Axis, 0, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot04")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot04" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(Axis, -Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot03")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot03" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(0, -Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 1:
                                        if (hit.collider.name == "Dot01")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot01" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(-Axis, 0, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot03")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot03" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(-Axis, -Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot04")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot04" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(0, -Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 2:
                                        if (hit.collider.name == "Dot02")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot02" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(Axis, Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot04")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot04" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(Axis, 0, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot01")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot01" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(0, Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 3:
                                        if (hit.collider.name == "Dot01")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot01" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(-Axis, Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot02")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot02" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(0, Axis, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot03")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot03" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                                Vector3[] EndingPos = new Vector3[2];
                                                EndingPos[1] = new Vector3(-Axis, 0, 0);
                                                Line[i].SetPositions(EndingPos);
                                            }
                                            else
                                            {
                                                DotSelected[i].SetActive(false);
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                }


                            }
                            if (PlayerCount >= LinesAtATime * Round)
                            {
                                AI.pp();
                                //WhatIsGoingOn.text = "Generting Lines";
                                IsAIGameState = true;
                                HasDrawnLine = false;
                                PlayerCount = 0;
                                //AI.pp();

                                for (int p = 0; p < AI.Instruction.Length; p++)
                                {
                                    TheInstructions[p + 2 * Round] = AI.Instruction[p];
                                }
                                Round++;
                                WhatIsGoingOn.text = "Round " + Round;

                                pp = 0;
                                for (int a = 0; a < Line.Length; a++)
                                {
                                    Line[a].enabled = false;
                                }

                            }
                            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
                            {
                                HasPlaced = true;
                            }
                        }
                        else
                        {
                            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                            if (LineCounter == 0)
                            {
                                Line_To_Delete = i;
                            }
                            LineCounter++;
                            if (LineCounter >= 1)
                            {
                                Line[Line_To_Delete].enabled = false;
                                isLineActive[Line_To_Delete] = false;
                                isOnelineActive = false;
                                HasPlaced = false;

                                LineCounter = 0;
                            }

                            switch (i)
                            {
                                case 0:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                        // Line[i].enabled = false;
                                        return;
                                    }

                                    switch (hit.collider.name)
                                    {
                                        case "Dot02":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(Axis, -Axis, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(0, -Axis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        default:
                                            //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 1:
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    HasPlaced = false;
                                    if (hit.collider == null)
                                    {
                                        //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(-Axis, -Axis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(0, -Axis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        default:
                                            //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 2:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                        //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot02":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(Axis, Axis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot01":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(0, Axis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        default:
                                            //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 3:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                        //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-Axis, Axis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(0, Axis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(-Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        default:
                                            // Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                default:
                                    //  Line[i].enabled = false;
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}