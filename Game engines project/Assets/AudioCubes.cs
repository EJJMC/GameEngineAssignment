using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCubes : MonoBehaviour

{
    public GameObject cubes;
    GameObject[] samplecube= new GameObject[512];

    public float maxScale;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject insSampleCube = (GameObject) Instantiate(cubes);
            insSampleCube.transform.position = this.transform.position;
            insSampleCube.transform.parent = this.transform;
            insSampleCube.name = "sampleCube" + i;
            this.transform.eulerAngles=new Vector3(0,-0.703125f * i,0);
            insSampleCube.transform.position= Vector3.forward * 100;
            samplecube[i] = insSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (samplecube != null)
            {
                samplecube[i].transform.localScale = new Vector3(10,(Audio.samples[i] * maxScale)+ 2,10);
            }
        }
    }
}
