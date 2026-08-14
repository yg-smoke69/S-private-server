using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003996")]
public class UISceneEditRecommendMapItemView : UIBaseView
{
	[Token(Token = "0x4018223")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018224")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNMapIcon;

	[Token(Token = "0x4018225")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GameMap;

	[Token(Token = "0x4018226")]
	[FieldOffset(Offset = "0x20")]
	public UITexture GameMapBg;

	[Token(Token = "0x4018227")]
	[FieldOffset(Offset = "0x24")]
	public UITexture GameBitOutLineMap;

	[Token(Token = "0x4018228")]
	[FieldOffset(Offset = "0x28")]
	public UITexture GameBitMap;

	[Token(Token = "0x4018229")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite IconItemSpite;

	[Token(Token = "0x401822A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ModeLabel;

	[Token(Token = "0x401822B")]
	[FieldOffset(Offset = "0x34")]
	public UILabel NameTxt;

	[Token(Token = "0x401822C")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LikeCnt;

	[Token(Token = "0x401822D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SubCnt;

	[Token(Token = "0x6017069")]
	[Address(RVA = "0x2DA6790", Offset = "0x2DA6790", VA = "0x2DA6790")]
	public UISceneEditRecommendMapItemView()
	{
	}

	[Token(Token = "0x601706A")]
	[Address(RVA = "0x2DA6798", Offset = "0x2DA6798", VA = "0x2DA6798", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601706B")]
	[Address(RVA = "0x2DA6CF4", Offset = "0x2DA6CF4", VA = "0x2DA6CF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
