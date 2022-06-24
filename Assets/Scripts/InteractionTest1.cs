using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;
using Dreamteck.Editor;

public class InteractionTest1 : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;

    public Spline mySpline;

    Vector3 hitPosition;

    RaycastHit raycastHit;

    SplinePoint[] points;
    

    int baseLength;
    int nextPoint;

    SplineComputer spline;




    // Start is called before the first frame update
    void Start()
    {
        baseLength = 3;
        nextPoint = baseLength + 1;

        //Add a Spline Computer component to this object
        //SplineComputer spline = GetComponent<SplineComputer>();

        //Create a new array of spline points
        //SplinePoint[] points = new SplinePoint[20];

    }

    // Update is called once per frame
    void Update()
    {
        
        SplineComputer spline = GetComponent<SplineComputer>();
        //spline.type = Spline.Type.BSpline;
        //spline.space = Space.Local;
        
        //Get the spline's points
        //SplinePoint[] points = spline.GetPoints();



        // SplineComputer spline = GetComponent<SplineComputer>();
        // spline.type = Spline.Type.BSpline;
        // spline.space = Space.Local;
        // spline.SetPoint(0, new SplinePoint(new Vector3(10f, 24f, 1f)));
        // spline.SetPoint(0, new SplinePoint(hitPosition));









        //Set each point's properties
        for (int i = 0; i <= baseLength; i++)
        {
            points[i] = new SplinePoint();
            points[i].position = Vector3.forward * i;
            points[i].normal = Vector3.up;
            points[i].size = 1f;
            points[i].color = Color.white;
        }
        //Write the points to the spline
        spline.SetPoints(points);




        ////// Edit spline

        //SplineComputer spline = gameObject.GetComponent<SplineComputer>();

        

             



        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {

            if (Input.GetMouseButtonUp(0))
            {
                hitPosition = raycastHit.point;

                //points[nextPoint] = new SplinePoint();
                points[nextPoint].position = hitPosition;
                points[nextPoint].normal = Vector3.up;
                points[nextPoint].size = 1f;
                points[nextPoint].color = Color.white;

                spline.SetPoints(points);

                nextPoint++;
            }
        }

        //// Debugging
        ///

        Debug.Log("next Point: " + nextPoint);
        Debug.Log("Points array length: " + points.Length);
        Debug.Log("next Point Position: " + points[nextPoint].position);
        Debug.Log("RaycasHit.point position: " + hitPosition);


    }
}
