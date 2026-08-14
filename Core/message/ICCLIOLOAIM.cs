using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200116D")]
internal class ICCLIOLOAIM : UDPClientMessageBase
{
	[Token(Token = "0x4007ECE")]
	[FieldOffset(Offset = "0xC")]
	public uint PDCMJIBHDLP;

	[Token(Token = "0x4007ECF")]
	[FieldOffset(Offset = "0x10")]
	public uint PEJNLEADPNH;

	[Token(Token = "0x600739A")]
	[Address(RVA = "0x361675C", Offset = "0x361675C", VA = "0x361675C")]
	public ICCLIOLOAIM()
	{
	}

	[Token(Token = "0x600739B")]
	[Address(RVA = "0x36167E0", Offset = "0x36167E0", VA = "0x36167E0", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600739C")]
	[Address(RVA = "0x361686C", Offset = "0x361686C", VA = "0x361686C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600739D")]
	[Address(RVA = "0x36168A0", Offset = "0x36168A0", VA = "0x36168A0", Slot = "9")]
	public override void Recycle()
	{
	}
}
