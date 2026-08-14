using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001110")]
internal class ABJFDIFIILN : UDPClientMessageBase
{
	[Token(Token = "0x4007E1C")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007E1D")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> ECIIBCCIFKO;

	[Token(Token = "0x6007226")]
	[Address(RVA = "0x337489C", Offset = "0x337489C", VA = "0x337489C")]
	public ABJFDIFIILN()
	{
	}

	[Token(Token = "0x6007227")]
	[Address(RVA = "0x3374920", Offset = "0x3374920", VA = "0x3374920", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007228")]
	[Address(RVA = "0x3374B34", Offset = "0x3374B34", VA = "0x3374B34", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007229")]
	[Address(RVA = "0x3374C5C", Offset = "0x3374C5C", VA = "0x3374C5C", Slot = "9")]
	public override void Recycle()
	{
	}
}
