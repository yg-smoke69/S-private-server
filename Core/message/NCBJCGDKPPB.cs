using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F88")]
internal class NCBJCGDKPPB : UDPClientMessageBase
{
	[Token(Token = "0x4007A72")]
	[FieldOffset(Offset = "0xC")]
	public int NIDNCDNNGME;

	[Token(Token = "0x4007A73")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> FKEPDMFBDPD;

	[Token(Token = "0x6006C04")]
	[Address(RVA = "0x3641FFC", Offset = "0x3641FFC", VA = "0x3641FFC")]
	public NCBJCGDKPPB()
	{
	}

	[Token(Token = "0x6006C05")]
	[Address(RVA = "0x3642080", Offset = "0x3642080", VA = "0x3642080", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006C06")]
	[Address(RVA = "0x3642294", Offset = "0x3642294", VA = "0x3642294", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006C07")]
	[Address(RVA = "0x36423BC", Offset = "0x36423BC", VA = "0x36423BC", Slot = "9")]
	public override void Recycle()
	{
	}
}
