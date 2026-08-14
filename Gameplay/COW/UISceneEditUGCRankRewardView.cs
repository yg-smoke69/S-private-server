using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A0")]
public class UISceneEditUGCRankRewardView : UIBaseView
{
	[Token(Token = "0x40182A5")]
	[FieldOffset(Offset = "0x14")]
	public UISprite CreatetorExpProgress;

	[Token(Token = "0x40182A6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CreatetorExp;

	[Token(Token = "0x40182A7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GameTimeNum;

	[Token(Token = "0x40182A8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlayNum;

	[Token(Token = "0x40182A9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CreateNum;

	[Token(Token = "0x40182AA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RoomNum;

	[Token(Token = "0x40182AB")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LikeNum;

	[Token(Token = "0x40182AC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SubscribeNum;

	[Token(Token = "0x40182AD")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CreatetorName;

	[Token(Token = "0x40182AE")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList RewardShowGrid;

	[Token(Token = "0x40182AF")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite CreateIcon;

	[Token(Token = "0x40182B0")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget PreviewContainer;

	[Token(Token = "0x40182B1")]
	[FieldOffset(Offset = "0x44")]
	public GameObject RewardPreviewView;

	[Token(Token = "0x40182B2")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DataViewRoot;

	[Token(Token = "0x40182B3")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton RewardPreviewBackBtn;

	[Token(Token = "0x6017087")]
	[Address(RVA = "0x1A41338", Offset = "0x1A41338", VA = "0x1A41338")]
	public UISceneEditUGCRankRewardView()
	{
	}

	[Token(Token = "0x6017088")]
	[Address(RVA = "0x1A41340", Offset = "0x1A41340", VA = "0x1A41340", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017089")]
	[Address(RVA = "0x1A41A10", Offset = "0x1A41A10", VA = "0x1A41A10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
