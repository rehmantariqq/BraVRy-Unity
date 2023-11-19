using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

public class FlagDataStructure : MonoBehaviour
{
    public List<GameObject> flags;
    public Hashtable table = new Hashtable();

    void Start()
    {
        for (int i = 0; i < flags.Count; i++)
        {
            table.Add(flags[i].name, 0);
            Debug.Log(table[flags[i].name]);
        }

        // Serialize the hashtable and write it to a JSON file
        string json = JsonConvert.SerializeObject(table, Newtonsoft.Json.Formatting.Indented);
        string filePath = Path.Combine(Application.persistentDataPath, "table.json"); // Adjust the file path as needed
        File.WriteAllText(filePath, json);

        Debug.Log("Hashtable serialized and written to JSON file: " + filePath);
    }

    // Method to update the Hashtable when collision happens
    public void UpdateFlag(string flagName, int time)
    {
        if (table.ContainsKey(flagName))
        {
            table[flagName] = time;
            Debug.Log("Updated value for " + flagName + ": " + table[flagName]);

            // Update and rewrite the JSON file after updating the table
            string json = JsonConvert.SerializeObject(table, Newtonsoft.Json.Formatting.Indented);
            string filePath = Path.Combine(Application.persistentDataPath, "table.json"); // Adjust the file path as needed
            File.WriteAllText(filePath, json);

            Debug.Log("Hashtable updated and rewritten to JSON file: " + filePath);
        }
    }
}
