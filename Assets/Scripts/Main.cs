using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    List<GameObject> pipeListDown;
    List<GameObject> pipeListUp;
    public GameObject prefabPipe;

    void Start()
    {
        this.pipeListDown = new List<GameObject>();
        this.Spawn();
    }
    void Update()
    {





        if (12- pipeListDown[pipeListDown.Count-1].transform.position.x > 5)
        {
             this.Spawn();
        }
    }
    void Spawn()
    {
        Camera cam = Camera.main; 

        float height = 2f * cam.orthographicSize;
        Debug.Log(this.prefabPipe.transform.localScale.y / 2);
        float width = height * cam.aspect;
        float maxPosX = (width + this.prefabPipe.transform.localScale.x) / 2;
        Quaternion rotate = transform.rotation;
        Vector2 upPos = new Vector2(maxPosX, this.prefabPipe.transform.position.y);
        GameObject pipeObjectUp = Instantiate(this.prefabPipe, upPos, rotate);
        pipeObjectUp.transform.localScale = new Vector3(1.5f, Random.Range(5, 10), transform.localScale.z);
        pipeObjectUp.SetActive(true);
        this.pipeListDown.Add(pipeObjectUp);
        Vector2  downPos = new Vector2(maxPosX, -height/2+ this.prefabPipe.transform.localScale.y/2);
        GameObject pipeObjectDown = Instantiate(this.prefabPipe, downPos, rotate);
        pipeObjectDown.transform.localScale = new Vector3(1.5f, Random.Range(5, 10), transform.localScale.z);
        pipeObjectDown.SetActive(true);
        this.pipeListDown.Add(pipeObjectDown);
    }
    // Update is called once per frame
}
