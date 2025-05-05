using UnityEngine;

public class Movement : MonoBehaviour
{
    readonly float deltaX = 8;
    float initialX = 0;
    float direction = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < initialX - deltaX || transform.position.x > initialX + deltaX) {
            direction = -direction;
        }
        transform.position = new Vector3 (transform.position.x + direction * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
