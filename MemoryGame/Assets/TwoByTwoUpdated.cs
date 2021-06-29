using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoByTwoUpdated : MonoBehaviour
{
    // Update is called once per frame
    public AIgeneratedColor AI;
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
    float Axis = 2;
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
    public Vector3 BottomRight1 = new Vector3(1, -2, 0);
    public Vector3 TopRight1 = new Vector3(1, 0, 0);
    public Vector3 TopLeft1 = new Vector3(-1, 0, 0);
    public Vector3 BottomLeft1 = new Vector3(-1, -2, 0);
    bool Thing = false;
    public void Awake()
    {
        isLineActive = new bool[4];
        // Dots = new GameObject[9];
        IsAIGameState = true;
        EndingDots = new string[300];
        AI.pp();
        WhatIsGoingOn.text = "Generating Lines";
        TheInstructions = new string[300];
        for (int p = 0; p < AI.Instruction.Length; p++)
        {
            TheInstructions[p] = AI.Instruction[p];
        }
    }
    IEnumerator WaitThing()
    {
        switch (StartingDotAI)
        {
            case "Yellow":
                switch (EndingDotAI)
                {
                    case "Red":
                        GameObject Clone = Instantiate(PrefabTrail, Line[0].transform);
                        if(Dots[0].transform.position.x - Dots[1].transform.position.x == -2)
                        {
                            Clone.GetComponent<ExampleClass>().XDistance = Axis;
                        }
                        else if(Dots[0].transform.position.x - Dots[1].transform.position.x == -2)
                        {
                            Clone.GetComponent<ExampleClass>().XDistance = -Axis;
                        }
                        else if(Dots[0].transform.position.x - Dots[1].transform.position.x == 0)
                        {
                            Clone.GetComponent<ExampleClass>().XDistance = 0;
                        }
                        if (Dots[0].transform.position.y - Dots[1].transform.position.y == 2)
                        {
                            Clone.GetComponent<ExampleClass>().YDistance = -Axis;
                        }
                        else if (Dots[0].transform.position.y - Dots[1].transform.position.y == -2)
                        {
                            Clone.GetComponent<ExampleClass>().YDistance = Axis;
                        }
                        else if (Dots[0].transform.position.y - Dots[1].transform.position.y == 0)
                        {
                            Clone.GetComponent<ExampleClass>().YDistance = 0;
                        }
                        break;
                    case "Green":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[0].transform);
                        if (Dots[0].transform.position.x - Dots[2].transform.position.x == -2)
                        {
                            Clone2.GetComponent<ExampleClass>().XDistance = Axis;
                        }
                        else if (Dots[0].transform.position.x - Dots[2].transform.position.x == -2)
                        {
                            Clone2.GetComponent<ExampleClass>().XDistance = -Axis;
                        }
                        else if (Dots[0].transform.position.x - Dots[2].transform.position.x == 0)
                        {
                            Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        }
                        if (Dots[0].transform.position.y - Dots[2].transform.position.y == 2)
                        {
                            Clone2.GetComponent<ExampleClass>().YDistance = -Axis;
                        }
                        else if (Dots[0].transform.position.y - Dots[2].transform.position.y == -2)
                        {
                            Clone2.GetComponent<ExampleClass>().YDistance = Axis;
                        }
                        else if (Dots[0].transform.position.y - Dots[2].transform.position.y == 0)
                        {
                            Clone2.GetComponent<ExampleClass>().YDistance = 0;
                        }
                        break;
                    case "Blue":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[0].transform);
                        if (Dots[0].transform.position.x - Dots[3].transform.position.x == -2)
                        {
                            Clone3.GetComponent<ExampleClass>().XDistance = Axis;
                        }
                        else if (Dots[0].transform.position.x - Dots[3].transform.position.x == -2)
                        {
                            Clone3.GetComponent<ExampleClass>().XDistance = -Axis;
                        }
                        else if (Dots[0].transform.position.x - Dots[3].transform.position.x == 0)
                        {
                            Clone3.GetComponent<ExampleClass>().XDistance = 0;
                        }
                        if (Dots[0].transform.position.y - Dots[3].transform.position.y == 2)
                        {
                            Clone3.GetComponent<ExampleClass>().YDistance = -Axis;
                        }
                        else if (Dots[0].transform.position.y - Dots[3].transform.position.y == -2)
                        {
                            Clone3.GetComponent<ExampleClass>().YDistance = Axis;
                        }
                        else if (Dots[0].transform.position.y - Dots[3].transform.position.y == 0)
                        {
                            Clone3.GetComponent<ExampleClass>().YDistance = 0;
                        }
                        break;
                }
                break;
            case "Red":
                switch (EndingDotAI)
                {
                    case "Yellow":
                        GameObject Clone = Instantiate(PrefabTrail, Line[1].transform);
                        if (Dots[1].transform.position.x - Dots[0].transform.position.x == -2)
                        {
                            Clone.GetComponent<ExampleClass>().XDistance = Axis;
                        }
                        else if (Dots[1].transform.position.x - Dots[0].transform.position.x == -2)
                        {
                            Clone.GetComponent<ExampleClass>().XDistance = -Axis;
                        }
                        else if (Dots[1].transform.position.x - Dots[0].transform.position.x == 0)
                        {
                            Clone.GetComponent<ExampleClass>().XDistance = 0;
                        }
                        if (Dots[1].transform.position.y - Dots[0].transform.position.y == 2)
                        {
                            Clone.GetComponent<ExampleClass>().YDistance = -Axis;
                        }
                        else if (Dots[1].transform.position.y - Dots[0].transform.position.y == -2)
                        {
                            Clone.GetComponent<ExampleClass>().YDistance = Axis;
                        }
                        else if (Dots[1].transform.position.y - Dots[0].transform.position.y == 0)
                        {
                            Clone.GetComponent<ExampleClass>().YDistance = 0;
                        }
                        break;
                    case "Green":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[1].transform);
                        if (Dots[1].transform.position.x - Dots[2].transform.position.x == -2)
                        {
                            Clone2.GetComponent<ExampleClass>().XDistance = Axis;
                        }
                        else if (Dots[1].transform.position.x - Dots[2].transform.position.x == -2)
                        {
                            Clone2.GetComponent<ExampleClass>().XDistance = -Axis;
                        }
                        else if (Dots[1].transform.position.x - Dots[2].transform.position.x == 0)
                        {
                            Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        }
                        if (Dots[1].transform.position.y - Dots[2].transform.position.y == 2)
                        {
                            Clone2.GetComponent<ExampleClass>().YDistance = -Axis;
                        }
                        else if (Dots[1].transform.position.y - Dots[2].transform.position.y == -2)
                        {
                            Clone2.GetComponent<ExampleClass>().YDistance = Axis;
                        }
                        else if (Dots[1].transform.position.y - Dots[2].transform.position.y == 0)
                        {
                            Clone2.GetComponent<ExampleClass>().YDistance = 0;
                        }
                        break;
                    case "Blue":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[1].transform);
                        if (Dots[1].transform.position.x - Dots[3].transform.position.x == -2)
                        {
                            Clone3.GetComponent<ExampleClass>().XDistance = Axis;
                        }
                        else if (Dots[1].transform.position.x - Dots[3].transform.position.x == -2)
                        {
                            Clone3.GetComponent<ExampleClass>().XDistance = -Axis;
                        }
                        else if (Dots[1].transform.position.x - Dots[3].transform.position.x == 0)
                        {
                            Clone3.GetComponent<ExampleClass>().XDistance = 0;
                        }
                        if (Dots[1].transform.position.y - Dots[3].transform.position.y == 2)
                        {
                            Clone3.GetComponent<ExampleClass>().YDistance = -Axis;
                        }
                        else if (Dots[1].transform.position.y - Dots[3].transform.position.y == -2)
                        {
                            Clone3.GetComponent<ExampleClass>().YDistance = Axis;
                        }
                        else if (Dots[1].transform.position.y - Dots[3].transform.position.y == 0)
                        {
                            Clone3.GetComponent<ExampleClass>().YDistance = 0;
                        }
                        break;
                }
                break;
            case "Green":
                switch (EndingDotAI)
                {
                    case "Red":
                        GameObject Clone = Instantiate(PrefabTrail, Line[2].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = Axis;
                        Clone.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                    case "Yellow":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = 0;
                        Clone2.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                    case "Blue":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[2].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = Axis;
                        Clone3.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                }
                break;
            case "Blue":
                switch (EndingDotAI)
                {
                    case "Red":
                        GameObject Clone = Instantiate(PrefabTrail, Line[3].transform);
                        Clone.GetComponent<ExampleClass>().XDistance = 0;
                        Clone.GetComponent<ExampleClass>().YDistance = Axis;
                        break;
                    case "Green":
                        GameObject Clone2 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone2.GetComponent<ExampleClass>().XDistance = -Axis;
                        Clone2.GetComponent<ExampleClass>().YDistance = 0;
                        break;
                    case "Yellow":
                        GameObject Clone3 = Instantiate(PrefabTrail, Line[3].transform);
                        Clone3.GetComponent<ExampleClass>().XDistance = -Axis;
                        Clone3.GetComponent<ExampleClass>().YDistance = Axis;
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
                    for (int i = TheInstructions[pp].IndexOf("_") + 1; i < TheInstructions[pp].Length; i++)
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
                    WhatIsGoingOn.text = "Draw Lines!";
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
                        case "Yellow":
                            Vector3[] EndingPos1 = new Vector3[2];
                            Line[0].SetPositions(EndingPos1);
                            Line[0].enabled = true;
                            isLineActive[0] = true;
                            isOnelineActive = true;
                            break;
                        case "Red":
                            Vector3[] EndingPos12 = new Vector3[2];
                            Line[1].SetPositions(EndingPos12);
                            Line[1].enabled = true;
                            isLineActive[1] = true;
                            isOnelineActive = true;
                            break;
                        case "Green":
                            Vector3[] EndingPos123 = new Vector3[2];
                            Line[2].SetPositions(EndingPos123);
                            Line[2].enabled = true;
                            isLineActive[2] = true;
                            isOnelineActive = true;
                            break;
                        case "Blue":
                            Vector3[] EndingPos124 = new Vector3[2];
                            Line[3].SetPositions(EndingPos124);
                            Line[3].enabled = true;
                            isLineActive[3] = true;
                            isOnelineActive = true;
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
                                        if (hit.collider.name == "Red")
                                        {
                                            if (EndingDots[PlayerCount] != "Red")
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
                                        else if (hit.collider.name == "Blue")
                                        {
                                            if (EndingDots[PlayerCount] != "Blue")
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
                                        else if (hit.collider.name == "Green")
                                        {
                                            if (EndingDots[PlayerCount] != "Green")
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
                                        if (hit.collider.name == "Yellow")
                                        {
                                            if (EndingDots[PlayerCount] != "Yellow")
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
                                        else if (hit.collider.name == "Green")
                                        {
                                            if (EndingDots[PlayerCount] != "Green")
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
                                        else if (hit.collider.name == "Blue")
                                        {
                                            if (EndingDots[PlayerCount] != "Blue")
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
                                        if (hit.collider.name == "Red")
                                        {
                                            if (EndingDots[PlayerCount] != "Red")
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
                                        else if (hit.collider.name == "Blue")
                                        {
                                            if (EndingDots[PlayerCount] != "Blue")
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
                                        else if (hit.collider.name == "Yellow")
                                        {
                                            if (EndingDots[PlayerCount] != "Yellow")
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
                                        if (hit.collider.name == "Yellow")
                                        {
                                            if (EndingDots[PlayerCount] != "Yellow")
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
                                        else if (hit.collider.name == "Red")
                                        {
                                            if (EndingDots[PlayerCount] != "Red")
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
                                        else if (hit.collider.name == "Green")
                                        {
                                            if (EndingDots[PlayerCount] != "Green")
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
                                if (PlayerCount >= LinesAtATime * Round)
                                {
                                    AI.pp();
                                    WhatIsGoingOn.text = "Generting Lines";
                                    IsAIGameState = true;
                                    HasDrawnLine = false;
                                    PlayerCount = 0;
                                    //AI.pp();

                                    for (int p = 0; p < AI.Instruction.Length; p++)
                                    {
                                        TheInstructions[p + 2 * Round] = AI.Instruction[p];
                                    }
                                    Round++;
                                    pp = 0;
                                    for (int a = 0; a < Line.Length; a++)
                                    {
                                        Line[a].enabled = false;
                                    }

                                    int randnum = UnityEngine.Random.Range(0, 3);
                                    switch (randnum)
                                    {
                                        case 0:
                                            Vector3 temp = Dots[0].transform.position;
                                            Dots[0].transform.position = Dots[1].transform.position;
                                            Dots[1].transform.position = temp;
                                            Vector3 T = Line[0].transform.position;
                                            Line[0].transform.position = Line[1].transform.position;
                                            Line[1].transform.position = T;
                                            break;
                                        case 1:
                                            Vector3 temp2 = Dots[0].transform.position;
                                            Dots[0].transform.position = Dots[2].transform.position;
                                            Dots[2].transform.position = temp2;
                                            Vector3 T1 = Line[0].transform.position;
                                            Line[0].transform.position = Line[2].transform.position;
                                            Line[2].transform.position = T1;
                                            break;
                                        case 2:
                                            Vector3 temp3 = Dots[0].transform.position;
                                            Dots[0].transform.position = Dots[3].transform.position;
                                            Dots[3].transform.position = temp3;
                                            Vector3 T2 = Line[0].transform.position;
                                            Line[0].transform.position = Line[3].transform.position;
                                            Line[3].transform.position = T2;
                                            break;
                                    }
                                    int randnum2 = UnityEngine.Random.Range(0, 3);
                                    switch (randnum2)
                                    {
                                        case 0:
                                            Vector3 temp = Dots[1].transform.position;
                                            Dots[1].transform.position = Dots[0].transform.position;
                                            Dots[0].transform.position = temp;
                                            Vector3 T = Line[1].transform.position;
                                            Line[1].transform.position = Line[0].transform.position;
                                            Line[0].transform.position = T;
                                            break;
                                        case 1:
                                            Vector3 temp2 = Dots[1].transform.position;
                                            Dots[1].transform.position = Dots[2].transform.position;
                                            Dots[2].transform.position = temp2;
                                            Vector3 T2 = Line[1].transform.position;
                                            Line[1].transform.position = Line[2].transform.position;
                                            Line[2].transform.position = T2;
                                            break;
                                        case 2:
                                            Vector3 temp3 = Dots[1].transform.position;
                                            Dots[1].transform.position = Dots[3].transform.position;
                                            Dots[3].transform.position = temp3;
                                            Vector3 T3 = Line[1].transform.position;
                                            Line[1].transform.position = Line[3].transform.position;
                                            Line[3].transform.position = T3;
                                            break;
                                    }
                                    int randnum3 = UnityEngine.Random.Range(0, 3);
                                    switch (randnum3)
                                    {
                                        case 0:
                                            Vector3 temp = Dots[2].transform.position;
                                            Dots[2].transform.position = Dots[1].transform.position;
                                            Dots[1].transform.position = temp;
                                            Vector3 T = Line[2].transform.position;
                                            Line[2].transform.position = Line[1].transform.position;
                                            Line[1].transform.position = T;
                                            break;
                                        case 1:
                                            Vector3 temp2 = Dots[2].transform.position;
                                            Dots[2].transform.position = Dots[0].transform.position;
                                            Dots[0].transform.position = temp2;
                                            Vector3 T1 = Line[2].transform.position;
                                            Line[2].transform.position = Line[0].transform.position;
                                            Line[0].transform.position = T1;
                                            break;
                                        case 2:
                                            Vector3 temp3 = Dots[2].transform.position;
                                            Dots[2].transform.position = Dots[3].transform.position;
                                            Dots[3].transform.position = temp3;
                                            Vector3 T2 = Line[2].transform.position;
                                            Line[2].transform.position = Line[3].transform.position;
                                            Line[3].transform.position = T2;
                                            break;
                                    }
                                    int randnum4 = UnityEngine.Random.Range(0, 3);
                                    switch (randnum4)
                                    {
                                        case 0:
                                            Vector3 temp = Dots[3].transform.position;
                                            Dots[3].transform.position = Dots[1].transform.position;
                                            Dots[1].transform.position = temp;
                                            Vector3 T = Line[3].transform.position;
                                            Line[3].transform.position = Line[1].transform.position;
                                            Line[1].transform.position = T;
                                            break;
                                        case 1:
                                            Vector3 temp2 = Dots[3].transform.position;
                                            Dots[3].transform.position = Dots[2].transform.position;
                                            Dots[2].transform.position = temp2;
                                            Vector3 T1 = Line[3].transform.position;
                                            Line[3].transform.position = Line[2].transform.position;
                                            Line[2].transform.position = T1;
                                            break;
                                        case 2:
                                            Vector3 temp3 = Dots[3].transform.position;
                                            Dots[3].transform.position = Dots[0].transform.position;
                                            Dots[0].transform.position = temp3;
                                            Vector3 T2 = Line[3].transform.position;
                                            Line[3].transform.position = Line[0].transform.position;
                                            Line[0].transform.position = T2;
                                            break;
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
                                        case "Red":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Blue":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(Axis, -Axis, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        case "Green":
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
                                        case "Yellow":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Green":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(-Axis, -Axis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Blue":
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
                                        case "Red":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(Axis, Axis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Blue":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(Axis, 0, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Yellow":
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
                                        case "Yellow":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-Axis, Axis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Red":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(0, Axis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Green":
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