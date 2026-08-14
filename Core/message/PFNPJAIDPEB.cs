using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011FF")]
internal class PFNPJAIDPEB : UDPClientMessageBase
{
	[Token(Token = "0x400803A")]
	[FieldOffset(Offset = "0xC")]
	public uint HBGEPLMAAIG;

	[Token(Token = "0x400803B")]
	[FieldOffset(Offset = "0x10")]
	public bool MJHEGNPGPNK;

	[Token(Token = "0x400803C")]
	[FieldOffset(Offset = "0x14")]
	public List<FIMGICJHBNI> LNOLNLMIEHC;

	[Token(Token = "0x60075E2")]
	[Address(RVA = "0x3170B54", Offset = "0x3170B54", VA = "0x3170B54")]
	public PFNPJAIDPEB()
	{
	}

	[Token(Token = "0x60075E3")]
	[Address(RVA = "0x3170BD8", Offset = "0x3170BD8", VA = "0x3170BD8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60075E4")]
	[Address(RVA = "0x3170E18", Offset = "0x3170E18", VA = "0x3170E18", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60075E5")]
	[Address(RVA = "0x3171000", Offset = "0x3171000", VA = "0x3171000", Slot = "9")]
	public override void Recycle()
	{
	}
}
