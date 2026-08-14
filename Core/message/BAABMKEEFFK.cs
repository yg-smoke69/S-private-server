using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001034")]
internal class BAABMKEEFFK : UDPClientMessageBase
{
	[Token(Token = "0x4007C1F")]
	[FieldOffset(Offset = "0xC")]
	public List<GAJBFNEFMKN> MCOEIMCHEPO;

	[Token(Token = "0x4007C20")]
	[FieldOffset(Offset = "0x10")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x6006EB4")]
	[Address(RVA = "0x3381760", Offset = "0x3381760", VA = "0x3381760")]
	public BAABMKEEFFK()
	{
	}

	[Token(Token = "0x6006EB5")]
	[Address(RVA = "0x33817E4", Offset = "0x33817E4", VA = "0x33817E4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006EB6")]
	[Address(RVA = "0x3381A04", Offset = "0x3381A04", VA = "0x3381A04", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006EB7")]
	[Address(RVA = "0x3381BDC", Offset = "0x3381BDC", VA = "0x3381BDC", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006EB8")]
	[Address(RVA = "0x3381D24", Offset = "0x3381D24", VA = "0x3381D24", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
