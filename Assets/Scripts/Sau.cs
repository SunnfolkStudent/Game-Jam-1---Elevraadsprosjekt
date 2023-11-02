using UnityEngine;

public class Sau : MonoBehaviour
{
    public Transform flower;
    public float moveSpeed = 5f;
    private PlayerController _player;
    void Start()
    {
        flower = GameObject.FindGameObjectWithTag("Flower").transform;
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
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
                if (directionToFlower.x < 0)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }
            }
        }
        else
        {
            if (GameObject.FindGameObjectWithTag("Flower"))
            {
                flower = GameObject.FindGameObjectWithTag("Flower").transform;
                gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
            else
            {
                _player.activeObjects.Remove(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
