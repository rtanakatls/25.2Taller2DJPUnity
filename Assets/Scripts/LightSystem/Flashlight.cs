using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam=Camera.main;
    }

    private void Update()
    {
        Vector2 mousePosition=cam.ScreenToWorldPoint(Input.mousePosition);
        transform.up=mousePosition-(Vector2)transform.position;
    }

}
