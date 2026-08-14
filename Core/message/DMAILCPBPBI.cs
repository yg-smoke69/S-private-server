using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FBF")]
internal class DMAILCPBPBI : UDPClientMessageBase
{
	[Token(Token = "0x4007B18")]
	[FieldOffset(Offset = "0xC")]
	public uint EDNDLAJOJMM;

	[Token(Token = "0x4007B19")]
	[FieldOffset(Offset = "0x10")]
	public List<ALOMCCEHJOI> POAJLIPDANG;

	[Token(Token = "0x4007B1A")]
	[FieldOffset(Offset = "0x14")]
	public uint CMEKDNHLCGK;

	[Token(Token = "0x6006CE0")]
	[Address(RVA = "0x3763738", Offset = "0x3763738", VA = "0x3763738")]
	public DMAILCPBPBI()
	{
	}

	[Token(Token = "0x6006CE1")]
	[Address(RVA = "0x37637BC", Offset = "0x37637BC", VA = "0x37637BC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006CE2")]
	[Address(RVA = "0x3763A00", Offset = "0x3763A00", VA = "0x3763A00", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006CE3")]
	[Address(RVA = "0x3763BEC", Offset = "0x3763BEC", VA = "0x3763BEC", Slot = "9")]
	public override void Recycle()
	{
	}
}
