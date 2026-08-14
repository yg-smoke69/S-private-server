using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200112A")]
internal class FNLGKLNNPAG : UDPClientMessageBase
{
	[Token(Token = "0x4007E60")]
	[FieldOffset(Offset = "0x9")]
	public byte GGKOCCEOFJM;

	[Token(Token = "0x4007E61")]
	[FieldOffset(Offset = "0xC")]
	public uint FABBDMDFAAO;

	[Token(Token = "0x4007E62")]
	[FieldOffset(Offset = "0x10")]
	public List<FACBAIGOONF> JFNPIIHICEH;

	[Token(Token = "0x600728E")]
	[Address(RVA = "0x3638B40", Offset = "0x3638B40", VA = "0x3638B40")]
	public FNLGKLNNPAG()
	{
	}

	[Token(Token = "0x600728F")]
	[Address(RVA = "0x3638BC4", Offset = "0x3638BC4", VA = "0x3638BC4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007290")]
	[Address(RVA = "0x3638E0C", Offset = "0x3638E0C", VA = "0x3638E0C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007291")]
	[Address(RVA = "0x3638FF4", Offset = "0x3638FF4", VA = "0x3638FF4", Slot = "9")]
	public override void Recycle()
	{
	}
}
