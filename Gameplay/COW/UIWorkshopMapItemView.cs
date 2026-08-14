using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A8A")]
public class UIWorkshopMapItemView : UIBaseView
{
	[Token(Token = "0x4018E6E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite CDNDefault;

	[Token(Token = "0x4018E6F")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4018E70")]
	[FieldOffset(Offset = "0x1C")]
	public UITexture GameMapBg;

	[Token(Token = "0x4018E71")]
	[FieldOffset(Offset = "0x20")]
	public UITexture GameBitMap;

	[Token(Token = "0x4018E72")]
	[FieldOffset(Offset = "0x24")]
	public UITexture GameBitMapOutLine;

	[Token(Token = "0x4018E73")]
	[FieldOffset(Offset = "0x28")]
	public UISprite IconItemSpite;

	[Token(Token = "0x6017344")]
	[Address(RVA = "0x1A33B58", Offset = "0x1A33B58", VA = "0x1A33B58")]
	public UIWorkshopMapItemView()
	{
	}

	[Token(Token = "0x6017345")]
	[Address(RVA = "0x1A33B60", Offset = "0x1A33B60", VA = "0x1A33B60", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017346")]
	[Address(RVA = "0x1A33EE8", Offset = "0x1A33EE8", VA = "0x1A33EE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
