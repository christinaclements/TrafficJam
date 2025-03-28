using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;
using UnityEngine.UIElements;
using System.ComponentModel.Design.Serialization;

public class ScoreBehavior : MonoBehaviour{
    public static int score;
    public static TextMeshProUGUI scoreField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        scoreField = GetComponent<TextMeshProUGUI>();
        score = 0;
        if (scoreField == null){
            Debug.Log("No component found");
        }
    }
    // Update is called once per frame
        private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Boarder"){
            Destroy(this.gameObject);
            //score.increase();
        }
    }
    public static void increase(){
        score = score + 1;
        if (scoreField != null){
            string message = string.Format("Score: " + score);
            scoreField.text = message;
        }
    }
}
