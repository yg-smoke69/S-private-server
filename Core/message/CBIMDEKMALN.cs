using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200102B")]
internal class CBIMDEKMALN : UDPClientMessageBase
{
	[Token(Token = "0x4007C0A")]
	[FieldOffset(Offset = "0x9")]
	public bool DAMANDJHHFP;

	[Token(Token = "0x4007C0B")]
	[FieldOffset(Offset = "0xC")]
	public List<int> KELMLEGABNF;

	[Token(Token = "0x6006E90")]
	[Address(RVA = "0x374EC20", Offset = "0x374EC20", VA = "0x374EC20")]
	public CBIMDEKMALN()
	{
	}

	[Token(Token = "0x6006E91")]
	[Address(RVA = "0x374ECA4", Offset = "0x374ECA4", VA = "0x374ECA4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006E92")]
	[Address(RVA = "0x374EEC0", Offset = "0x374EEC0", VA = "0x374EEC0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006E93")]
	[Address(RVA = "0x374EFE8", Offset = "0x374EFE8", VA = "0x374EFE8", Slot = "9")]
	public override void Recycle()
	{
	}
}
