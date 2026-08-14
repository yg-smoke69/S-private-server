using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200109D")]
internal class KACBLCKLCAG : UDPClientMessageBase
{
	[Token(Token = "0x4007D14")]
	[FieldOffset(Offset = "0x9")]
	public byte DBPDEFEOPCB;

	[Token(Token = "0x4007D15")]
	[FieldOffset(Offset = "0xC")]
	public uint CCFCMGLIEFH;

	[Token(Token = "0x6007059")]
	[Address(RVA = "0x3685270", Offset = "0x3685270", VA = "0x3685270")]
	public KACBLCKLCAG()
	{
	}

	[Token(Token = "0x600705A")]
	[Address(RVA = "0x36852F4", Offset = "0x36852F4", VA = "0x36852F4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600705B")]
	[Address(RVA = "0x3685380", Offset = "0x3685380", VA = "0x3685380", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600705C")]
	[Address(RVA = "0x36853B4", Offset = "0x36853B4", VA = "0x36853B4", Slot = "9")]
	public override void Recycle()
	{
	}
}
