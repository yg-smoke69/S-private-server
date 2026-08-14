using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200111F")]
internal class CKCCONIMDJE : UDPClientMessageBase
{
	[Token(Token = "0x4007E43")]
	[FieldOffset(Offset = "0xC")]
	public List<IJKEMPEMMDN> ALGIIOFINJH;

	[Token(Token = "0x6007262")]
	[Address(RVA = "0x3756AC8", Offset = "0x3756AC8", VA = "0x3756AC8")]
	public CKCCONIMDJE()
	{
	}

	[Token(Token = "0x6007263")]
	[Address(RVA = "0x3756B4C", Offset = "0x3756B4C", VA = "0x3756B4C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007264")]
	[Address(RVA = "0x3756D3C", Offset = "0x3756D3C", VA = "0x3756D3C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007265")]
	[Address(RVA = "0x3756EFC", Offset = "0x3756EFC", VA = "0x3756EFC", Slot = "9")]
	public override void Recycle()
	{
	}
}
