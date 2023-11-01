using UnityEngine;

public class Sau : MonoBehaviour
{
    public Transform flower;
    public float moveSpeed = 5f;
    void Start()
    {
        flower = GameObject.FindGameObjectWithTag("Flower").transform;
    }

    
    void Update()
    {
        if (flower == true)
        {
            Vector3 flowerPosition = flower.transform.position;
            Vector3 directionToFlower = flowerPosition - transform.position;
            float distanceToFlower = directionToFlower.magnitude;

            if (distanceToFlower > 0)
            {
                directionToFlower.Normalize();
                transform.Translate(directionToFlower * (moveSpeed * Time.deltaTime));
            }
        }
        else
        {
            flower = GameObject.FindGameObjectWithTag("Flower").transform;
        }
    }
}
