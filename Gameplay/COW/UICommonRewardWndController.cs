using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200258B")]
public class UICommonRewardWndController : UIPopupWindowController
{
	[Token(Token = "0x200258C")]
	public enum WndStyleEnum
	{
		[Token(Token = "0x400E878")]
		COMMON,
		[Token(Token = "0x400E879")]
		BRIGHT1,
		[Token(Token = "0x400E87A")]
		LEGENDDOWBLEROW,
		[Token(Token = "0x400E87B")]
		LEGENDONEROW,
		[Token(Token = "0x400E87C")]
		NEWONEROW,
		[Token(Token = "0x400E87D")]
		NEWDOUBLEROW,
		[Token(Token = "0x400E87E")]
		Hurricane,
		[Token(Token = "0x400E87F")]
		BOYBANDB,
		[Token(Token = "0x400E880")]
		FFWS03,
		[Token(Token = "0x400E881")]
		SEASONLADDERRANKUP,
		[Token(Token = "0x400E882")]
		DIGITALUNIVERSEB
	}

	[Token(Token = "0x200258D")]
	public enum RepurchaseCurrencyType
	{
		[Token(Token = "0x400E884")]
		NONE,
		[Token(Token = "0x400E885")]
		FREE,
		[Token(Token = "0x400E886")]
		COUPON,
		[Token(Token = "0x400E887")]
		GOLD,
		[Token(Token = "0x400E888")]
		DIAMOND
	}

	[Token(Token = "0x200258E")]
	public delegate void PurchaseDelegate(bool isRepurchase);

	[Token(Token = "0x200258F")]
	private sealed class _003CInitOptionalRewards_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E889")]
		[FieldOffset(Offset = "0x8")]
		internal CommonRewardItemInfo info;

