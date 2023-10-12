using UnityEngine;

class PlayerMovement: MonoBehaviour
{
    private void Update()
    {
        CheckTouch();
    }

    void CheckTouch()
    {
        // Is the touch count more than zero?
        if (Input.touchCount > 0)
        {
            // First finger touches the screen.
            Touch touch = Input.GetTouch(0);
            touch.phase = TouchPhase.Began;
        }
    }
}
