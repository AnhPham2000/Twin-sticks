using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string LEVEL_KEY = "Level_Unlocked";

	public static void UnlockLevel (int level)
	{
		if (level <= SceneManager.sceneCount - 1)
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1);
	}

	public bool IsLevelUnlocked (int level)
	{
		int levelvalue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
		bool IsLevelUnlocked = (levelvalue == 1);

		if (level <= SceneManager.sceneCount - 1)
			return IsLevelUnlocked;

		return false;
	}

}