using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001163")]
internal class JDAPHICOGNG : UDPClientMessageBase
{
	[Token(Token = "0x4007EC5")]
	[FieldOffset(Offset = "0xC")]
	public List<byte> CLCFBJIKGBN;

	[Token(Token = "0x6007372")]
	[Address(RVA = "0x367700C", Offset = "0x367700C", VA = "0x367700C")]
	public JDAPHICOGNG()
	{
	}

	[Token(Token = "0x6007373")]
	[Address(RVA = "0x3677090", Offset = "0x3677090", VA = "0x3677090", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007374")]
	[Address(RVA = "0x3677280", Offset = "0x3677280", VA = "0x3677280", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007375")]
	[Address(RVA = "0x3677394", Offset = "0x3677394", VA = "0x3677394", Slot = "9")]
	public override void Recycle()
	{
	}
}
