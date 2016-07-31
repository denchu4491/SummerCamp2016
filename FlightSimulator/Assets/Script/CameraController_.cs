using UnityEngine;
using System.Collections;

public class CameraController_ : MonoBehaviour {

    //playerを追従するカメラの制御

    private GameObject player = null;
    private Vector3 offset = Vector3.zero;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    void Update()
    {

    }
    
    
	void LateUpdate ()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.transform.position.x + offset.x;
        newPosition.y = player.transform.position.y + offset.y;
        newPosition.z = player.transform.position.z + offset.z;
	}
}
