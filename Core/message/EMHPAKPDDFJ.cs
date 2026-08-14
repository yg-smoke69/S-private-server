using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001231")]
internal class EMHPAKPDDFJ : UDPClientMessageBase
{
	[Token(Token = "0x40080AF")]
	[FieldOffset(Offset = "0xC")]
	public int APNNIJDMGGF;

	[Token(Token = "0x40080B0")]
	[FieldOffset(Offset = "0x10")]
	public List<string> EMGLFOHCILK;

	[Token(Token = "0x40080B1")]
	[FieldOffset(Offset = "0x14")]
	public List<sbyte> IAOIMPBHJMP;

	[Token(Token = "0x60076AA")]
	[Address(RVA = "0x362CC60", Offset = "0x362CC60", VA = "0x362CC60")]
	public EMHPAKPDDFJ()
	{
	}

	[Token(Token = "0x60076AB")]
	[Address(RVA = "0x362CCE4", Offset = "0x362CCE4", VA = "0x362CCE4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60076AC")]
	[Address(RVA = "0x362D058", Offset = "0x362D058", VA = "0x362D058", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60076AD")]
	[Address(RVA = "0x362D244", Offset = "0x362D244", VA = "0x362D244", Slot = "9")]
	public override void Recycle()
	{
	}
}
