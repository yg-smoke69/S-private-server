using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EC6")]
internal class JOEINMGBILP : UDPClientMessageBase
{
	[Token(Token = "0x4007860")]
	[FieldOffset(Offset = "0xC")]
	public List<GEDBLBAKEHG> GLLNDPEHOFP;

	[Token(Token = "0x60068F4")]
	[Address(RVA = "0x3682D58", Offset = "0x3682D58", VA = "0x3682D58")]
	public JOEINMGBILP()
	{
	}

	[Token(Token = "0x60068F5")]
	[Address(RVA = "0x3682DDC", Offset = "0x3682DDC", VA = "0x3682DDC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60068F6")]
	[Address(RVA = "0x3682FCC", Offset = "0x3682FCC", VA = "0x3682FCC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60068F7")]
	[Address(RVA = "0x368318C", Offset = "0x368318C", VA = "0x368318C", Slot = "9")]
	public override void Recycle()
	{
	}
}
