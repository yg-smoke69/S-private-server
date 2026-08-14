using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B5")]
public class MysteryBonusDesc
{
	[Token(Token = "0x400A11B")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A11C")]
	[FieldOffset(Offset = "0xC")]
	public uint paid_level;

	[Token(Token = "0x400A11D")]
	[FieldOffset(Offset = "0x10")]
	public uint bonus_max;

	[Token(Token = "0x400A11E")]
	[FieldOffset(Offset = "0x14")]
	public string start_time;

	[Token(Token = "0x400A11F")]
	[FieldOffset(Offset = "0x18")]
	public string end_time;

	[Token(Token = "0x400A120")]
	[FieldOffset(Offset = "0x1C")]
	public uint start_time_stamp;

	[Token(Token = "0x400A121")]
	[FieldOffset(Offset = "0x20")]
	public uint end_time_stamp;

	[Token(Token = "0x400A122")]
	[FieldOffset(Offset = "0x24")]
	public uint pool_id;

	[Token(Token = "0x400A123")]
	[FieldOffset(Offset = "0x28")]
	public uint probability_id;

	[Token(Token = "0x600800D")]
	[Address(RVA = "0x30A94D0", Offset = "0x30A94D0", VA = "0x30A94D0")]
	public MysteryBonusDesc()
	{
	}
}
