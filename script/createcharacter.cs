using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class createcharacter : MonoBehaviour
{
    public TMPro.TMP_Text currentnameclass;
    public TMPro.TMP_InputField namecharacter;
    public TMPro.TMP_Text male;
    public TMPro.TMP_Text[] detailproperties;
    public TMPro.TMP_Text detailclass;
    int Class = 0;
    public class_of_char[] nameclass;
    public string female;
    public int count_of_class = 5;
    public Sprite avatar;
    private void Start()
    {
        changeClass(0);
    }
    public void create()
    {
        //tao nhan vat 
        PlayerPrefs.SetString("name", namecharacter.text);
        PlayerPrefs.SetInt("isNewGame", 1);
        PlayerPrefs.SetInt("classofchar", Class);
        PlayerPrefs.SetInt("male", (male.text == "Nam") ? 1 : 0);
        Debug.Log(Class);

        //load scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void changeClass(int changenumber)
    {
        int temp = Class + changenumber;
        if (temp > count_of_class - 1)
        {
            Class = 0;
        }
        else if (temp < 0)
        {
            Class = count_of_class - 1;
        }
        else
        {
            Class += changenumber;
        }
        currentnameclass.text = nameclass[Class].name_class;
        detailclass.text = nameclass[Class].describetion;
        avatar = (male.text == "Nam") ? nameclass[Class].malesprite : nameclass[Class].femalesprite;
        updatedetail();
    }
    public void changeMale()
    {
        if (male.text == "Nam")
        {
            male.text = female;

        }
        else
        {
            male.text = "Nam";
        }
    }

    public void updatedetail()
    {
        //Debug.Log();


        detailproperties[0].text = nameclass[Class].power_magic.ToString();
        detailproperties[1].text = nameclass[Class].master_magic.ToString();
        detailproperties[2].text = nameclass[Class].intelligion.ToString();
        detailproperties[3].text = nameclass[Class].life.ToString();
        detailproperties[4].text = nameclass[Class].power_spirit.ToString();
        detailproperties[5].text = nameclass[Class].mastery_of_taijutsu.ToString();
    }
}
