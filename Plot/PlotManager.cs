using UnityEngine;
using System.IO;

public class PlotManager:MonoBehaviour
{
    public string sentence;
    public string talker;
    public int chapter;
    public void loadPlot()
    {
        string path = "chuong"+chapter;
        
        FileStream datastream = new FileStream(path,FileMode.Open);
        //TextReader textReader = datastream.Read();
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