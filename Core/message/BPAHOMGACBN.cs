using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001142")]
internal class BPAHOMGACBN : UDPClientMessageBase
{
	[Token(Token = "0x4007E90")]
	[FieldOffset(Offset = "0x9")]
	public bool DEEDDGFLDPH;

	[Token(Token = "0x60072EE")]
	[Address(RVA = "0x374E2A4", Offset = "0x374E2A4", VA = "0x374E2A4")]
	public BPAHOMGACBN()
	{
	}

	[Token(Token = "0x60072EF")]
	[Address(RVA = "0x374E328", Offset = "0x374E328", VA = "0x374E328", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60072F0")]
	[Address(RVA = "0x374E394", Offset = "0x374E394", VA = "0x374E394", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60072F1")]
	[Address(RVA = "0x374E3B0", Offset = "0x374E3B0", VA = "0x374E3B0", Slot = "9")]
	public override void Recycle()
	{
	}
}
