using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037FD")]
public class UIIntegerateRewardPoolLevelItemView : UIBaseView
{
	[Token(Token = "0x4016BF0")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4016BF1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PriceLevel;

	[Token(Token = "0x4016BF2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Sprite;

	[Token(Token = "0x4016BF3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Sprite_1;

	[Token(Token = "0x6016BA2")]
	[Address(RVA = "0x128156C", Offset = "0x128156C", VA = "0x128156C")]
	public UIIntegerateRewardPoolLevelItemView()
	{
	}

	[Token(Token = "0x6016BA3")]
	[Address(RVA = "0x1281574", Offset = "0x1281574", VA = "0x1281574", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BA4")]
	[Address(RVA = "0x128177C", Offset = "0x128177C", VA = "0x128177C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
