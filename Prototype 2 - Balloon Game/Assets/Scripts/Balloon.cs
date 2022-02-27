using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int ScoreToGive = 100; 
    public int clickToPop = 3;

    public float scaleToIncrease = 0.25f;
    // Start is called before the first frame update

    public ScoreManager scoreManager; // a variable to reference the ScoreManager
    void Start()
    {
        //reference ScoreManager component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -4) {
            scoreManager.DecreaseScoreText(ScoreToGive);
            Destroy(gameObject);
        }
    }
    void OnMouseDown() {
        //reduce clicks by 1
        clickToPop -= 1;
        //change the scale
        transform.localScale += Vector3.one * scaleToIncrease;
        if (clickToPop == 0) {
            //Debug.Log("the balloon has popped");
            scoreManager.IncreaseScoreText(ScoreToGive);
            Destroy(gameObject);
        }
    }
}
