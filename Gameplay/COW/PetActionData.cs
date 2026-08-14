using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001ED")]
public class PetActionData : CSVBaseData
{
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0xC")]
	public int Type;

	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x10")]
	public float Time;

	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x14")]
	public int PetID;

	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x18")]
	public int PetLevel;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x1C")]
	public string ResourceName;

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID ActionSound;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID ActionMoodSound;

	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x28")]
	public bool IsActive;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID AnimResource;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID ActionVFX;

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x1BF9398", Offset = "0x1BF9398", VA = "0x1BF9398")]
	public PetActionData()
	{
	}

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x1BF941C", Offset = "0x1BF941C", VA = "0x1BF941C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x1BF9480", Offset = "0x1BF9480", VA = "0x1BF9480", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
