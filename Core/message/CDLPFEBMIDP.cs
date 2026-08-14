using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010F7")]
internal class CDLPFEBMIDP : UDPClientMessageBase
{
	[Token(Token = "0x4007DDA")]
	[FieldOffset(Offset = "0x9")]
	public byte NCHOPFNDDNM;

	[Token(Token = "0x4007DDB")]
	[FieldOffset(Offset = "0xA")]
	public byte EHDNIOLBBDD;

	[Token(Token = "0x4007DDC")]
	[FieldOffset(Offset = "0xC")]
	public uint NDECJGIMIFA;

	[Token(Token = "0x4007DDD")]
	[FieldOffset(Offset = "0x10")]
	public byte CBEHCNLNNLD;

	[Token(Token = "0x4007DDE")]
	[FieldOffset(Offset = "0x14")]
	public uint GPLEDKJINKK;

	[Token(Token = "0x4007DDF")]
	[FieldOffset(Offset = "0x18")]
	public byte JAKCPJNHNMD;

	[Token(Token = "0x4007DE0")]
	[FieldOffset(Offset = "0x20")]
	public ulong PEDAJLDOALF;

	[Token(Token = "0x60071C1")]
	[Address(RVA = "0x374FB98", Offset = "0x374FB98", VA = "0x374FB98")]
	public CDLPFEBMIDP()
	{
	}

	[Token(Token = "0x60071C2")]
	[Address(RVA = "0x374FC1C", Offset = "0x374FC1C", VA = "0x374FC1C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071C3")]
	[Address(RVA = "0x374FD98", Offset = "0x374FD98", VA = "0x374FD98", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071C4")]
	[Address(RVA = "0x374FE30", Offset = "0x374FE30", VA = "0x374FE30", Slot = "9")]
	public override void Recycle()
	{
	}
}
