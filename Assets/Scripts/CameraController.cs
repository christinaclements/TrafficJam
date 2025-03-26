using UnityEngine;

public class CameraController : MonoBehaviour{
    public float cameraSpeed;

    // Update is called once per frame
    void Update(){
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
