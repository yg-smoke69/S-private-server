using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003570")]
public class UIGachaExtraPreviewItemView : UIBaseView
{
	[Token(Token = "0x40152E6")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x40152E7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ObtainedTag;

	[Token(Token = "0x40152E8")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite QualityBG;

	[Token(Token = "0x40152E9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RewardName;

	[Token(Token = "0x40152EA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Num;

	[Token(Token = "0x40152EB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite LimitTag;

	[Token(Token = "0x40152EC")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LimitTime;

	[Token(Token = "0x6016400")]
	[Address(RVA = "0x2478AA4", Offset = "0x2478AA4", VA = "0x2478AA4")]
	public UIGachaExtraPreviewItemView()
	{
	}

	[Token(Token = "0x6016401")]
	[Address(RVA = "0x2478AAC", Offset = "0x2478AAC", VA = "0x2478AAC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016402")]
	[Address(RVA = "0x2478E88", Offset = "0x2478E88", VA = "0x2478E88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
