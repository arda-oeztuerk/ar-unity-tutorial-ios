using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // For Pointer events

public class MultiObjectInteraction : MonoBehaviour
{
    public List<GameObject> objects; // List of 3D objects
    public List<AudioClip> audioClips; // Corresponding audio clips
    public Button switchButton, rotateButton, soundButton; // UI buttons
    private AudioSource audioSource;

    private int currentIndex = 0; // Tracks the active object
    private bool isRotating = false; // Tracks if rotation is active
    private bool isSoundPlaying = false; // Tracks sound playback state

    public float rotationSpeed = 45f; // Speed of rotation

    void Start()
    {
        // Initialize audio source
        audioSource = gameObject.AddComponent<AudioSource>();

        // Assign button actions
        switchButton.onClick.AddListener(SwitchToNextObject);
        soundButton.onClick.AddListener(ToggleSound);

        // Add rotation events
        EventTrigger trigger = rotateButton.gameObject.AddComponent<EventTrigger>();

        // PointerDown for starting rotation
        EventTrigger.Entry pointerDownEntry = new EventTrigger.Entry
        {
            eventID = EventTriggerType.PointerDown
        };
        pointerDownEntry.callback.AddListener((data) => ToggleRotation(true));
        trigger.triggers.Add(pointerDownEntry);

        // PointerUp for stopping rotation
        EventTrigger.Entry pointerUpEntry = new EventTrigger.Entry
        {
            eventID = EventTriggerType.PointerUp
        };
        pointerUpEntry.callback.AddListener((data) => ToggleRotation(false));
        trigger.triggers.Add(pointerUpEntry);

        UpdateActiveObject(); // Ensure only the first object is active
    }

    void Update()
    {
        // Handle continuous rotation
        if (isRotating && objects[currentIndex] != null)
        {
            objects[currentIndex].transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }

    public void SwitchToNextObject()
    {
        // Stop sound when switching objects
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            isSoundPlaying = false;
        }

        // Deactivate current object
        if (objects[currentIndex] != null)
        {
            objects[currentIndex].SetActive(false);
        }

        // Move to the next object
        currentIndex = (currentIndex + 1) % objects.Count;

        // Update active object
        UpdateActiveObject();
    }

    public void ToggleRotation(bool state)
    {
        // Toggle rotation state when button is pressed or released
        isRotating = state;
    }

    public void ToggleSound()
    {
        if (audioSource == null || currentIndex >= audioClips.Count || audioClips[currentIndex] == null)
        {
            Debug.LogWarning("Missing AudioSource or AudioClip");
            return;
        }

        if (!isSoundPlaying) // Play sound
        {
            audioSource.clip = audioClips[currentIndex];
            audioSource.Play();
            isSoundPlaying = true;
            Debug.Log("Sound started");
        }
        else // Stop sound
        {
            audioSource.Stop();
            isSoundPlaying = false;
            Debug.Log("Sound stopped");
        }
    }



    public void UpdateActiveObject()
    {
        // Activate only the current object
        for (int i = 0; i < objects.Count; i++)
        {
            objects[i].SetActive(i == currentIndex);
        }
    }
}







