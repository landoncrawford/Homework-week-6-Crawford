using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesInstanceBehavior : MonoBehaviour
{
    public float moveSpeed = 5;
    public float despawnXPosition = -12;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < despawnXPosition)
        {
            Destroy(gameObject);
        }
    }
}
