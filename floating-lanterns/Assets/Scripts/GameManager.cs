using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // VARIABLES
    public GameObject prefab;
    public GameObject player;
    GameObject lantern;

    public AudioClip[] sounds;
    AudioSource audioSource;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lantern = Instantiate(prefab, player.transform.position + (player.transform.forward * Random.Range(8, 20)), Quaternion.identity, this.transform) as GameObject;

            audioSource = lantern.AddComponent<AudioSource>();

            audioSource.clip = RandomClip();
            audioSource.loop = true;
            audioSource.volume = 0.6f;
            audioSource.spatialBlend = 1f;

            audioSource.Play();
        }
    }

    AudioClip RandomClip()
    {
        return sounds[Random.Range(0, sounds.Length - 1)];
    }
}
