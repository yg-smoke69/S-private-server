using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F83")]
internal class HLDGABAIPAL : UDPClientMessageBase
{
	[Token(Token = "0x4007A66")]
	[FieldOffset(Offset = "0xC")]
	public uint PIAAFCGBIAA;

	[Token(Token = "0x6006BF0")]
	[Address(RVA = "0x3610FF0", Offset = "0x3610FF0", VA = "0x3610FF0")]
	public HLDGABAIPAL()
	{
	}

	[Token(Token = "0x6006BF1")]
	[Address(RVA = "0x3611074", Offset = "0x3611074", VA = "0x3611074", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006BF2")]
	[Address(RVA = "0x36110D0", Offset = "0x36110D0", VA = "0x36110D0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006BF3")]
	[Address(RVA = "0x36110EC", Offset = "0x36110EC", VA = "0x36110EC", Slot = "9")]
	public override void Recycle()
	{
	}
}
