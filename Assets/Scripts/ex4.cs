using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public GameObject cubePrefab;

    private void Start()
    {
        StartCoroutine("Position");
    }

    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(2,1,0);

    }
  
    public IEnumerator Position()
    {
        for(int i = 0; i <= 10; i++)
        {
            yield return new WaitForSeconds(2);
          
            Vector3 pos = new Vector3(2,1,0);
            GameObject inst = Instantiate(cubePrefab, pos, Quaternion.identity);
        }
    }

}
