using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20028FF")]
public class UILegendClothVaultController : UINavigationController, _Attribute
{
	[Token(Token = "0x2002900")]
	public enum ShowingSubPage
	{
		[Token(Token = "0x400FC7A")]
		Main,
		[Token(Token = "0x400FC7B")]
		Emote,
		[Token(Token = "0x400FC7C")]
		EnterTeamAnim,
		[Token(Token = "0x400FC7D")]
		CustomAnim,
		[Token(Token = "0x400FC7E")]
		ColorPanelPage,
		[Token(Token = "0x400FC7F")]
		TransformAnim
	}

	[Token(Token = "0x2002901")]
	private sealed class _003CMoveAvatar_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FC80")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 _003Cpos_003E__0;

		[Token(Token = "0x400FC81")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 _003CpanelPos_003E__0;

		[Token(Token = "0x400FC82")]
		[FieldOffset(Offset = "0x20")]
		internal float _003CcdnPosX_003E__0;

		[Token(Token = "0x400FC83")]
		[FieldOffset(Offset = "0x24")]
		internal float _003CminDeltaX_003E__0;

		[Token(Token = "0x400FC84")]
		[FieldOffset(Offset = "0x28")]
		internal int _003CminDeltaUIX_003E__0;

		[Token(Token = "0x400FC85")]
		[FieldOffset(Offset = "0x2C")]
		internal float _003CmovePerFrame_003E__0;

		[Token(Token = "0x400FC86")]
		[FieldOffset(Offset = "0x30")]
		internal int _003CpanelMovePerFrame_003E__0;

		[Token(Token = "0x400FC87")]
		[FieldOffset(Offset = "0x34")]
		internal float x;

		[Token(Token = "0x400FC88")]
		[FieldOffset(Offset = "0x38")]
		internal float uix;

		[Token(Token = "0x400FC89")]
		[FieldOffset(Offset = "0x3C")]
		internal UILegendClothVaultController _0024this;

		[Token(Token = "0x400FC8A")]
		[FieldOffset(Offset = "0x40")]
		internal object _0024current;

		[Token(Token = "0x400FC8B")]
		[FieldOffset(Offset = "0x44")]
		internal bool _0024disposing;

		[Token(Token = "0x400FC8C")]
		[FieldOffset(Offset = "0x48")]
		internal int _0024PC;

		[Token(Token = "0x1700120F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60103E8")]
			[Address(RVA = "0x253C760", Offset = "0x253C760", VA = "0x253C760", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001210")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60103E9")]
			[Address(RVA = "0x253C768", Offset = "0x253C768", VA = "0x253C768", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60103E6")]
		[Address(RVA = "0x253BFD8", Offset = "0x253BFD8", VA = "0x253BFD8")]
		public _003CMoveAvatar_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60103E7")]
		[Address(RVA = "0x253BFE0", Offset = "0x253BFE0", VA = "0x253BFE0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60103EA")]
		[Address(RVA = "0x253C770", Offset = "0x253C770", VA = "0x253C770", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60103EB")]
		[Address(RVA = "0x253C784", Offset = "0x253C784", VA = "0x253C784", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002902")]
	private sealed class _003CRefreshDownloadState_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FC8D")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> listResNeedDownload;

		[Token(Token = "0x400FC8E")]
		[FieldOffset(Offset = "0xC")]
		internal string title;

		[Token(Token = "0x400FC8F")]
		[FieldOffset(Offset = "0x10")]
		internal UILegendClothVaultController _0024this;

		[Token(Token = "0x60103EC")]
		[Address(RVA = "0x253C80C", Offset = "0x253C80C", VA = "0x253C80C")]
		public _003CRefreshDownloadState_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60103ED")]
		[Address(RVA = "0x253C814", Offset = "0x253C814", VA = "0x253C814")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400FC5A")]
	[FieldOffset(Offset = "0x68")]
	private UILegendClothVaultView m_View;

	[Token(Token = "0x400FC5B")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400FC5C")]
	[FieldOffset(Offset = "0x70")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400FC5D")]
	[FieldOffset(Offset = "0x74")]
	private LegendClothVaultPageType m_PageType;

	[Token(Token = "0x400FC5E")]
	[FieldOffset(Offset = "0x78")]
	private uint m_LegendId;

	[Token(Token = "0x400FC5F")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IsMatchGender;

	[Token(Token = "0x400FC60")]
	private const float MoveLeftPixel = -0.35f;

	[Token(Token = "0x400FC61")]
	private const float MiddlePixel = 0f;

	[Token(Token = "0x400FC62")]
	private const float MoveLeftPixelUI = -200f;

	[Token(Token = "0x400FC63")]
	private const float MiddlePixelUI = 0f;

	[Token(Token = "0x400FC64")]
	private const int UIStoryPanelBottomAnchorWhenFold = -184;

	[Token(Token = "0x400FC65")]
	private const int UIStoryPanelBottomAnchorWhenUnfold = -362;

	[Token(Token = "0x400FC66")]
	private const int DefaultShowLegendType = 1;

	[Token(Token = "0x400FC67")]
	private const uint InvalidClothId = 0u;

	[Token(Token = "0x400FC68")]
	private const uint DefaultAvatarIdFemale = 101000018u;

	[Token(Token = "0x400FC69")]
	private const uint DefaultAvatarIdMale = 102000012u;

	[Token(Token = "0x400FC6A")]
	[FieldOffset(Offset = "0x80")]
	private uint m_ChoosingColorLevel;

	[Token(Token = "0x400FC6B")]
	[FieldOffset(Offset = "0x84")]
	private GameObject m_GoMixCamera;

	[Token(Token = "0x400FC6C")]
	[FieldOffset(Offset = "0x88")]
	private UIMaleAvatar m_Avatar;

	[Token(Token = "0x400FC6D")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2 m_BgCdnSceneSize;

	[Token(Token = "0x400FC6E")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 m_AvatarLeftPos;

	[Token(Token = "0x400FC6F")]
	[FieldOffset(Offset = "0xA0")]
	private UIModelAvatarBase.EWardrobeType m_ChoosingWardrobeType;

	[Token(Token = "0x400FC70")]
	[FieldOffset(Offset = "0xA4")]
	private Dictionary<int, UILegendClothVaultSlotItemController> m_SlotItems;

	[Token(Token = "0x400FC71")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<int, UISprite> m_DictSlotSpriteCurrentColor;

	[Token(Token = "0x400FC72")]
	[FieldOffset(Offset = "0xAC")]
	private UITexture m_BgCdnTexture;

	[Token(Token = "0x400FC73")]
	[FieldOffset(Offset = "0xB0")]
	private Coroutine m_MovingAvatarCoroutine;

	[Token(Token = "0x400FC74")]
	[FieldOffset(Offset = "0xB4")]
	private ShowingSubPage m_CurrentSubPage;

	[Token(Token = "0x400FC75")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> UI3DOBJECT_NAMES;

	[Token(Token = "0x400FC76")]
	[FieldOffset(Offset = "0xB8")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x400FC77")]
	[FieldOffset(Offset = "0xBC")]
	private HashSet<ResVersionInfo.FileInfo> m_NeedDownloadFileInfoList;

	[Token(Token = "0x400FC78")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601039D")]
	[Address(RVA = "0x1AA5AC0", Offset = "0x1AA5AC0", VA = "0x1AA5AC0")]
	public UILegendClothVaultController()
	{
	}

	[Token(Token = "0x601039E")]
	[Address(RVA = "0x1AA5BBC", Offset = "0x1AA5BBC", VA = "0x1AA5BBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601039F")]
	[Address(RVA = "0x1AA5C60", Offset = "0x1AA5C60", VA = "0x1AA5C60", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x60103A0")]
	[Address(RVA = "0x1AA5D38", Offset = "0x1AA5D38", VA = "0x1AA5D38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60103A1")]
	[Address(RVA = "0x1AA6FE4", Offset = "0x1AA6FE4", VA = "0x1AA6FE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60103A2")]
	[Address(RVA = "0x1AA73E4", Offset = "0x1AA73E4", VA = "0x1AA73E4", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60103A3")]
	[Address(RVA = "0x1AA76C8", Offset = "0x1AA76C8", VA = "0x1AA76C8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60103A4")]
	[Address(RVA = "0x1AA8428", Offset = "0x1AA8428", VA = "0x1AA8428")]
	private void SetCdnPosX(float x)
	{
	}

	[Token(Token = "0x60103A5")]
	[Address(RVA = "0x1AA85B4", Offset = "0x1AA85B4", VA = "0x1AA85B4", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60103A6")]
	[Address(RVA = "0x1AA8860", Offset = "0x1AA8860", VA = "0x1AA8860", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60103A7")]
	[Address(RVA = "0x1AA8934", Offset = "0x1AA8934", VA = "0x1AA8934")]
	public void SetData(LegendClothVaultPageType pageType, uint legendId = 1u)
	{
	}

	[Token(Token = "0x60103A8")]
	[Address(RVA = "0x1AA7EE4", Offset = "0x1AA7EE4", VA = "0x1AA7EE4")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60103A9")]
	[Address(RVA = "0x1AA6D20", Offset = "0x1AA6D20", VA = "0x1AA6D20")]
	private void InitAvatarAndCamera()
	{
	}

	[Token(Token = "0x60103AA")]
	[Address(RVA = "0x1AAC308", Offset = "0x1AAC308", VA = "0x1AAC308")]
	private void InitAvatar()
	{
	}

	[Token(Token = "0x60103AB")]
	[Address(RVA = "0x1AA6F44", Offset = "0x1AA6F44", VA = "0x1AA6F44")]
	private void PrepareSlotItems()
	{
	}

	[Token(Token = "0x60103AC")]
	[Address(RVA = "0x1AAC628", Offset = "0x1AAC628", VA = "0x1AAC628")]
	private void PrepareSlotItem(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
	}

	[Token(Token = "0x60103AD")]
	[Address(RVA = "0x1AA7A0C", Offset = "0x1AA7A0C", VA = "0x1AA7A0C")]
	private bool IfMatchGender()
	{
		return default(bool);
	}

	[Token(Token = "0x60103AE")]
	[Address(RVA = "0x1AA8E58", Offset = "0x1AA8E58", VA = "0x1AA8E58")]
	private void RefreshTags(LegendClothData baseClothData)
	{
	}

	[Token(Token = "0x60103AF")]
	[Address(RVA = "0x1AAB47C", Offset = "0x1AAB47C", VA = "0x1AAB47C")]
	private void RefreshColorPanelColors(List<LegendClothData> data)
	{
	}

	[Token(Token = "0x60103B0")]
	[Address(RVA = "0x1AACA64", Offset = "0x1AACA64", VA = "0x1AACA64")]
	private void RefreshColorPanelUnlockRank(uint level)
	{
	}

	[Token(Token = "0x60103B1")]
	[Address(RVA = "0x1AACF00", Offset = "0x1AACF00", VA = "0x1AACF00")]
	private void OnBtnColorPanelClick()
	{
	}

	[Token(Token = "0x60103B2")]
	[Address(RVA = "0x1AAD154", Offset = "0x1AAD154", VA = "0x1AAD154")]
	private void OnBtnHideColorPanelClick()
	{
	}

	[Token(Token = "0x60103B3")]
	[Address(RVA = "0x1AAD238", Offset = "0x1AAD238", VA = "0x1AAD238")]
	private void OnBtnPurchaseClick()
	{
	}

	[Token(Token = "0x60103B4")]
	[Address(RVA = "0x1AAD344", Offset = "0x1AAD344", VA = "0x1AAD344")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x60103B5")]
	[Address(RVA = "0x1AADB0C", Offset = "0x1AADB0C", VA = "0x1AADB0C")]
	private bool CheckHaveHadAllSlotClothes()
	{
		return default(bool);
	}

	[Token(Token = "0x60103B6")]
	[Address(RVA = "0x1AADDD0", Offset = "0x1AADDD0", VA = "0x1AADDD0")]
	private void OnFeatureShow(object[] data)
	{
	}

	[Token(Token = "0x60103B7")]
	[Address(RVA = "0x1AAD0D4", Offset = "0x1AAD0D4", VA = "0x1AAD0D4")]
	private void MoveAvatarLeft()
	{
	}

	[Token(Token = "0x60103B8")]
	[Address(RVA = "0x1AAD1C0", Offset = "0x1AAD1C0", VA = "0x1AAD1C0")]
	private void MoveAvatarMiddle()
	{
	}

	[Token(Token = "0x60103B9")]
	[Address(RVA = "0x1AA7C30", Offset = "0x1AA7C30", VA = "0x1AA7C30")]
	private void SetAvatarPos(float x, float uix, bool instant = false)
	{
	}

	[Token(Token = "0x60103BA")]
	[Address(RVA = "0x1AAE33C", Offset = "0x1AAE33C", VA = "0x1AAE33C")]
	private IEnumerator MoveAvatar(float x, float uix)
	{
		return null;
	}

	[Token(Token = "0x60103BB")]
	[Address(RVA = "0x1AAB9F0", Offset = "0x1AAB9F0", VA = "0x1AAB9F0")]
	private void SwitchPage(ShowingSubPage showType)
	{
	}

	[Token(Token = "0x60103BC")]
	[Address(RVA = "0x1AAE460", Offset = "0x1AAE460", VA = "0x1AAE460")]
	private void SetAvatarPos(bool inputEnable, bool resetRotation)
	{
	}

	[Token(Token = "0x60103BD")]
	[Address(RVA = "0x1AA95A0", Offset = "0x1AA95A0", VA = "0x1AA95A0")]
	private void RefreshPropertyContainer()
	{
	}

	[Token(Token = "0x60103BE")]
	[Address(RVA = "0x1AAE930", Offset = "0x1AAE930", VA = "0x1AAE930")]
	private void OnBtnSlotChooseClick(object[] data)
	{
	}

	[Token(Token = "0x60103BF")]
	[Address(RVA = "0x1AA8D34", Offset = "0x1AA8D34", VA = "0x1AA8D34")]
	private void TakeOnAll(int level = 0)
	{
	}

	[Token(Token = "0x60103C0")]
	[Address(RVA = "0x1AAF3D4", Offset = "0x1AAF3D4", VA = "0x1AAF3D4")]
	private void RefreshColorPanelSlotAllCurrentColor()
	{
	}

	[Token(Token = "0x60103C1")]
	[Address(RVA = "0x1AAF334", Offset = "0x1AAF334", VA = "0x1AAF334")]
	private void CheckWearingAndTakeOnByLevel(UIModelAvatarBase.EWardrobeType slot, int level)
	{
	}

	[Token(Token = "0x60103C2")]
	[Address(RVA = "0x1AAF1F4", Offset = "0x1AAF1F4", VA = "0x1AAF1F4")]
	private void TakeOnByLevel(UIModelAvatarBase.EWardrobeType slot, int level)
	{
	}

	[Token(Token = "0x60103C3")]
	[Address(RVA = "0x1AAEAE4", Offset = "0x1AAEAE4", VA = "0x1AAEAE4")]
	private void TakeOnById(UIModelAvatarBase.EWardrobeType slot, uint itemId, int level)
	{
	}

	[Token(Token = "0x60103C4")]
	[Address(RVA = "0x1AAADA0", Offset = "0x1AAADA0", VA = "0x1AAADA0")]
	private void RefreshShowingPreviewAvatarCloth()
	{
	}

	[Token(Token = "0x60103C5")]
	[Address(RVA = "0x1AAFCB0", Offset = "0x1AAFCB0", VA = "0x1AAFCB0")]
	private void RefreshSlotPanel()
	{
	}

	[Token(Token = "0x60103C6")]
	[Address(RVA = "0x1AB0E80", Offset = "0x1AB0E80", VA = "0x1AB0E80")]
	private void OnBtnSlotCancelClick(object[] data)
	{
	}

	[Token(Token = "0x60103C7")]
	[Address(RVA = "0x1AA7644", Offset = "0x1AA7644", VA = "0x1AA7644")]
	private void OnAnimExit(object[] data)
	{
	}

	[Token(Token = "0x60103C8")]
	[Address(RVA = "0x1AB0FDC", Offset = "0x1AB0FDC", VA = "0x1AB0FDC")]
	private void TakeOff(UIModelAvatarBase.EWardrobeType slot)
	{
	}

	[Token(Token = "0x60103C9")]
	[Address(RVA = "0x1AB0A28", Offset = "0x1AB0A28", VA = "0x1AB0A28")]
	private bool CheckHaveWearing()
	{
		return default(bool);
	}

	[Token(Token = "0x60103CA")]
	[Address(RVA = "0x1AB0C98", Offset = "0x1AB0C98", VA = "0x1AB0C98")]
	private void RefreshConfirmBtn()
	{
	}

	[Token(Token = "0x60103CB")]
	[Address(RVA = "0x1AB12FC", Offset = "0x1AB12FC", VA = "0x1AB12FC")]
	private List<uint> ClothIdListRemoveTargetSlot(List<uint> clothList, UIModelAvatarBase.EWardrobeType slotType)
	{
		return null;
	}

	[Token(Token = "0x60103CC")]
	[Address(RVA = "0x1AB1550", Offset = "0x1AB1550", VA = "0x1AB1550")]
	private void OnSwitchColor(object[] data)
	{
	}

	[Token(Token = "0x60103CD")]
	[Address(RVA = "0x1AB16A4", Offset = "0x1AB16A4", VA = "0x1AB16A4")]
	private void OnBtnFoldStoryClick()
	{
	}

	[Token(Token = "0x60103CE")]
	[Address(RVA = "0x1AB185C", Offset = "0x1AB185C", VA = "0x1AB185C")]
	private void OnBtnUnFoldStoryClick()
	{
	}

	[Token(Token = "0x60103CF")]
	[Address(RVA = "0x1AB19E4", Offset = "0x1AB19E4", VA = "0x1AB19E4")]
	private void OnBtnColorPanelComponentHairClick()
	{
	}

	[Token(Token = "0x60103D0")]
	[Address(RVA = "0x1AB1A48", Offset = "0x1AB1A48", VA = "0x1AB1A48")]
	private void OnBtnColorPanelComponentFaceClick()
	{
	}

	[Token(Token = "0x60103D1")]
	[Address(RVA = "0x1AB1AAC", Offset = "0x1AB1AAC", VA = "0x1AB1AAC")]
	private void OnBtnColorPanelComponentHeadAdditiveClick()
	{
	}

	[Token(Token = "0x60103D2")]
	[Address(RVA = "0x1AB1B10", Offset = "0x1AB1B10", VA = "0x1AB1B10")]
	private void OnBtnColorPanelComponentChestClick()
	{
	}

	[Token(Token = "0x60103D3")]
	[Address(RVA = "0x1AB1B74", Offset = "0x1AB1B74", VA = "0x1AB1B74")]
	private void OnBtnColorPanelComponentLegsClick()
	{
	}

	[Token(Token = "0x60103D4")]
	[Address(RVA = "0x1AB1BD8", Offset = "0x1AB1BD8", VA = "0x1AB1BD8")]
	private void OnBtnColorPanelComponentFeetClick()
	{
	}

	[Token(Token = "0x60103D5")]
	[Address(RVA = "0x1AB1C3C", Offset = "0x1AB1C3C", VA = "0x1AB1C3C")]
	private void OnBtnColorPanelComponentAllClick()
	{
	}

	[Token(Token = "0x60103D6")]
	[Address(RVA = "0x1AB1CA0", Offset = "0x1AB1CA0", VA = "0x1AB1CA0")]
	public void OnGotoCharaBtnClick()
	{
	}

	[Token(Token = "0x60103D7")]
	[Address(RVA = "0x1AAE5FC", Offset = "0x1AAE5FC", VA = "0x1AAE5FC")]
	private void PickChoosingWardrobeType(UIModelAvatarBase.EWardrobeType choosingType)
	{
	}

	[Token(Token = "0x60103D8")]
	[Address(RVA = "0x1AAFE8C", Offset = "0x1AAFE8C", VA = "0x1AAFE8C")]
	private void RefreshColorPanelComponentStates()
	{
	}

	[Token(Token = "0x60103D9")]
	[Address(RVA = "0x1AB0880", Offset = "0x1AB0880", VA = "0x1AB0880")]
	private void RefreshColorPanelColorStates()
	{
	}

	[Token(Token = "0x60103DA")]
	[Address(RVA = "0x1AB1D88", Offset = "0x1AB1D88", VA = "0x1AB1D88")]
	private bool SlotHaveItem(UIModelAvatarBase.EWardrobeType slotType)
	{
		return default(bool);
	}

	[Token(Token = "0x60103DB")]
	[Address(RVA = "0x1AAFA08", Offset = "0x1AAFA08", VA = "0x1AAFA08")]
	private bool IsWearingWardrobeAtSlot(UIModelAvatarBase.EWardrobeType slotType)
	{
		return default(bool);
	}

	[Token(Token = "0x60103DC")]
	[Address(RVA = "0x1AAA6D0", Offset = "0x1AAA6D0", VA = "0x1AAA6D0")]
	private void RefreshDownloadState(string title)
	{
	}

	[Token(Token = "0x60103DE")]
	[Address(RVA = "0x1AB1FB8", Offset = "0x1AB1FB8", VA = "0x1AB1FB8")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60103DF")]
	[Address(RVA = "0x1AB1FF8", Offset = "0x1AB1FF8", VA = "0x1AB1FF8")]
	private bool _003CSetData_003Em__1(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60103E0")]
	[Address(RVA = "0x1AB2030", Offset = "0x1AB2030", VA = "0x1AB2030")]
	private static void _003COnBtnConfirmClick_003Em__2()
	{
	}

	[Token(Token = "0x60103E1")]
	[Address(RVA = "0x1AB20F0", Offset = "0x1AB20F0", VA = "0x1AB20F0")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x60103E2")]
	[Address(RVA = "0x1AB20F8", Offset = "0x1AB20F8", VA = "0x1AB20F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60103E3")]
	[Address(RVA = "0x1AB2100", Offset = "0x1AB2100", VA = "0x1AB2100")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60103E4")]
	[Address(RVA = "0x1AB2108", Offset = "0x1AB2108", VA = "0x1AB2108")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x60103E5")]
	[Address(RVA = "0x1AB2110", Offset = "0x1AB2110", VA = "0x1AB2110")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
