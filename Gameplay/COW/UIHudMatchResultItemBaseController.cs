using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200224A")]
public class UIHudMatchResultItemBaseController : UIEasyListItemController
{
	[Token(Token = "0x400D6A7")]
	[FieldOffset(Offset = "0x38")]
	protected List<int> m_InfoTypeList;

	[Token(Token = "0x400D6A8")]
	[FieldOffset(Offset = "0x3C")]
	protected int[] m_InfoTypeForUGC;

	[Token(Token = "0x400D6A9")]
	[FieldOffset(Offset = "0x40")]
	protected TeammateStats m_TeammateStats;

	[Token(Token = "0x400D6AA")]
	[FieldOffset(Offset = "0x44")]
	protected TeamTotalStats m_TeamTotalStats;

	[Token(Token = "0x400D6AB")]
	[FieldOffset(Offset = "0x60")]
	private ulong _003CTargetAccountID_003Ek__BackingField;

	[Token(Token = "0x400D6AC")]
	[FieldOffset(Offset = "0x68")]
	private IHAAMHPPLMG m_TargetPlayerID;

	[Token(Token = "0x400D6AD")]
	[FieldOffset(Offset = "0x80")]
	private string m_TargetName;

	[Token(Token = "0x400D6AE")]
	[FieldOffset(Offset = "0x84")]
	protected EMatchResultPageType m_PageType;

	[Token(Token = "0x400D6AF")]
	[FieldOffset(Offset = "0x88")]
	protected bool m_HasBanner;

	[Token(Token = "0x400D6B0")]
	[FieldOffset(Offset = "0x8C")]
	public Func<ulong, ExtraPlayerDataForMatchResult> GetExtraPlayerDataForMatchResultDelegate;

	[Token(Token = "0x400D6B1")]
	[FieldOffset(Offset = "0x90")]
	public Func<ulong, string, ExtraPlayerDataForMatchResult> GetExtraPlayerDataIncludingBotForMatchResultDelegate;

	[Token(Token = "0x400D6B2")]
	[FieldOffset(Offset = "0x94")]
	private ExtraPlayerDataForMatchResult _003CExtraPlayerData_003Ek__BackingField;

	[Token(Token = "0x400D6B3")]
	[FieldOffset(Offset = "0x98")]
	protected bool AutoShowAddFriendAfterLike;

	[Token(Token = "0x400D6B4")]
	[FieldOffset(Offset = "0x9C")]
	protected UIButton m_AddFriendBtn;

	[Token(Token = "0x400D6B5")]
	[FieldOffset(Offset = "0xA0")]
	protected UIButton m_ReportBtn;

	[Token(Token = "0x400D6B6")]
	[FieldOffset(Offset = "0xA4")]
	protected UILabel m_LikeNum;

