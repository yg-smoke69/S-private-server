using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F17")]
internal class HCLCACHJAON : UDPClientMessageBase
{
	[Token(Token = "0x4007982")]
	[FieldOffset(Offset = "0xC")]
	public List<PMGCGPJEGOO> GBEHIPBDLCB;

	[Token(Token = "0x6006A40")]
	[Address(RVA = "0x360C208", Offset = "0x360C208", VA = "0x360C208")]
	public HCLCACHJAON()
	{
	}

	[Token(Token = "0x6006A41")]
	[Address(RVA = "0x360C28C", Offset = "0x360C28C", VA = "0x360C28C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006A42")]
	[Address(RVA = "0x360C47C", Offset = "0x360C47C", VA = "0x360C47C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006A43")]
	[Address(RVA = "0x360C63C", Offset = "0x360C63C", VA = "0x360C63C", Slot = "9")]
	public override void Recycle()
	{
	}
}
