using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	GameObject data;

	public int scoredata;
	int stage = 1; //あとで消す(セーブデータ参照)

	void Start ()
	{
		data = GameObject.Find("MainCamera");
	}

	void Update ()
	{
		if (FlagManager.Instance.flags [10] == true)
		{
			BreakCounter block = data.GetComponent<BreakCounter>();
			ItemCounter  item  = data.GetComponent<ItemCounter>();

			if (stage == 1)
			{
				// 最適解:4 ボーダー:14
				int blockdata = 70 - (7 * (block.breakcount - 4));  // 70点分
				int itemdata  = item.itemcount * 10;                // 30点分

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
