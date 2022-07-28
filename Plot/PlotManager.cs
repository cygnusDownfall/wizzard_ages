using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class PlotManager : MonoBehaviour
{
    public GameObject plotUI;
    public List<string> sentences;
    //dung de load chuong
    public int chapter;
    public int currentSentence;
    public TMPro.TMP_Text sentence;
    public TMPro.TMP_Text talker;

    public void loadPlot()
    {
        sentences.Clear();
        string path = @"Assets\Plot\chuong" + chapter + ".txt";

        using (StreamReader streamReader = new StreamReader(path))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                sentences.Add(line);


            }
            streamReader.Close();
        }
    }
    public void showDialog(int indexsentence)
    {
        int n = sentences[indexsentence].Length;
        currentsentence(n);
        plotUI.SetActive(true);
        bool istalker = true;
        for ( int i = 0; i < n; i++)
        {
            if (sentences[indexsentence][i] == ':')
            {
                istalker = false;
                continue;
            }
            if (istalker)
            {
                talker.text+= sentences[indexsentence][i];
            }else
            {
                sentence.text+= sentences[indexsentence][i];
            }
           
        }
        
    }
    IEnumerable<int> currentsentence(int max)
    {
        for(int i = 0; i < max; i++) 
        yield return i;
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