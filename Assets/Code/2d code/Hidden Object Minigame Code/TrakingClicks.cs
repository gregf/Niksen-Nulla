using UnityEngine;
using UnityEngine.SceneManagement;

public class TrakingClicks : MonoBehaviour
{
    public static int totalClicks = 0;
    public KeyCode mouseClicks;


    void Update()
    {

        if (Input.GetKeyDown (mouseClicks)){
            totalClicks += 1;
        }

        if (totalClicks >= 10){
            Debug.Log ("fail");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
            totalClicks = 0;
        }
    }
}
