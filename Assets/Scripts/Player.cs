using UnityEngine;

public class Player : MonoBehaviour {
    
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerPos;
    void Start(){
        //rb = GetComponent<Rigidbody2D>();
    }

    
    void Update(){
        float moveY = Input.GetAxis("Vertical");
        playerPos = new Vector2 (0, moveY) * playerSpeed * Time.deltaTime;
        transform.position = (Vector2)transform.position + playerPos;
    }
    private void FixedUpdate(){
        //rb.linearVelocity = new Vector2(0, playerSpeed * playerPos.y);
    }
}