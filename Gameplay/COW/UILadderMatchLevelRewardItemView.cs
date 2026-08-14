using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200380C")]
public class UILadderMatchLevelRewardItemView : UIBaseView
{
	[Token(Token = "0x4016C8E")]
	[FieldOffset(Offset = "0x14")]
	public Transform RewardItemNode;

	[Token(Token = "0x4016C8F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemNormalBgBlackPx;

	[Token(Token = "0x4016C90")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ItemNormalBgYellowPx;

	[Token(Token = "0x4016C91")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ProgreessBarContainer;

	[Token(Token = "0x4016C92")]
	[FieldOffset(Offset = "0x24")]
	public UISprite RankItem;

	[Token(Token = "0x4016C93")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RankLabel;

	[Token(Token = "0x4016C94")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UILadderMatchLevelRewardItem;

	[Token(Token = "0x4016C95")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Thumb;

	[Token(Token = "0x4016C96")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Arrow;

	[Token(Token = "0x4016C97")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArrowDark;

	[Token(Token = "0x6016BCF")]
	[Address(RVA = "0x1AF2D30", Offset = "0x1AF2D30", VA = "0x1AF2D30")]
	public UILadderMatchLevelRewardItemView()
	{
	}

	[Token(Token = "0x6016BD0")]
	[Address(RVA = "0x1AF2D38", Offset = "0x1AF2D38", VA = "0x1AF2D38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BD1")]
	[Address(RVA = "0x1AF31D0", Offset = "0x1AF31D0", VA = "0x1AF31D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
