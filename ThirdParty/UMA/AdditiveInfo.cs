using System;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x2003C90")]
public class AdditiveInfo
{
	[Token(Token = "0x4019BEC")]
	[FieldOffset(Offset = "0x8")]
	public EAdditiveTargetSlot TargetSlot;

	[Token(Token = "0x4019BED")]
	[FieldOffset(Offset = "0x9")]
	public byte SlotIndex;

	[Token(Token = "0x4019BEE")]
	[FieldOffset(Offset = "0xA")]
	public byte OverlayOrder;

	[Token(Token = "0x4019BEF")]
	[FieldOffset(Offset = "0xB")]
	public EAdditiveMethod Method;

	[Token(Token = "0x4019BF0")]
	[FieldOffset(Offset = "0xC")]
	public EAdditiveOrderType OrderType;

	[Token(Token = "0x170019A8")]
	public EWardrobeSlot TargetWardrobeSlot
	{
		[Token(Token = "0x6018395")]
		[Address(RVA = "0x224C0BC", Offset = "0x224C0BC", VA = "0x224C0BC")]
		get
		{
			return default(EWardrobeSlot);
		}
	}

	[Token(Token = "0x6018394")]
	[Address(RVA = "0x224C0B4", Offset = "0x224C0B4", VA = "0x224C0B4")]
	public AdditiveInfo()
	{
	}

	[Token(Token = "0x6018396")]
	[Address(RVA = "0x224C0C8", Offset = "0x224C0C8", VA = "0x224C0C8")]
	public byte SerializeToByte()
	{
		return default(byte);
	}

	[Token(Token = "0x6018397")]
	[Address(RVA = "0x224C108", Offset = "0x224C108", VA = "0x224C108")]
	public static AdditiveInfo DeserializeFromByte(byte b)
	{
		return null;
	}

	[Token(Token = "0x6018398")]
	[Address(RVA = "0x224C1F8", Offset = "0x224C1F8", VA = "0x224C1F8")]
	public static bool NotNullOrEmpty(AdditiveInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6018399")]
	[Address(RVA = "0x224C214", Offset = "0x224C214", VA = "0x224C214")]
	public static bool IsNullOrEmpty(AdditiveInfo info)
	{
		return default(bool);
	}
}
