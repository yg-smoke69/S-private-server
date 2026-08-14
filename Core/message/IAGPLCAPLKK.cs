using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EC7")]
internal class IAGPLCAPLKK : UDPClientMessageBase
{
	[Token(Token = "0x4007861")]
	[FieldOffset(Offset = "0xC")]
	public List<EBNJADFGCFA> ENGHFAGKCNA;

	[Token(Token = "0x60068F8")]
	[Address(RVA = "0x3614A40", Offset = "0x3614A40", VA = "0x3614A40")]
	public IAGPLCAPLKK()
	{
	}

	[Token(Token = "0x60068F9")]
	[Address(RVA = "0x3614AC4", Offset = "0x3614AC4", VA = "0x3614AC4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60068FA")]
	[Address(RVA = "0x3614CB4", Offset = "0x3614CB4", VA = "0x3614CB4", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60068FB")]
	[Address(RVA = "0x3614E74", Offset = "0x3614E74", VA = "0x3614E74", Slot = "9")]
	public override void Recycle()
	{
	}
}
