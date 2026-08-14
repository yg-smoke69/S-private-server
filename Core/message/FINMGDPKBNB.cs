using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F2E")]
internal class FINMGDPKBNB : UDPClientMessageBase
{
	[Token(Token = "0x40079B2")]
	[FieldOffset(Offset = "0xA")]
	public ushort EHCHPAGEHIA;

	[Token(Token = "0x40079B3")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x40079B4")]
	[FieldOffset(Offset = "0x10")]
	public uint HABBKIPEHBL;

	[Token(Token = "0x40079B5")]
	[FieldOffset(Offset = "0x14")]
	public bool AGOFJNKOIBI;

	[Token(Token = "0x6006A9C")]
	[Address(RVA = "0x3635828", Offset = "0x3635828", VA = "0x3635828")]
	public FINMGDPKBNB()
	{
	}

	[Token(Token = "0x6006A9D")]
	[Address(RVA = "0x36358AC", Offset = "0x36358AC", VA = "0x36358AC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006A9E")]
	[Address(RVA = "0x36359A0", Offset = "0x36359A0", VA = "0x36359A0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006A9F")]
	[Address(RVA = "0x36359FC", Offset = "0x36359FC", VA = "0x36359FC", Slot = "9")]
	public override void Recycle()
	{
	}
}
