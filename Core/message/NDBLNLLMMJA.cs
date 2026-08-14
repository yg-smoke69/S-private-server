using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010E2")]
internal class NDBLNLLMMJA : UDPClientMessageBase
{
	[Token(Token = "0x4007DA9")]
	[FieldOffset(Offset = "0xC")]
	public List<BENHAIGLOGI> MBIDDNPBDOC;

	[Token(Token = "0x4007DAA")]
	[FieldOffset(Offset = "0x10")]
	public string FEILONHCPHG;

	[Token(Token = "0x4007DAB")]
	[FieldOffset(Offset = "0x14")]
	public bool JAEKNAGMFAB;

	[Token(Token = "0x600716D")]
	[Address(RVA = "0x3642D04", Offset = "0x3642D04", VA = "0x3642D04")]
	public NDBLNLLMMJA()
	{
	}

	[Token(Token = "0x600716E")]
	[Address(RVA = "0x3642D88", Offset = "0x3642D88", VA = "0x3642D88", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600716F")]
	[Address(RVA = "0x3642FCC", Offset = "0x3642FCC", VA = "0x3642FCC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007170")]
	[Address(RVA = "0x36431B8", Offset = "0x36431B8", VA = "0x36431B8", Slot = "9")]
	public override void Recycle()
	{
	}
}
