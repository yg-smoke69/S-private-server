using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011A9")]
internal class JMCBPOPJLDL : UDPClientMessageBase
{
	[Token(Token = "0x4007F6D")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> IGDJDHACOLL;

	[Token(Token = "0x600748A")]
	[Address(RVA = "0x36800E4", Offset = "0x36800E4", VA = "0x36800E4")]
	public JMCBPOPJLDL()
	{
	}

	[Token(Token = "0x600748B")]
	[Address(RVA = "0x3680168", Offset = "0x3680168", VA = "0x3680168", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600748C")]
	[Address(RVA = "0x3680358", Offset = "0x3680358", VA = "0x3680358", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600748D")]
	[Address(RVA = "0x368046C", Offset = "0x368046C", VA = "0x368046C", Slot = "9")]
	public override void Recycle()
	{
	}
}
