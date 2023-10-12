using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    // Character Controller
    public CharacterController control;
    // Animator
    public Animator anim;

    // Joystick
    public Joystick joystick;

    // Speed variable
    public float speed = 10f;

    // Moves along the horizontal axis.
    float horizontalMovement = 0f;

    // Intially set jumping to false.
    public bool jumping = false;

    public void Update()
    {
        // Is the joystick moving more than .2f?
        if (joystick.Horizontal >= .2f)
        {
            horizontalMovement = speed;
        }
        // Joystick isn't moving.
        else if (joystick.Horizontal <= -.2f)
        {
            horizontalMovement = -speed;
        }
        else
        {
            horizontalMovement = 0f;
        }

        // Handles jumping.
        float verticalMovement = joystick.Vertical;

        anim.SetFloat("speed", Mathf.Abs(horizontalMovement));

        // Are we getting ready to jump?
        if (verticalMovement >= .5f)
        {
            // Set jump to true, and play jump animation.
            jumping = true;
            anim.SetBool("jump", true);
        }
        else if (verticalMovement <= -.5f)
        {
            jumping = false;
            anim.SetBool("jump", false);
        }
    }
}