		[Token(Token = "0x600DBEC")]
		[Address(RVA = "0x1EB05A4", Offset = "0x1EB05A4", VA = "0x1EB05A4")]
		public _003CInitOptionalRewards_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DBED")]
		[Address(RVA = "0x1EB05AC", Offset = "0x1EB05AC", VA = "0x1EB05AC")]
		internal bool _003C_003Em__0(OptionalBundleShowData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002590")]
	private sealed class _003CRefreshOptionalViews_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E88A")]
		[FieldOffset(Offset = "0x8")]
		internal uint order;

		[Token(Token = "0x600DBEE")]
		[Address(RVA = "0x1EB06A8", Offset = "0x1EB06A8", VA = "0x1EB06A8")]
		public _003CRefreshOptionalViews_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DBEF")]
		[Address(RVA = "0x1EB06B0", Offset = "0x1EB06B0", VA = "0x1EB06B0")]
		internal bool _003C_003Em__0(OptionalBundleShowData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002591")]
	private sealed class _003COnFastEquipClick_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E88B")]
		[FieldOffset(Offset = "0x8")]
		internal CSSharedItemData itemData;

		[Token(Token = "0x600DBF0")]
		[Address(RVA = "0x1EB05F8", Offset = "0x1EB05F8", VA = "0x1EB05F8")]
		public _003COnFastEquipClick_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600DBF1")]
		[Address(RVA = "0x1EB0600", Offset = "0x1EB0600", VA = "0x1EB0600")]
		internal bool _003C_003Em__0(PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002592")]
	private sealed class _003COnFastEquipClick_003Ec__AnonStorey3
	{
		[Token(Token = "0x400E88C")]
		[FieldOffset(Offset = "0x8")]
		internal PetSkinData skinData;

		[Token(Token = "0x600DBF2")]
		[Address(RVA = "0x1EB064C", Offset = "0x1EB064C", VA = "0x1EB064C")]
		public _003COnFastEquipClick_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600DBF3")]
		[Address(RVA = "0x1EB0654", Offset = "0x1EB0654", VA = "0x1EB0654")]
		internal bool _003C_003Em__0(PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E83D")]
	[FieldOffset(Offset = "0x48")]
	public Action m_CloseAction;

	[Token(Token = "0x400E83E")]
	[FieldOffset(Offset = "0x4C")]
	public Action m_OpenAction;

	[Token(Token = "0x400E83F")]
	[FieldOffset(Offset = "0x50")]
	public bool m_EnableFastEquip;

	[Token(Token = "0x400E840")]
	[FieldOffset(Offset = "0x51")]
	public bool m_IsBigPrice;

	[Token(Token = "0x400E841")]
	[FieldOffset(Offset = "0x52")]
	public bool m_IsAvatarLink;

	[Token(Token = "0x400E842")]
	[FieldOffset(Offset = "0x53")]
	public bool m_EnableOptionalSelect;

	[Token(Token = "0x400E843")]
	[FieldOffset(Offset = "0x54")]
	public bool m_EnableOKBtn;

	[Token(Token = "0x400E844")]
	[FieldOffset(Offset = "0x58")]
	private UICommonRewardWndView m_View;

	[Token(Token = "0x400E845")]
	[FieldOffset(Offset = "0x5C")]
	private CommonRewardWindowStyleBaseController m_StyleBaseController;

	[Token(Token = "0x400E846")]
	[FieldOffset(Offset = "0x60")]
	private CommonRewardWnd_BGStyle_CommonView m_StyleView;

	[Token(Token = "0x400E847")]
	[FieldOffset(Offset = "0x64")]
	private UICommonRewardItemController m_ExtraReward;

	[Token(Token = "0x400E848")]
	[FieldOffset(Offset = "0x68")]
	private List<UICommonRewardItemController> m_RewardList;

	[Token(Token = "0x400E849")]
	[FieldOffset(Offset = "0x6C")]
	private CommonRewardItemInfo m_FreeRewardInfo;

	[Token(Token = "0x400E84A")]
	[FieldOffset(Offset = "0x70")]
	private List<CommonRewardItemInfo> m_RewardInfoList;

	[Token(Token = "0x400E84B")]
	[FieldOffset(Offset = "0x74")]
	private List<OptionalBundleShowData> m_OptionalBundleShowDataList;

	[Token(Token = "0x400E84C")]
	[FieldOffset(Offset = "0x78")]
	private int m_CurRewardIdx;

	[Token(Token = "0x400E84D")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_VoucherID;

	[Token(Token = "0x400E84E")]
	[FieldOffset(Offset = "0x80")]
	private uint m_ShowRewardDC;

	[Token(Token = "0x400E84F")]
	[FieldOffset(Offset = "0x84")]
	private uint m_ScrollviewDC;

	[Token(Token = "0x400E850")]
	[FieldOffset(Offset = "0x88")]
	public uint m_SelectAvatarID;

	[Token(Token = "0x400E851")]
	[FieldOffset(Offset = "0x8C")]
	public uint m_SelectPetId;

	[Token(Token = "0x400E852")]
	[FieldOffset(Offset = "0x90")]
	public bool m_ChildWndKeepStyle;

	[Token(Token = "0x400E853")]
	[FieldOffset(Offset = "0x91")]
	private bool m_HasBundle;

	[Token(Token = "0x400E854")]
	[FieldOffset(Offset = "0x92")]
	private bool m_HasTreesureBoxOnlyOne;

	[Token(Token = "0x400E855")]
	[FieldOffset(Offset = "0x94")]
	public Dictionary<uint, uint> m_SelectPetSkinDict;

	[Token(Token = "0x400E856")]
	private const int m_MaxRewardCnt1Row = 5;

	[Token(Token = "0x400E857")]
	private const int m_MaxRewardCnt2Row = 11;

	[Token(Token = "0x400E858")]
	[FieldOffset(Offset = "0x98")]
	private float m_ShowRewardSecondInterval;

	[Token(Token = "0x400E859")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_Instant;

	[Token(Token = "0x400E85A")]
	[FieldOffset(Offset = "0x9D")]
	private bool m_First;

	[Token(Token = "0x400E85B")]
	[FieldOffset(Offset = "0x9E")]
	private bool m_IsShowAll;

	[Token(Token = "0x400E85C")]
	[FieldOffset(Offset = "0x9F")]
	private bool m_IsDestory;

	[Token(Token = "0x400E85D")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_IsCrate;

	[Token(Token = "0x400E85E")]
	[FieldOffset(Offset = "0xA1")]
	private bool m_HasShownFinished;

	[Token(Token = "0x400E85F")]
	[FieldOffset(Offset = "0xA2")]
	private bool m_UseNewItem;

	[Token(Token = "0x400E860")]
	[FieldOffset(Offset = "0xA3")]
	private bool m_ShowTween;

	[Token(Token = "0x400E861")]
	[FieldOffset(Offset = "0xA4")]
	private GameObject m_FastEquipNormalBg;

	[Token(Token = "0x400E862")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_FastEquipDisableBg;

	[Token(Token = "0x400E863")]
	[FieldOffset(Offset = "0xAC")]
	private UILabel m_FastEquipLabel;

	[Token(Token = "0x400E864")]
	[FieldOffset(Offset = "0xB0")]
	private Color m_FastEquipNormalColor;

	[Token(Token = "0x400E865")]
	[FieldOffset(Offset = "0xC0")]
	private Color m_FastEquipDisableColor;

	[Token(Token = "0x400E866")]
	[FieldOffset(Offset = "0xD0")]
	private WndStyleEnum m_wndStyle;

	[Token(Token = "0x400E867")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_EnableShowFeature;

	[Token(Token = "0x400E868")]
	[FieldOffset(Offset = "0xD8")]
	private RepurchaseCurrencyType m_RepurchaseCurrencyType;

	[Token(Token = "0x400E869")]
	[FieldOffset(Offset = "0xDC")]
	private PurchaseDelegate m_PurchaseDelegate;

	[Token(Token = "0x400E86A")]
	[FieldOffset(Offset = "0xE0")]
	private int m_EquippedSuccessNum;

	[Token(Token = "0x400E86B")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_HaveShowFailTip;

	[Token(Token = "0x400E86C")]
	[FieldOffset(Offset = "0xE8")]
	public Dictionary<uint, UICommonRewardItemController> m_SelectedDict;

	[Token(Token = "0x400E86D")]
	[FieldOffset(Offset = "0xEC")]
	private uint m_AutoCloseDC;

	[Token(Token = "0x400E86E")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_EnableOKBtnClick;

	[Token(Token = "0x400E86F")]
	[FieldOffset(Offset = "0xF1")]
	private bool m_HasABNotReadyItem;

	[Token(Token = "0x400E870")]
	[FieldOffset(Offset = "0xF4")]
	private uint m_EquipAvatar;

	[Token(Token = "0x400E871")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_EquipCloth;

	[Token(Token = "0x400E872")]
	[FieldOffset(Offset = "0xFC")]
	private List<uint> m_EquipClothList;

	[Token(Token = "0x400E873")]
	[FieldOffset(Offset = "0x100")]
	private bool m_OwnedSecondConfirm;

	[Token(Token = "0x400E874")]
	[FieldOffset(Offset = "0x104")]
	private Dictionary<uint, long> m_ReturnIdNumDic;

	[Token(Token = "0x400E875")]
	[FieldOffset(Offset = "0x108")]
	private long m_ReturnCoinNum;

	[Token(Token = "0x400E876")]
	[FieldOffset(Offset = "0x110")]
	private long m_ReturnDiamondNum;

	[Token(Token = "0x600DB93")]
	[Address(RVA = "0x2CEABF4", Offset = "0x2CEABF4", VA = "0x2CEABF4")]
	public UICommonRewardWndController()
	{
	}

	[Token(Token = "0x600DB94")]
	[Address(RVA = "0x2CEADD4", Offset = "0x2CEADD4", VA = "0x2CEADD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB95")]
	[Address(RVA = "0x2CEAE78", Offset = "0x2CEAE78", VA = "0x2CEAE78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB96")]
	[Address(RVA = "0x2CEB54C", Offset = "0x2CEB54C", VA = "0x2CEB54C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600DB97")]
	[Address(RVA = "0x2CEB67C", Offset = "0x2CEB67C", VA = "0x2CEB67C")]
	public void SetRewardsData(List<CommonRewardItemInfo> infoList, [Optional] CommonRewardItemInfo extraRewardInfo, [Optional] CommonRewardItemInfo freeRewardInfo)
	{
	}

	[Token(Token = "0x600DB98")]
	[Address(RVA = "0x2CEBCF0", Offset = "0x2CEBCF0", VA = "0x2CEBCF0")]
	public void SetOptionalRewardData(List<CommonRewardItemInfo> infoList, List<OptionalBundleShowData> optionalBundleShowDataList)
	{
	}

	[Token(Token = "0x600DB99")]
	[Address(RVA = "0x2CEC384", Offset = "0x2CEC384", VA = "0x2CEC384")]
	public void SetLadderRankData(ELadderRankUpMatchType rankType, string rankName, ResourceID iconRes, uint rank)
	{
	}

	[Token(Token = "0x600DB9A")]
	[Address(RVA = "0x2CEC544", Offset = "0x2CEC544", VA = "0x2CEC544")]
	public void ShowView(bool enableShowOneByOneAnim = false)
	{
	}

	[Token(Token = "0x600DB9B")]
	[Address(RVA = "0x2CED90C", Offset = "0x2CED90C", VA = "0x2CED90C")]
	public void SetWndTitle(string key)
	{
	}

	[Token(Token = "0x600DB9C")]
	[Address(RVA = "0x2CEDA60", Offset = "0x2CEDA60", VA = "0x2CEDA60")]
	public void SetTransferHint(string content)
	{
	}

	[Token(Token = "0x600DB9D")]
	[Address(RVA = "0x2CEDC2C", Offset = "0x2CEDC2C", VA = "0x2CEDC2C")]
	public void SetTransferHintLabel(string content)
	{
	}

	[Token(Token = "0x600DB9E")]
	[Address(RVA = "0x2CEDDAC", Offset = "0x2CEDDAC", VA = "0x2CEDDAC")]
	public void SelectWndStyle(WndStyleEnum style)
	{
	}

	[Token(Token = "0x600DB9F")]
	[Address(RVA = "0x2CEE718", Offset = "0x2CEE718", VA = "0x2CEE718")]
	public void EnableShowFeature(List<uint> conditions)
	{
	}

	[Token(Token = "0x600DBA0")]
	[Address(RVA = "0x2CEE7EC", Offset = "0x2CEE7EC", VA = "0x2CEE7EC")]
	public void EnableBuyAgain(RepurchaseCurrencyType type, ResourceID resID, int price, int repurchaseNum, PurchaseDelegate purchase)
	{
	}

	[Token(Token = "0x600DBA1")]
	[Address(RVA = "0x2CEB76C", Offset = "0x2CEB76C", VA = "0x2CEB76C")]
	private void InitRewards(List<CommonRewardItemInfo> infoList, CommonRewardItemInfo extraRewardInfo, CommonRewardItemInfo freeRewardInfo)
	{
	}

	[Token(Token = "0x600DBA2")]
	[Address(RVA = "0x2CEBDE0", Offset = "0x2CEBDE0", VA = "0x2CEBDE0")]
	private void InitOptionalRewards(List<CommonRewardItemInfo> infoList, List<OptionalBundleShowData> optionalBundleShowDataList)
	{
	}

	[Token(Token = "0x600DBA3")]
	[Address(RVA = "0x2CE8944", Offset = "0x2CE8944", VA = "0x2CE8944")]
	public void OnOptionalBundleSelected(uint order)
	{
	}

	[Token(Token = "0x600DBA4")]
	[Address(RVA = "0x2CEEA7C", Offset = "0x2CEEA7C", VA = "0x2CEEA7C")]
	private void RefreshOptionalToggles(uint order)
	{
	}

	[Token(Token = "0x600DBA5")]
	[Address(RVA = "0x2CEEC28", Offset = "0x2CEEC28", VA = "0x2CEEC28")]
	private void RefreshOptionalViews(uint order)
	{
	}

	[Token(Token = "0x600DBA6")]
	[Address(RVA = "0x2CED3AC", Offset = "0x2CED3AC", VA = "0x2CED3AC")]
	private void AdjustWindowVFX()
	{
	}

	[Token(Token = "0x600DBA7")]
	[Address(RVA = "0x2CEC6CC", Offset = "0x2CEC6CC", VA = "0x2CEC6CC")]
	private void AdjustBGView()
	{
	}

	[Token(Token = "0x600DBA8")]
	[Address(RVA = "0x2CF0FA8", Offset = "0x2CF0FA8", VA = "0x2CF0FA8")]
	public void SetRewardInstant(bool flag)
	{
	}

	[Token(Token = "0x600DBA9")]
	[Address(RVA = "0x2CF1008", Offset = "0x2CF1008", VA = "0x2CF1008")]
	public void SetShowAll(bool flag)
	{
	}

	[Token(Token = "0x600DBAA")]
	[Address(RVA = "0x2CF1068", Offset = "0x2CF1068", VA = "0x2CF1068")]
	public void SetCrate(bool flag)
	{
	}

	[Token(Token = "0x600DBAB")]
	[Address(RVA = "0x2CED4C0", Offset = "0x2CED4C0", VA = "0x2CED4C0")]
	private void ShowRewardsView()
	{
	}

	[Token(Token = "0x600DBAC")]
	[Address(RVA = "0x2CF3410", Offset = "0x2CF3410", VA = "0x2CF3410")]
	private void RefreshStateAfterShowView()
	{
	}

	[Token(Token = "0x600DBAD")]
	[Address(RVA = "0x2CE7EE0", Offset = "0x2CE7EE0", VA = "0x2CE7EE0")]
	public void OnPetToggle(uint petId = 0u, bool isSkin = false, uint petSkinId = 0u)
	{
	}

	[Token(Token = "0x600DBAE")]
	[Address(RVA = "0x2CE7B78", Offset = "0x2CE7B78", VA = "0x2CE7B78")]
	public void OnAvatarToggle(uint selectid = 0u)
	{
	}

	[Token(Token = "0x600DBAF")]
	[Address(RVA = "0x2CF4428", Offset = "0x2CF4428", VA = "0x2CF4428")]
	private void RefreshClothsState()
	{
	}

	[Token(Token = "0x600DBB0")]
	[Address(RVA = "0x2CF41AC", Offset = "0x2CF41AC", VA = "0x2CF41AC")]
	private bool CheckFeatureCanShow(UICommonRewardItemController reward)
	{
		return default(bool);
	}

	[Token(Token = "0x600DBB1")]
	[Address(RVA = "0x2CF4020", Offset = "0x2CF4020", VA = "0x2CF4020")]
	private void ShowNextRewardView()
	{
	}

	[Token(Token = "0x600DBB2")]
	[Address(RVA = "0x2CF3BD4", Offset = "0x2CF3BD4", VA = "0x2CF3BD4")]
	private void ShowRewardItemView(UICommonRewardItemController ctrl)
	{
	}

	[Token(Token = "0x600DBB3")]
	[Address(RVA = "0x2CF3E34", Offset = "0x2CF3E34", VA = "0x2CF3E34")]
	private void ShowRewardFeatureView(UICommonRewardItemController item)
	{
	}

	[Token(Token = "0x600DBB4")]
	[Address(RVA = "0x2CF4CDC", Offset = "0x2CF4CDC", VA = "0x2CF4CDC")]
	private void ShowExtraRewardView()
	{
	}

	[Token(Token = "0x600DBB5")]
	[Address(RVA = "0x2CF2550", Offset = "0x2CF2550", VA = "0x2CF2550")]
	private void ShowFreeRewardView()
	{
	}

	[Token(Token = "0x600DBB6")]
	[Address(RVA = "0x2CF4950", Offset = "0x2CF4950", VA = "0x2CF4950")]
	private void ShowRewardItemVFX(UICommonRewardItemController item)
	{
	}

	[Token(Token = "0x600DBB7")]
	[Address(RVA = "0x2CF4E10", Offset = "0x2CF4E10", VA = "0x2CF4E10")]
	private void TryCreatePermanentEffect(UICommonRewardItemController item)
	{
	}

	[Token(Token = "0x600DBB8")]
	[Address(RVA = "0x2CF4B08", Offset = "0x2CF4B08", VA = "0x2CF4B08")]
	private void SetRewardToggleState(UICommonRewardItemController item)
	{
	}

	[Token(Token = "0x600DBB9")]
	[Address(RVA = "0x2CF540C", Offset = "0x2CF540C", VA = "0x2CF540C")]
	private bool CheckAvatarBundleEquip(UICommonRewardItemController item)
	{
		return default(bool);
	}

	[Token(Token = "0x600DBBA")]
	[Address(RVA = "0x2CF554C", Offset = "0x2CF554C", VA = "0x2CF554C")]
	private bool CheckAvatarBundle()
	{
		return default(bool);
	}

	[Token(Token = "0x600DBBB")]
	[Address(RVA = "0x2CF22DC", Offset = "0x2CF22DC", VA = "0x2CF22DC")]
	private void ShowTitleView()
	{
	}

	[Token(Token = "0x600DBBC")]
	[Address(RVA = "0x2CF1208", Offset = "0x2CF1208", VA = "0x2CF1208")]
	private void ShowBtnsView()
	{
	}

	[Token(Token = "0x600DBBD")]
	[Address(RVA = "0x2CF28B4", Offset = "0x2CF28B4", VA = "0x2CF28B4")]
	private void ShowVoucherGroupView()
	{
	}

	[Token(Token = "0x600DBBE")]
	[Address(RVA = "0x2CF2E68", Offset = "0x2CF2E68", VA = "0x2CF2E68")]
	private void ShowShareView()
	{
	}

	[Token(Token = "0x600DBBF")]
	[Address(RVA = "0x2CF10C8", Offset = "0x2CF10C8", VA = "0x2CF10C8")]
	private void SetCommonWndVisble(bool flag)
	{
	}

	[Token(Token = "0x600DBC0")]
	[Address(RVA = "0x2CF3200", Offset = "0x2CF3200", VA = "0x2CF3200")]
	private void ShowVoucherTweenAnim()
	{
	}

	[Token(Token = "0x600DBC1")]
	[Address(RVA = "0x2CF5CB8", Offset = "0x2CF5CB8", VA = "0x2CF5CB8")]
	public void RefreshCurrencyIcon(ResourceID resID)
	{
	}

	[Token(Token = "0x600DBC2")]
	[Address(RVA = "0x2CF5DB8", Offset = "0x2CF5DB8", VA = "0x2CF5DB8")]
	public void RefreshCurrencyCountDown(DateTime time)
	{
	}

	[Token(Token = "0x600DBC3")]
	[Address(RVA = "0x2CF604C", Offset = "0x2CF604C", VA = "0x2CF604C")]
	public void RefreshCurrencyIcon(string spritename)
	{
	}

	[Token(Token = "0x600DBC4")]
	[Address(RVA = "0x2CF5738", Offset = "0x2CF5738", VA = "0x2CF5738")]
	private void RefreshBuyAgainBtnView()
	{
	}

	[Token(Token = "0x600DBC5")]
	[Address(RVA = "0x2CF60DC", Offset = "0x2CF60DC", VA = "0x2CF60DC")]
	private void OnBannerEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600DBC6")]
	[Address(RVA = "0x2CF66A0", Offset = "0x2CF66A0", VA = "0x2CF66A0")]
	private void OnHeadPicEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600DBC7")]
	[Address(RVA = "0x2CF670C", Offset = "0x2CF670C", VA = "0x2CF670C")]
	private void OnCommonEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600DBC8")]
	[Address(RVA = "0x2CF707C", Offset = "0x2CF707C", VA = "0x2CF707C")]
	private void RemoveWeaponSkinsInNewItemCache(IEnumerable<uint> Ids)
	{
	}

	[Token(Token = "0x600DBC9")]
	[Address(RVA = "0x2CF7640", Offset = "0x2CF7640", VA = "0x2CF7640")]
	private void OnEmoteEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600DBCA")]
	[Address(RVA = "0x2CF76AC", Offset = "0x2CF76AC", VA = "0x2CF76AC")]
	private void OnClothEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600DBCB")]
	[Address(RVA = "0x2CF7890", Offset = "0x2CF7890", VA = "0x2CF7890")]
	private void OnAvatarEquipResult(object[] data)
	{
	}

	[Token(Token = "0x600DBCC")]
	[Address(RVA = "0x2CF631C", Offset = "0x2CF631C", VA = "0x2CF631C")]
	private void OnEquipSuccess(bool isTipShow = true)
	{
	}

	[Token(Token = "0x600DBCD")]
	[Address(RVA = "0x2CF647C", Offset = "0x2CF647C", VA = "0x2CF647C")]
	private void OnEquipFail()
	{
	}

	[Token(Token = "0x600DBCE")]
	[Address(RVA = "0x2CF7EC4", Offset = "0x2CF7EC4", VA = "0x2CF7EC4")]
	private void ShowResult(bool isTipShow = true)
	{
	}

	[Token(Token = "0x600DBCF")]
	[Address(RVA = "0x2CF74F0", Offset = "0x2CF74F0", VA = "0x2CF74F0")]
	private void AutoClose()
	{
	}

	[Token(Token = "0x600DBD0")]
	[Address(RVA = "0x2CF8194", Offset = "0x2CF8194", VA = "0x2CF8194")]
	private void OnOKBtnClick()
	{
	}

	[Token(Token = "0x600DBD1")]
	[Address(RVA = "0x2CF8280", Offset = "0x2CF8280", VA = "0x2CF8280")]
	private void OnOpenBtnClick()
	{
	}

	[Token(Token = "0x600DBD2")]
	[Address(RVA = "0x2CF8D10", Offset = "0x2CF8D10", VA = "0x2CF8D10")]
	private void OnChooseBtnClick()
	{
	}

	[Token(Token = "0x600DBD3")]
	[Address(RVA = "0x2CF8FFC", Offset = "0x2CF8FFC", VA = "0x2CF8FFC", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x600DBD4")]
	[Address(RVA = "0x2CF7A78", Offset = "0x2CF7A78", VA = "0x2CF7A78")]
	private void UpdateAvatarClothData(uint itemID)
	{
	}

	[Token(Token = "0x600DBD5")]
	[Address(RVA = "0x2CE8564", Offset = "0x2CE8564", VA = "0x2CE8564")]
	public void OnToggleSelected()
	{
	}

	[Token(Token = "0x600DBD6")]
	[Address(RVA = "0x2CF911C", Offset = "0x2CF911C", VA = "0x2CF911C")]
	private void OnFastEquipClick()
	{
	}

	[Token(Token = "0x600DBD7")]
	[Address(RVA = "0x2CFB1D0", Offset = "0x2CFB1D0", VA = "0x2CFB1D0")]
	private bool CheckItemABReady(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600DBD8")]
	[Address(RVA = "0x2CFB31C", Offset = "0x2CFB31C", VA = "0x2CFB31C")]
	private void OnRepurchaseBtnClick()
	{
	}

	[Token(Token = "0x600DBD9")]
	[Address(RVA = "0x2CFB398", Offset = "0x2CFB398", VA = "0x2CFB398")]
	private void OnSkipMaskClick()
	{
	}

	[Token(Token = "0x600DBDA")]
	[Address(RVA = "0x2CFB3F4", Offset = "0x2CFB3F4", VA = "0x2CFB3F4")]
	private void OnGoToExchangeClick()
	{
	}

	[Token(Token = "0x600DBDB")]
	[Address(RVA = "0x2CFB580", Offset = "0x2CFB580", VA = "0x2CFB580")]
	private void OnGoToSharePreviewClick()
	{
	}

	[Token(Token = "0x600DBDC")]
	[Address(RVA = "0x2CF83B8", Offset = "0x2CF83B8", VA = "0x2CF83B8")]
	private void DefOpenAction()
	{
	}

	[Token(Token = "0x600DBDD")]
	[Address(RVA = "0x2CFB91C", Offset = "0x2CFB91C", VA = "0x2CFB91C")]
	public void SetUseNewItem()
	{
	}

	[Token(Token = "0x600DBDE")]
	[Address(RVA = "0x2CEE2A0", Offset = "0x2CEE2A0", VA = "0x2CEE2A0")]
	private void CreateWndStyle()
	{
	}

	[Token(Token = "0x600DBDF")]
	[Address(RVA = "0x2CFB978", Offset = "0x2CFB978", VA = "0x2CFB978", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DBE0")]
	[Address(RVA = "0x2CFBAAC", Offset = "0x2CFBAAC", VA = "0x2CFBAAC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DBE1")]
	[Address(RVA = "0x2CFBF18", Offset = "0x2CFBF18", VA = "0x2CFBF18")]
	private void _003CInitOptionalRewards_003Em__0()
	{
	}

	[Token(Token = "0x600DBE2")]
	[Address(RVA = "0x2CFBF8C", Offset = "0x2CFBF8C", VA = "0x2CFBF8C")]
	private void _003CShowRewardFeatureView_003Em__1()
	{
	}

	[Token(Token = "0x600DBE3")]
	[Address(RVA = "0x2CFBF90", Offset = "0x2CFBF90", VA = "0x2CFBF90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DBE4")]
	[Address(RVA = "0x2CFBF98", Offset = "0x2CFBF98", VA = "0x2CFBF98")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600DBE5")]
	[Address(RVA = "0x2CFBFA0", Offset = "0x2CFBFA0", VA = "0x2CFBFA0")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}

	[Token(Token = "0x600DBE6")]
	[Address(RVA = "0x2CFBFA8", Offset = "0x2CFBFA8", VA = "0x2CFBFA8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DBE7")]
	[Address(RVA = "0x2CFBFB0", Offset = "0x2CFBFB0", VA = "0x2CFBFB0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
