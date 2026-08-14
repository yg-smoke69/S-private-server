using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001200")]
internal class CLKNHKCFGPB : UDPClientMessageBase
{
	[Token(Token = "0x400803D")]
	[FieldOffset(Offset = "0xC")]
	public List<DFEIJFCJBDM> EBPHALPIDGA;

	[Token(Token = "0x60075E6")]
	[Address(RVA = "0x3758670", Offset = "0x3758670", VA = "0x3758670")]
	public CLKNHKCFGPB()
	{
	}

	[Token(Token = "0x60075E7")]
	[Address(RVA = "0x37586F4", Offset = "0x37586F4", VA = "0x37586F4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60075E8")]
	[Address(RVA = "0x37588E4", Offset = "0x37588E4", VA = "0x37588E4", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60075E9")]
	[Address(RVA = "0x3758AA4", Offset = "0x3758AA4", VA = "0x3758AA4", Slot = "9")]
	public override void Recycle()
	{
	}
}
