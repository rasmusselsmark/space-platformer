using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject Background;

    private static Game instance = null;
    public static Game Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Game> ();
            }
            return instance;
        }
    }

    public void SetBackgroundSpeed(float value)
    {
        BackgroundScroller scroller = Background.GetComponent<BackgroundScroller> ();

        scroller.Speed = value;
    }
}
