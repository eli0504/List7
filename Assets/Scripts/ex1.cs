using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    public GameObject cubePrefab;
    
    //Random position
    public int xRandom = 5;
    public int yRandom = 3;
    public int zRandom = 6;
    void Start()
    {
        for(int i = 0; i<=10; i++) //a for loop for instantiate 10 cubes
        {
            xRandom = Random.Range(-5, 5);
            yRandom = Random.Range(-3, 3);
            zRandom = Random.Range(-6, 6);
            Vector3 pos = new Vector3(xRandom, yRandom, zRandom);
            GameObject inst = Instantiate(cubePrefab, pos, Quaternion.identity);
            inst.transform.localScale = Vector3.one * Random.Range(2, 8); //random scale
        }
    }
}
