using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F29")]
internal class BEGIFLLPAFO : UDPClientMessageBase
{
	[Token(Token = "0x40079A9")]
	[FieldOffset(Offset = "0xA")]
	public ushort EHCHPAGEHIA;

	[Token(Token = "0x6006A88")]
	[Address(RVA = "0x3385004", Offset = "0x3385004", VA = "0x3385004")]
	public BEGIFLLPAFO()
	{
	}

	[Token(Token = "0x6006A89")]
	[Address(RVA = "0x3385088", Offset = "0x3385088", VA = "0x3385088", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006A8A")]
	[Address(RVA = "0x33850E4", Offset = "0x33850E4", VA = "0x33850E4", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006A8B")]
	[Address(RVA = "0x3385100", Offset = "0x3385100", VA = "0x3385100", Slot = "9")]
	public override void Recycle()
	{
	}
}
