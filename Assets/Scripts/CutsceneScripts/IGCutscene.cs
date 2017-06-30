using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

//stands for In Game Cutscene
public class IGCutscene {
    private string[][] script;

    public void loadScript (string path) {

        try {
            using (StreamReader sr = new StreamReader(path)) {
                string line = sr.ReadLine();
                string temp = "";
                int length;
                Int32.TryParse(line, out length);
                script = new string[length][];//create array using length read from first line of script.
                while (sr.Peek() >= 0) {//1 line per loop
                    line = sr.ReadLine();

                }
            }
        }
        catch (Exception e) {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

    }
	
}
