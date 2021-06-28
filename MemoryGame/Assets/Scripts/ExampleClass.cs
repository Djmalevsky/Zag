using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExampleClass : MonoBehaviour
{
    public float XDistance = 2;
    public float YDistance = 6;
    public float speed1 = 1;
    public float speed2 = 1;
    private TrailRenderer tr;
    float time = 0;
    void Start()
    {
        StartCoroutine(pp());
        tr = GetComponent<TrailRenderer>();
       // tr.time = 3f;
        tr.widthMultiplier = 0.1f;

        if (Mathf.Abs(XDistance) > Mathf.Abs(YDistance))
        {
            if (Mathf.Abs(YDistance) > 0)
            {
                speed1 = speed2 * Mathf.Abs(XDistance / YDistance);
            }
        }


        if (Mathf.Abs(YDistance) > Mathf.Abs(XDistance))
        {
            if (Mathf.Abs(XDistance) > 0)
            {
                speed2 = speed1 * Mathf.Abs(YDistance / XDistance);
            }
        }
        
        if(XDistance == 0)
        {
            speed1 = 0;
        }
        if(YDistance == 0)
        {
            speed2 = 0;
        }
    }
    private Vector3 CalculatePosition2(float time)
    {
        return new Vector3(-time * speed1, time * speed2, 0.0f);
    }
    private Vector3 CalculatePosition3(float time)
    {
        return new Vector3(time * speed1, -time * speed2, 0.0f);
    }
    void Update()
    {
        if (XDistance < 0 && YDistance > 0)
        {
            if (tr.transform.localPosition.x > XDistance && tr.transform.localPosition.y < YDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition2(time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (XDistance > 0 && YDistance < 0)
        {
            if (tr.transform.localPosition.x < XDistance && tr.transform.localPosition.y > YDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition3(time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (XDistance < 0 && YDistance < 0)
        {
            if (tr.transform.localPosition.x > XDistance && tr.transform.localPosition.y > YDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition(-time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (XDistance > 0 && YDistance > 0)
        {
            if (tr.transform.localPosition.x < XDistance && tr.transform.localPosition.y < YDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition(time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (XDistance > 0 && YDistance == 0)
        {
            if (tr.transform.localPosition.x < XDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition(time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (YDistance > 0 && XDistance == 0)
        {
            if (tr.transform.localPosition.y < YDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition(time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (YDistance < 0 && XDistance == 0)
        {
            if (tr.transform.localPosition.y > YDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition(-time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
        else if (XDistance < 0 && YDistance == 0)
        {
            if (tr.transform.localPosition.x > XDistance)
            {
                time += Time.deltaTime;
                tr.transform.localPosition = CalculatePosition(-time);
            }
            else
            {
                StartCoroutine(pp());
            }
        }
    }

    private Vector3 CalculatePosition(float time)
    {

        return new Vector3(time * speed1, time * speed2, 0.0f);
    }

    IEnumerator pp()
    {
        yield return new WaitForSeconds(1.5f);

    }
    private void OnDestroy()
    {
        if (GameObject.Find("Main Camera").GetComponent<TouchScreenMode>() != null)
        {
            GameObject.Find("Main Camera").GetComponent<TouchScreenMode>().pp++;
            GameObject.Find("Main Camera").GetComponent<TouchScreenMode>().EndingDotAI = "";
            GameObject.Find("Main Camera").GetComponent<TouchScreenMode>().HasDrawnLine = false;
        }
        if(GameObject.Find("Main Camera").GetComponent<TwoByTwo>() != null)
        {
            GameObject.Find("Main Camera").GetComponent<TwoByTwo>().pp++;
            GameObject.Find("Main Camera").GetComponent<TwoByTwo>().EndingDotAI = "";
            GameObject.Find("Main Camera").GetComponent<TwoByTwo>().HasDrawnLine = false;
        }
        if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>() != null)
        {
            GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().pp++;
            GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDotAI = "";
            GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasDrawnLine = false;
        }
        //   GameObject.Find("Main Camera").GetComponent<TestScript>().pp();
        //   GameObject.Find("Main Camera").GetComponent<TouchScreenMode>().pp++;
        //  GameObject.Find("Main Camera").GetComponent<TouchScreenMode>().EndingDotAI = "";
        //  GameObject.Find("Main Camera").GetComponent<TouchScreenMode>().HasDrawnLine = false;
    }
}