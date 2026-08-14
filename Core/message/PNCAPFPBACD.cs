using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001251")]
internal class PNCAPFPBACD : UDPClientMessageBase
{
	[Token(Token = "0x40080F2")]
	[FieldOffset(Offset = "0xC")]
	public uint CMEKDNHLCGK;

	[Token(Token = "0x40080F3")]
	[FieldOffset(Offset = "0x10")]
	public uint DKCFMPDAKAP;

	[Token(Token = "0x40080F4")]
	[FieldOffset(Offset = "0x14")]
	public uint MKPMGMKKNCH;

	[Token(Token = "0x600772A")]
	[Address(RVA = "0x3177AFC", Offset = "0x3177AFC", VA = "0x3177AFC")]
	public PNCAPFPBACD()
	{
	}

	[Token(Token = "0x600772B")]
	[Address(RVA = "0x3177B80", Offset = "0x3177B80", VA = "0x3177B80", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600772C")]
	[Address(RVA = "0x3177C38", Offset = "0x3177C38", VA = "0x3177C38", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600772D")]
	[Address(RVA = "0x3177C80", Offset = "0x3177C80", VA = "0x3177C80", Slot = "9")]
	public override void Recycle()
	{
	}
}
