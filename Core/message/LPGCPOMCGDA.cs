using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED1")]
internal class LPGCPOMCGDA : UDPClientMessageBase
{
	[Token(Token = "0x4007875")]
	[FieldOffset(Offset = "0xC")]
	public int EGOMKONIBMP;

	[Token(Token = "0x4007876")]
	[FieldOffset(Offset = "0x10")]
	public List<BMMNIPHPNKI> HGMACOCMDMI;

	[Token(Token = "0x4007877")]
	[FieldOffset(Offset = "0x14")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x6006922")]
	[Address(RVA = "0x3439F74", Offset = "0x3439F74", VA = "0x3439F74")]
	public LPGCPOMCGDA()
	{
	}

	[Token(Token = "0x6006923")]
	[Address(RVA = "0x3439FF8", Offset = "0x3439FF8", VA = "0x3439FF8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006924")]
	[Address(RVA = "0x343A23C", Offset = "0x343A23C", VA = "0x343A23C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006925")]
	[Address(RVA = "0x343A428", Offset = "0x343A428", VA = "0x343A428", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006926")]
	[Address(RVA = "0x343A570", Offset = "0x343A570", VA = "0x343A570", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
