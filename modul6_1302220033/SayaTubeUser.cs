using System;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string Username;

	public SayaTubeUser(String title)
	{
		Random acak = new Random();
	}

	public int GetTotalVideoPlayCount()
	{
		int total;
		for (int i = 0; i < uploadedVideos.IncreasePlaycount(); i++)
		{
			total = total + uploadedVideos;
		}
		return total;
	}

	public void AddVideo()
	{

	}

	public void PrintAllVideoPlaycount()
	{

	}
}
