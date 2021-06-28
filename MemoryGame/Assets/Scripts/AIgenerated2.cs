using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIgenerated2 : MonoBehaviour
{
    string StartingDot = "";
    int InstructionCount = 2;
    public string[] Instruction;
    public bool HasStarted = false;
    public TwoByTwo T;
    private void Awake()
    {
        InstructionCount = T.LinesAtATime;
    }
    public void pp()
    {
        Instruction = new string[InstructionCount];
        if (!HasStarted)
        {
            int randnum = Random.Range(0, 3);
            switch (randnum)
            {
                case 0:
                    StartingDot = "Dot01";
                    break;
                case 1:
                    StartingDot = "Dot02";
                    break;
                case 2:
                    StartingDot = "Dot03";
                    break;
                case 3:
                    StartingDot = "Dot04";
                    break;
            }
            HasStarted = true;
        }

        for (int i = 0; i < InstructionCount; i++)
        {
            switch (StartingDot)
            {
                case "Dot01":
                    int randnum1 = Random.Range(0, 3);
                    switch (randnum1)
                    {
                        case 0:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot01_Dot02";
                            break;
                        case 1:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot01_Dot04";
                            break;
                        case 2:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot01_Dot03";
                            break;
                    }
                    break;
                case "Dot02":
                    int randnum2 = Random.Range(0, 3);
                    switch (randnum2)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot02_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot02_Dot03";
                            break;
                        case 2:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot02_Dot04";
                            break;
                    }
                    break;
                case "Dot03":
                    int randnum3 = Random.Range(0, 3);
                    switch (randnum3)
                    {
                        case 0:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot03_Dot02";
                            break;
                        case 1:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot03_Dot04";
                            break;
                        case 2:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot03_Dot01";
                            break;
                    }
                    break;
                case "Dot04":
                    int randnum4 = Random.Range(0, 3);
                    switch (randnum4)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot04_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot04_Dot02";
                            break;
                        case 2:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot04_Dot03";
                            break;
                    }
                    break;
            }
        }
        for (int u = 0; u < InstructionCount; u++)
        {
            print(Instruction[u]);
        }
    }
}
