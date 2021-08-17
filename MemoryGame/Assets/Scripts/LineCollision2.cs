using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PolygonCollider2D))]

public class LineCollision2 : MonoBehaviour
{
    PolygonCollider2D polygonCollider2D;
    List<Vector2> colliderPoints = new List<Vector2>();

    void Start()
    {
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        colliderPoints = CalculateColliderPoints();
        polygonCollider2D.SetPath(0, colliderPoints.ConvertAll(p => (Vector2)transform.InverseTransformPoint(p)));
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        if (colliderPoints != null) colliderPoints.ForEach(p => Gizmos.DrawSphere(p, 0.1f));
    }
    public void TestCollision(String Dots, String EndingDot)
    {
        if (GameObject.Find(Dots).GetComponent<Transform>().position.x == -1 && GameObject.Find(Dots).GetComponent<Transform>().position.y == 1)
        {
            if (polygonCollider2D.OverlapPoint(new Vector2(2, 0.1f)) || polygonCollider2D.OverlapPoint(new Vector2(2, -0.1f)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot02" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[0].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[0].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(-0.1f, -2)) || polygonCollider2D.OverlapPoint(new Vector2(0.1f, -2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot03" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(0, -GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[0].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[0].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(2.1f, -2)) || polygonCollider2D.OverlapPoint(new Vector2(1.9f, -2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot04" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, -GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[0].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[0].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
        }
        if (GameObject.Find(Dots).GetComponent<Transform>().position.x == 1 && GameObject.Find(Dots).GetComponent<Transform>().position.y == 1)
        {
            if (polygonCollider2D.OverlapPoint(new Vector2(-2, 0.1f)) || polygonCollider2D.OverlapPoint(new Vector2(-2, -0.1f)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot01" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(-GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[1].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[1].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(-2.1f, -2)) || polygonCollider2D.OverlapPoint(new Vector2(-1.9f, -2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot03" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(-GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, -GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[1].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[1].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(-0.1f, -2)) || polygonCollider2D.OverlapPoint(new Vector2(0.1f, -2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot04" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(0, -GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[1].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[1].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
        }
        if (GameObject.Find(Dots).GetComponent<Transform>().position.x == -1 && GameObject.Find(Dots).GetComponent<Transform>().position.y == -1)
        {
            if (polygonCollider2D.OverlapPoint(new Vector2(2, 2.1f)) || polygonCollider2D.OverlapPoint(new Vector2(2, -1.9f)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot02" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[2].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[2].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(-0.1f, 2)) || polygonCollider2D.OverlapPoint(new Vector2(0.1f, 2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot01" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(0, GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[2].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[2].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(2, -0.1f)) || polygonCollider2D.OverlapPoint(new Vector2(2, -0.1f)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot04" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[2].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[2].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
        }
        if (GameObject.Find(Dots).GetComponent<Transform>().position.x == 1 && GameObject.Find(Dots).GetComponent<Transform>().position.y == -1)
        {
            if (polygonCollider2D.OverlapPoint(new Vector2(-2.1f, 2f)) || polygonCollider2D.OverlapPoint(new Vector2(-1.9f, 2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot01" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(-GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[3].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[3].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(-0.1f, 2)) || polygonCollider2D.OverlapPoint(new Vector2(0.1f, 2)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot02" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(0, GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[3].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[3].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().HasPlaced = true;
            }
            if (polygonCollider2D.OverlapPoint(new Vector2(-2, -0.1f)) || polygonCollider2D.OverlapPoint(new Vector2(-2, 0.1f)))
            {
                if (GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != "Dot03" || GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().StartingDots[GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount] != GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().CurrentStartingDot)
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndCondition.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().EndGame = true;
                    Vector3[] EndingPos = new Vector3[2];
                    EndingPos[1] = new Vector3(-GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Axis, 0, 0);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().Line[3].SetPositions(EndingPos);
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().DotSelected[3].SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<TwoByTwoUpdated>().PlayerCount++;
                }
                GameObject.Find("Main Camera").GetComponent<TwoByTwo>().HasPlaced = true;
            }
        }
    }
    private List<Vector2> CalculateColliderPoints()
    {
        //Get All positions on the line renderer
        Vector3[] positions = GetPositions();

        //Get the Width of the Line
        float width = GetWidth();

        //m = (y2 - y1) / (x2 - x1)
        float m = (positions[1].y - positions[0].y) / (positions[1].x - positions[0].x);
        float deltaX = (width / 2f) * (m / Mathf.Pow(m * m + 1, 0.5f));
        float deltaY = (width / 2f) * (1 / Mathf.Pow(1 + m * m, 0.5f));

        //Calculate the Offset from each point to the collision vertex
        Vector3[] offsets = new Vector3[2];
        offsets[0] = new Vector3(-deltaX, deltaY);
        offsets[1] = new Vector3(deltaX, -deltaY);

        //Generate the Colliders Vertices
        List<Vector2> colliderPositions = new List<Vector2> {
            positions[0] + offsets[0],
            positions[1] + offsets[0],
            positions[1] + offsets[1],
            positions[0] + offsets[1]
        };

        return colliderPositions;
    }
    public Vector3[] GetPositions()
    {
        Vector3[] positions = new Vector3[gameObject.GetComponent<LineRenderer>().positionCount];
        gameObject.GetComponent<LineRenderer>().GetPositions(positions);
        return positions;
    }
    public float GetWidth()
    {
        return gameObject.GetComponent<LineRenderer>().startWidth;
    }
}
