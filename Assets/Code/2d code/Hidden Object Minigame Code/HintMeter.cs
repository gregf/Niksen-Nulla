using UnityEngine;

public class HintMeter : MonoBehaviour
{
    #region variables
    public float rb = 1f;
    public float colourTimer = 0;

    public static string hintReady = "n";
    public static string hintUsed = "n";

    public Transform hintGlow;

    #endregion variables

    [System.Obsolete]
    void Start()
    {
        hintGlow.GetComponent<ParticleSystem>().enableEmission = false;
    }

    [System.Obsolete]
    void Update()
    {
        colourTimer += Time.deltaTime;

        if ((colourTimer >= .5) && (rb > 0)){
            rb -= .01f;
            colourTimer = 0;
        }

        GetComponent<SpriteRenderer>().color = new Color (rb, 1, rb);
        if(rb <= 0){
            hintReady = "y";
            hintGlow.GetComponent<ParticleSystem>().enableEmission = true;
        }
    }

    [System.Obsolete]
    void OnMouseDown()
    {
        if(hintReady == "y"){
            hintUsed = "y";
            hintReady = "n";
            rb = 1f;
             hintGlow.GetComponent<ParticleSystem>().enableEmission = false;
        }
    }

}
