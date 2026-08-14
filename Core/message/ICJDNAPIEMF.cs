using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FF0")]
internal class ICJDNAPIEMF : UDPClientMessageBase
{
	[Token(Token = "0x4007B9B")]
	[FieldOffset(Offset = "0xC")]
	public List<FFKKHGEMNAN> JHNBBOJBPAJ;

	[Token(Token = "0x4007B9C")]
	[FieldOffset(Offset = "0x10")]
	public uint DIAJDJCKKFP;

	[Token(Token = "0x4007B9D")]
	[FieldOffset(Offset = "0x14")]
	public byte CDOIDJPNCGL;

	[Token(Token = "0x4007B9E")]
	[FieldOffset(Offset = "0x15")]
	public byte HAOCAELGLBJ;

	[Token(Token = "0x4007B9F")]
	[FieldOffset(Offset = "0x16")]
	public bool FPECMAADAFG;

	[Token(Token = "0x6006DA4")]
	[Address(RVA = "0x3616E20", Offset = "0x3616E20", VA = "0x3616E20")]
	public ICJDNAPIEMF()
	{
	}

	[Token(Token = "0x6006DA5")]
	[Address(RVA = "0x3616EA4", Offset = "0x3616EA4", VA = "0x3616EA4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006DA6")]
	[Address(RVA = "0x3617158", Offset = "0x3617158", VA = "0x3617158", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006DA7")]
	[Address(RVA = "0x361736C", Offset = "0x361736C", VA = "0x361736C", Slot = "9")]
	public override void Recycle()
	{
	}
}
