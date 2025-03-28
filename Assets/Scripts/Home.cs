using UnityEngine;

public class Home : MonoBehaviour{

    public void goToGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
    public void goToSelection(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("CharacterSelection");
    }
    public void goToMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
    }

}
