using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
   public void Update()
    {
        Movement();
    }

    public void Movement()
    {
        // Keep looping until touchCount has been reached.
        for (int i = 0; i < Input.touchCount; i++)
        {
            // Camera set to the touch point.
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);

            // Move the character to the place of the touch.
            transform.position = touchPos;

            // Draws a line for debugging purposes.
            Debug.DrawLine(Vector2.zero, touchPos, Color.green);
        }
    }
}
