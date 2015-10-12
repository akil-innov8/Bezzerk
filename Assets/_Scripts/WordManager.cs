using UnityEngine;
using System.Collections;

public class WordManager : MonoBehaviour {
	public string word;
	public GameObject LetterPrefab;
	// Use this for initialization
	void Start () {
		//Invoke("Create",1);
		word = "Doctor";
		word = word.ToUpper();

		Create();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Create(){

		for(int i=0;i<word.Length;i++){
			GameObject go = NGUITools.AddChild(gameObject, LetterPrefab);
			go.GetComponent<UILabel>().text=word[i].ToString();
			go.BroadcastMessage("CreatePanel");
			GetComponent<UIGrid>().Reposition();

			go.GetComponent<CreateLetter>().letter=word[i].ToString();
			go.GetComponent<CreateLetter>().Create();

		}
	}
}
