using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010FF")]
internal class BLCEPOBBBEI : UDPClientMessageBase
{
	[Token(Token = "0x4007DF0")]
	[FieldOffset(Offset = "0xC")]
	public uint POBGKMDJMDC;

	[Token(Token = "0x4007DF1")]
	[FieldOffset(Offset = "0x10")]
	public byte HMEBLIODHEO;

	[Token(Token = "0x4007DF2")]
	[FieldOffset(Offset = "0x11")]
	public byte MMJMADPFKIF;

	[Token(Token = "0x4007DF3")]
	[FieldOffset(Offset = "0x14")]
	public List<byte> LNOLNLMIEHC;

	[Token(Token = "0x60071E1")]
	[Address(RVA = "0x37498D4", Offset = "0x37498D4", VA = "0x37498D4")]
	public BLCEPOBBBEI()
	{
	}

	[Token(Token = "0x60071E2")]
	[Address(RVA = "0x3749958", Offset = "0x3749958", VA = "0x3749958", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071E3")]
	[Address(RVA = "0x3749BCC", Offset = "0x3749BCC", VA = "0x3749BCC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071E4")]
	[Address(RVA = "0x3749D1C", Offset = "0x3749D1C", VA = "0x3749D1C", Slot = "9")]
	public override void Recycle()
	{
	}
}
