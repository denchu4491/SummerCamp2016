using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    private float time = 120;
    public GameObject gameFinishText;
	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = ((int)time).ToString();
}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time < 0) {
            time = 0;
            SceneManager.LoadScene("Main");
        }
        GetComponent<Text>().text = ((int)time).ToString();
    }
}
