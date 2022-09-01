using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleProjectile : MonoBehaviour
{
    Vector3 startingPos;
    Vector3 endingPos;

    public int range;
    public float speed;
    float flip;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position; //make this enemies position
        endingPos = new Vector3(startingPos.x + range, startingPos.y, startingPos.z); //make this aim at players position 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endingPos, speed * Time.deltaTime);

        if (transform.position == endingPos)
        {
            Destroy(this.gameObject);
        }
    }
}
