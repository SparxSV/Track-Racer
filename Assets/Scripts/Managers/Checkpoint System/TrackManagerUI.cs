﻿using System;

using UnityEditor.Search;

using UnityEngine;

namespace Managers.Checkpoint_System
{
	public class TrackManagerUI : MonoBehaviour
	{
		[SerializeField] private TrackManager trackManager;
		
		private void Start()
		{
			trackManager.onPlayerCorrectCheckpoint += TrackManager_OnPlayerCorrectCheckpoint;
			trackManager.onPlayerWrongCheckpoint += TrackManager_OnPlayerWrongCheckpoint;
		}

		private void TrackManager_OnPlayerWrongCheckpoint(object _sender, System.EventArgs _e) => Show();

		private void TrackManager_OnPlayerCorrectCheckpoint(object _sender, System.EventArgs _e) => Hide();

		private void Show() => gameObject.SetActive(true);

		private void Hide() => gameObject.SetActive(false);
	}
}