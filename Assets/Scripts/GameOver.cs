using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void goToGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
    public void goToMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
    }
    public void goToPinSelection(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("CharacterSelection");
    }
}
