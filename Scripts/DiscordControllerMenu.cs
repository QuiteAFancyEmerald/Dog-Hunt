using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordControllerMenu : MonoBehaviour
{

	public Discord.Discord discord;

	// Use this for initialization
	void Start()
	{
		discord = new Discord.Discord(758714048115245077, (System.UInt64)Discord.CreateFlags.Default);
		var activityManager = discord.GetActivityManager();
		var activity = new Discord.Activity
		{
			State = "",
			Details = "In Main Menu"
		};
		activityManager.UpdateActivity(activity, (res) =>
		{
			if (res == Discord.Result.Ok)
			{
				Debug.LogError("Menu okay!");
			}
		});
	}

	// Update is called once per frame
	void Update()
	{
		discord.RunCallbacks();
	}

}
