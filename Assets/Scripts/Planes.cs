using UnityEngine;

[CreateAssetMenu(fileName = "Planes", menuName = "Scriptable Objects/Plane")]
public class Planes : ScriptableObject{
    public Plane[] planes;

    public int count(){
        return planes.Length;
    }
    public Plane getPlane(int i){
        return planes[i]; ;
    }
}
