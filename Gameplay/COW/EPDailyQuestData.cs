using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200011C")]
public class EPDailyQuestData : CsvDataIndexedReading
{
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x8")]
	public string ChallengeDesc;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0xC")]
	public uint QuestId;

	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x10")]
	public uint TargetValue;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x14")]
	public uint TargetValue2;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x18")]
	public byte CountType;

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x1C9D950", Offset = "0x1C9D950", VA = "0x1C9D950")]
	public EPDailyQuestData()
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x1C9D958", Offset = "0x1C9D958", VA = "0x1C9D958", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x1C9D9BC", Offset = "0x1C9D9BC", VA = "0x1C9D9BC", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x1C9E068", Offset = "0x1C9E068", VA = "0x1C9E068", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x1C9E530", Offset = "0x1C9E530", VA = "0x1C9E530")]
	public static void GetDailyData(out List<EPDailyQuestData> dailyQuestLst)
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x1C9E770", Offset = "0x1C9E770", VA = "0x1C9E770")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x1C9E778", Offset = "0x1C9E778", VA = "0x1C9E778")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
