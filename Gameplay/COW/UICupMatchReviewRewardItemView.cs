using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200349C")]
public class UICupMatchReviewRewardItemView : UIBaseView
{
	[Token(Token = "0x4014857")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RewardIcon;

	[Token(Token = "0x4014858")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid RewardLevel;

	[Token(Token = "0x4014859")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Level1;

	[Token(Token = "0x401485A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Level2;

	[Token(Token = "0x401485B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RewardLeft;

	[Token(Token = "0x401485C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LeftRewardBg1;

	[Token(Token = "0x401485D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LeftRewardBg2;

	[Token(Token = "0x401485E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LeftRewardBg3;

	[Token(Token = "0x401485F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LeftRewardBg4;

	[Token(Token = "0x4014860")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RewardRight;

	[Token(Token = "0x4014861")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RightRewardBg1;

	[Token(Token = "0x4014862")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RightRewardBg2;

	[Token(Token = "0x4014863")]
	[FieldOffset(Offset = "0x44")]
	public GameObject RightRewardBg3;

	[Token(Token = "0x4014864")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RightRewardBg4;

	[Token(Token = "0x4014865")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite RightBG;

	[Token(Token = "0x4014866")]
	[FieldOffset(Offset = "0x50")]
	public Transform RewardIconLeftPos;

	[Token(Token = "0x4014867")]
	[FieldOffset(Offset = "0x54")]
	public Transform RewardIconRightPos;

	[Token(Token = "0x6016188")]
	[Address(RVA = "0x2AABAC4", Offset = "0x2AABAC4", VA = "0x2AABAC4")]
	public UICupMatchReviewRewardItemView()
	{
	}

	[Token(Token = "0x6016189")]
	[Address(RVA = "0x2AABACC", Offset = "0x2AABACC", VA = "0x2AABACC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601618A")]
	[Address(RVA = "0x2AAC1AC", Offset = "0x2AAC1AC", VA = "0x2AAC1AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
