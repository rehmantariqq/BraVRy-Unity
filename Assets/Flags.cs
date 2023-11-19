using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flags : MonoBehaviour
{
    bool hasCollided;
    [SerializeField] Timer timer;
    [SerializeField] FlagDataStructure flagDataStructure; // Reference to the FlagDataStructure script

    // Assigns the reference to the FlagDataStructure script
    public void AssignFlagDataStructure(FlagDataStructure fds)
    {
        flagDataStructure = fds;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasCollided = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasCollided && flagDataStructure != null)
        {
            Debug.Log("Camera collided with " + gameObject.name);
            hasCollided = true;
            flagDataStructure.UpdateFlag(gameObject.name, timer.getTime()); // Calls method in FlagDataStructure
        }
    }
}
