
using UnityEngine;

[CreateAssetMenu(fileName ="thuycau",menuName ="thuycau")]
public class Thuycau :skill
{
    public GameObject bubble;
    public override float SkillTrigger(character character)
    {
        base.SkillTrigger(character);
        switch (lv)
        {
            case 1:
                {
                    return cap1(character.Atk, character);
               
                }
            case 2:
                {
                    return cap2(character.Atk, character);

                }
            case 3:
                {
                    return cap3(character.Atk, character);
                    //break;
                }
            case 4:
                {
                    return cap4(character.Atk, character);
                   // break;
                }
            case 5:
                {
                    
                    return cap5(character.Atk, character);
                    //break;
                }
            case 6:
                {
                    return cap6(character.Atk,character);
                   // break;
                }
        }
        Debug.LogError("level khong hop le");
        return 0;
        

    }
    public float cap1(float atk, character character)
    {
        GameObject bongbong = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        //tra ve luong dmg gay ra
        return 120/100* lv * atk;
    }
    public float cap2(float atk, character character)
    {
        GameObject bongbong = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        return 130 / 100 * lv * atk;
    }
    public float cap3(float atk, character character)
    {
        GameObject bongbong = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        return 140 / 100 * lv * atk;
    }
    public float cap4(float atk, character character)
    {
        GameObject bongbong = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        return 155 / 100 * lv * atk;
    }
    public float cap5(float atk, character character)
    {
        GameObject bongbong = Instantiate(bubble, character.transform.position,Quaternion.identity);
        bongbong.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        impactskill.delay(1);
        GameObject bongbong2 = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong2.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        impactskill.delay(1);
        GameObject bongbong3 = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong3.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;

        return 155 / 100 * lv * atk +2*75/100*(155 / 100 * lv * atk);
    }
    public float cap6(float atk,character character)
    {
        GameObject bongbong = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        impactskill.delay(1);
        GameObject bongbong2 = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong2.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;
        impactskill.delay(1);
        GameObject bongbong3 = Instantiate(bubble, character.transform.position, Quaternion.identity);
        bongbong3.GetComponent<ThuycauNo>().target = character.currenttarget.gameObject.transform;

        bongbong.GetComponent<ThuycauNo>().dmg = 150 / 100 * atk;
        return 155 / 100 * lv * atk + 2 * 75 / 100 * (155 / 100 * lv * atk);
    }
}
