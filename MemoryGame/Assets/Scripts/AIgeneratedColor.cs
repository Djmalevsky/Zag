using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIgeneratedColor : MonoBehaviour
{
    string StartingDot = "";
    int InstructionCount = 2;
    public string[] Instruction;
    public bool HasStarted = false;
    public TwoByTwoUpdated T;
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
                    StartingDot = "Yellow";
                    break;
                case 1:
                    StartingDot = "Red";
                    break;
                case 2:
                    StartingDot = "Green";
                    break;
                case 3:
                    StartingDot = "Blue";
                    break;
            }
            HasStarted = true;
        }

        for (int i = 0; i < InstructionCount; i++)
        {
            switch (StartingDot)
            {
                case "Yellow":
                    int randnum1 = Random.Range(0, 3);
                    switch (randnum1)
                    {
                        case 0:
                            StartingDot = "Red";
                            Instruction[i] = "Yellow_Red";
                            break;
                        case 1:
                            StartingDot = "Blue";
                            Instruction[i] = "Yellow_Blue";
                            break;
                        case 2:
                            StartingDot = "Green";
                            Instruction[i] = "Yellow_Green";
                            break;
                    }
                    break;
                case "Red":
                    int randnum2 = Random.Range(0, 3);
                    switch (randnum2)
                    {
                        case 0:
                            StartingDot = "Yellow";
                            Instruction[i] = "Red_Yellow";
                            break;
                        case 1:
                            StartingDot = "Green";
                            Instruction[i] = "Red_Green";
                            break;
                        case 2:
                            StartingDot = "Blue";
                            Instruction[i] = "Red_Blue";
                            break;
                    }
                    break;
                case "Green":
                    int randnum3 = Random.Range(0, 3);
                    switch (randnum3)
                    {
                        case 0:
                            StartingDot = "Red";
                            Instruction[i] = "Green_Red";
                            break;
                        case 1:
                            StartingDot = "Blue";
                            Instruction[i] = "Green_Blue";
                            break;
                        case 2:
                            StartingDot = "Yellow";
                            Instruction[i] = "Green_Yellow";
                            break;
                    }
                    break;
                case "Blue":
                    int randnum4 = Random.Range(0, 3);
                    switch (randnum4)
                    {
                        case 0:
                            StartingDot = "Yellow";
                            Instruction[i] = "Blue_Yellow";
                            break;
                        case 1:
                            StartingDot = "Red";
                            Instruction[i] = "Blue_Red";
                            break;
                        case 2:
                            StartingDot = "Green";
                            Instruction[i] = "Blue_Green";
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
