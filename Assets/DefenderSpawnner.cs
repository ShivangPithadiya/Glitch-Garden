using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawnner : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        //camera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnMouseDown()
    //{
    //    Debug.Log("Clicked");
    //    Debug.Log(Input.mousePosition);
    //    //Debug.Log(snapToGrid( calculatWorldPointOfMousePoint()));
        
    //}
    //Vector2 snapToGrid(Vector2 rawWorldPos)
    //{
    //    float newX = Mathf.RoundToInt(rawWorldPos.x);
    //    float newY = Mathf.RoundToInt(rawWorldPos.y);
    //    return new Vector2(newX, newY);
    //}
    //Vector2 calculatWorldPointOfMousePoint()
    //{
    //    float mouX = Input.mousePosition.x;
    //    float mouY = Input.mousePosition.y;
    //    float distanceFromCamara = 10f;

    //    Vector3 weird = new Vector3(mouX, mouY, distanceFromCamara);
    //    Vector2 worldPos = camera.ScreenToWorldPoint(weird);
    //    return worldPos;
    //}
}
