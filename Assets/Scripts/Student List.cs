using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class StudentList :  MonoBehaviour{
	float [] lab1Grade = new float[100];
	float[] lab2Grade = new float[100];
	float[] lab3Grade = new float[100];
	string[] studentName = new string[100];

	studentName[0] = "John Smith";
	studentName[1] = "Andrew Wilson";
	studentName[2] = "Timothy Anderson";
	studentName[3] = "Jason Lee";
	studentName[4] = "Jessica Lewis";
	studentName[5] = "Abbey Ryan";

	lab1Grade[0] = 84;
	lab1Grade[1] = 66;
	lab1Grade[2] = 92;
	lab1Grade[4] = 75;
	lab1Grade[5] = 80;

	lab2Grade[0] = 97;
	lab2Grade[1] = 85;
	lab2Grade[2] = 88;
	lab2Grade[4] = 71;
	lab2Grade[5] = 76;

	lab3Grade[0] = 67;
	lab3Grade[1] = 77;
	lab3Grade[2] = 91;
	lab3Grade[4] = 55;
	lab3Grade[5] = 100;


}
