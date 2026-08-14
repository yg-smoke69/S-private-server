using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001126")]
internal class AGBFCOGPPAB : UDPClientMessageBase
{
	[Token(Token = "0x4007E55")]
	[FieldOffset(Offset = "0xC")]
	public uint EOICDHCMGPI;

	[Token(Token = "0x4007E56")]
	[FieldOffset(Offset = "0x10")]
	public List<PABEENFAMLF> MHOFNBLGEOL;

	[Token(Token = "0x4007E57")]
	[FieldOffset(Offset = "0x14")]
	public uint NOINKPPCHKJ;

	[Token(Token = "0x4007E58")]
	[FieldOffset(Offset = "0x18")]
	public byte CHJPOPOLOHP;

	[Token(Token = "0x4007E59")]
	[FieldOffset(Offset = "0x19")]
	public byte AIALIPMLOKO;

	[Token(Token = "0x4007E5A")]
	[FieldOffset(Offset = "0x1A")]
	public bool EMNMKHEFPJG;

	[Token(Token = "0x600727E")]
	[Address(RVA = "0x337868C", Offset = "0x337868C", VA = "0x337868C")]
	public AGBFCOGPPAB()
	{
	}

	[Token(Token = "0x600727F")]
	[Address(RVA = "0x3378710", Offset = "0x3378710", VA = "0x3378710", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007280")]
	[Address(RVA = "0x33789E8", Offset = "0x33789E8", VA = "0x33789E8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007281")]
	[Address(RVA = "0x3378C10", Offset = "0x3378C10", VA = "0x3378C10", Slot = "9")]
	public override void Recycle()
	{
	}
}
