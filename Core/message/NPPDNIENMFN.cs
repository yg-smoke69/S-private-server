using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EBA")]
internal class NPPDNIENMFN : UDPClientMessageBase
{
	[Token(Token = "0x400783E")]
	[FieldOffset(Offset = "0x9")]
	public byte OCJDFFIDIEM;

	[Token(Token = "0x400783F")]
	[FieldOffset(Offset = "0xC")]
	public IAAEJDDHOKB LMBMCIJAMOI;

	[Token(Token = "0x4007840")]
	[FieldOffset(Offset = "0x10")]
	public uint FHBGNKLPEBI;

	[Token(Token = "0x4007841")]
	[FieldOffset(Offset = "0x14")]
	public byte HMJGBALHPOD;

	[Token(Token = "0x4007842")]
	[FieldOffset(Offset = "0x18")]
	public DEACEIFBHJK ILLLMECFNMN;

	[Token(Token = "0x4007843")]
	[FieldOffset(Offset = "0x1C")]
	public List<uint> EBOADPEENIP;

	[Token(Token = "0x60068C4")]
	[Address(RVA = "0x364D160", Offset = "0x364D160", VA = "0x364D160")]
	public NPPDNIENMFN()
	{
	}

	[Token(Token = "0x60068C5")]
	[Address(RVA = "0x364D1E4", Offset = "0x364D1E4", VA = "0x364D1E4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60068C6")]
	[Address(RVA = "0x364D58C", Offset = "0x364D58C", VA = "0x364D58C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60068C7")]
	[Address(RVA = "0x364D7E8", Offset = "0x364D7E8", VA = "0x364D7E8", Slot = "9")]
	public override void Recycle()
	{
	}
}
