using UnityEngine;

public class cubeMove : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocity.y);
        Debug.Log(Input.GetAxis("Horizontal"));
    }
    
}
