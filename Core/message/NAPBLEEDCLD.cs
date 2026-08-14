using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200113C")]
internal class NAPBLEEDCLD : UDPClientMessageBase
{
	[Token(Token = "0x4007E86")]
	[FieldOffset(Offset = "0xC")]
	public List<ALOMCCEHJOI> HGMACOCMDMI;

	[Token(Token = "0x4007E87")]
	[FieldOffset(Offset = "0x10")]
	public float NCOOLBMDMMI;

	[Token(Token = "0x4007E88")]
	[FieldOffset(Offset = "0x14")]
	public uint ECHKJNEKPCG;

	[Token(Token = "0x60072D6")]
	[Address(RVA = "0x36403C8", Offset = "0x36403C8", VA = "0x36403C8")]
	public NAPBLEEDCLD()
	{
	}

	[Token(Token = "0x60072D7")]
	[Address(RVA = "0x364044C", Offset = "0x364044C", VA = "0x364044C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60072D8")]
	[Address(RVA = "0x36406A0", Offset = "0x36406A0", VA = "0x36406A0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60072D9")]
	[Address(RVA = "0x364088C", Offset = "0x364088C", VA = "0x364088C", Slot = "9")]
	public override void Recycle()
	{
	}
}
