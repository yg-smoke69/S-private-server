using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FB6")]
internal class NFMMDECNNAA : UDPClientMessageBase
{
	[Token(Token = "0x4007B08")]
	[FieldOffset(Offset = "0xC")]
	public uint NKDDCHOAPCB;

	[Token(Token = "0x6006CBC")]
	[Address(RVA = "0x3644DB4", Offset = "0x3644DB4", VA = "0x3644DB4")]
	public NFMMDECNNAA()
	{
	}

	[Token(Token = "0x6006CBD")]
	[Address(RVA = "0x3644E38", Offset = "0x3644E38", VA = "0x3644E38", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006CBE")]
	[Address(RVA = "0x3644E94", Offset = "0x3644E94", VA = "0x3644E94", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006CBF")]
	[Address(RVA = "0x3644EB0", Offset = "0x3644EB0", VA = "0x3644EB0", Slot = "9")]
	public override void Recycle()
	{
	}
}
