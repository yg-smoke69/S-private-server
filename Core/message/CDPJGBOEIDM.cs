using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F91")]
internal class CDPJGBOEIDM : UDPClientMessageBase
{
	[Token(Token = "0x4007A87")]
	[FieldOffset(Offset = "0xC")]
	public uint HFPGENNDGME;

	[Token(Token = "0x6006C28")]
	[Address(RVA = "0x37503B0", Offset = "0x37503B0", VA = "0x37503B0")]
	public CDPJGBOEIDM()
	{
	}

	[Token(Token = "0x6006C29")]
	[Address(RVA = "0x3750434", Offset = "0x3750434", VA = "0x3750434", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006C2A")]
	[Address(RVA = "0x3750490", Offset = "0x3750490", VA = "0x3750490", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006C2B")]
	[Address(RVA = "0x37504AC", Offset = "0x37504AC", VA = "0x37504AC", Slot = "9")]
	public override void Recycle()
	{
	}
}
