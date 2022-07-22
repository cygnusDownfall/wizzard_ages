
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public character player;
    public void savegame(int key)
    {
        DataSaving data = new DataSaving();
        SaveSystem.save(data,key);
    }
    public void loadgame(int key)
    {
        DataSaving data = SaveSystem.load(key);

        player.namecharacter = data.namecharacter;
        player.level = data.lv;
        player.plot.currentplot = data.plot;

        player.maxHP = data.life * 100 * data.lv;
        player.maxMP = (data.power_magic * 10 + data.power_spirit * 20) * data.lv;
        player.HP = data.HP;
        player.MP = data.MP;
        player.Atk = data.Atk;
        player.Def = data.Def;

        player.power_magic = data.power_magic;
        player.power_spirit = data.power_spirit;
        player.mastery_taijutsu = data.mastery_taijutsu;
        player.master_magic = data.master_magic;
        player.life = data.life;
        player.intelligion = data.intelligion;

        player.transform.position = new Vector3(data.potitions[0], data.potitions[1], data.potitions[2]);
    }
    public void backtomenu()
    {
        SceneManager.LoadScene(0);
    }
    public void playgame()
    {
        SceneManager.LoadScene(1);
    }



   

}
