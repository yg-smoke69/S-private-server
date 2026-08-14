using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001104")]
internal class DBLNGCIBFPD : UDPClientMessageBase
{
	[Token(Token = "0x4007DFF")]
	[FieldOffset(Offset = "0xC")]
	public uint AIIFDCBFPMN;

	[Token(Token = "0x60071F5")]
	[Address(RVA = "0x375CBDC", Offset = "0x375CBDC", VA = "0x375CBDC")]
	public DBLNGCIBFPD()
	{
	}

	[Token(Token = "0x60071F6")]
	[Address(RVA = "0x375CC60", Offset = "0x375CC60", VA = "0x375CC60", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071F7")]
	[Address(RVA = "0x375CCBC", Offset = "0x375CCBC", VA = "0x375CCBC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071F8")]
	[Address(RVA = "0x375CCD8", Offset = "0x375CCD8", VA = "0x375CCD8", Slot = "9")]
	public override void Recycle()
	{
	}
}
