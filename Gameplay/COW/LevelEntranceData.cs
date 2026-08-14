using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000168")]
public class LevelEntranceData : CSVBaseData
{
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x8")]
	public uint EntranceId;

	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0xC")]
	public string EntranceNameKey;

	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x10")]
	public uint LockStatus;

	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x14")]
	public uint UnlockType;

	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x18")]
	public uint UnlockNum;

	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x1C")]
	public uint AnnounceLevel;

	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x20")]
	public string IconResId;

	[Token(Token = "0x6000863")]
	[Address(RVA = "0xEBC6F8", Offset = "0xEBC6F8", VA = "0xEBC6F8")]
	public LevelEntranceData()
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0xEBC77C", Offset = "0xEBC77C", VA = "0xEBC77C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0xEBC7E0", Offset = "0xEBC7E0", VA = "0xEBC7E0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
