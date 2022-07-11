using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class PlotManager : MonoBehaviour
{
    public List<string> sentences;
    //dung de load chuong
    public int chapter;

    public TMPro.TMP_Text sentence;
    public TMPro.TMP_Text talker;

    public void loadPlot()
    {
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
        bool istalker = true;
        for ( int i = 0,n = sentences[indexsentence].Length; i < n; i++)
        {
            if (sentences[indexsentence][i] == ':')
            {
                istalker = false;
            }
            if (istalker)
            {
                talker.text += sentences[indexsentence][i];
            }else
            {
                sentence.text+= sentences[indexsentence][i];
            }
           
        }
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