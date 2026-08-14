using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003830")]
public class UILoadingPlayerInfoItemView : UIBaseView
{
	[Token(Token = "0x4016E92")]
	[FieldOffset(Offset = "0x14")]
	public Animation Anim;

	[Token(Token = "0x4016E93")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteIcon;

	[Token(Token = "0x4016E94")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelData;

	[Token(Token = "0x4016E95")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteHideData;

	[Token(Token = "0x4016E96")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelTitle;

	[Token(Token = "0x6016C3B")]
	[Address(RVA = "0x215B574", Offset = "0x215B574", VA = "0x215B574")]
	public UILoadingPlayerInfoItemView()
	{
	}

	[Token(Token = "0x6016C3C")]
	[Address(RVA = "0x215B5EC", Offset = "0x215B5EC", VA = "0x215B5EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C3D")]
	[Address(RVA = "0x215B914", Offset = "0x215B914", VA = "0x215B914")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
