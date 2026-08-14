using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200349D")]
public class UICupMatchReviewRewardListView : UIBaseView
{
	[Token(Token = "0x4014868")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Left;

	[Token(Token = "0x4014869")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RewardNameLeft;

	[Token(Token = "0x401486A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x401486B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LeftTitleBG;

	[Token(Token = "0x401486C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LeftUnSelectBG;

	[Token(Token = "0x401486D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite RewardIconLeft;

	[Token(Token = "0x401486E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LeftRewardVFX;

	[Token(Token = "0x401486F")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid GridLeft;

	[Token(Token = "0x4014870")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Right;

	[Token(Token = "0x4014871")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RewardNameRight;

	[Token(Token = "0x4014872")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RightUnSelectBG;

	[Token(Token = "0x4014873")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RightTitleBG;

	[Token(Token = "0x4014874")]
	[FieldOffset(Offset = "0x44")]
	public UISprite TicketIcon;

	[Token(Token = "0x4014875")]
	[FieldOffset(Offset = "0x48")]
	public UISprite RewardIconRight;

	[Token(Token = "0x4014876")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject RightRewardVFX;

	[Token(Token = "0x4014877")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid GridRight;

	[Token(Token = "0x601618B")]
	[Address(RVA = "0x2AAD3EC", Offset = "0x2AAD3EC", VA = "0x2AAD3EC")]
	public UICupMatchReviewRewardListView()
	{
	}

	[Token(Token = "0x601618C")]
	[Address(RVA = "0x2AAD3F4", Offset = "0x2AAD3F4", VA = "0x2AAD3F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601618D")]
	[Address(RVA = "0x2AADADC", Offset = "0x2AADADC", VA = "0x2AADADC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
