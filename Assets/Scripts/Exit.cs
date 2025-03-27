using UnityEngine;

public class Exit : MonoBehaviour{
    public void QuitGame(){
        Debug.Log("Game is exiting...");
        Application.Quit(); 
    }
}
