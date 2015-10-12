using UnityEngine;
using System.Collections;

public class CreateLetter : MonoBehaviour {
	public string letter,letters;
	public string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	public GameObject ChoiceGrid,ChoicePrefab;
	int start,end;
	// Use this for initialization
	void Start () {
		//Create();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Create(){


		switch(letter){
			case "A":
			case "B":
			case "C":
			{
				start=0;
				end=2;
				break;
			}

			case "D":
			case "E":
			case "F":
			{
				start=3;
				end=5;
				break;
			}

			case "G":
			case "H":
			case "I":
			{
				start=6;
				end=8;
				break;
			}

			case "J":
			case "K":
			case "L":
			{
				start=9;
				end=11;
				break;
			}

			case "M":
			case "N":
			case "O":
			{
				start=12;
				end=14;
				break;
			}

			case "P":
			case "Q":
			case "R":
			case "S":
			{
				start=15;
				end=18;
				break;
			}

			case "T":
			case "U":
			case "V":
			{
				start=19;
				end=21;
				break;
			}

			case "W":
			case "X":
			case "Y":
			case "Z":
			{
				start=22;
				end=25;
				break;
			}

			default:
				break;	
		}

		for(int i=start;i<end+1;i++){
			GameObject go = NGUITools.AddChild(ChoiceGrid, ChoicePrefab);
			go.GetComponent<UILabel>().text=alphabets[i].ToString();
			go.BroadcastMessage("CreatePanel");
			ChoiceGrid.GetComponent<UIGrid>().Reposition();
		}


	}
}
