using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200395A")]
public class UIRewardPreviewItemView : UIBaseView
{
	[Token(Token = "0x4018022")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4018023")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ObtainedTag;

	[Token(Token = "0x4018024")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RewardName;

	[Token(Token = "0x4018025")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Num;

	[Token(Token = "0x4018026")]
	[FieldOffset(Offset = "0x24")]
	public UISprite QualityBG;

	[Token(Token = "0x4018027")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LimitTime;

	[Token(Token = "0x4018028")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite LimitTag;

	[Token(Token = "0x6016FB5")]
	[Address(RVA = "0x1E58B28", Offset = "0x1E58B28", VA = "0x1E58B28")]
	public UIRewardPreviewItemView()
	{
	}

	[Token(Token = "0x6016FB6")]
	[Address(RVA = "0x1E58B30", Offset = "0x1E58B30", VA = "0x1E58B30", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FB7")]
	[Address(RVA = "0x1E58F0C", Offset = "0x1E58F0C", VA = "0x1E58F0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
