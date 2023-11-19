using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.IO;

public class RunPython : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        var psi = new ProcessStartInfo();
        psi.FileName = @"C:\Users\rehma\AppData\Local\Programs\Python\Python311\python.exe";
        var script = @"C:\Users\rehma\Downloads\muse_code\muse_ppg_script.py";
        psi.Arguments = script; // Set the Python script as an argument

        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;

        // Specify paths for output and error files
        string outputPath = @"C:\Users\rehma\Downloads\output.txt";
        string errorPath = @"C:\Users\rehma\Downloads\error.txt";

        // Redirect output and error to files
        psi.StandardOutputEncoding = System.Text.Encoding.UTF8;
        psi.StandardErrorEncoding = System.Text.Encoding.UTF8;
        psi.StandardOutput = new StreamWriter(outputPath);
        psi.StandardError = new StreamWriter(errorPath);

        using (var process = Process.Start(psi))
        {
            process.WaitForExit(); // Wait for the process to complete
        }

        UnityEngine.Debug.Log("Process completed. Check output and error files for details: " + outputPath + ", " + errorPath);
        */
    }

    // Update is called once per frame
    void Update()
    {

    }
}
