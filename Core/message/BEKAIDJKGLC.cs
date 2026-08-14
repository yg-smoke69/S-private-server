using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FEF")]
internal class BEKAIDJKGLC : UDPClientMessageBase
{
	[Token(Token = "0x4007B97")]
	[FieldOffset(Offset = "0xC")]
	public List<byte> AFKAIMGAINI;

	[Token(Token = "0x4007B98")]
	[FieldOffset(Offset = "0x10")]
	public bool KFFALCDONPP;

	[Token(Token = "0x4007B99")]
	[FieldOffset(Offset = "0x11")]
	public byte LGKMCHBPMEJ;

	[Token(Token = "0x4007B9A")]
	[FieldOffset(Offset = "0x12")]
	public ushort FIBGEBKHPEH;

	[Token(Token = "0x6006DA0")]
	[Address(RVA = "0x3385104", Offset = "0x3385104", VA = "0x3385104")]
	public BEKAIDJKGLC()
	{
	}

	[Token(Token = "0x6006DA1")]
	[Address(RVA = "0x3385188", Offset = "0x3385188", VA = "0x3385188", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006DA2")]
	[Address(RVA = "0x3385410", Offset = "0x3385410", VA = "0x3385410", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006DA3")]
	[Address(RVA = "0x3385560", Offset = "0x3385560", VA = "0x3385560", Slot = "9")]
	public override void Recycle()
	{
	}
}
