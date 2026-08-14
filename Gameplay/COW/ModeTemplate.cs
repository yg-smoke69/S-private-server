using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200027C")]
internal class ModeTemplate
{
	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x8")]
	public uint modeType;

	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0xC")]
	public uint templateID;

	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x2281808", Offset = "0x2281808", VA = "0x2281808")]
	public ModeTemplate()
	{
	}

	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x2281810", Offset = "0x2281810", VA = "0x2281810")]
	public ModeTemplate(uint type, uint tID)
	{
	}

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x2281838", Offset = "0x2281838", VA = "0x2281838", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x22818A0", Offset = "0x22818A0", VA = "0x22818A0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x22819A8", Offset = "0x22819A8", VA = "0x22819A8")]
	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x22819B0", Offset = "0x22819B0", VA = "0x22819B0")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}
}
