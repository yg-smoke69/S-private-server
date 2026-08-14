using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F22")]
internal class BOOFMIIIIBH : UDPClientMessageBase
{
	[Token(Token = "0x400799D")]
	[FieldOffset(Offset = "0xC")]
	public uint LEMPPLMKNIN;

	[Token(Token = "0x400799E")]
	[FieldOffset(Offset = "0x10")]
	public ushort ECBHBKFCMBI;

	[Token(Token = "0x400799F")]
	[FieldOffset(Offset = "0x14")]
	public string KGAGDHFOKKE;

	[Token(Token = "0x40079A0")]
	[FieldOffset(Offset = "0x18")]
	public DEACEIFBHJK CCIKDFGDBAM;

	[Token(Token = "0x40079A1")]
	[FieldOffset(Offset = "0x1C")]
	public GAKIHFPIOEF CCDDHEBKMGD;

	[Token(Token = "0x40079A2")]
	[FieldOffset(Offset = "0x20")]
	public List<byte> CLCFBJIKGBN;

	[Token(Token = "0x6006A6C")]
	[Address(RVA = "0x374DB24", Offset = "0x374DB24", VA = "0x374DB24")]
	public BOOFMIIIIBH()
	{
	}

	[Token(Token = "0x6006A6D")]
	[Address(RVA = "0x374DBA8", Offset = "0x374DBA8", VA = "0x374DBA8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006A6E")]
	[Address(RVA = "0x374DF40", Offset = "0x374DF40", VA = "0x374DF40", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006A6F")]
	[Address(RVA = "0x374E19C", Offset = "0x374E19C", VA = "0x374E19C", Slot = "9")]
	public override void Recycle()
	{
	}
}
