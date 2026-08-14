using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010D2")]
internal class PIKICFOICGP : UDPClientMessageBase
{
	[Token(Token = "0x4007D8B")]
	[FieldOffset(Offset = "0xC")]
	public uint ODHCCIDCBAB;

	[Token(Token = "0x600712D")]
	[Address(RVA = "0x3172ECC", Offset = "0x3172ECC", VA = "0x3172ECC")]
	public PIKICFOICGP()
	{
	}

	[Token(Token = "0x600712E")]
	[Address(RVA = "0x3172F50", Offset = "0x3172F50", VA = "0x3172F50", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600712F")]
	[Address(RVA = "0x3172FAC", Offset = "0x3172FAC", VA = "0x3172FAC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007130")]
	[Address(RVA = "0x3172FC8", Offset = "0x3172FC8", VA = "0x3172FC8", Slot = "9")]
	public override void Recycle()
	{
	}
}
