using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainScript : MonoBehaviour {

    public GameObject coin;
    public int score;
    private List<GameObject> maps = new List<GameObject>();

	// Use this for initialization
	void Start () {
        var res = Resources.LoadAll("Map");

        foreach (GameObject GO in res)
            maps.Add(GO);

        var selectedMap = maps[Random.Range(0, maps.Count)];

        Instantiate(selectedMap, new Vector2(2.2f, 0), transform.rotation);

        InvokeRepeating("CoinSpawn", 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CoinSpawn()
    {
        Instantiate(coin, new Vector2(Random.Range(-7, 7), Random.Range(-2.8f, 4.3f)), transform.rotation);
    }
}
