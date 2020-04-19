using UnityEngine;
using System.Collections;

public class PlayRandomSounds : MonoBehaviour {

    public AudioClip[] sounds;

    public float minInterval = 5f;
    public float maxInterval = 10f;

    float timer;
    float interval;

    AudioSource[] sources;

    // Use this for initialization
    void Start() {
        interval = Random.Range(minInterval, maxInterval);

        sources = GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;

        if (timer >= interval) {
            int randomSource = Random.Range(0, sources.Length);

            sources[randomSource].clip = sounds[Random.Range(0, sounds.Length)];
            sources[randomSource].Play();
            interval = Random.Range(minInterval, maxInterval);
            timer = 0;
        }
    }
}
