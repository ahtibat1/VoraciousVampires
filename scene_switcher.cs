using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_switcher : MonoBehaviour
{
    public void GoToPlayerSelectScene(){
        SceneManager.LoadScene("player_select_scene");
    }
    public void GoToMapScene(){
        SceneManager.LoadScene("map_scene");
    }
    public void GoToQuizScene(){
        SceneManager.LoadScene("quiz_scene");
    }
    public void GoToTitleScene(){
        SceneManager.LoadScene("title_scene");
    }
    public void GoToQuit()
    {
        Application.Quit();
    }
    // Help Scenes
    public void GoToHelpScene(){
        SceneManager.LoadScene("help_scene_summary");
    }
    public void GoToSummaryScene(){
        SceneManager.LoadScene("help_scene_summary");
    }
    public void GoToCreditsScene(){
        SceneManager.LoadScene("help_scene_credits");
    }
    public void GoToCharactersScene(){
        SceneManager.LoadScene("help_scene_characters_tsundere");
    }
    public void GoToTsundereScene(){
        SceneManager.LoadScene("help_scene_characters_tsundere");
    }
    public void GoToLoveleeScene(){
        SceneManager.LoadScene("help_scene_characters_lovelee");
    }
    public void GoToReginaScene(){
        SceneManager.LoadScene("help_scene_characters_regina");
    }
    public void GoToTomScene(){
        SceneManager.LoadScene("help_scene_characters_tom");
    }
    public void GoToVanityScene(){
        SceneManager.LoadScene("help_scene_characters_vanity");
    }
    public void GoToWolfieScene(){
        SceneManager.LoadScene("help_scene_characters_wolfie");
    }
    //public void GoTo
    // Game Scenes
    public void GoToGameScene(){
        SceneManager.LoadScene("game_scene");
    }
    public void GoToBedroomScene(){
        SceneManager.LoadScene("game_scene_bedroom");
    }
    public void GoToCryptScene(){
        SceneManager.LoadScene("game_scene_crypts");
    }
    public void GoToGrandHall(){
        SceneManager.LoadScene("game_scene_grand_hall");
    }
    public void GoToGraveyard(){
        SceneManager.LoadScene("game_scene_graveyard");
    }
    public void GoToKitchen(){
        SceneManager.LoadScene("game_scene_kitchen");
    }
    public void GoToStudy(){
        SceneManager.LoadScene("game_scene_study");
    }
}
