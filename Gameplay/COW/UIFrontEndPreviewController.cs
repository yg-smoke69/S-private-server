using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002CA6")]
public class UIFrontEndPreviewController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002CA7")]
	public enum ProbabilityStyleType
	{
		[Token(Token = "0x40110E5")]
		None,
		[Token(Token = "0x40110E6")]
		Default,
		[Token(Token = "0x40110E7")]
		TopRight
	}

	[Token(Token = "0x2002CA8")]
	public enum SwitchType
	{
		[Token(Token = "0x40110E9")]
		Gun,
		[Token(Token = "0x40110EA")]
		Person
	}

	[Token(Token = "0x2002CA9")]
	public enum BackpackSwithType
	{
		[Token(Token = "0x40110EC")]
		Backpack,
		[Token(Token = "0x40110ED")]
		Person
	}

	[Token(Token = "0x2002CAA")]
	public enum PropertyType
	{
		[Token(Token = "0x40110EF")]
		None,
		[Token(Token = "0x40110F0")]
		Pve,
		[Token(Token = "0x40110F1")]
		Pvp,
		[Token(Token = "0x40110F2")]
		VehicleSkin
	}

	[Token(Token = "0x2002CAB")]
	public enum SkillTipsType
	{
		[Token(Token = "0x40110F4")]
		IconOnly,
		[Token(Token = "0x40110F5")]
		Detail
	}

	[Token(Token = "0x2002CAC")]
	public struct AutoCalculatePanelSizeInfo
	{
		[Token(Token = "0x40110F6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AutoCalculatePanelSizeInfo sm_Default;

		[Token(Token = "0x40110F7")]
		[FieldOffset(Offset = "0x28")]
		public static readonly float AccuracyOffset;

		[Token(Token = "0x40110F8")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 WorldPosition;

		[Token(Token = "0x40110F9")]
		[FieldOffset(Offset = "0xC")]
		public Quaternion WorldRotation;

		[Token(Token = "0x40110FA")]
		[FieldOffset(Offset = "0x1C")]
		public Pivot Pivot;

		[Token(Token = "0x40110FB")]
		[FieldOffset(Offset = "0x20")]
		public int Width;

		[Token(Token = "0x40110FC")]
		[FieldOffset(Offset = "0x24")]
		public int Height;

		[Token(Token = "0x17001348")]
		public static AutoCalculatePanelSizeInfo Default
		{
			[Token(Token = "0x6012B41")]
			[Address(RVA = "0x27EDD18", Offset = "0x27EDD18", VA = "0x27EDD18")]
			get
			{
				return default(AutoCalculatePanelSizeInfo);
			}
		}

		[Token(Token = "0x6012B40")]
		[Address(RVA = "0x93D32C", Offset = "0x93D32C", VA = "0x93D32C")]
		public AutoCalculatePanelSizeInfo(UIWidget widget)
		{
		}

		[Token(Token = "0x6012B42")]
		[Address(RVA = "0x93D334", Offset = "0x93D334", VA = "0x93D334")]
		public bool CheckDirty(UIWidget widget)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002CAD")]
	private sealed class _003CResetWeapon_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40110FD")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject _003Ccurgo_003E__0;

		[Token(Token = "0x40110FE")]
		[FieldOffset(Offset = "0xC")]
		internal Quaternion _003Clerproate_003E__0;

		[Token(Token = "0x40110FF")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003Ctime_003E__0;

		[Token(Token = "0x4011100")]
		[FieldOffset(Offset = "0x20")]
		internal UIFrontEndPreviewController _0024this;

		[Token(Token = "0x4011101")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4011102")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x4011103")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17001349")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6012B46")]
			[Address(RVA = "0x27F7A44", Offset = "0x27F7A44", VA = "0x27F7A44", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700134A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6012B47")]
			[Address(RVA = "0x27F7A4C", Offset = "0x27F7A4C", VA = "0x27F7A4C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012B44")]
		[Address(RVA = "0x27E8A34", Offset = "0x27E8A34", VA = "0x27E8A34")]
		public _003CResetWeapon_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012B45")]
		[Address(RVA = "0x27F76D0", Offset = "0x27F76D0", VA = "0x27F76D0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6012B48")]
		[Address(RVA = "0x27F7A54", Offset = "0x27F7A54", VA = "0x27F7A54", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6012B49")]
		[Address(RVA = "0x27F7A68", Offset = "0x27F7A68", VA = "0x27F7A68", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40110AE")]
	public const uint ITEMCLOTHFEMALEMIN = 203000578u;

	[Token(Token = "0x40110AF")]
	public const uint ITEMCLOTHFEMALEMAX = 203999999u;

	[Token(Token = "0x40110B0")]
	public const uint ITEMCLOTHMALEMIN = 211000343u;

	[Token(Token = "0x40110B1")]
	public const uint ITEMCLOTHMALEMAX = 211999999u;

	[Token(Token = "0x40110B2")]
	private const string DEFAULTWEBSHOWSPRITENAME = "UI_Icon_PreviewWebview";

	[Token(Token = "0x40110B3")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, uint> m_PreviewTypeToClickType;

	[Token(Token = "0x40110B4")]
	[FieldOffset(Offset = "0x2C")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x40110B5")]
	[FieldOffset(Offset = "0x30")]
	private FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	[Token(Token = "0x40110B6")]
	[FieldOffset(Offset = "0x34")]
	private FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	[Token(Token = "0x40110B7")]
	[FieldOffset(Offset = "0x38")]
	private List<UIFrontEndPreviewUIComponentBaseController> m_UIFrontEndPreviewUIComponentBaseControllers;

	[Token(Token = "0x40110B8")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewItemDescBaseController m_UIFrontEndPreviewItemDescBaseController;

	[Token(Token = "0x40110B9")]
	[FieldOffset(Offset = "0x40")]
	private UIFrontEndPreviewBundlePreviewBaseController m_UIFrontEndPreviewBundlePreviewBaseController;

	[Token(Token = "0x40110BA")]
	[FieldOffset(Offset = "0x44")]
	private UIFrontEndPreviewWeaponPropertyPanelBaseController m_UIFrontEndPreviewWeaponPropertyPanelBaseController;

	[Token(Token = "0x40110BB")]
	[FieldOffset(Offset = "0x48")]
	private UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController m_UIFrontEndPreviewVehicleSkinPropertyPanelBaseController;

	[Token(Token = "0x40110BC")]
	[FieldOffset(Offset = "0x4C")]
	private UIFrontEndPreviewWeaponSkinUpgradeBaseController m_UIFrontEndPreviewWeaponSkinUpgradeBaseController;

	[Token(Token = "0x40110BD")]
	[FieldOffset(Offset = "0x50")]
	private UIFrontEndPreviewBackpackLevelBaseController m_UIFrontEndPreviewBackpackLevelBaseController;

	[Token(Token = "0x40110BE")]
	[FieldOffset(Offset = "0x54")]
	private UIFrontEndPreviewHairStyleLevelBaseController m_UIFrontEndPreviewHairStyleLevelBaseController;

	[Token(Token = "0x40110BF")]
	[FieldOffset(Offset = "0x58")]
	private UIFrontendPreviewPVEWeaponPropertyBaseController m_UIFrontEndPreviewPVEWeaponPropertyBaseController;

	[Token(Token = "0x40110C0")]
	[FieldOffset(Offset = "0x5C")]
	private UIFrontEndPreviewHotFixDownloadBaseController m_UIFrontEndPreviewOptionalDownloadBaseController;

	[Token(Token = "0x40110C1")]
	[FieldOffset(Offset = "0x60")]
	private FrontEndPreviewDetailSkillInfoPanelBaseController m_FrontEndPreviewDetailSkillInfoPanelBaseController;

	[Token(Token = "0x40110C2")]
	[FieldOffset(Offset = "0x64")]
	private UIModelPreviewWebShow m_ModelPreviewWebShow;

	[Token(Token = "0x40110C3")]
	[FieldOffset(Offset = "0x68")]
	public bool EnableOptionalDownloadRefresh;

	[Token(Token = "0x40110C4")]
	[FieldOffset(Offset = "0x6C")]
	private PropertyType m_PropertyType;

	[Token(Token = "0x40110C5")]
	[FieldOffset(Offset = "0x70")]
	private UIFrontEndPreviewView m_View;

	[Token(Token = "0x40110C6")]
	[FieldOffset(Offset = "0x74")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x40110C7")]
	[FieldOffset(Offset = "0x78")]
	private uint m_CurrentItemID;

	[Token(Token = "0x40110C8")]
	[FieldOffset(Offset = "0x7C")]
	public uint ShowItemID;

	[Token(Token = "0x40110C9")]
	[FieldOffset(Offset = "0x80")]
	private FrontendPreviewType m_UiType;

	[Token(Token = "0x40110CA")]
	[FieldOffset(Offset = "0x84")]
	private int m_PanelWidth;

	[Token(Token = "0x40110CB")]
	[FieldOffset(Offset = "0x88")]
	private bool _003CIsShowOwned_003Ek__BackingField;

	[Token(Token = "0x40110CC")]
	[FieldOffset(Offset = "0x8C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x40110CD")]
	[FieldOffset(Offset = "0x90")]
	private SwitchType m_Swithtype;

	[Token(Token = "0x40110CE")]
	[FieldOffset(Offset = "0x94")]
	private BackpackSwithType m_BackSwithType;

	[Token(Token = "0x40110CF")]
	[FieldOffset(Offset = "0x98")]
	private float _003CModelPosX_003Ek__BackingField;

	[Token(Token = "0x40110D0")]
	[FieldOffset(Offset = "0x9C")]
	private float _003CModelPosY_003Ek__BackingField;

	[Token(Token = "0x40110D1")]
	[FieldOffset(Offset = "0xA0")]
	private bool _003CMagnifierState_003Ek__BackingField;

	[Token(Token = "0x40110D2")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x40110D3")]
	[FieldOffset(Offset = "0xA4")]
	private Coroutine m_Cor;

	[Token(Token = "0x40110D4")]
	[FieldOffset(Offset = "0xA8")]
	private UIWeaponKillNotificationItemController m_KillNotification;

	[Token(Token = "0x40110D5")]
	[FieldOffset(Offset = "0xAC")]
	private UIFrontEndPreview2DItemController m_2DPreviewitem;

	[Token(Token = "0x40110D6")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_HiddenVFX;

	[Token(Token = "0x40110D7")]
	[FieldOffset(Offset = "0xB4")]
	private uint m_WeaponScoreOpen;

	[Token(Token = "0x40110D8")]
	private const uint AVATARNAMECOLOR = 4290380031u;

	[Token(Token = "0x40110D9")]
	[FieldOffset(Offset = "0xB8")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x40110DA")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_TreasureBoxOpenState;

	[Token(Token = "0x40110DB")]
	[FieldOffset(Offset = "0xC0")]
	private uint m_TreasureBoxID;

	[Token(Token = "0x40110DC")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_InGameBonusID;

	[Token(Token = "0x40110DD")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_CollectionBag;

	[Token(Token = "0x40110DE")]
	[FieldOffset(Offset = "0xC9")]
	private bool m_RefreshBundleTab;

	[Token(Token = "0x40110DF")]
	[FieldOffset(Offset = "0xCC")]
	private Dictionary<int, Transform> m_AnchorToParentDic;

	[Token(Token = "0x40110E0")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsOptionalDownloadShow;

	[Token(Token = "0x40110E1")]
	[FieldOffset(Offset = "0xD1")]
	private bool m_bIsAutoCalculatePanelSize;

	[Token(Token = "0x40110E2")]
	[FieldOffset(Offset = "0xD4")]
	private AutoCalculatePanelSizeInfo m_cachePanelSize;

	[Token(Token = "0x40110E3")]
	[FieldOffset(Offset = "0xFC")]
	private UIWidget m_AutoCalculateCacheVidget;

	[Token(Token = "0x17001342")]
	public UIFrontEndPreviewView View
	{
		[Token(Token = "0x6012A9B")]
		[Address(RVA = "0x27E2030", Offset = "0x27E2030", VA = "0x27E2030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001343")]
	public uint CurrentItemID
	{
		[Token(Token = "0x6012A9C")]
		[Address(RVA = "0x27E2088", Offset = "0x27E2088", VA = "0x27E2088")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6012A9D")]
		[Address(RVA = "0x27E20E0", Offset = "0x27E20E0", VA = "0x27E20E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001344")]
	public bool IsShowOwned
	{
		[Token(Token = "0x6012A9E")]
		[Address(RVA = "0x27E0044", Offset = "0x27E0044", VA = "0x27E0044")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012A9F")]
		[Address(RVA = "0x27E2294", Offset = "0x27E2294", VA = "0x27E2294")]
		private set
		{
		}
	}

	[Token(Token = "0x17001345")]
	public float ModelPosX
	{
		[Token(Token = "0x6012AA0")]
		[Address(RVA = "0x27E229C", Offset = "0x27E229C", VA = "0x27E229C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6012AA1")]
		[Address(RVA = "0x27E22A4", Offset = "0x27E22A4", VA = "0x27E22A4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001346")]
	public float ModelPosY
	{
		[Token(Token = "0x6012AA2")]
		[Address(RVA = "0x27E22AC", Offset = "0x27E22AC", VA = "0x27E22AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6012AA3")]
		[Address(RVA = "0x27E22B4", Offset = "0x27E22B4", VA = "0x27E22B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001347")]
	public bool MagnifierState
	{
		[Token(Token = "0x6012AA4")]
		[Address(RVA = "0x27E22BC", Offset = "0x27E22BC", VA = "0x27E22BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012AA5")]
		[Address(RVA = "0x27E22C4", Offset = "0x27E22C4", VA = "0x27E22C4")]
		private set
		{
		}
	}

	[Token(Token = "0x6012A9A")]
	[Address(RVA = "0x27E1E58", Offset = "0x27E1E58", VA = "0x27E1E58")]
	public UIFrontEndPreviewController()
	{
	}

	[Token(Token = "0x6012AA6")]
	[Address(RVA = "0x27E22CC", Offset = "0x27E22CC", VA = "0x27E22CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012AA7")]
	[Address(RVA = "0x27E2374", Offset = "0x27E2374", VA = "0x27E2374", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012AA8")]
	[Address(RVA = "0x27E35D4", Offset = "0x27E35D4", VA = "0x27E35D4")]
	private void InitView()
	{
	}

	[Token(Token = "0x6012AA9")]
	[Address(RVA = "0x27E3D74", Offset = "0x27E3D74", VA = "0x27E3D74")]
	public void SetUIType(FrontendPreviewType eFrontendUIType, FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6012AAA")]
	[Address(RVA = "0x27E5E80", Offset = "0x27E5E80", VA = "0x27E5E80")]
	private void InjectUIConfigAndPreviewComponent()
	{
	}

	[Token(Token = "0x6012AAB")]
	[Address(RVA = "0x27E6054", Offset = "0x27E6054", VA = "0x27E6054", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012AAC")]
	[Address(RVA = "0x27E614C", Offset = "0x27E614C", VA = "0x27E614C")]
	public void SetShowUI(bool showUI)
	{
	}

	[Token(Token = "0x6012AAD")]
	[Address(RVA = "0x27E61E4", Offset = "0x27E61E4", VA = "0x27E61E4")]
	public void CloseItemDesc()
	{
	}

	[Token(Token = "0x6012AAE")]
	[Address(RVA = "0x27E6294", Offset = "0x27E6294", VA = "0x27E6294")]
	private void RefreshItemOnOptionalBundleDownloaded(uint itemID)
	{
	}

	[Token(Token = "0x6012AAF")]
	[Address(RVA = "0x27E63D8", Offset = "0x27E63D8", VA = "0x27E63D8")]
	private void OnTreasureBoxProbabilityClick()
	{
	}

	[Token(Token = "0x6012AB0")]
	[Address(RVA = "0x27E69FC", Offset = "0x27E69FC", VA = "0x27E69FC")]
	private void OnInGameBonusProbabilityClick()
	{
	}

	[Token(Token = "0x6012AB1")]
	[Address(RVA = "0x27E6AF4", Offset = "0x27E6AF4", VA = "0x27E6AF4")]
	public void SetTreasureBoxID(uint id)
	{
	}

	[Token(Token = "0x6012AB2")]
	[Address(RVA = "0x27E6C88", Offset = "0x27E6C88", VA = "0x27E6C88")]
	public void SetInGameBonusID(uint itemId)
	{
	}

	[Token(Token = "0x6012AB3")]
	[Address(RVA = "0x27E7200", Offset = "0x27E7200", VA = "0x27E7200")]
	public void ShowInstallmentInfoBtn(bool show)
	{
	}

	[Token(Token = "0x6012AB4")]
	[Address(RVA = "0x27E74A8", Offset = "0x27E74A8", VA = "0x27E74A8")]
	private void OnInstallmentInfoBtnClick()
	{
	}

	[Token(Token = "0x6012AB5")]
	[Address(RVA = "0x27E76D4", Offset = "0x27E76D4", VA = "0x27E76D4")]
	public void ShowInstallmentInfo(bool show)
	{
	}

	[Token(Token = "0x6012AB6")]
	[Address(RVA = "0x27E7B94", Offset = "0x27E7B94", VA = "0x27E7B94")]
	public void ShowIPTag()
	{
	}

	[Token(Token = "0x6012AB7")]
	[Address(RVA = "0x27E7C00", Offset = "0x27E7C00", VA = "0x27E7C00")]
	public void ShowIPTag(uint id)
	{
	}

	[Token(Token = "0x6012AB8")]
	[Address(RVA = "0x27E7C98", Offset = "0x27E7C98", VA = "0x27E7C98")]
	public void ShowNotReadyLabel(uint id)
	{
	}

	[Token(Token = "0x6012AB9")]
	[Address(RVA = "0x27E807C", Offset = "0x27E807C", VA = "0x27E807C")]
	public void HideEffectClothIcon()
	{
	}

	[Token(Token = "0x6012ABA")]
	[Address(RVA = "0x27E80D0", Offset = "0x27E80D0", VA = "0x27E80D0")]
	public void ShowEffectClothIcon()
	{
	}

	[Token(Token = "0x6012ABB")]
	[Address(RVA = "0x27E6574", Offset = "0x27E6574", VA = "0x27E6574")]
	private void ShowTreasureBoxProbabilityTips(CSGetTreasureBoxPRRes probability)
	{
	}

	[Token(Token = "0x6012ABC")]
	[Address(RVA = "0x27E816C", Offset = "0x27E816C", VA = "0x27E816C")]
	private void ShowInGameBonusProbabilityTips(CSGetInGameBonusPRRes probability)
	{
	}

	[Token(Token = "0x6012ABD")]
	[Address(RVA = "0x27E85F4", Offset = "0x27E85F4", VA = "0x27E85F4")]
	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6012ABE")]
	[Address(RVA = "0x27E887C", Offset = "0x27E887C", VA = "0x27E887C")]
	private void OndragStart(GameObject gameObject)
	{
	}

	[Token(Token = "0x6012ABF")]
	[Address(RVA = "0x27E88E4", Offset = "0x27E88E4", VA = "0x27E88E4")]
	private void OndragEnd(GameObject gameObject)
	{
	}

	[Token(Token = "0x6012AC0")]
	[Address(RVA = "0x27E60D4", Offset = "0x27E60D4", VA = "0x27E60D4")]
	public void ClearCoroutine()
	{
	}

	[Token(Token = "0x6012AC1")]
	[Address(RVA = "0x27E8968", Offset = "0x27E8968", VA = "0x27E8968")]
	private IEnumerator ResetWeapon()
	{
		return null;
	}

	[Token(Token = "0x6012AC2")]
	[Address(RVA = "0x27E8A3C", Offset = "0x27E8A3C", VA = "0x27E8A3C")]
	public void SetBackpackSwitchVisible(bool flag)
	{
	}

	[Token(Token = "0x6012AC3")]
	[Address(RVA = "0x27E8CCC", Offset = "0x27E8CCC", VA = "0x27E8CCC")]
	public void ClearBackpck()
	{
	}

	[Token(Token = "0x6012AC4")]
	[Address(RVA = "0x27E8D7C", Offset = "0x27E8D7C", VA = "0x27E8D7C")]
	private void OnupdateScrollview(object[] data)
	{
	}

	[Token(Token = "0x6012AC5")]
	[Address(RVA = "0x27E8EC0", Offset = "0x27E8EC0", VA = "0x27E8EC0")]
	private void OnRefreshEventTrigger(object[] data)
	{
	}

	[Token(Token = "0x6012AC6")]
	[Address(RVA = "0x27E9238", Offset = "0x27E9238", VA = "0x27E9238")]
	private void OnWeaponSkinTimelineRefresh(object[] data)
	{
	}

	[Token(Token = "0x6012AC7")]
	[Address(RVA = "0x27E92B8", Offset = "0x27E92B8", VA = "0x27E92B8")]
	public void OnHyperBookHiddenPageDescUpdate(object[] data)
	{
	}

	[Token(Token = "0x6012AC8")]
	[Address(RVA = "0x27E94D4", Offset = "0x27E94D4", VA = "0x27E94D4")]
	public void SetWeaponSkinUpgradeLevel(bool isMaxLv)
	{
	}

	[Token(Token = "0x6012AC9")]
	[Address(RVA = "0x27E95DC", Offset = "0x27E95DC", VA = "0x27E95DC")]
	private void OnAlignmentClick()
	{
	}

	[Token(Token = "0x6012ACA")]
	[Address(RVA = "0x27E98F4", Offset = "0x27E98F4", VA = "0x27E98F4")]
	private void OnBtnZoomClick()
	{
	}

	[Token(Token = "0x6012ACB")]
	[Address(RVA = "0x27E99B4", Offset = "0x27E99B4", VA = "0x27E99B4")]
	public bool CheckAbReadyWhenClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6012ACC")]
	[Address(RVA = "0x27E9BC4", Offset = "0x27E9BC4", VA = "0x27E9BC4")]
	private void OnBtnZoomWithCamera()
	{
	}

	[Token(Token = "0x6012ACD")]
	[Address(RVA = "0x27E9C60", Offset = "0x27E9C60", VA = "0x27E9C60")]
	private void OnBtnMagnifierClick()
	{
	}

	[Token(Token = "0x6012ACE")]
	[Address(RVA = "0x27EA0EC", Offset = "0x27EA0EC", VA = "0x27EA0EC")]
	public void SetMagnifierState(bool zoom)
	{
	}

	[Token(Token = "0x6012ACF")]
	[Address(RVA = "0x27EA1C0", Offset = "0x27EA1C0", VA = "0x27EA1C0")]
	private void OnbackpckBtnSwitchClick()
	{
	}

	[Token(Token = "0x6012AD0")]
	[Address(RVA = "0x27EA700", Offset = "0x27EA700", VA = "0x27EA700")]
	private void OnBtnSwitchClick()
	{
	}

	[Token(Token = "0x6012AD1")]
	[Address(RVA = "0x27EAC2C", Offset = "0x27EAC2C", VA = "0x27EAC2C")]
	public void RefreshNotificationState()
	{
	}

	[Token(Token = "0x6012AD2")]
	[Address(RVA = "0x27EADB0", Offset = "0x27EADB0", VA = "0x27EADB0")]
	public void OnBtnNotificationClick()
	{
	}

	[Token(Token = "0x6012AD3")]
	[Address(RVA = "0x27EAEB8", Offset = "0x27EAEB8", VA = "0x27EAEB8")]
	public void ClickDefaultBackPack()
	{
	}

	[Token(Token = "0x6012AD4")]
	[Address(RVA = "0x27EAFB4", Offset = "0x27EAFB4", VA = "0x27EAFB4")]
	public void ClickDefaultHairStyle()
	{
	}

	[Token(Token = "0x6012AD5")]
	[Address(RVA = "0x27EB29C", Offset = "0x27EB29C", VA = "0x27EB29C")]
	public void ClickDefaultEpicClothStyle()
	{
	}

	[Token(Token = "0x6012AD6")]
	[Address(RVA = "0x27EB5E8", Offset = "0x27EB5E8", VA = "0x27EB5E8")]
	public void SetCommonPanel(UIWidget previewBorder)
	{
	}

	[Token(Token = "0x6012AD7")]
	[Address(RVA = "0x27EDC10", Offset = "0x27EDC10", VA = "0x27EDC10")]
	public void CloseAutoCalculatePanel()
	{
	}

	[Token(Token = "0x6012AD8")]
	[Address(RVA = "0x27EDDFC", Offset = "0x27EDDFC", VA = "0x27EDDFC")]
	public void SetAutoCalculatePanel(UIWidget widget)
	{
	}

	[Token(Token = "0x6012AD9")]
	[Address(RVA = "0x27EE1AC", Offset = "0x27EE1AC", VA = "0x27EE1AC")]
	private void UpdateCalculatePanelSize()
	{
	}

	[Token(Token = "0x6012ADA")]
	[Address(RVA = "0x27EE388", Offset = "0x27EE388", VA = "0x27EE388")]
	private bool CheckDirty(UIWidget widget)
	{
		return default(bool);
	}

	[Token(Token = "0x6012ADB")]
	[Address(RVA = "0x27EEC28", Offset = "0x27EEC28", VA = "0x27EEC28")]
	private void Update()
	{
	}

	[Token(Token = "0x6012ADC")]
	[Address(RVA = "0x27E91A0", Offset = "0x27E91A0", VA = "0x27E91A0")]
	public void SetWeaponEventTriggerVisble(bool flag)
	{
	}

	[Token(Token = "0x6012ADD")]
	[Address(RVA = "0x27EEC88", Offset = "0x27EEC88", VA = "0x27EEC88")]
	public void SetCollecionBag(bool flag)
	{
	}

	[Token(Token = "0x6012ADE")]
	[Address(RVA = "0x27E34D0", Offset = "0x27E34D0", VA = "0x27E34D0")]
	public void InitTreaboxOpenState()
	{
	}

	[Token(Token = "0x6012ADF")]
	[Address(RVA = "0x27EECE8", Offset = "0x27EECE8", VA = "0x27EECE8")]
	public void RefreshTreasureBox()
	{
	}

	[Token(Token = "0x6012AE0")]
	[Address(RVA = "0x27E6E94", Offset = "0x27E6E94", VA = "0x27E6E94")]
	public void SetTreasureBoxProbabilityState(bool show)
	{
	}

	[Token(Token = "0x6012AE1")]
	[Address(RVA = "0x27EED4C", Offset = "0x27EED4C", VA = "0x27EED4C")]
	public void SetModelX(Vector3 pos)
	{
	}

	[Token(Token = "0x6012AE2")]
	[Address(RVA = "0x27EEF0C", Offset = "0x27EEF0C", VA = "0x27EEF0C")]
	public void CreatePreview2dItem()
	{
	}

	[Token(Token = "0x6012AE3")]
	[Address(RVA = "0x27EF488", Offset = "0x27EF488", VA = "0x27EF488")]
	public void ClosePreview2dItem()
	{
	}

	[Token(Token = "0x6012AE4")]
	[Address(RVA = "0x27EF58C", Offset = "0x27EF58C", VA = "0x27EF58C")]
	public void ShowPreview2DItem(bool show = true)
	{
	}

	[Token(Token = "0x6012AE5")]
	[Address(RVA = "0x27EF6AC", Offset = "0x27EF6AC", VA = "0x27EF6AC")]
	public void SetSpecial2dItemUIdata(BaseItemInfo data)
	{
	}

	[Token(Token = "0x6012AE6")]
	[Address(RVA = "0x27EF7B4", Offset = "0x27EF7B4", VA = "0x27EF7B4")]
	public void Set2dItemUIdata(CSSharedItemData data)
	{
	}

	[Token(Token = "0x6012AE7")]
	[Address(RVA = "0x27EF8BC", Offset = "0x27EF8BC", VA = "0x27EF8BC")]
	public void Set2dItemLeftAnchor(int biasLeft, int biasRight, int biasTop, int biasBottom)
	{
	}

	[Token(Token = "0x6012AE8")]
	[Address(RVA = "0x27EF9F0", Offset = "0x27EF9F0", VA = "0x27EF9F0")]
	public void Set2dItemRightAnchor()
	{
	}

	[Token(Token = "0x6012AE9")]
	[Address(RVA = "0x27EFAEC", Offset = "0x27EFAEC", VA = "0x27EFAEC")]
	public void Set2dItemScale(int num = 1)
	{
	}

	[Token(Token = "0x6012AEA")]
	[Address(RVA = "0x27EFC84", Offset = "0x27EFC84", VA = "0x27EFC84")]
	public void Set2dItemScale(float num = 1f)
	{
	}

	[Token(Token = "0x6012AEB")]
	[Address(RVA = "0x27EFE24", Offset = "0x27EFE24", VA = "0x27EFE24")]
	public void SetSpecialData(string name, string desc, bool flag)
	{
	}

	[Token(Token = "0x6012AEC")]
	[Address(RVA = "0x27EFF10", Offset = "0x27EFF10", VA = "0x27EFF10")]
	public void RefreshCollectionBackPack()
	{
	}

	[Token(Token = "0x6012AED")]
	[Address(RVA = "0x27F0038", Offset = "0x27F0038", VA = "0x27F0038")]
	public void CloseUIExceptMagn()
	{
	}

	[Token(Token = "0x6012AEE")]
	[Address(RVA = "0x27F0858", Offset = "0x27F0858", VA = "0x27F0858")]
	public void SetRightIconGridHide()
	{
	}

	[Token(Token = "0x6012AEF")]
	[Address(RVA = "0x27F0AC0", Offset = "0x27F0AC0", VA = "0x27F0AC0")]
	public void CloseAllUI()
	{
	}

	[Token(Token = "0x6012AF0")]
	[Address(RVA = "0x27F1264", Offset = "0x27F1264", VA = "0x27F1264")]
	public void SetItemData(uint id)
	{
	}

	[Token(Token = "0x6012AF1")]
	[Address(RVA = "0x27F1A1C", Offset = "0x27F1A1C", VA = "0x27F1A1C")]
	public void SetNewQuaityIcon(uint id)
	{
	}

	[Token(Token = "0x6012AF2")]
	[Address(RVA = "0x27F1AA8", Offset = "0x27F1AA8", VA = "0x27F1AA8")]
	public void SetNewQuaitySpIcon(EInventory.AwardType type)
	{
	}

	[Token(Token = "0x6012AF3")]
	[Address(RVA = "0x27F1B34", Offset = "0x27F1B34", VA = "0x27F1B34")]
	public void SetItemID(uint id)
	{
	}

	[Token(Token = "0x6012AF4")]
	[Address(RVA = "0x27F1BAC", Offset = "0x27F1BAC", VA = "0x27F1BAC")]
	public void RefreshBundlePreviewTab(List<BaseItemInfo> list, CSSharedItemDataManager.ItemType type, bool showbundleTitle, bool isOwned, bool showPreviewScrollView = true)
	{
	}

	[Token(Token = "0x6012AF5")]
	[Address(RVA = "0x27DEE78", Offset = "0x27DEE78", VA = "0x27DEE78")]
	public void SetRefreshBundleFlag(bool flag)
	{
	}

	[Token(Token = "0x6012AF6")]
	[Address(RVA = "0x27F1F88", Offset = "0x27F1F88", VA = "0x27F1F88")]
	public void RefreshCratePreviewTab(List<BaseItemInfo> list)
	{
	}

	[Token(Token = "0x6012AF7")]
	[Address(RVA = "0x27DEED8", Offset = "0x27DEED8", VA = "0x27DEED8")]
	public void ReRearrangePreviewTab()
	{
	}

	[Token(Token = "0x6012AF8")]
	[Address(RVA = "0x27F12E0", Offset = "0x27F12E0", VA = "0x27F12E0")]
	private void SetOriginal()
	{
	}

	[Token(Token = "0x6012AF9")]
	[Address(RVA = "0x27F2014", Offset = "0x27F2014", VA = "0x27F2014")]
	public void ResetUI()
	{
	}

	[Token(Token = "0x6012AFA")]
	[Address(RVA = "0x27F25F8", Offset = "0x27F25F8", VA = "0x27F25F8")]
	private void OnGotoWeaponSkinUpgraderClick()
	{
	}

	[Token(Token = "0x6012AFB")]
	[Address(RVA = "0x27F2908", Offset = "0x27F2908", VA = "0x27F2908")]
	private void OnPvpToggleClick()
	{
	}

	[Token(Token = "0x6012AFC")]
	[Address(RVA = "0x27F2D00", Offset = "0x27F2D00", VA = "0x27F2D00")]
	private void OnPveToggleClick()
	{
	}

	[Token(Token = "0x6012AFD")]
	[Address(RVA = "0x27F2970", Offset = "0x27F2970", VA = "0x27F2970")]
	private void ShowPropertyContainer(bool isVisible, PropertyType pType)
	{
	}

	[Token(Token = "0x6012AFE")]
	[Address(RVA = "0x27F2E74", Offset = "0x27F2E74", VA = "0x27F2E74")]
	public void SetItemDescYPos(float nameposY, float descposY)
	{
	}

	[Token(Token = "0x6012AFF")]
	[Address(RVA = "0x27F2F1C", Offset = "0x27F2F1C", VA = "0x27F2F1C")]
	public Vector2 GetItemNameWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012B00")]
	[Address(RVA = "0x27F2FA8", Offset = "0x27F2FA8", VA = "0x27F2FA8")]
	public Vector2 GetItemDescWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012B01")]
	[Address(RVA = "0x27F3034", Offset = "0x27F3034", VA = "0x27F3034")]
	public Vector2 GetItemDownloadBtnPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012B02")]
	[Address(RVA = "0x27F3290", Offset = "0x27F3290", VA = "0x27F3290")]
	public float GetBoostCameraPosX()
	{
		return default(float);
	}

	[Token(Token = "0x6012B03")]
	[Address(RVA = "0x27DF110", Offset = "0x27DF110", VA = "0x27DF110")]
	public void DisVisbleIconTableInfo()
	{
	}

	[Token(Token = "0x6012B04")]
	[Address(RVA = "0x27F3718", Offset = "0x27F3718", VA = "0x27F3718")]
	public void RefreshItemDesc(uint itemid)
	{
	}

	[Token(Token = "0x6012B05")]
	[Address(RVA = "0x27F1924", Offset = "0x27F1924", VA = "0x27F1924")]
	public void RefreshItemView()
	{
	}

	[Token(Token = "0x6012B06")]
	[Address(RVA = "0x27E93F4", Offset = "0x27E93F4", VA = "0x27E93F4")]
	public void SetItemDesc(string name, string description)
	{
	}

	[Token(Token = "0x6012B07")]
	[Address(RVA = "0x27F380C", Offset = "0x27F380C", VA = "0x27F380C")]
	public void DisplayWeaponPropertyScore(bool show)
	{
	}

	[Token(Token = "0x6012B08")]
	[Address(RVA = "0x27F38D4", Offset = "0x27F38D4", VA = "0x27F38D4")]
	public void RefreshWeaponPropertyScore(uint itemid)
	{
	}

	[Token(Token = "0x6012B09")]
	[Address(RVA = "0x27F3E48", Offset = "0x27F3E48", VA = "0x27F3E48")]
	public void RefreshEmotePrivilegeIcon(bool show)
	{
	}

	[Token(Token = "0x6012B0A")]
	[Address(RVA = "0x27F3ED4", Offset = "0x27F3ED4", VA = "0x27F3ED4")]
	public void RefreshVehicleSkinPropertyScore(uint itemid)
	{
	}

	[Token(Token = "0x6012B0B")]
	[Address(RVA = "0x27F3F98", Offset = "0x27F3F98", VA = "0x27F3F98")]
	public void SetWeaponPropertyVisible(bool isVisible)
	{
	}

	[Token(Token = "0x6012B0C")]
	[Address(RVA = "0x27F2D68", Offset = "0x27F2D68", VA = "0x27F2D68")]
	public bool SetWeaponPvpPropertyScoreVisble(bool isVisble)
	{
		return default(bool);
	}

	[Token(Token = "0x6012B0D")]
	[Address(RVA = "0x27F3D78", Offset = "0x27F3D78", VA = "0x27F3D78")]
	public void SetWeaponSkinUpgradeLevelVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B0E")]
	[Address(RVA = "0x27F4030", Offset = "0x27F4030", VA = "0x27F4030")]
	public void SetBackPackLevelVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B0F")]
	[Address(RVA = "0x27F4188", Offset = "0x27F4188", VA = "0x27F4188")]
	public void SetHairStyleLevelVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B10")]
	[Address(RVA = "0x27F4528", Offset = "0x27F4528", VA = "0x27F4528")]
	public void SetEpicClothStyleIconVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B11")]
	[Address(RVA = "0x27F4890", Offset = "0x27F4890", VA = "0x27F4890")]
	public void SetMagnifierBtnVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B12")]
	[Address(RVA = "0x27F49A4", Offset = "0x27F49A4", VA = "0x27F49A4")]
	public void SetSkillVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B13")]
	[Address(RVA = "0x27F4A30", Offset = "0x27F4A30", VA = "0x27F4A30")]
	public void SetAlignmentVisble(bool show)
	{
	}

	[Token(Token = "0x6012B14")]
	private void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x6012B15")]
	[Address(RVA = "0x27F4ABC", Offset = "0x27F4ABC", VA = "0x27F4ABC", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6012B16")]
	[Address(RVA = "0x27F4C04", Offset = "0x27F4C04", VA = "0x27F4C04", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6012B17")]
	[Address(RVA = "0x27F4C80", Offset = "0x27F4C80", VA = "0x27F4C80")]
	public void SetSwithBtnVisble(bool need_show, SwitchType type = SwitchType.Gun)
	{
	}

	[Token(Token = "0x6012B18")]
	[Address(RVA = "0x27F4DC4", Offset = "0x27F4DC4", VA = "0x27F4DC4")]
	public void SetNotificationBtnVisble(bool need_show, bool needCombine = false)
	{
	}

	[Token(Token = "0x6012B19")]
	[Address(RVA = "0x27F4EF4", Offset = "0x27F4EF4", VA = "0x27F4EF4")]
	public void SetShowIconVisble(bool need_show)
	{
	}

	[Token(Token = "0x6012B1A")]
	[Address(RVA = "0x27F4F80", Offset = "0x27F4F80", VA = "0x27F4F80")]
	public void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
	{
	}

	[Token(Token = "0x6012B1B")]
	[Address(RVA = "0x27F500C", Offset = "0x27F500C", VA = "0x27F500C")]
	public void ShowAvatarSkill(uint avatarID)
	{
	}

	[Token(Token = "0x6012B1C")]
	[Address(RVA = "0x27F5390", Offset = "0x27F5390", VA = "0x27F5390")]
	public void ShowAvatarAlignment(uint avatarID)
	{
	}

	[Token(Token = "0x6012B1D")]
	[Address(RVA = "0x27F541C", Offset = "0x27F541C", VA = "0x27F541C")]
	public void ShowPetSkill(uint petid)
	{
	}

	[Token(Token = "0x6012B1E")]
	[Address(RVA = "0x27F5694", Offset = "0x27F5694", VA = "0x27F5694")]
	public bool GetHotFixShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6012B1F")]
	[Address(RVA = "0x27E3C4C", Offset = "0x27E3C4C", VA = "0x27E3C4C")]
	public void SetOptionalDownloadShow(bool show, [Optional] DownloadInfoSpecific downloadInfo)
	{
	}

	[Token(Token = "0x6012B20")]
	[Address(RVA = "0x27EAA4C", Offset = "0x27EAA4C", VA = "0x27EAA4C")]
	private void SwitchChange(SwitchType type)
	{
	}

	[Token(Token = "0x6012B21")]
	[Address(RVA = "0x27E8AEC", Offset = "0x27E8AEC", VA = "0x27E8AEC")]
	private void BackPackSwitchChange(BackpackSwithType type)
	{
	}

	[Token(Token = "0x6012B22")]
	[Address(RVA = "0x27F6024", Offset = "0x27F6024", VA = "0x27F6024")]
	public void SetTweenEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6012B23")]
	[Address(RVA = "0x27EA4C8", Offset = "0x27EA4C8", VA = "0x27EA4C8")]
	public void SetZoomBtnVisible(bool showzoomspr, bool showplayspr = true)
	{
	}

	[Token(Token = "0x6012B24")]
	[Address(RVA = "0x27F613C", Offset = "0x27F613C", VA = "0x27F613C")]
	public void SetZoomWithCameraBtnVisible(bool isShow)
	{
	}

	[Token(Token = "0x6012B25")]
	[Address(RVA = "0x27F62BC", Offset = "0x27F62BC", VA = "0x27F62BC")]
	public FrontEndPreviewUIConfigData GetUIConfigData()
	{
		return null;
	}

	[Token(Token = "0x6012B26")]
	[Address(RVA = "0x27F6314", Offset = "0x27F6314", VA = "0x27F6314")]
	public void ShowWebGuideBtn(uint id)
	{
	}

	[Token(Token = "0x6012B27")]
	[Address(RVA = "0x27F65BC", Offset = "0x27F65BC", VA = "0x27F65BC")]
	private void OnWebGuideBtnClick()
	{
	}

	[Token(Token = "0x6012B28")]
	[Address(RVA = "0x27F0764", Offset = "0x27F0764", VA = "0x27F0764")]
	public void SetWebGuideBtnShow(bool show)
	{
	}

	[Token(Token = "0x6012B29")]
	[Address(RVA = "0x27E5D60", Offset = "0x27E5D60", VA = "0x27E5D60")]
	public void SetAvatarSkillInfoPanelShow(bool show)
	{
	}

	[Token(Token = "0x6012B2A")]
	[Address(RVA = "0x27F68D8", Offset = "0x27F68D8", VA = "0x27F68D8")]
	public void SetShowBackpackLevel()
	{
	}

	[Token(Token = "0x6012B2B")]
	[Address(RVA = "0x27F69D4", Offset = "0x27F69D4", VA = "0x27F69D4")]
	public void SetHideBackpackLevel()
	{
	}

	[Token(Token = "0x6012B2C")]
	[Address(RVA = "0x27F6AD0", Offset = "0x27F6AD0", VA = "0x27F6AD0")]
	public uint GetBackpackSelectLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6012B2D")]
	[Address(RVA = "0x27F6BD8", Offset = "0x27F6BD8", VA = "0x27F6BD8", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012B2E")]
	[Address(RVA = "0x27F6C6C", Offset = "0x27F6C6C", VA = "0x27F6C6C", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012B2F")]
	[Address(RVA = "0x27E4644", Offset = "0x27E4644", VA = "0x27E4644")]
	public UIFrontEndPreviewItemDescBaseController GetPreviewItemDescBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B30")]
	[Address(RVA = "0x27E48C0", Offset = "0x27E48C0", VA = "0x27E48C0")]
	public UIFrontEndPreviewBundlePreviewBaseController GetBundlePreviewBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B31")]
	[Address(RVA = "0x27E4AAC", Offset = "0x27E4AAC", VA = "0x27E4AAC")]
	public UIFrontEndPreviewWeaponPropertyPanelBaseController GetWeaponPropertyPanelBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B32")]
	[Address(RVA = "0x27E4D28", Offset = "0x27E4D28", VA = "0x27E4D28")]
	public UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController GetVehiclePropertyPanelBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B33")]
	[Address(RVA = "0x27E4F50", Offset = "0x27E4F50", VA = "0x27E4F50")]
	public UIFrontEndPreviewWeaponSkinUpgradeBaseController GetWeaponSkinUpgradeBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B34")]
	[Address(RVA = "0x27E5178", Offset = "0x27E5178", VA = "0x27E5178")]
	public UIFrontEndPreviewBackpackLevelBaseController GetBackpackLevelBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B35")]
	[Address(RVA = "0x27E5450", Offset = "0x27E5450", VA = "0x27E5450")]
	public UIFrontEndPreviewHairStyleLevelBaseController GetHairStyleLevelBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B36")]
	[Address(RVA = "0x27E5678", Offset = "0x27E5678", VA = "0x27E5678")]
	public UIFrontendPreviewPVEWeaponPropertyBaseController GetPveWeaponPropertyBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B37")]
	[Address(RVA = "0x27E57B4", Offset = "0x27E57B4", VA = "0x27E57B4")]
	public UIFrontEndPreviewHotFixDownloadBaseController GetHotFixDownloadBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B38")]
	[Address(RVA = "0x27E5BA0", Offset = "0x27E5BA0", VA = "0x27E5BA0")]
	public FrontEndPreviewDetailSkillInfoPanelBaseController GetDetailSkillInfoPanelBaseController()
	{
		return null;
	}

	[Token(Token = "0x6012B39")]
	[Address(RVA = "0x27F701C", Offset = "0x27F701C", VA = "0x27F701C")]
	public void CreatHiddenPageVFX(ResourceID resID)
	{
	}

	[Token(Token = "0x6012B3A")]
	[Address(RVA = "0x27F732C", Offset = "0x27F732C", VA = "0x27F732C")]
	public void CloseHiddenPageVfxItem()
	{
	}

	[Token(Token = "0x6012B3B")]
	[Address(RVA = "0x27F7444", Offset = "0x27F7444", VA = "0x27F7444")]
	private void _003COnTreasureBoxProbabilityClick_003Em__0()
	{
	}

	[Token(Token = "0x6012B3C")]
	[Address(RVA = "0x27F74EC", Offset = "0x27F74EC", VA = "0x27F74EC")]
	private void _003COnInGameBonusProbabilityClick_003Em__1()
	{
	}

	[Token(Token = "0x6012B3D")]
	[Address(RVA = "0x27F7594", Offset = "0x27F7594", VA = "0x27F7594")]
	private void _003CShowInstallmentInfo_003Em__2()
	{
	}

	[Token(Token = "0x6012B3E")]
	[Address(RVA = "0x27F76C0", Offset = "0x27F76C0", VA = "0x27F76C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012B3F")]
	[Address(RVA = "0x27F76C8", Offset = "0x27F76C8", VA = "0x27F76C8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
