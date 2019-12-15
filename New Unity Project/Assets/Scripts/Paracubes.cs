using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paracubes : MonoBehaviour
{
    public int band;

    public float startscale, startmultiplyer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale=new Vector3(transform.localScale.x,(Audio.freqBand[band] * startmultiplyer)+ startscale,transform.localScale.z);
    }
}
