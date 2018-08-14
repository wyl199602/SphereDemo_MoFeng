using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //public GameObject[] SphereAIList;
    public Dictionary<int, GameObject> SphereAIList = new Dictionary<int, GameObject>();
    //自动产生AI
    public int AiNum;    
    public GameObject SphereAIPrefab;
    public float prefabHight = .6f;
    public int[] Scope = { -10, 10 };
    
	void Start () {

        AddSphereAi();

        
    }
	
	void Update () {
		
	}
        
    void AddSphereAi() {
        if (AiNum <= 0) AiNum = 5;

        for(int i=0; i < AiNum; i++)
        {
            GameObject SphereAI = (GameObject)Instantiate(SphereAIPrefab,
                            new Vector3(Random.Range(Scope[0], Scope[1]), prefabHight, Random.Range(Scope[0], Scope[1])),
                            Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            SphereAI.name += i.ToString();
            SphereAIList.Add(i, SphereAI);
            //Debug.Log("生成AI： " + SphereAI.name);
        }

    }
}
