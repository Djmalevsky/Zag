using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchScreenMode : MonoBehaviour
{
    // Update is called once per frame
    public AIgenerated AI;
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
    bool HasPlaced = false;
    public float CloseXAxis = 2;
    public float FarXAxis = 4;
    public float CloseYAxis = 3;
    public float FarYAxis = 6;
    public int pp = 0;
    int sec = 3;
    int PlayerCount = 0;
    public GameObject EndCondition;
    public string[] EndingDots;
    public GameObject PrefabTrail;
    public Text WhatIsGoingOn;
    public string[] TheInstructions;
    public int Round = 1;
    public bool EndGame = false;
    public int LinesAtATime = 2;
    public GameObject pause;
    public string[] StartingDots;
    public string CurrentStartingDot = "";
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
    public void Awake()
    {
        StartingDots = new string[300];
        isLineActive = new bool[9];
        // Dots = new GameObject[9];
        IsAIGameState = true;
        EndingDots = new string[300];
        AI.pp();
        WhatIsGoingOn.text = "Round 1";
        TheInstructions = new string[300];
        for(int p = 0; p < AI.Instruction.Length; p++)
        {
            TheInstructions[p] = AI.Instruction[p];
        }
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
                        Clone.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot04":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[0].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        Clone2.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[0].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot06":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[0].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = FarXAxis;
                        Clone4.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[0].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = -FarYAxis;
                        break;

                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot02":
                switch (EndingDotAI)
                {
                    case "Dot01":
                        GameObject Clone = Instantiate(PrefabTrail, Line[1].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot03":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone2.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot04":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = 0;
                        Clone4.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot06":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot07":
                        GameObject Clone6 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone6.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone6.GetComponent<ExampleClass>().YDistance = -FarYAxis;
                        break;
                    case "Dot09":
                        GameObject Clone7 = Instantiate(PrefabTrail, Line[1].transform);
                        Clone7.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone7.GetComponent<ExampleClass>().YDistance = -FarYAxis;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot03":
                switch (EndingDotAI)
                {
                    case "Dot02":
                        GameObject Clone = Instantiate(PrefabTrail, Line[2].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot04":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = -FarXAxis;
                        Clone2.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot06":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = 0;
                        Clone4.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = -FarYAxis;
                        break;
                    default:
                        break;
                }
                break;
            case "Dot04":
                switch (EndingDotAI)
                {
                    case "Dot01":
                        GameObject Clone = Instantiate(PrefabTrail, Line[3].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = 0;
                        Clone.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot02":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone2.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot03":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = FarXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone4.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot07":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = 0;
                        Clone5.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone6 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone6.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone6.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot09":
                        GameObject Clone7 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone7.GetComponent<ExampleClass>().XDistance = FarXAxis;
                        Clone7.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    default:
                        // Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot05":
                switch (EndingDotAI)
                {
                    case "Dot01":
                        GameObject Clone = Instantiate(PrefabTrail, Line[4].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot02":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        Clone2.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot03":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot04":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone4.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot06":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot07":
                        GameObject Clone6 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone6.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone6.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone7 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone7.GetComponent<ExampleClass>().XDistance = 0;
                        Clone7.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot09":
                        GameObject Clone8 = Instantiate(PrefabTrail, Line[4].transform);
                        Clone8.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone8.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot06":
                switch (EndingDotAI)
                {
                    case "Dot01":
                        GameObject Clone = Instantiate(PrefabTrail, Line[5].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -FarXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot02":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[5].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone2.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot03":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[5].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = 0;
                        Clone3.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[5].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone4.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot07":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[5].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = -FarXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone6 = Instantiate(PrefabTrail, Line[5].transform);
                        Clone6.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone6.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    case "Dot09":
                        GameObject Clone7 = Instantiate(PrefabTrail, Line[5].transform);
                        Clone7.GetComponent<ExampleClass>().XDistance = 0;
                        Clone7.GetComponent<ExampleClass>().YDistance = -CloseYAxis;
                        break;
                    default:
                        //   Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot07":
                switch (EndingDotAI)
                {
                    case "Dot02":
                        GameObject Clone = Instantiate(PrefabTrail, Line[6].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = FarYAxis;
                        break;
                    case "Dot04":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[6].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        Clone2.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[6].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot06":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[6].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = FarXAxis;
                        Clone4.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[6].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    default:
                        break;
                }
                break;
            case "Dot08":
                switch (EndingDotAI)
                {
                    case "Dot01":
                        GameObject Clone = Instantiate(PrefabTrail, Line[7].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = FarYAxis; break;
                    case "Dot03":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[7].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone2.GetComponent<ExampleClass>().YDistance = FarYAxis;
                        break;
                    case "Dot04":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[7].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[7].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = 0;
                        Clone4.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot06":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[7].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot07":
                        GameObject Clone6 = Instantiate(PrefabTrail, Line[7].transform);
                        Clone6.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone6.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Dot09":
                        GameObject Clone7 = Instantiate(PrefabTrail, Line[7].transform);
                        Clone7.GetComponent<ExampleClass>().XDistance = CloseXAxis;
                        Clone7.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    default:
                        break;
                }
                break;
            case "Dot09":
                switch (EndingDotAI)
                {
                    case "Dot02":
                        GameObject Clone = Instantiate(PrefabTrail, Line[8].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone.GetComponent<ExampleClass>().YDistance = FarYAxis;
                        break;
                    case "Dot04":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[8].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = -FarXAxis;
                        Clone2.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot05":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[8].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone3.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot06":
                        GameObject Clone4 = Instantiate(PrefabTrail, Line[8].transform);
                        Clone4.GetComponent<ExampleClass>().XDistance = 0;
                        Clone4.GetComponent<ExampleClass>().YDistance = CloseYAxis;
                        break;
                    case "Dot08":
                        GameObject Clone5 = Instantiate(PrefabTrail, Line[8].transform);
                        Clone5.GetComponent<ExampleClass>().XDistance = -CloseXAxis;
                        Clone5.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(3);
       // HasDrawnLine = false;
       // pp++;
       // EndingDotAI = "";
        StopCoroutine(WaitThing());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 1;
        }
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
                    print(pp);
                    StartingDotAI = TheInstructions[pp].Substring(0, TheInstructions[pp].IndexOf("_"));
                    //print(AI.Instruction[pp].Length);
                    for (int i = 6; i < TheInstructions[pp].Length; i++)
                    {
                        EndingDotAI += TheInstructions[pp][i];
                    }
                    EndingDots[pp] = EndingDotAI;
                    print(EndingDotAI);
                    HasDrawnLine = true;
                    StartCoroutine(WaitThing());
                }
                else
                {
                    HasDrawnLine = true;
                    IsAIGameState = false;
                    WhatIsGoingOn.text = "Begin!";

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
                            //     print("PP");

                            Vector3[] EndingPos1 = new Vector3[2];
                            Line[0].SetPositions(EndingPos1);
                            Line[0].enabled = true;
                            isLineActive[0] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot01";
                            //   currentDot = 0; 
                            //   print("DOT1");

                            break;
                        case "Dot02":
                            Vector3[] EndingPos12 = new Vector3[2];
                            Line[1].SetPositions(EndingPos12);
                            Line[1].enabled = true;
                            isLineActive[1] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot02";

                            //   currentDot = 1;

                            //   print("DOT2");

                            break;
                        case "Dot03":
                            Vector3[] EndingPos123 = new Vector3[2];
                            Line[2].SetPositions(EndingPos123);
                            Line[2].enabled = true;
                            isLineActive[2] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot03";

                            //  currentDot = 2;

                            //  print("DOT3");

                            break;
                        case "Dot04":
                            Vector3[] EndingPos124 = new Vector3[2];
                            Line[3].SetPositions(EndingPos124);
                            Line[3].enabled = true;
                            isLineActive[3] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot04";

                            //  print("DOT4");
                            //  currentDot = 3;


                            break;
                        case "Dot05":

                            Vector3[] EndingPos15 = new Vector3[2];
                            Line[4].SetPositions(EndingPos15);
                            Line[4].enabled = true;
                            isLineActive[4] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot05";

                            // currentDot = 4;

                            //  print("DOT5");

                            break;
                        case "Dot06":
                            Vector3[] EndingPos14 = new Vector3[2];
                            Line[5].SetPositions(EndingPos14);
                            Line[5].enabled = true;
                            isLineActive[5] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot06";

                            //  currentDot = 5;

                            //      print("DOT6");

                            break;
                        case "Dot07":
                            Vector3[] EndingPos122 = new Vector3[2];
                            Line[6].SetPositions(EndingPos122);
                            Line[6].enabled = true;
                            isLineActive[6] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot07";

                            //    print("DOT7");
                            //  currentDot = 6;

                            break;
                        case "Dot08":
                            Vector3[] EndingPos121 = new Vector3[2];
                            Line[7].SetPositions(EndingPos121);
                            Line[7].enabled = true;
                            isLineActive[7] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot08";

                            //   print("DOT8");
                            // currentDot = 7;

                            break;
                        case "Dot09":
                            Vector3[] EndingPos152 = new Vector3[2];
                            Line[8].SetPositions(EndingPos152);
                            Line[8].enabled = true;
                            isLineActive[8] = true;
                            isOnelineActive = true;
                            CurrentStartingDot = "Dot09";

                            //   print("DOT9");
                            //  currentDot = 8;

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
                            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot08" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot07" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot09")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot09" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot08" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot07" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot08" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot09")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot09" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 4:
                                        if (hit.collider.name == "Dot01")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot01" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot07" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot02" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot09")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot09" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 5:
                                        if (hit.collider.name == "Dot01")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot01" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot07" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot08" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot09")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot09" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 6:
                                        if (hit.collider.name == "Dot02")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot02" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot08" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 7:
                                        if (hit.collider.name == "Dot01")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot01" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot07" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot09")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot09" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 8:
                                        if (hit.collider.name == "Dot02")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot02" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
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
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot05" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot06" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08")
                                        {
                                            if (EndingDots[PlayerCount] != "Dot08" || StartingDots[PlayerCount] != CurrentStartingDot)
                                            {
                                                EndCondition.SetActive(true);
                                                EndGame = true;
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                }
                                if(PlayerCount >= LinesAtATime * Round)
                                {
                                  //  AI.pp();
                                    
                                    IsAIGameState = true;
                                    HasDrawnLine = false;
                                    PlayerCount = 0;
                                    AI.pp();

                                    for (int p = 0; p < AI.Instruction.Length; p++)
                                    {
                                        TheInstructions[p + 2 * Round] = AI.Instruction[p];
                                    }
                                    Round++;
                                    WhatIsGoingOn.text = "Round " + Round;
                                    pp = 0;
                                    for(int a = 0; a < Line.Length; a++)
                                    {
                                        Line[a].enabled = false;
                                    }

                                }

                            }
                            if (Input.GetMouseButtonDown(0))
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
                                            EndingPos[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
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
                                            EndingPos[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
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
                                            EndingPos7[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(-CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
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
                                            EndingPos7[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        default:
                                            // Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 4:
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
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos9 = new Vector3[2];
                                            EndingPos9[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos9);
                                            break;
                                        default:
                                            //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 5:
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
                                            EndingPos7[1] = new Vector3(-FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(-FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos9 = new Vector3[2];
                                            EndingPos9[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos9);
                                            break;
                                        default:
                                            //   Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 6:
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
                                            EndingPos7[1] = new Vector3(CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        default:
                                            //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 7:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                        //   Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos9 = new Vector3[2];
                                            EndingPos9[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos9);
                                            break;
                                        default:
                                            //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 8:
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
                                            EndingPos7[1] = new Vector3(-CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        default:
                                            //    Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                default:
                                    //  Line[i].enabled = false;
                                    break;
                            }
                            Handheld.Vibrate();
                            GameObject.Find("PP").SetActive(true);
                        }
                    }
                }
            }
        }
    }
}