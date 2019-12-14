using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour


{
    
    AudioSource audiosource;
   public static float[] samples = new float[512];

   public static float[] freqBand = new float[8];
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
    }

    void GetSpectrumAudioSource()
    {
        audiosource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void MakeFrequencyBands()
    {
        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float avarage = 0;
            int SampleCount = (int) Mathf.Pow(2, i) * 2; // if its 0 , 2 will go to the power of 0
        

        for(int j =0;  j< SampleCount; j++)
        {
            avarage += samples[count] * (count + 1);
            count++;
        }

        avarage /= count;

        freqBand[i] = avarage * 10;

        }
    }
}
