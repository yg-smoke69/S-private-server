using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001240")]
internal class LHKCFEDFAND : UDPClientMessageBase
{
	[Token(Token = "0x40080CC")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> OLHLOPLLCKN;

	[Token(Token = "0x40080CD")]
	[FieldOffset(Offset = "0x10")]
	public List<string> EAAPHHHFDND;

	[Token(Token = "0x60076E6")]
	[Address(RVA = "0x34336B0", Offset = "0x34336B0", VA = "0x34336B0")]
	public LHKCFEDFAND()
	{
	}

	[Token(Token = "0x60076E7")]
	[Address(RVA = "0x3433734", Offset = "0x3433734", VA = "0x3433734", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60076E8")]
	[Address(RVA = "0x3433A7C", Offset = "0x3433A7C", VA = "0x3433A7C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60076E9")]
	[Address(RVA = "0x3433C54", Offset = "0x3433C54", VA = "0x3433C54", Slot = "9")]
	public override void Recycle()
	{
	}
}
