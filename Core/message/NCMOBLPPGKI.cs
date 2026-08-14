using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001006")]
internal class NCMOBLPPGKI : UDPClientMessageBase
{
	[Token(Token = "0x4007BC5")]
	[FieldOffset(Offset = "0xC")]
	public uint POBGKMDJMDC;

	[Token(Token = "0x6006DFC")]
	[Address(RVA = "0x3642774", Offset = "0x3642774", VA = "0x3642774")]
	public NCMOBLPPGKI()
	{
	}

	[Token(Token = "0x6006DFD")]
	[Address(RVA = "0x36427F8", Offset = "0x36427F8", VA = "0x36427F8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006DFE")]
	[Address(RVA = "0x3642854", Offset = "0x3642854", VA = "0x3642854", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006DFF")]
	[Address(RVA = "0x3642870", Offset = "0x3642870", VA = "0x3642870", Slot = "9")]
	public override void Recycle()
	{
	}
}
