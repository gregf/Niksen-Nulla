using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickControl : MonoBehaviour
{
    private const int V = 5;
    public static string nameOfObj;
    public GameObject objNameText;
    public static int remainingItenms = 7;
    
    public Transform objNameTextPos;
    public Transform successClick;

    public int randNumb = 0;


    void Update()
    {
        if (HintMeter.hintUsed == "y")
        {
            randNumb = Random.Range(1, 8);

            if ((gameObject.name == "megaphone") && (randNumb == 1)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }

            if ((gameObject.name == "cd player") && (randNumb == 2)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }

            if ((gameObject.name == "uk flag") && (randNumb == 3)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }

            if ((gameObject.name == "gpu vinyl") && (randNumb == 4)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }

            if ((gameObject.name == "tree vinyl") && (randNumb == 5)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }

            if ((gameObject.name == "cowboy") && (randNumb == 6)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }

            if ((gameObject.name == "indian") && (randNumb == 7)){
                GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
                HintMeter.hintUsed = "n";
            }
        }
            
    }

    void OnMouseDown()
    {
        nameOfObj = gameObject.name;
        Destroy(gameObject);
        Destroy(objNameText);
        remainingItenms -= 1;
        if (remainingItenms <= 0){
            Debug.Log("geia sas");
            Action();
        }
        TrakingClicks.totalClicks = 0;
        Instantiate(successClick, objNameTextPos.position, successClick.rotation);
    }

    private void Action(){
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
