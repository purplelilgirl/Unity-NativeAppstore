package com.purplelilgirl.nativeappstore;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;

import com.unity3d.player.UnityPlayer;

public class NativeAppstore 
{
	private Activity activity;
	
	public NativeAppstore()
	{	activity = UnityPlayer.currentActivity;
	}
	
	public void OpenInAppStore(final String url)
	{	
		activity.runOnUiThread(new Runnable() 
		{	public void run()
			{	
				Intent intent = new Intent(Intent.ACTION_VIEW);
				intent.setData(Uri.parse(url));
				activity.startActivity(intent);
			}
		});
	}
}
