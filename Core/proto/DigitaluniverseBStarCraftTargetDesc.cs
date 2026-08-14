using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C1B")]
public class DigitaluniverseBStarCraftTargetDesc
{
	[Token(Token = "0x400B0EA")]
	[FieldOffset(Offset = "0x8")]
	public uint target_id;

	[Token(Token = "0x400B0EB")]
	[FieldOffset(Offset = "0xC")]
	public uint target_value;

	[Token(Token = "0x400B0EC")]
	[FieldOffset(Offset = "0x10")]
	public uint number_of_people;

	[Token(Token = "0x400B0ED")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc award;

	[Token(Token = "0x6008275")]
	[Address(RVA = "0x309EDA0", Offset = "0x309EDA0", VA = "0x309EDA0")]
	public DigitaluniverseBStarCraftTargetDesc()
	{
	}
}
