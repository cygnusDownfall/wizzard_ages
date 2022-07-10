
using UnityEngine;


[CreateAssetMenu(fileName = "new_class", menuName = "class")]
public class class_of_char  : ScriptableObject
{
    public skill[] skills;
    [SerializeField]
    public string name_class;
    public Sprite malesprite;
    public Sprite femalesprite;
    [TextArea] public string describetion;
    public int power_magic, master_magic, intelligion, life, power_spirit, mastery_of_taijutsu;


}









