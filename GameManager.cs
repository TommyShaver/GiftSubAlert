using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] virutalCameras;
    private AudioSource soundPlayer;
    private float timer;
    private int cameraSwitch;
    private bool startTimer;
    [SerializeField]private float[] musicHits = {
        1.2f, //Record Strach
        1.8f, // Hit 1
        2.2f, // Hit 2
        2.5f, // Hit 3
        3.1f, // Music Part
        5.3f, // Hit 4
        5.8f, // Hit 5
        6.2f, // Hit 6
        6.7f, // Music Part
        8.9f, // Hit 7
        9.3f, // Hit 8
        9.8f, // Hit 9
        10.2f, //Music Part
        11.5f, //Navi
        12.0f, //Scream
        12.4f, //Hit 10
        12.9f, //Hit 11
        13.3f, //Hit 12
        13.8f, //MusicPart
        16.0f  //Navi
    };
    private void Awake()
    {
        soundPlayer = GetComponent<AudioSource>();
    }
    private void Start()
    {
        soundPlayer.Play();
        startTimer = true;
    }
    private void Update()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
        }
        if (timer >= musicHits[cameraSwitch])
        {
            Debug.Log("Music Hit: " + musicHits[cameraSwitch]);
            cameraSwitch++;
        }
    }
}
