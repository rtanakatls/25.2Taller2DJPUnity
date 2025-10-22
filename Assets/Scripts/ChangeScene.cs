using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadingScreen.Instance.LoadScene(sceneName);
        }   
    }
}
