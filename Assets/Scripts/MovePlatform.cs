using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
   public bool isMovingX = true;
   
    public float platformMovingSpeed;
    public float movingRange;

    float platformTransition = 0f;
    Transform platform;
    Vector3 startPosition;

    private void Start()
    {
        platform = transform;
        startPosition = platform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        platformTransition += Time.deltaTime * platformMovingSpeed;

        float movePosition = Mathf.Sin(platformTransition * movingRange) * (-movingRange * 0.5f);

        if (isMovingX)
        {
            platform.localPosition = new Vector3(startPosition.x + movePosition, startPosition.y, startPosition.z);
        }
        else
        {
            platform.localPosition = new Vector3(startPosition.x,startPosition.y,startPosition.z + movePosition);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
