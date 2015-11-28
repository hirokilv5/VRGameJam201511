using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour {
	
	public Transform Target_Pos;
	/*カメラの中心点*/
	public Vector3 Height = new Vector3(0f, 0.5f, 0f);
	
	/*マウス移動量感度*/
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	
	/*Y軸カメラ方向制限*/
	public float minimumY = -60F;
	public float maximumY = 60F;
	
	/*カメラ回転量変数*/
	float rotationX = 0F;
	float rotationY = 0F;

	// Stageのメソッドを呼び出すのに使います
	public Stage stage;

	// 引数に使います
	bool seting;
	public GameObject obj = null;
	// Use this for initialization
	void Start () {
		//		camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
    void Update()
    {
		// マウスでオブジェクトの情報を取得
		//  Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit ();
		if (Physics.Raycast(Height, Camera.main.transform.forward, out hit)) {
			if(obj == hit.collider.gameObject){

            }
            else
            {
                if (obj != null)
                {
                    Debug.Log("ho");
                    stage.Lighting(obj, false);
                }

                obj = hit.collider.gameObject;

                // setingをtrueにします
                seting = true;
                stage.Lighting(obj, seting);

                Debug.Log(obj.name);
            }

				
		}
		// ここまで

		/*カメラ方向移動慮*/
		rotationX = Input.GetAxis ("Mouse X") * sensitivityX;
		rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
		/*X軸カメラ方向処理*/
		this.transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityX, 0);
		/*y軸カメラ方向制限処理*/
		rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
		
		/*Y軸カメラ歩行処理*/
		this.transform.localEulerAngles = new Vector3 (-rotationY, transform.localEulerAngles.y, 0);
	}
	
	void LateUpdate(){
		if (Target_Pos)
			this.transform.position = Target_Pos.position + Height;
		
	}
}
