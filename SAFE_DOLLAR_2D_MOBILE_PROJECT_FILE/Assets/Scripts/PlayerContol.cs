using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContol : MonoBehaviour
{
    public float speed = 100f;
    public float verticalSpeed = 5f;
    private Vector2 startTouchPosition, currentTouchPosition;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    void Update()
    {
        SwipeCheck();
        if (transform.position.y >= -1 )
        {
            transform.position = new Vector2(transform.position.x, -1);
        }
        else if (transform.position.y <=-8 )
        {
            transform.position = new Vector2(transform.position.x, -8);

        }
    }

    void SwipeCheck()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                currentTouchPosition = touch.position;

                float swipeDeltaY = currentTouchPosition.y - startTouchPosition.y;

                transform.position += Vector3.up * swipeDeltaY * verticalSpeed * Time.deltaTime;

                startTouchPosition = currentTouchPosition;
            }
        }
    }
}
