using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour {
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int buildingFootpringt = 12;
    void Start() {
        float seed = 69;// UnityEngine.Random.Range(0, 100);
        for(int i = 0; i < mapHeight; i++) {
            for(int j = 0; j < mapWidth; j++) {
                int result = (int)(Mathf.PerlinNoise(j/10.0f + seed, i/10.0f + seed) * 10);
                Vector3 pos = new Vector3(j * buildingFootpringt, 0, i * buildingFootpringt);
                if(result < 2) {
                    Instantiate(buildings[0], pos, Quaternion.identity);
                }
                else if(result > 2 && result < 4) {
                    Instantiate(buildings[1], pos, Quaternion.identity);
                }
                else if (result > 4 && result < 6) {
                    Instantiate(buildings[2], pos, Quaternion.identity);
                }
                else if ( result > 6 && result < 8) {
                    Instantiate(buildings[3], pos, Quaternion.identity);
                }
                else if (result > 8 && result < 9) {
                    Instantiate(buildings[4], pos, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
