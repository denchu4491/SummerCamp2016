using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Destroy2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Object"))
        {
            Debug.Log("collied");
            //SceneManager.LoadScene("Next");
        }
    }
}
