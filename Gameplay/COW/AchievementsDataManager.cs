using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D99")]
public class AchievementsDataManager : SingletonModule<AchievementsDataManager>
{
	[Token(Token = "0x4011808")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, AchievementData> m_AchievementsDict;

	[Token(Token = "0x6013173")]
	[Address(RVA = "0x14B83A4", Offset = "0x14B83A4", VA = "0x14B83A4")]
	public AchievementsDataManager()
	{
	}

	[Token(Token = "0x6013174")]
	[Address(RVA = "0x14B8468", Offset = "0x14B8468", VA = "0x14B8468", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013175")]
	[Address(RVA = "0x14B86B4", Offset = "0x14B86B4", VA = "0x14B86B4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013176")]
	[Address(RVA = "0x14B877C", Offset = "0x14B877C", VA = "0x14B877C")]
	public AchievementData FindAchievementDataByID(int id)
	{
		return null;
	}

	[Token(Token = "0x6013177")]
	[Address(RVA = "0x14B8874", Offset = "0x14B8874", VA = "0x14B8874")]
	public AchievementData GetTopPriorityAchievementData(uint[] achievementList)
	{
		return null;
	}
}
