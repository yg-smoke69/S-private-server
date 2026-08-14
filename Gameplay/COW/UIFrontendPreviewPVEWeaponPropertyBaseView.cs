using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CC4")]
public class UIFrontendPreviewPVEWeaponPropertyBaseView : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x4011159")]
	[FieldOffset(Offset = "0xC")]
	public GameObject PropertyScore;

	[Token(Token = "0x401115A")]
	[FieldOffset(Offset = "0x10")]
	public UISprite BG;

	[Token(Token = "0x401115B")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ScoreGrid;

	[Token(Token = "0x401115C")]
	[FieldOffset(Offset = "0x18")]
	public UIPVEWeaponPropertyItemView ItemView;

	[Token(Token = "0x6012BDA")]
	[Address(RVA = "0x26593FC", Offset = "0x26593FC", VA = "0x26593FC")]
	public UIFrontendPreviewPVEWeaponPropertyBaseView()
	{
	}
}
