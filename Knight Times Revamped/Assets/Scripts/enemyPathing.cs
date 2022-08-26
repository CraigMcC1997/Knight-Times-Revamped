using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPathing : MonoBehaviour
{
    Vector3 startingPos;
    Vector3 endingPos;
    
    public int range;
    public float speed;
    float flip;

    bool atStart = false;
    bool atEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        endingPos = new Vector3(startingPos.x + range, startingPos.y, startingPos.z);   
    }

    // Update is called once per frame
    void Update()
    {
        //check if reached destination
        if (transform.position == startingPos)
        {
            atEnd = false;
            atStart = true;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z); //flip the object
        }
           
        if (transform.position == endingPos)
        {
            atStart = false;
            atEnd = true;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z); //flip the object
        }


        //if reached destination then turn and go the other way
        if (atStart)
            transform.position = Vector3.MoveTowards(transform.position, endingPos, speed * Time.deltaTime);
        if (atEnd)
            transform.position = Vector3.MoveTowards(transform.position, startingPos, speed * Time.deltaTime);
    }
}
