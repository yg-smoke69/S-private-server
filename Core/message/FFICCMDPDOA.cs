using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011E8")]
internal class FFICCMDPDOA : UDPClientMessageBase
{
	[Token(Token = "0x4008001")]
	[FieldOffset(Offset = "0xC")]
	public HFMEHNDOKCA BKFMPACNBLJ;

	[Token(Token = "0x4008002")]
	[FieldOffset(Offset = "0x10")]
	public float JOKDJFPBKFL;

	[Token(Token = "0x4008003")]
	[FieldOffset(Offset = "0x14")]
	public bool FMFLJAADBHG;

	[Token(Token = "0x6007586")]
	[Address(RVA = "0x36331B4", Offset = "0x36331B4", VA = "0x36331B4")]
	public FFICCMDPDOA()
	{
	}

	[Token(Token = "0x6007587")]
	[Address(RVA = "0x3633238", Offset = "0x3633238", VA = "0x3633238", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007588")]
	[Address(RVA = "0x3633308", Offset = "0x3633308", VA = "0x3633308", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007589")]
	[Address(RVA = "0x3633350", Offset = "0x3633350", VA = "0x3633350", Slot = "9")]
	public override void Recycle()
	{
	}
}
