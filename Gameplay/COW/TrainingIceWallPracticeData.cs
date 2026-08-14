using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW;

[Token(Token = "0x200024D")]
public class TrainingIceWallPracticeData : _Attribute
{
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x8")]
	public uint Rule;

	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemID;

	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x10")]
	public uint GiveCount;

	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x14")]
	public float GameTime;

	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x18")]
	public uint EndGameHp;

	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x1C")]
	public uint PartChangeTime;

	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x20")]
	public float WeaponShowTime;

	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x24")]
	public int WeaponCntPerGroup;

	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x28")]
	public uint IceWallHP;

	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x2C")]
	public uint IceWallMaxNum;

	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x232BA4C", Offset = "0x232BA4C", VA = "0x232BA4C")]
	public TrainingIceWallPracticeData()
	{
	}

	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x232BA54", Offset = "0x232BA54", VA = "0x232BA54", Slot = "4")]
	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
