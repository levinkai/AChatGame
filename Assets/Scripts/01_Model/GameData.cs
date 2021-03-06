﻿using UnityEngine.UI;
using System.Collections.Generic;
using System;

[System.Serializable]
public class GameData{
	private bool m_isEmilyLevelOver;
	private bool m_isGameOver;
	private bool m_isIntroductionLevelOver;

	public bool IsEmilyLevelOver{
		get { return m_isEmilyLevelOver; } 
		set { m_isEmilyLevelOver = value; } 
	}

	public bool IsGameOver{
		get { return m_isGameOver; } 
		set { m_isGameOver = value; } 
	}

	public bool IsIntroductionLevelOver{
		get { return m_isIntroductionLevelOver; }
		set { m_isIntroductionLevelOver = value; }
	}
}
