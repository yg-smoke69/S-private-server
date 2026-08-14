using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200015A")]
public class HudConfigItem
{
	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x8")]
	public double CoordinateX;

	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x10")]
	public double CoordinateY;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x18")]
	public EUIAnchor Anchor;

	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x20")]
	public double BtnScale;

	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0x28")]
	public double BtnMaxScale;

	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x30")]
	public double BtnMinScale;

	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x38")]
	public double ShowAlpha;

	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x40")]
	public bool Locked;

	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x44")]
	public string HudName;

	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x48")]
	public bool Hidden;

	[Token(Token = "0x600081A")]
	[Address(RVA = "0x2C6A088", Offset = "0x2C6A088", VA = "0x2C6A088")]
	public HudConfigItem()
	{
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0x2C6A160", Offset = "0x2C6A160", VA = "0x2C6A160")]
	public HudConfigItem(HudConfigItem item)
	{
	}

	[Token(Token = "0x600081C")]
	[Address(RVA = "0x2C6A354", Offset = "0x2C6A354", VA = "0x2C6A354")]
	public void SetValueFromExistItem(HudConfigItem item)
	{
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0x2C6A4CC", Offset = "0x2C6A4CC", VA = "0x2C6A4CC")]
	public bool EqualTo(HudConfigItem item)
	{
		return default(bool);
	}
}
