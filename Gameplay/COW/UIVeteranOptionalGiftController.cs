using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BE0")]
internal class UIVeteranOptionalGiftController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x2002BE1")]
	private sealed class _003CRefreshBundleItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010C2B")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x4010C2C")]
		[FieldOffset(Offset = "0xC")]
		internal UIVeteranOptionalGiftController _0024this;

		[Token(Token = "0x60122FB")]
		[Address(RVA = "0x2CAC948", Offset = "0x2CAC948", VA = "0x2CAC948")]
		public _003CRefreshBundleItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60122FC")]
		[Address(RVA = "0x2CAC950", Offset = "0x2CAC950", VA = "0x2CAC950")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002BE2")]
	private sealed class _003COnBundleSecondConfirm_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010C2D")]
		[FieldOffset(Offset = "0x8")]
		internal uint[] optionalOrderIDs;

		[Token(Token = "0x60122FD")]
		[Address(RVA = "0x2CAC8B4", Offset = "0x2CAC8B4", VA = "0x2CAC8B4")]
		public _003COnBundleSecondConfirm_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x2002BE3")]
	private sealed class _003COnBundleSecondConfirm_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010C2E")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4010C2F")]
		[FieldOffset(Offset = "0xC")]
		internal _003COnBundleSecondConfirm_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x60122FE")]
		[Address(RVA = "0x2CAC8BC", Offset = "0x2CAC8BC", VA = "0x2CAC8BC")]
		public _003COnBundleSecondConfirm_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60122FF")]
		[Address(RVA = "0x2CAC8C4", Offset = "0x2CAC8C4", VA = "0x2CAC8C4")]
		internal bool _003C_003Em__0(OptionalBundleShowData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002BE4")]
	private sealed class _003CGenerateOrderDic_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010C30")]
		[FieldOffset(Offset = "0x8")]
		internal OptionalBundleShowData data;

		[Token(Token = "0x6012300")]
		[Address(RVA = "0x2CAC860", Offset = "0x2CAC860", VA = "0x2CAC860")]
		public _003CGenerateOrderDic_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6012301")]
		[Address(RVA = "0x2CAC868", Offset = "0x2CAC868", VA = "0x2CAC868")]
		internal bool _003C_003Em__0(OptionalBundleShowData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010C17")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelFriends m_ModelFriend;

	[Token(Token = "0x4010C18")]
	[FieldOffset(Offset = "0x80")]
	private UIModelVeteranSignin m_ModelSignin;

	[Token(Token = "0x4010C19")]
	[FieldOffset(Offset = "0x84")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x4010C1A")]
	[FieldOffset(Offset = "0x88")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x4010C1B")]
	[FieldOffset(Offset = "0x8C")]
	private UIModelInventory m_Inventory;

	[Token(Token = "0x4010C1C")]
	[FieldOffset(Offset = "0x90")]
	private UIVeteranOptionalGiftView m_View;

	[Token(Token = "0x4010C1D")]
	[FieldOffset(Offset = "0x94")]
	private List<bool> m_AutoChangeList;

	[Token(Token = "0x4010C1E")]
	[FieldOffset(Offset = "0x98")]
	private List<UIToggleButton> m_GiftToggleList;

	[Token(Token = "0x4010C1F")]
	[FieldOffset(Offset = "0x9C")]
	private List<UIVeteranOptionalGiftItemController> m_GiftPreItemList;

	[Token(Token = "0x4010C20")]
	[FieldOffset(Offset = "0xA0")]
	private List<UIVeteranStandardItemMiniController> m_GiftBundleList;

	[Token(Token = "0x4010C21")]
	[FieldOffset(Offset = "0xA4")]
	private Dictionary<int, List<OptionalBundleShowData>> m_SortBundleDic;

	[Token(Token = "0x4010C22")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_AvatarID;

	[Token(Token = "0x4010C23")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<int, int> m_OrderIdDic;

	[Token(Token = "0x4010C24")]
	[FieldOffset(Offset = "0xB0")]
	private int m_ChooseId;

	[Token(Token = "0x4010C25")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_Flag;

	[Token(Token = "0x4010C26")]
	[FieldOffset(Offset = "0xB5")]
	private bool m_AvatarChoosed;

	[Token(Token = "0x4010C27")]
	private const int GIFTNUM = 6;

	[Token(Token = "0x4010C28")]
	[FieldOffset(Offset = "0xB8")]
	private List<uint> m_BundleItemDelayCallList;

	[Token(Token = "0x4010C29")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010C2A")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60122C6")]
	[Address(RVA = "0x285E218", Offset = "0x285E218", VA = "0x285E218")]
	public UIVeteranOptionalGiftController()
	{
	}

	[Token(Token = "0x60122C7")]
	[Address(RVA = "0x285E3DC", Offset = "0x285E3DC", VA = "0x285E3DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60122C8")]
	[Address(RVA = "0x285E480", Offset = "0x285E480", VA = "0x285E480", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60122C9")]
	[Address(RVA = "0x285F740", Offset = "0x285F740", VA = "0x285F740", Slot = "45")]
	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x60122CA")]
	[Address(RVA = "0x285F798", Offset = "0x285F798", VA = "0x285F798", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60122CB")]
	[Address(RVA = "0x285FA10", Offset = "0x285FA10", VA = "0x285FA10")]
	private void RefreshAvatarCloth()
	{
	}

	[Token(Token = "0x60122CC")]
	[Address(RVA = "0x285FCB8", Offset = "0x285FCB8", VA = "0x285FCB8")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x60122CD")]
	[Address(RVA = "0x28600A4", Offset = "0x28600A4", VA = "0x28600A4")]
	private void RefreshAvatarPreview(int slot, int itemindex, uint avatarid)
	{
	}

	[Token(Token = "0x60122CE")]
	[Address(RVA = "0x285F5B0", Offset = "0x285F5B0", VA = "0x285F5B0")]
	private void PlayAnimation()
	{
	}

	[Token(Token = "0x60122CF")]
	[Address(RVA = "0x2860158", Offset = "0x2860158", VA = "0x2860158", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60122D0")]
	[Address(RVA = "0x286029C", Offset = "0x286029C", VA = "0x286029C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60122D1")]
	[Address(RVA = "0x28604D8", Offset = "0x28604D8", VA = "0x28604D8", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x60122D2")]
	[Address(RVA = "0x285F178", Offset = "0x285F178", VA = "0x285F178")]
	private void InitPreviewToggles()
	{
	}

	[Token(Token = "0x60122D3")]
	[Address(RVA = "0x2860FDC", Offset = "0x2860FDC", VA = "0x2860FDC")]
	private void OnToggleClick()
	{
	}

	[Token(Token = "0x60122D4")]
	[Address(RVA = "0x285EE24", Offset = "0x285EE24", VA = "0x285EE24")]
	private void InitAutoChangeList()
	{
	}

	[Token(Token = "0x60122D5")]
	[Address(RVA = "0x286243C", Offset = "0x286243C", VA = "0x286243C")]
	private void ResetAutoChangeList()
	{
	}

	[Token(Token = "0x60122D6")]
	[Address(RVA = "0x285EEF4", Offset = "0x285EEF4", VA = "0x285EEF4")]
	private void InitFirstGiftBundle()
	{
	}

	[Token(Token = "0x60122D7")]
	[Address(RVA = "0x2862514", Offset = "0x2862514", VA = "0x2862514")]
	private void RefreshUIView()
	{
	}

	[Token(Token = "0x60122D8")]
	[Address(RVA = "0x2861900", Offset = "0x2861900", VA = "0x2861900")]
	private void RefreshBundleItem(int chooseId)
	{
	}

	[Token(Token = "0x60122D9")]
	[Address(RVA = "0x2862CB0", Offset = "0x2862CB0", VA = "0x2862CB0")]
	private void ConvertBundleItemState(int chooseId)
	{
	}

	[Token(Token = "0x60122DA")]
	[Address(RVA = "0x2863050", Offset = "0x2863050", VA = "0x2863050")]
	private void ChangeAvatar(uint currentAvatarId, uint preAcvatarId)
	{
	}

	[Token(Token = "0x60122DB")]
	[Address(RVA = "0x28634E4", Offset = "0x28634E4", VA = "0x28634E4")]
	private void SetItemClickCallBack()
	{
	}

	[Token(Token = "0x60122DC")]
	[Address(RVA = "0x2864880", Offset = "0x2864880", VA = "0x2864880")]
	private void SaveChooseAward(int index)
	{
	}

	[Token(Token = "0x60122DD")]
	[Address(RVA = "0x28632E8", Offset = "0x28632E8", VA = "0x28632E8")]
	private void RefreshConfirmIconShow()
	{
	}

	[Token(Token = "0x60122DE")]
	[Address(RVA = "0x286053C", Offset = "0x286053C", VA = "0x286053C")]
	private void OnClose()
	{
	}

	[Token(Token = "0x60122DF")]
	[Address(RVA = "0x2864954", Offset = "0x2864954", VA = "0x2864954")]
	private void CloseNavigation()
	{
	}

	[Token(Token = "0x60122E0")]
	[Address(RVA = "0x2864BB4", Offset = "0x2864BB4", VA = "0x2864BB4")]
	private void OnClickConfirm()
	{
	}

	[Token(Token = "0x60122E1")]
	[Address(RVA = "0x2865054", Offset = "0x2865054", VA = "0x2865054")]
	private void OnClickRecommend()
	{
	}

	[Token(Token = "0x60122E2")]
	[Address(RVA = "0x28668F8", Offset = "0x28668F8", VA = "0x28668F8")]
	private void OnBundleSecondConfirm()
	{
	}

	[Token(Token = "0x60122E3")]
	[Address(RVA = "0x286156C", Offset = "0x286156C", VA = "0x286156C")]
	private void OnClickVault()
	{
	}

	[Token(Token = "0x60122E4")]
	[Address(RVA = "0x28672C4", Offset = "0x28672C4", VA = "0x28672C4")]
	private void GotoItemCon()
	{
	}

	[Token(Token = "0x60122E5")]
	[Address(RVA = "0x286283C", Offset = "0x286283C", VA = "0x286283C")]
	private void SetEmptytSlotIcon()
	{
	}

	[Token(Token = "0x60122E6")]
	[Address(RVA = "0x286295C", Offset = "0x286295C", VA = "0x286295C")]
	private void RefreshSlotIcon()
	{
	}

	[Token(Token = "0x60122E7")]
	[Address(RVA = "0x2862B80", Offset = "0x2862B80", VA = "0x2862B80")]
	private void RefreshAutoChangeList()
	{
	}

	[Token(Token = "0x60122E8")]
	[Address(RVA = "0x28631E8", Offset = "0x28631E8", VA = "0x28631E8")]
	private void SetEmptySlotChange(int start)
	{
	}

	[Token(Token = "0x60122E9")]
	[Address(RVA = "0x285FD20", Offset = "0x285FD20", VA = "0x285FD20")]
	private void RefreshActiviness()
	{
	}

	[Token(Token = "0x60122EA")]
	[Address(RVA = "0x28673FC", Offset = "0x28673FC", VA = "0x28673FC")]
	private void RefreshRewardWnd(AwardData award)
	{
	}

	[Token(Token = "0x60122EB")]
	[Address(RVA = "0x285FF40", Offset = "0x285FF40", VA = "0x285FF40")]
	private void RefreshGift()
	{
	}

	[Token(Token = "0x60122EC")]
	[Address(RVA = "0x28625C4", Offset = "0x28625C4", VA = "0x28625C4")]
	private void GenerateOrderDic()
	{
	}

	[Token(Token = "0x60122ED")]
	[Address(RVA = "0x2867798", Offset = "0x2867798", VA = "0x2867798", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60122EE")]
	[Address(RVA = "0x286782C", Offset = "0x286782C", VA = "0x286782C", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60122EF")]
	[Address(RVA = "0x2867A90", Offset = "0x2867A90", VA = "0x2867A90", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x60122F0")]
	[Address(RVA = "0x2867B00", Offset = "0x2867B00", VA = "0x2867B00", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x60122F1")]
	[Address(RVA = "0x2867B58", Offset = "0x2867B58", VA = "0x2867B58")]
	private void _003CPlayAnimation_003Em__0()
	{
	}

	[Token(Token = "0x60122F2")]
	[Address(RVA = "0x2867C58", Offset = "0x2867C58", VA = "0x2867C58")]
	private static CommonRewardItemInfo _003CRefreshRewardWnd_003Em__1(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x60122F3")]
	[Address(RVA = "0x2867C60", Offset = "0x2867C60", VA = "0x2867C60")]
	private static void _003CRefreshRewardWnd_003Em__2()
	{
	}

	[Token(Token = "0x60122F4")]
	[Address(RVA = "0x2867D20", Offset = "0x2867D20", VA = "0x2867D20")]
	private void _003CRefreshRewardWnd_003Em__3()
	{
	}

	[Token(Token = "0x60122F5")]
	[Address(RVA = "0x2867D4C", Offset = "0x2867D4C", VA = "0x2867D4C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60122F6")]
	[Address(RVA = "0x2867D54", Offset = "0x2867D54", VA = "0x2867D54")]
	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x60122F7")]
	[Address(RVA = "0x2867D5C", Offset = "0x2867D5C", VA = "0x2867D5C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60122F8")]
	[Address(RVA = "0x2867D64", Offset = "0x2867D64", VA = "0x2867D64")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60122F9")]
	[Address(RVA = "0x2867D6C", Offset = "0x2867D6C", VA = "0x2867D6C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60122FA")]
	[Address(RVA = "0x2867D74", Offset = "0x2867D74", VA = "0x2867D74")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}
}
