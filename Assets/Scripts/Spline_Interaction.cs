using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class Spline_Interaction : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;

    public Spline mySpline;

    Vector3 hitPosition;

    RaycastHit raycastHit;

    SplinePoint[] points;

    int baseLength;
    int nextPoint;



    // Start is called before the first frame update
    void Start()
    {
        baseLength = 0;
        nextPoint = baseLength + 1;




        //Get the Spline Computer component to this object
        SplineComputer spline = gameObject.GetComponent<SplineComputer>();

        //Create a new array of spline points
        SplinePoint[] points = new SplinePoint[baseLength+1];

        //Set each point's properties
        for (int i = 0; i <= baseLength; i++)
        {
            points[i] = new SplinePoint();
            points[i].position = Vector3.forward * i;
            points[i].normal = Vector3.up;
            points[i].size = 1f;
            points[i].color = Color.green;
        }
        //Write the points to the spline
        spline.SetPoints(points);



    }

    // Update is called once per frame
    void Update()
    {

        SplineComputer spline = gameObject.GetComponent<SplineComputer>();
        SplinePoint[] points = spline.GetPoints();


        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            
            if (Input.GetMouseButtonUp(0))
            {
                hitPosition = raycastHit.point;

                SplinePoint[] pointsExp = new SplinePoint[points.Length + 1];
                //int counter = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    pointsExp[i] = points[i];
                }

                pointsExp[nextPoint].position = hitPosition;
                pointsExp[nextPoint].normal = Vector3.up;
                pointsExp[nextPoint].size = 1f;
                pointsExp[nextPoint].color = Color.white;

                //points[nextPoint].position = hitPosition;
                //points[nextPoint].normal = Vector3.up;
                //points[nextPoint].size = 1f;
                //points[nextPoint].color = Color.white;

                points = pointsExp;

                spline.SetPoints(points);

                nextPoint++;
            }
        }

        

        //// Debugging

        Debug.Log("next Point: " + nextPoint);
        //Debug.Log("Points array length: " + points.Length);
        //Debug.Log("next Point Position: " + points[nextPoint].position);
        Debug.Log("RaycasHit.point position: " + hitPosition);


    }
}