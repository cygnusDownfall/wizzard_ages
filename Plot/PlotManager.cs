using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class PlotManager:MonoBehaviour
{
    public List<string> sentences;
    public string talkers;
    //dung de load chuong
    public int chapter;

    public TMPro.TMP_Text sentence;
    public TMPro.TMP_Text talker;

    public IEnumerable<int> loadPlot()
    {
        int numstsentences=0;
        string path = @"Assets\Plot\chuong" + chapter+".txt";

        using (StreamReader streamReader = new StreamReader(path)) {
            string line;
            while ((line =streamReader.ReadLine() )!= null)
            {
                sentences.Add(line);
                numstsentences++;
                yield return numstsentences-1;
            }
            streamReader.Close();
        }
        
        // yield return numstsentences;
    }
}
public class plotAccess
{
    public string[] tientrinhplot;
    public int currentplot = 0;
    public void next()
    {
        currentplot++;
    }
}