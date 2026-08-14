using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F89")]
internal class MCJDCJCKADL : UDPClientMessageBase
{
	[Token(Token = "0x4007A74")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007A75")]
	[FieldOffset(Offset = "0x10")]
	public int NIDNCDNNGME;

	[Token(Token = "0x4007A76")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> FKEPDMFBDPD;

	[Token(Token = "0x6006C08")]
	[Address(RVA = "0x343FD3C", Offset = "0x343FD3C", VA = "0x343FD3C")]
	public MCJDCJCKADL()
	{
	}

	[Token(Token = "0x6006C09")]
	[Address(RVA = "0x343FDC0", Offset = "0x343FDC0", VA = "0x343FDC0", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006C0A")]
	[Address(RVA = "0x3440008", Offset = "0x3440008", VA = "0x3440008", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006C0B")]
	[Address(RVA = "0x3440144", Offset = "0x3440144", VA = "0x3440144", Slot = "9")]
	public override void Recycle()
	{
	}
}
