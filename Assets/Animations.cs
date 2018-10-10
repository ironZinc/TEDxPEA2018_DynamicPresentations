using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {

	public GameObject Pos2_1;
	public GameObject Pos2_2;
	public GameObject Pos2_3;
	public GameObject Pos2_4;
	public GameObject Pos2_5;
	public GameObject Pos6_1;
	public GameObject Pos6_2;

	public GameObject vid;


	public int count = 0;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S))
		{
			count += 1;
			animations();
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			count -= 1;
			animations();
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			UnityEngine.Video.VideoPlayer vp = vid.GetComponent<UnityEngine.Video.VideoPlayer>();
			vp.frame = 0;
		}
	}

	void animations()
	{
		if(count == 0)
		{
			Pos2_1.SetActive(true);
			Pos2_2.SetActive(false);
			Pos2_3.SetActive(false);
			Pos2_4.SetActive(false);
			Pos2_5.SetActive(false);
			//vid.SetActive(false);
		}else if(count == 1){
			Pos2_1.SetActive(true);
			Pos2_2.SetActive(true);
			Pos2_3.SetActive(false);
			Pos2_4.SetActive(false);
			Pos2_5.SetActive(false);
			//vid.SetActive(false);
		}else if(count == 2){
			Pos2_1.SetActive(true);
			Pos2_2.SetActive(true);
			Pos2_3.SetActive(true);
			Pos2_4.SetActive(false);
			Pos2_5.SetActive(false);
			//vid.SetActive(false);
		}else if(count == 3){
			Pos2_1.SetActive(true);
			Pos2_2.SetActive(true);
			Pos2_3.SetActive(true);
			Pos2_4.SetActive(true);
			Pos2_5.SetActive(false);
			//vid.SetActive(false);
		}else if(count == 4){
			Pos2_1.SetActive(false);
			Pos2_2.SetActive(false);
			Pos2_3.SetActive(false);
			Pos2_4.SetActive(false);
			Pos2_5.SetActive(true);
			//vid.SetActive(false);
		}else if(count == 5){
			Pos6_1.SetActive(false);
			Pos6_2.SetActive(true);
		}
	}
}
