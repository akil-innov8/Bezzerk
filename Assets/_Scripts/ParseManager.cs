using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Parse;

public class ParseManager : MonoBehaviour {
	public List<string> Words,Easy,Medium,Hard;
	// Use this for initialization
	void Start () {
//		ParseObject testObject = new ParseObject("UnityObject");
//		testObject["UserName"] = "Akil";
//		testObject.SaveAsync();



		//StartCoroutine("RetrieveData");
	
		GetEasyWords();

		//GetWords();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator RetrieveData(){



		var query = ParseObject.GetQuery("UnityObject").WhereExists("UserName");
		query.FindAsync().ContinueWith(t =>
		                               {
			IEnumerable<ParseObject> results = t.Result;
			foreach (var result in results) {
				Debug.Log("Name: " + result["UserName"]);
			}
		});


		yield return null;

	}


	void GetEasyWords(){
		var query = ParseObject.GetQuery("NewDictionary").WhereExists("type");
		query.FindAsync().ContinueWith(t =>
		                               {
			IEnumerable<ParseObject> results = t.Result;
			foreach (var result in results) {
				Words.Add(result["Word"].ToString());

				if(result["type"].ToString()=="E")
					Easy.Add(result["Word"].ToString());
			}
		});
	}

	void GetWords(){
		var query = ParseObject.GetQuery("Dictionary").WhereExists("Level");
		query.FindAsync().ContinueWith(t =>
		                               {
			IEnumerable<ParseObject> results = t.Result;
			foreach (var result in results) {
				
				if(result["Level"].ToString()=="23")
					Words.Add(result["Word"].ToString());
			}
		});
	}
}
