//要編集？

using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	GameObject data;

	public int scoredata;
	int        playingstage;

	void Start ()
	{
		data = GameObject.Find("MainCamera");

		playingstage = PlayerPrefs.GetInt("PlayingStage",0);
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [10] == true)
		{
			BreakCounter block = data.GetComponent<BreakCounter>();
			ItemCounter  item  = data.GetComponent<ItemCounter>();

			if (playingstage == 1)
			{
				// 最適解:2 ボーダー:12
				int blockdata = 70 - (7 * (block.breakcount - 2));  // 70点分
				int itemdata  = item.itemcount * 10;                // 30点分

				check(ref blockdata);

				scoredata = blockdata + itemdata;
			}

			if (playingstage == 2)
			{
				// 最適解:6 ボーダー:14
				int blockdata = 70 - (9 * (block.breakcount - 6));  // 70点分
				int itemdata  = item.itemcount * 10;                 // 30点分

				check(ref blockdata);

				scoredata = blockdata + itemdata;
			}

			if (playingstage == 3)
			{
				// 最適解:13 ボーダー:22
				int blockdata = 70 - (8 * (block.breakcount - 13));  // 70点分
				int itemdata  = item.itemcount * 10;                 // 30点分

				check(ref blockdata);

				scoredata = blockdata + itemdata;
			}

			if (playingstage == 4)
			{
				// 最適解:14 ボーダー:28
				int blockdata = 70 - (5 * (block.breakcount - 14));  // 70点分
				int itemdata  = item.itemcount * 10;                 // 30点分

				check(ref blockdata);

				scoredata = blockdata + itemdata;
			}

			if (playingstage == 5)
			{
				// 最適解:12 ボーダー:16
				int blockdata = 70 - (18 * (block.breakcount - 12));  // 70点分
				int itemdata  = item.itemcount * 10;                 // 30点分

				check(ref blockdata);

				scoredata = blockdata + itemdata;
			}
		}
	}

	void check (ref int blockdata)
	{
		if (blockdata < 0)
		{
			blockdata = 0;
		}

		if (70 < blockdata)
		{
			blockdata = 70;
		}
	}
}
