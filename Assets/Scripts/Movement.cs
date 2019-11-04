using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float Speed = 1.0f;
    public float JumpPower = 6.0f;
    public 

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
            return;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
            this.transform.Translate (-1 * Time.deltaTime * Speed, 0, 0);
            Game.Instance.SetBackgroundSpeed (-0.01f);

        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            this.transform.localScale = new Vector3 (1, 1, 1);
            this.transform.Translate (1 * Time.deltaTime * Speed, 0, 0);
            Game.Instance.SetBackgroundSpeed (0.01f);
        }
        else if (!Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Game.Instance.SetBackgroundSpeed (0.0f);
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            this.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * JumpPower, ForceMode2D.Impulse);
        }
    }
}
