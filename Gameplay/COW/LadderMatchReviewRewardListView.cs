using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200338A")]
public class LadderMatchReviewRewardListView : UIBaseView
{
	[Token(Token = "0x4013A63")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4013A64")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel ScrollPanel;

	[Token(Token = "0x4013A65")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x4013A66")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTextureExt CdnReward;

	[Token(Token = "0x4013A67")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TimeLimit;

	[Token(Token = "0x4013A68")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TitleContainer;

	[Token(Token = "0x4013A69")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SeasonIconLabel;

	[Token(Token = "0x4013A6A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TitleLabel;

	[Token(Token = "0x4013A6B")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget PreviewContainer;

	[Token(Token = "0x6015E55")]
	[Address(RVA = "0x1EF473C", Offset = "0x1EF473C", VA = "0x1EF473C")]
	public LadderMatchReviewRewardListView()
	{
	}

	[Token(Token = "0x6015E56")]
	[Address(RVA = "0x1EF4744", Offset = "0x1EF4744", VA = "0x1EF4744", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E57")]
	[Address(RVA = "0x1EF4BE0", Offset = "0x1EF4BE0", VA = "0x1EF4BE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
