using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011C6")]
internal class ICMBDCMDCGF : UDPClientMessageBase
{
	[Token(Token = "0x4007FB4")]
	[FieldOffset(Offset = "0xC")]
	public List<LPMJFFLPOIB> NMAFMCKMKPP;

	[Token(Token = "0x60074FE")]
	[Address(RVA = "0x36174B4", Offset = "0x36174B4", VA = "0x36174B4")]
	public ICMBDCMDCGF()
	{
	}

	[Token(Token = "0x60074FF")]
	[Address(RVA = "0x3617538", Offset = "0x3617538", VA = "0x3617538", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007500")]
	[Address(RVA = "0x3617728", Offset = "0x3617728", VA = "0x3617728", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007501")]
	[Address(RVA = "0x36178E8", Offset = "0x36178E8", VA = "0x36178E8", Slot = "9")]
	public override void Recycle()
	{
	}
}
