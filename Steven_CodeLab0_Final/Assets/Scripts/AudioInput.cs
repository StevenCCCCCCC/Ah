using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInput : MonoBehaviour
{
    public static float volume;

    AudioClip micRecord;//declare a variable to record the volume the plater input

    string device; //record the name of the device

    public int MicorphoneOrder = 0;//flexble for changing the order of the microphone
    
    
    // Start is called before the first frame update
    void Start()
    {
        device = Microphone.devices[MicorphoneOrder];//set the device to the first microphone on computer
        micRecord = Microphone.Start(device, true, 999, 44100);//record the sound input, 44100 means 44.1 Hz
    }

    // Update is called once per frame
    void Update()
    {
        volume = GetMaxVolume();
    }

    float GetMaxVolume() {

        float maxVolume = 0f;
        float[] volumeData = new float[128];//The amount of data picked from player's sound input
        int offset = Microphone.GetPosition(device) - 128 + 1;

        if (offset < 0) {
            return 0;
        }//if the data number is smaller than 128, then don't activate this function


        micRecord.GetData(volumeData, offset);//get the data from the sound input

        for(int i = 0; i < 128; i++)
        {
            float tempMax = volumeData[i];
            if(maxVolume < tempMax) {
                maxVolume = tempMax;
            }
         }//record the max sounds Input from player

        return maxVolume; //return the max volume recorded from player
    }
}
