using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    public float tileSizeX;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
