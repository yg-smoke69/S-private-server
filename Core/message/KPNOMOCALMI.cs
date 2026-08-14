using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010E3")]
internal class KPNOMOCALMI : UDPClientMessageBase
{
	[Token(Token = "0x4007DAC")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> IPCIBPENHME;

	[Token(Token = "0x6007171")]
	[Address(RVA = "0x342D838", Offset = "0x342D838", VA = "0x342D838")]
	public KPNOMOCALMI()
	{
	}

	[Token(Token = "0x6007172")]
	[Address(RVA = "0x342D8BC", Offset = "0x342D8BC", VA = "0x342D8BC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007173")]
	[Address(RVA = "0x342DAAC", Offset = "0x342DAAC", VA = "0x342DAAC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007174")]
	[Address(RVA = "0x342DBC0", Offset = "0x342DBC0", VA = "0x342DBC0", Slot = "9")]
	public override void Recycle()
	{
	}
}
