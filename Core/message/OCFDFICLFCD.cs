using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200104C")]
internal class OCFDFICLFCD : UDPClientMessageBase
{
	[Token(Token = "0x4007C60")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007C61")]
	[FieldOffset(Offset = "0x10")]
	public byte JAKEIPJNLJK;

	[Token(Token = "0x4007C62")]
	[FieldOffset(Offset = "0x14")]
	public List<AEJALKJMIHC> MGKOCEDCMNL;

	[Token(Token = "0x6006F15")]
	[Address(RVA = "0x364FAEC", Offset = "0x364FAEC", VA = "0x364FAEC")]
	public OCFDFICLFCD()
	{
	}

	[Token(Token = "0x6006F16")]
	[Address(RVA = "0x364FB70", Offset = "0x364FB70", VA = "0x364FB70", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006F17")]
	[Address(RVA = "0x364FDB8", Offset = "0x364FDB8", VA = "0x364FDB8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006F18")]
	[Address(RVA = "0x364FFA0", Offset = "0x364FFA0", VA = "0x364FFA0", Slot = "9")]
	public override void Recycle()
	{
	}
}
