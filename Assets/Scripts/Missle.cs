using UnityEngine;

public class Missle : MonoBehaviour
{
    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Boarder")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "player") {
            Destroy(player.gameObject);
        }
    }
}
