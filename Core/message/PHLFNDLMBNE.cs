using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001232")]
internal class PHLFNDLMBNE : UDPClientMessageBase
{
	[Token(Token = "0x40080B2")]
	[FieldOffset(Offset = "0xC")]
	public int JMPBCFIGADG;

	[Token(Token = "0x40080B3")]
	[FieldOffset(Offset = "0x10")]
	public long JEFEINECLPJ;

	[Token(Token = "0x40080B4")]
	[FieldOffset(Offset = "0x18")]
	public string OGLIDLHPPJF;

	[Token(Token = "0x40080B5")]
	[FieldOffset(Offset = "0x1C")]
	public string FOECMDGEMHB;

	[Token(Token = "0x60076AE")]
	[Address(RVA = "0x3172974", Offset = "0x3172974", VA = "0x3172974")]
	public PHLFNDLMBNE()
	{
	}

	[Token(Token = "0x60076AF")]
	[Address(RVA = "0x31729F8", Offset = "0x31729F8", VA = "0x31729F8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60076B0")]
	[Address(RVA = "0x3172AB8", Offset = "0x3172AB8", VA = "0x3172AB8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60076B1")]
	[Address(RVA = "0x3172B14", Offset = "0x3172B14", VA = "0x3172B14", Slot = "9")]
	public override void Recycle()
	{
	}
}
