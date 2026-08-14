using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED9")]
internal class ONBLKKNIMJI : UDPClientMessageBase
{
	[Token(Token = "0x4007887")]
	[FieldOffset(Offset = "0xC")]
	public uint PBOAMDCIMGC;

	[Token(Token = "0x6006947")]
	[Address(RVA = "0x36577B8", Offset = "0x36577B8", VA = "0x36577B8")]
	public ONBLKKNIMJI()
	{
	}

	[Token(Token = "0x6006948")]
	[Address(RVA = "0x365783C", Offset = "0x365783C", VA = "0x365783C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006949")]
	[Address(RVA = "0x3657898", Offset = "0x3657898", VA = "0x3657898", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600694A")]
	[Address(RVA = "0x36578B4", Offset = "0x36578B4", VA = "0x36578B4", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x600694B")]
	[Address(RVA = "0x36578B8", Offset = "0x36578B8", VA = "0x36578B8", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
