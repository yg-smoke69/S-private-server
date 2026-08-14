using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW;

[Token(Token = "0x200024C")]
public class TrainingGrenadePracticeData : _Attribute
{
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x8")]
	public uint Rule;

	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0xC")]
	public uint GiveItemCnt;

	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x10")]
	public uint GiveItemId;

	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x14")]
	public float GameTime;

	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x18")]
	public uint InitOccurCnt;

	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x1C")]
	public uint EndGameNeedHitCnt;

	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x20")]
	public uint HP;

	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x24")]
	public float OccurMoveTargetPerTime;

	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x28")]
	public float OccurMultiTargetPerTime;

	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x2C")]
	public uint OccurNormalCntAfterTargetDown;

	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x232B74C", Offset = "0x232B74C", VA = "0x232B74C")]
	public TrainingGrenadePracticeData()
	{
	}

	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x232B754", Offset = "0x232B754", VA = "0x232B754", Slot = "4")]
	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
