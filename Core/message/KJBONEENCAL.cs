using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F04")]
internal class KJBONEENCAL : UDPClientMessageBase
{
	[Token(Token = "0x400794A")]
	[FieldOffset(Offset = "0xC")]
	public uint DGLCOGJJFMI;

	[Token(Token = "0x400794B")]
	[FieldOffset(Offset = "0x10")]
	public uint HFPGENNDGME;

	[Token(Token = "0x400794C")]
	[FieldOffset(Offset = "0x14")]
	public byte MBBDNIBDPME;

	[Token(Token = "0x60069F4")]
	[Address(RVA = "0x368E2FC", Offset = "0x368E2FC", VA = "0x368E2FC")]
	public KJBONEENCAL()
	{
	}

	[Token(Token = "0x60069F5")]
	[Address(RVA = "0x368E380", Offset = "0x368E380", VA = "0x368E380", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60069F6")]
	[Address(RVA = "0x368E438", Offset = "0x368E438", VA = "0x368E438", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60069F7")]
	[Address(RVA = "0x368E480", Offset = "0x368E480", VA = "0x368E480", Slot = "9")]
	public override void Recycle()
	{
	}
}
