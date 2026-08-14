using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EFB")]
internal class FPCOHGNMLBG : UDPClientMessageBase
{
	[Token(Token = "0x400792E")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x400792F")]
	[FieldOffset(Offset = "0x10")]
	public uint CJJDECHGLBK;

	[Token(Token = "0x4007930")]
	[FieldOffset(Offset = "0x14")]
	public uint IPHPGHNJCMB;

	[Token(Token = "0x4007931")]
	[FieldOffset(Offset = "0x18")]
	public uint DGCFNONGGDE;

	[Token(Token = "0x4007932")]
	[FieldOffset(Offset = "0x1C")]
	public List<uint> BANEMDIIAPO;

	[Token(Token = "0x4007933")]
	[FieldOffset(Offset = "0x20")]
	public bool CIILMLJIDBJ;

	[Token(Token = "0x60069D0")]
	[Address(RVA = "0x3639C20", Offset = "0x3639C20", VA = "0x3639C20")]
	public FPCOHGNMLBG()
	{
	}

	[Token(Token = "0x60069D1")]
	[Address(RVA = "0x3639CA4", Offset = "0x3639CA4", VA = "0x3639CA4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60069D2")]
	[Address(RVA = "0x3639F84", Offset = "0x3639F84", VA = "0x3639F84", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60069D3")]
	[Address(RVA = "0x363A0FC", Offset = "0x363A0FC", VA = "0x363A0FC", Slot = "9")]
	public override void Recycle()
	{
	}
}
