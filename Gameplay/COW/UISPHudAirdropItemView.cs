using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B4")]
public class UISPHudAirdropItemView : UIBaseView
{
	[Token(Token = "0x40183B5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AirpDropBtn;

	[Token(Token = "0x40183B6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NumLabel;

	[Token(Token = "0x40183B7")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Item1;

	[Token(Token = "0x40183B8")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Item2;

	[Token(Token = "0x40183B9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Item3;

	[Token(Token = "0x40183BA")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Item4;

	[Token(Token = "0x40183BB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Item5;

	[Token(Token = "0x40183BC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject EmptyLabel;

	[Token(Token = "0x40183BD")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SelectedBG;

	[Token(Token = "0x60170C3")]
	[Address(RVA = "0x1435FE4", Offset = "0x1435FE4", VA = "0x1435FE4")]
	public UISPHudAirdropItemView()
	{
	}

	[Token(Token = "0x60170C4")]
	[Address(RVA = "0x1435FEC", Offset = "0x1435FEC", VA = "0x1435FEC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170C5")]
	[Address(RVA = "0x1436488", Offset = "0x1436488", VA = "0x1436488")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
