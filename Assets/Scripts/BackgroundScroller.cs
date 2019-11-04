using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float Speed = 0f;
    public bool IsScrolling;

    private Vector2 offset = new Vector2 (0.25f, 0f);
    private Material material;

    void Start ()
    {
        material = this.GetComponent<Renderer> ().material;
    }

    public Material Material
    {
        set
        {
            this.GetComponent<Renderer> ().material = value;
            material = value;
        }
    }

    void Update ()
    {
        offset.x += Time.deltaTime * Speed;
        material.mainTextureOffset = offset;
    }
}
