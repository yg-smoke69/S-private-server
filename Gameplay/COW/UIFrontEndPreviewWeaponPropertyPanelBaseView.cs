using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CCF")]
public class UIFrontEndPreviewWeaponPropertyPanelBaseView : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x4011168")]
	[FieldOffset(Offset = "0xC")]
	public UIGrid ScoreGrid;

	[Token(Token = "0x4011169")]
	[FieldOffset(Offset = "0x10")]
	public UIButton WeaponSkillBtn;

	[Token(Token = "0x401116A")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SpriteWeaponSkillIcon;

	[Token(Token = "0x401116B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PropertyTitle;

	[Token(Token = "0x6012C11")]
	[Address(RVA = "0xE9396C", Offset = "0xE9396C", VA = "0xE9396C")]
	public UIFrontEndPreviewWeaponPropertyPanelBaseView()
	{
	}
}
