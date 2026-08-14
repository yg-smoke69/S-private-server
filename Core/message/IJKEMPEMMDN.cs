using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200111D")]
internal class IJKEMPEMMDN : UDPClientMessageBase
{
	[Token(Token = "0x4007E40")]
	[FieldOffset(Offset = "0xA")]
	public ushort BOCHCIEBCAL;

	[Token(Token = "0x4007E41")]
	[FieldOffset(Offset = "0xC")]
	public int BJDEIHKKJIC;

	[Token(Token = "0x600725A")]
	[Address(RVA = "0x361C50C", Offset = "0x361C50C", VA = "0x361C50C")]
	public IJKEMPEMMDN()
	{
	}

	[Token(Token = "0x600725B")]
	[Address(RVA = "0x361C590", Offset = "0x361C590", VA = "0x361C590", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600725C")]
	[Address(RVA = "0x361C61C", Offset = "0x361C61C", VA = "0x361C61C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600725D")]
	[Address(RVA = "0x361C650", Offset = "0x361C650", VA = "0x361C650", Slot = "9")]
	public override void Recycle()
	{
	}
}
