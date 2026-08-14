using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002523")]
public class SkillInfo
{
	[Token(Token = "0x400E64E")]
	[FieldOffset(Offset = "0x8")]
	public uint skillID;

	[Token(Token = "0x400E64F")]
	[FieldOffset(Offset = "0xC")]
	public bool isEquiped;

	[Token(Token = "0x400E650")]
	[FieldOffset(Offset = "0xD")]
	public bool nwEquiped;

	[Token(Token = "0x400E651")]
	[FieldOffset(Offset = "0x10")]
	public int slotID;

	[Token(Token = "0x400E652")]
	[FieldOffset(Offset = "0x14")]
	public int skillLevel;

	[Token(Token = "0x400E653")]
	[FieldOffset(Offset = "0x18")]
	public int skillColor;

	[Token(Token = "0x400E654")]
	[FieldOffset(Offset = "0x1C")]
	public bool avaviable;

	[Token(Token = "0x600D7E6")]
	[Address(RVA = "0x20F0004", Offset = "0x20F0004", VA = "0x20F0004")]
	public SkillInfo()
	{
	}
}
