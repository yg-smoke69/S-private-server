using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C3")]
public class UIAvatarAwakenView : UIBaseView
{
	[Token(Token = "0x4013C78")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RightArrowBtn;

	[Token(Token = "0x4013C79")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RightShowDisable;

	[Token(Token = "0x4013C7A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeftArrorwBtn;

	[Token(Token = "0x4013C7B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LeftShowDisable;

	[Token(Token = "0x4013C7C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFX_UI_Trail_Comic;

	[Token(Token = "0x4013C7D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Energy_01_Comic;

	[Token(Token = "0x4013C7E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Energy_02_Comic;

	[Token(Token = "0x4013C7F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Energy_03_Comic;

	[Token(Token = "0x4013C80")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CanUnlockEffect;

	[Token(Token = "0x4013C81")]
	[FieldOffset(Offset = "0x38")]
	public GameObject CanUnlock_1;

	[Token(Token = "0x4013C82")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject CanUnlock_2;

	[Token(Token = "0x4013C83")]
	[FieldOffset(Offset = "0x40")]
	public GameObject CanUnlock_3;

	[Token(Token = "0x4013C84")]
	[FieldOffset(Offset = "0x44")]
	public GameObject unlockEffect_Once;

	[Token(Token = "0x4013C85")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Unlock_1;

	[Token(Token = "0x4013C86")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Unlock_2;

	[Token(Token = "0x4013C87")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Unlock_3;

	[Token(Token = "0x4013C88")]
	[FieldOffset(Offset = "0x54")]
	public GameObject UnlockEffect;

	[Token(Token = "0x4013C89")]
	[FieldOffset(Offset = "0x58")]
	public UIScrollView StoryScrollView;

	[Token(Token = "0x4013C8A")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject StoryUnlock;

	[Token(Token = "0x4013C8B")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid StoryItemList;

	[Token(Token = "0x4013C8C")]
	[FieldOffset(Offset = "0x64")]
	public UIAvatarAwakenStoryItemController StoryItem;

	[Token(Token = "0x4013C8D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject AwakenState;

	[Token(Token = "0x4013C8E")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject OnGoing;

	[Token(Token = "0x4013C8F")]
	[FieldOffset(Offset = "0x70")]
	public UIButton AwardIcon;

	[Token(Token = "0x4013C90")]
	[FieldOffset(Offset = "0x74")]
	public GameObject effGo;

	[Token(Token = "0x4013C91")]
	[FieldOffset(Offset = "0x78")]
	public UIProgressBar FinishProgress;

	[Token(Token = "0x4013C92")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton AwakenBtn;

	[Token(Token = "0x4013C93")]
	[FieldOffset(Offset = "0x80")]
	public UIButton AwakenBtnDisable;

	[Token(Token = "0x4013C94")]
	[FieldOffset(Offset = "0x84")]
	public UILabel AwakenDescLabel;

	[Token(Token = "0x4013C95")]
	[FieldOffset(Offset = "0x88")]
	public GameObject AwakenTask;

	[Token(Token = "0x4013C96")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject TaskLock;

	[Token(Token = "0x4013C97")]
	[FieldOffset(Offset = "0x90")]
	public UILabel LockInfo;

	[Token(Token = "0x4013C98")]
	[FieldOffset(Offset = "0x94")]
	public UIButton GainAvatarBtn;

	[Token(Token = "0x4013C99")]
	[FieldOffset(Offset = "0x98")]
	public UIButton LevelUpBtn;

	[Token(Token = "0x4013C9A")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject taskList;

	[Token(Token = "0x4013C9B")]
	[FieldOffset(Offset = "0xA0")]
	public UIWidget listBgContent;

	[Token(Token = "0x4013C9C")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject TaskPos1;

	[Token(Token = "0x4013C9D")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject TaskPos2;

	[Token(Token = "0x4013C9E")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject TaskPos3;

	[Token(Token = "0x4013C9F")]
	[FieldOffset(Offset = "0xB0")]
	public UIAvatarAwakenTaskItemController taskItem;

	[Token(Token = "0x4013CA0")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject VFX_UI_Trail;

	[Token(Token = "0x4013CA1")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject Energy_01;

	[Token(Token = "0x4013CA2")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject Energy_02;

	[Token(Token = "0x4013CA3")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject Energy_03;

	[Token(Token = "0x4013CA4")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4013CA5")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject RefreshPrice;

	[Token(Token = "0x4013CA6")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel CurrencyNum;

	[Token(Token = "0x4013CA7")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite CurrencyIcon;

	[Token(Token = "0x4013CA8")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject RefreshLimit;

	[Token(Token = "0x6015EFF")]
	[Address(RVA = "0x1E86924", Offset = "0x1E86924", VA = "0x1E86924")]
	public UIAvatarAwakenView()
	{
	}

	[Token(Token = "0x6015F00")]
	[Address(RVA = "0x1E8692C", Offset = "0x1E8692C", VA = "0x1E8692C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F01")]
	[Address(RVA = "0x1E87B60", Offset = "0x1E87B60", VA = "0x1E87B60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
