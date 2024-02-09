using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;
    [SerializeField] float minY = -4f;
    [SerializeField] float maxY = 4f;

    //the boolean travelDirection is true when going up, false when going down
    bool travelDirection = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(travelDirection == true)
        {//moving up
            transform.Translate(speed * Vector3.up);
        }
        else
        {//moving down
            transform.Translate(speed * Vector3.down);
        }
        //if hit the top, change direction
        if(transform.position.y > maxY)
        {
            travelDirection = false;
        }
        //if hit bottom, change direction
        if(transform.position.y < minY)
        {
            travelDirection = true;
        }
    }
}