	[Token(Token = "0x400D6B7")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_LikeIcon;

	[Token(Token = "0x400D6B8")]
	[FieldOffset(Offset = "0xAC")]
	private GameObject m_NormalRoot;

	[Token(Token = "0x400D6B9")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_DataRoot;

	[Token(Token = "0x400D6BA")]
	[FieldOffset(Offset = "0xB4")]
	private GameObject m_FakeBg;

	[Token(Token = "0x400D6BB")]
	[FieldOffset(Offset = "0xB8")]
	private UIEffectSprite m_BannerBg;

	[Token(Token = "0x400D6BC")]
	[FieldOffset(Offset = "0xBC")]
	protected UIButton m_LikeBtn;

	[Token(Token = "0x400D6BD")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject m_LikeVFX;

	[Token(Token = "0x400D6BE")]
	[FieldOffset(Offset = "0xC4")]
	private GameObject m_AddFriendTips;

	[Token(Token = "0x400D6BF")]
	[FieldOffset(Offset = "0xC8")]
	private UIButton m_TipsButton;

	[Token(Token = "0x400D6C0")]
	[FieldOffset(Offset = "0xCC")]
	protected GameObject SelfBG;

	[Token(Token = "0x400D6C1")]
	[FieldOffset(Offset = "0xD0")]
	protected GameObject WinMVPGrade;

	[Token(Token = "0x400D6C2")]
	[FieldOffset(Offset = "0xD4")]
	protected GameObject FailMVPGrade;

	[Token(Token = "0x400D6C3")]
	[FieldOffset(Offset = "0xD8")]
	protected UILabel NormalGrade;

	[Token(Token = "0x1700106F")]
	public ulong TargetAccountID
	{
		[Token(Token = "0x600BA78")]
		[Address(RVA = "0x19B3420", Offset = "0x19B3420", VA = "0x19B3420")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600BA79")]
		[Address(RVA = "0x19B3428", Offset = "0x19B3428", VA = "0x19B3428")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001070")]
	public ExtraPlayerDataForMatchResult ExtraPlayerData
	{
		[Token(Token = "0x600BA7A")]
		[Address(RVA = "0x19B3438", Offset = "0x19B3438", VA = "0x19B3438")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BA7B")]
		[Address(RVA = "0x19B3440", Offset = "0x19B3440", VA = "0x19B3440")]
		private set
		{
		}
	}

	[Token(Token = "0x17001071")]
	public bool HasLike
	{
		[Token(Token = "0x600BA7C")]
		[Address(RVA = "0x19B3448", Offset = "0x19B3448", VA = "0x19B3448")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001072")]
	protected UIButton AddFriendBtn
	{
		[Token(Token = "0x600BA7D")]
		[Address(RVA = "0x19B34C0", Offset = "0x19B34C0", VA = "0x19B34C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001073")]
	protected UIButton ReportBtn
	{
		[Token(Token = "0x600BA7E")]
		[Address(RVA = "0x19B35E0", Offset = "0x19B35E0", VA = "0x19B35E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001074")]
	protected UILabel LikeNum
	{
		[Token(Token = "0x600BA7F")]
		[Address(RVA = "0x19B3700", Offset = "0x19B3700", VA = "0x19B3700")]
		set
		{
		}
	}

	[Token(Token = "0x17001075")]
	protected GameObject LikeIcon
	{
		[Token(Token = "0x600BA80")]
		[Address(RVA = "0x19B37A4", Offset = "0x19B37A4", VA = "0x19B37A4")]
		set
		{
		}
	}

	[Token(Token = "0x17001076")]
	protected GameObject NormalRoot
	{
		[Token(Token = "0x600BA81")]
		[Address(RVA = "0x19B3804", Offset = "0x19B3804", VA = "0x19B3804")]
		set
		{
		}
	}

	[Token(Token = "0x17001077")]
	protected GameObject DataRoot
	{
		[Token(Token = "0x600BA82")]
		[Address(RVA = "0x19B3864", Offset = "0x19B3864", VA = "0x19B3864")]
		set
		{
		}
	}

	[Token(Token = "0x17001078")]
	protected GameObject FakeBg
	{
		[Token(Token = "0x600BA83")]
		[Address(RVA = "0x19B38C4", Offset = "0x19B38C4", VA = "0x19B38C4")]
		set
		{
		}
	}

	[Token(Token = "0x17001079")]
	protected UIEffectSprite BannerBg
	{
		[Token(Token = "0x600BA84")]
		[Address(RVA = "0x19B3924", Offset = "0x19B3924", VA = "0x19B3924")]
		set
		{
		}
	}

	[Token(Token = "0x1700107A")]
	protected UIButton LikeBtn
	{
		[Token(Token = "0x600BA85")]
		[Address(RVA = "0x19B3984", Offset = "0x19B3984", VA = "0x19B3984")]
		set
		{
		}
	}

	[Token(Token = "0x1700107B")]
	protected GameObject LikeVFX
	{
		[Token(Token = "0x600BA86")]
		[Address(RVA = "0x19B3AAC", Offset = "0x19B3AAC", VA = "0x19B3AAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700107C")]
	protected GameObject AddFriendTips
	{
		[Token(Token = "0x600BA87")]
		[Address(RVA = "0x19B3B30", Offset = "0x19B3B30", VA = "0x19B3B30")]
		set
		{
		}
	}

	[Token(Token = "0x1700107D")]
	protected UIButton TipsButton
	{
		[Token(Token = "0x600BA88")]
		[Address(RVA = "0x19B3BB4", Offset = "0x19B3BB4", VA = "0x19B3BB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700107E")]
	public string TargetName
	{
		[Token(Token = "0x600BA89")]
		[Address(RVA = "0x19B3CD4", Offset = "0x19B3CD4", VA = "0x19B3CD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BA8A")]
		[Address(RVA = "0x19B3D2C", Offset = "0x19B3D2C", VA = "0x19B3D2C")]
		set
		{
		}
	}

	[Token(Token = "0x1700107F")]
	public IHAAMHPPLMG TargetPlayerID
	{
		[Token(Token = "0x600BA8B")]
		[Address(RVA = "0x19B3D8C", Offset = "0x19B3D8C", VA = "0x19B3D8C")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x600BA8C")]
		[Address(RVA = "0x19B3E00", Offset = "0x19B3E00", VA = "0x19B3E00")]
		set
		{
		}
	}

	[Token(Token = "0x600BA76")]
	[Address(RVA = "0x19B324C", Offset = "0x19B324C", VA = "0x19B324C")]
	public UIHudMatchResultItemBaseController()
	{
	}

	[Token(Token = "0x600BA77")]
	[Address(RVA = "0x19B3378", Offset = "0x19B3378", VA = "0x19B3378")]
	public void SetTeamTotalStats(TeamTotalStats value)
	{
	}

	[Token(Token = "0x600BA8D")]
	[Address(RVA = "0x19B3EAC", Offset = "0x19B3EAC", VA = "0x19B3EAC")]
	public void SetInfoTypeList(List<int> list)
	{
	}

	[Token(Token = "0x600BA8E")]
	[Address(RVA = "0x19B3F0C", Offset = "0x19B3F0C", VA = "0x19B3F0C")]
	public void SetInfoTypeList(int[] arr)
	{
	}

	[Token(Token = "0x600BA8F")]
	[Address(RVA = "0x19B3F6C", Offset = "0x19B3F6C", VA = "0x19B3F6C", Slot = "37")]
	public virtual void SetPlayerData(TeammateStats stats, bool single)
	{
	}

	[Token(Token = "0x600BA90")]
	[Address(RVA = "0x19B4510", Offset = "0x19B4510", VA = "0x19B4510", Slot = "38")]
	public virtual void SetPlayerData(UGCPlayerStats stats, bool single)
	{
	}

	[Token(Token = "0x600BA91")]
	[Address(RVA = "0x19B4398", Offset = "0x19B4398", VA = "0x19B4398")]
	public void SetPlayerLikedCount(uint count)
	{
	}

	[Token(Token = "0x600BA92")]
	[Address(RVA = "0x19B4774", Offset = "0x19B4774", VA = "0x19B4774")]
	public void ShowLikeIcon(bool show)
	{
	}

	[Token(Token = "0x600BA93")]
	[Address(RVA = "0x19B489C", Offset = "0x19B489C", VA = "0x19B489C")]
	public void ShowAddFriendButton(bool show)
	{
	}

	[Token(Token = "0x600BA94")]
	[Address(RVA = "0x19B4B98", Offset = "0x19B4B98", VA = "0x19B4B98", Slot = "39")]
	public virtual void ShowReportButton(bool show)
	{
	}

	[Token(Token = "0x600BA95")]
	[Address(RVA = "0x19B4D18", Offset = "0x19B4D18", VA = "0x19B4D18")]
	public void ShowLikeContainer(bool show)
	{
	}

	[Token(Token = "0x600BA96")]
	[Address(RVA = "0x19B5024", Offset = "0x19B5024", VA = "0x19B5024")]
	public void ShowLike(bool show)
	{
	}

	[Token(Token = "0x600BA97")]
	[Address(RVA = "0x19B51DC", Offset = "0x19B51DC", VA = "0x19B51DC")]
	public void SetGradeInfo(bool isMVP, bool win, string gradeTxt = "", bool hideScroe = false)
	{
	}

	[Token(Token = "0x600BA98")]
	[Address(RVA = "0x19B5438", Offset = "0x19B5438", VA = "0x19B5438", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BA99")]
	[Address(RVA = "0x19B5578", Offset = "0x19B5578", VA = "0x19B5578", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BA9A")]
	[Address(RVA = "0x19B55E8", Offset = "0x19B55E8", VA = "0x19B55E8", Slot = "40")]
	protected virtual void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x600BA9B")]
	[Address(RVA = "0x19B5664", Offset = "0x19B5664", VA = "0x19B5664", Slot = "41")]
	public virtual void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	[Token(Token = "0x600BA9C")]
	[Address(RVA = "0x19B580C", Offset = "0x19B580C", VA = "0x19B580C", Slot = "42")]
	protected virtual void UpdateBannerVisbility()
	{
	}

	[Token(Token = "0x600BA9D")]
	[Address(RVA = "0x19B59D8", Offset = "0x19B59D8", VA = "0x19B59D8", Slot = "43")]
	protected virtual void UpdateBannerInfo(uint bannerID)
	{
	}

	[Token(Token = "0x600BA9E")]
	[Address(RVA = "0x19B5C14", Offset = "0x19B5C14", VA = "0x19B5C14", Slot = "44")]
	protected virtual void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	[Token(Token = "0x600BA9F")]
	[Address(RVA = "0x19B5C84", Offset = "0x19B5C84", VA = "0x19B5C84")]
	protected void UpdateInfoData(UIHudMatchResultItemProgressBar bar, TeammateStats player, int index)
	{
	}

	[Token(Token = "0x600BAA0")]
	[Address(RVA = "0x19B601C", Offset = "0x19B601C", VA = "0x19B601C")]
	protected void UpdateInfoData(UILabel infoTxt, TeammateStats player, int index)
	{
	}

	[Token(Token = "0x600BAA1")]
	[Address(RVA = "0x19B75EC", Offset = "0x19B75EC", VA = "0x19B75EC")]
	protected void UpdateInfoDataForUGC(UILabel label, int index, UGCPlayerStats playerStats)
	{
	}

	[Token(Token = "0x600BAA2")]
	[Address(RVA = "0x19B77C4", Offset = "0x19B77C4", VA = "0x19B77C4", Slot = "45")]
	protected virtual void OnClickAddFriendBtn()
	{
	}

	[Token(Token = "0x600BAA3")]
	[Address(RVA = "0x19B7BE8", Offset = "0x19B7BE8", VA = "0x19B7BE8", Slot = "46")]
	protected virtual void OnClickReportBtn()
	{
	}

	[Token(Token = "0x600BAA4")]
	[Address(RVA = "0x19B7F10", Offset = "0x19B7F10", VA = "0x19B7F10", Slot = "47")]
	protected virtual void OnClickTipsBtn()
	{
	}

	[Token(Token = "0x600BAA5")]
	[Address(RVA = "0x19B8010", Offset = "0x19B8010", VA = "0x19B8010")]
	private void OnClickLikeBtn()
	{
	}

	[Token(Token = "0x600BAA6")]
	[Address(RVA = "0x19B4204", Offset = "0x19B4204", VA = "0x19B4204")]
	protected void SetIsSelf(bool self)
	{
	}

	[Token(Token = "0x600BAA7")]
	[Address(RVA = "0x19B86FC", Offset = "0x19B86FC", VA = "0x19B86FC", Slot = "48")]
	protected virtual void OnReportCheatSent(object[] param)
	{
	}

	[Token(Token = "0x600BAA8")]
	[Address(RVA = "0x19B8840", Offset = "0x19B8840", VA = "0x19B8840")]
	private void OnAddFriendRecommendClick(object[] param)
	{
	}

	[Token(Token = "0x600BAA9")]
	[Address(RVA = "0x19B8A10", Offset = "0x19B8A10", VA = "0x19B8A10")]
	public void BeforeScreenShot()
	{
	}

	[Token(Token = "0x600BAAA")]
	[Address(RVA = "0x19B5E10", Offset = "0x19B5E10", VA = "0x19B5E10")]
	public void SetMatchResultPlayerInfoData(UIHudMatchResultItemProgressBar bar, TeammateStats player, EMatchResultPlayerInfoType type)
	{
	}

	[Token(Token = "0x600BAAB")]
	[Address(RVA = "0x19B61A4", Offset = "0x19B61A4", VA = "0x19B61A4")]
	public static void SetMatchResultPlayerInfoData(UILabel label, TeammateStats player, EMatchResultPlayerInfoType type)
	{
	}

	[Token(Token = "0x600BAAC")]
	[Address(RVA = "0x19B8E64", Offset = "0x19B8E64", VA = "0x19B8E64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
