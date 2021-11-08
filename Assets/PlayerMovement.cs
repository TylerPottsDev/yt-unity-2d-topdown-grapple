using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rb;
    GrappleHook gh;
    
    [SerializeField] float speed = 5f;

    float mx;
    float my;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        gh = GetComponent<GrappleHook>();
    }

    private void Update() {
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        if (!gh.retracting) {
            rb.velocity = new Vector2(mx, my).normalized * speed;
        } else {
            rb.velocity = Vector2.zero;
        }
    }
}
