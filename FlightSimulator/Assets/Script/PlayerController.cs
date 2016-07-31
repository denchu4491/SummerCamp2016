using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    /*変位を管理する変数*/
    private float x, y, z;

	// Use this for initialization
	void Start () {
        initDisplacement();
	}
	
	// Update is called once per frame
	void Update () {
        /*上下の判定*/
		if (Input.GetKey (KeyCode.UpArrow))
        {
            x = -0.2f;
            y = 0.0f;
        }
        else if (Input.GetKey (KeyCode.DownArrow))
        {
            x = 0.2f;
            y = 0.0f;
        }
        transform.Rotate(x, y, 0, Space.Self);

        /*shiftキーが押されていたら加速する*/
        if (Input.GetKey(KeyCode.LeftShift))
        {
            z = 2.0f;
        }
        else
        {
            z = 0.1f;
        }
        transform.Translate(0, 0, z, Space.Self);
        initDisplacement();

        /*右旋回・左旋回の判定*/
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = 0.0f;
            y = -0.2f;
            z = 0.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 0.0f;
            y = 0.2f;
            z = 0.0f;
        }
        else
        {
            transform.localEulerAngles.Set(0f, 0f, 0f);
        }
        transform.Rotate(x, y, z, Space.Self);
        initDisplacement();
    }

    /*変位の初期化*/
    private void initDisplacement()
    {
        x = 0.0f;
        y = 0.0f;
        z = 0.0f;
    }

}
