using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public Text scoreText;
    public int scoreCounter = 0;
    Vector3 yPos = Vector3.zero;
    public List<GameObject> clifs = new List<GameObject> ();
    public GameObject hala;
    public GameObject father;
    // Start is called before the first frame update
    void Start () {
        for (int i = 0; i < clifs.Count; i++)
            CloningClifs ();
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = "Score:"+scoreCounter.ToString ();

        if ((hala.transform.position.y - 10) < yPos.y) {
            scoreCounter+=1;
            father.transform.position += (Vector3.down * 5);
            CloningClifs ();
        }
    }
    void CloningClifs (int index = 0) {

        GameObject clif = Instantiate (clifs[index], yPos, Quaternion.identity);
        
        yPos.y -= 5f;

    }

}