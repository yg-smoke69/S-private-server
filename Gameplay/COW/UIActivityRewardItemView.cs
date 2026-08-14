using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B1")]
public class UIActivityRewardItemView : UIBaseView
{
	[Token(Token = "0x4013BCF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BG;

	[Token(Token = "0x4013BD0")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4013BD1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite IconSprite;

	[Token(Token = "0x4013BD2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CountLabel;

	[Token(Token = "0x4013BD3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ExchangeCountLabel;

	[Token(Token = "0x4013BD4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameLabel;

	[Token(Token = "0x4013BD5")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite WeaponSprite;

	[Token(Token = "0x4013BD6")]
	[FieldOffset(Offset = "0x30")]
	public UIToggle ToggleBtn;

	[Token(Token = "0x6015EC9")]
	[Address(RVA = "0x2FBF7C4", Offset = "0x2FBF7C4", VA = "0x2FBF7C4")]
	public UIActivityRewardItemView()
	{
	}

	[Token(Token = "0x6015ECA")]
	[Address(RVA = "0x2FBF7CC", Offset = "0x2FBF7CC", VA = "0x2FBF7CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015ECB")]
	[Address(RVA = "0x2FBFC14", Offset = "0x2FBFC14", VA = "0x2FBFC14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
