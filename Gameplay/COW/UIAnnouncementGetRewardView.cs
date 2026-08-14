using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033BD")]
public class UIAnnouncementGetRewardView : UIBaseView
{
	[Token(Token = "0x4013C50")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4013C51")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RewardTitle;

	[Token(Token = "0x4013C52")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid AwardGrid;

	[Token(Token = "0x4013C53")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OKBtn;

	[Token(Token = "0x4013C54")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BtnLabel;

	[Token(Token = "0x4013C55")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TransferItemHint;

	[Token(Token = "0x4013C56")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton FastEquipBtn;

	[Token(Token = "0x4013C57")]
	[FieldOffset(Offset = "0x30")]
	public GameObject CenterPosGO;

	[Token(Token = "0x4013C58")]
	[FieldOffset(Offset = "0x34")]
	public UIButton GoToSharePreViewBtn;

	[Token(Token = "0x4013C59")]
	[FieldOffset(Offset = "0x38")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x6015EED")]
	[Address(RVA = "0x1E6EED8", Offset = "0x1E6EED8", VA = "0x1E6EED8")]
	public UIAnnouncementGetRewardView()
	{
	}

	[Token(Token = "0x6015EEE")]
	[Address(RVA = "0x1E6EEE0", Offset = "0x1E6EEE0", VA = "0x1E6EEE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EEF")]
	[Address(RVA = "0x1E6F3DC", Offset = "0x1E6F3DC", VA = "0x1E6F3DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
