using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025B7")]
internal class UICreateRoomSettingCSAdController : UIBaseController
{
	[Token(Token = "0x20025B8")]
	private enum TabType
	{
		[Token(Token = "0x400E97C")]
		ALL,
		[Token(Token = "0x400E97D")]
		RIFLE,
		[Token(Token = "0x400E97E")]
		SNIPER,
		[Token(Token = "0x400E97F")]
		PISTOL,
		[Token(Token = "0x400E980")]
		SUBMACHINE,
		[Token(Token = "0x400E981")]
		SHOTGUN,
		[Token(Token = "0x400E982")]
		MELEE,
		[Token(Token = "0x400E983")]
		THROWING,
		[Token(Token = "0x400E984")]
		SPECIAL
	}

	[Token(Token = "0x20025B9")]
	private sealed class _003CInitShopControllers_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E985")]
		[FieldOffset(Offset = "0x8")]
		internal RoomCreateCSShopData shopData;

		[Token(Token = "0x400E986")]
		[FieldOffset(Offset = "0xC")]
		internal UICreateRoomSettingCSAdController _0024this;

		[Token(Token = "0x600DD82")]
		[Address(RVA = "0x2735074", Offset = "0x2735074", VA = "0x2735074")]
		public _003CInitShopControllers_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DD83")]
		[Address(RVA = "0x27366EC", Offset = "0x27366EC", VA = "0x27366EC")]
		internal void _003C_003Em__0(int val)
		{
		}

		[Token(Token = "0x600DD84")]
		[Address(RVA = "0x2736778", Offset = "0x2736778", VA = "0x2736778")]
		internal void _003C_003Em__1(bool val)
		{
		}
	}

	[Token(Token = "0x20025BA")]
	private sealed class _003CInitRoundController_003Ec__AnonStorey2
	{
		[Token(Token = "0x400E987")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x400E988")]
		[FieldOffset(Offset = "0xC")]
		internal UICreateRoomSettingCSAdController _0024this;

		[Token(Token = "0x600DD85")]
		[Address(RVA = "0x2736058", Offset = "0x2736058", VA = "0x2736058")]
		public _003CInitRoundController_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600DD86")]
		[Address(RVA = "0x2736698", Offset = "0x2736698", VA = "0x2736698")]
		internal void _003C_003Em__0(int val)
		{
		}
	}

	[Token(Token = "0x20025BB")]
	private sealed class _003CInitEcoController_003Ec__AnonStorey3
	{
		[Token(Token = "0x400E989")]
		[FieldOffset(Offset = "0x8")]
		internal RoomCreateCSEcoData data;

		[Token(Token = "0x400E98A")]
		[FieldOffset(Offset = "0xC")]
		internal UICreateRoomSettingCSAdController _0024this;

		[Token(Token = "0x600DD87")]
		[Address(RVA = "0x2736060", Offset = "0x2736060", VA = "0x2736060")]
		public _003CInitEcoController_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x600DD88")]
		[Address(RVA = "0x27365E4", Offset = "0x27365E4", VA = "0x27365E4")]
		internal void _003C_003Em__0(int val)
		{
		}
	}

	[Token(Token = "0x20025BC")]
	private sealed class _003CTableReposition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E98B")]
		[FieldOffset(Offset = "0x8")]
		internal UICreateRoomSettingCSAdController _0024this;

		[Token(Token = "0x400E98C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E98D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E98E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001150")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600DD8B")]
			[Address(RVA = "0x273696C", Offset = "0x273696C", VA = "0x273696C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001151")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600DD8C")]
			[Address(RVA = "0x2736974", Offset = "0x2736974", VA = "0x2736974", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600DD89")]
		[Address(RVA = "0x27364BC", Offset = "0x27364BC", VA = "0x27364BC")]
		public _003CTableReposition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600DD8A")]
		[Address(RVA = "0x27367FC", Offset = "0x27367FC", VA = "0x27367FC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600DD8D")]
		[Address(RVA = "0x273697C", Offset = "0x273697C", VA = "0x273697C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600DD8E")]
		[Address(RVA = "0x2736990", Offset = "0x2736990", VA = "0x2736990", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E96E")]
	[FieldOffset(Offset = "0x28")]
	protected UICreateRoomSettingCSAdView m_View;

	[Token(Token = "0x400E96F")]
	[FieldOffset(Offset = "0x2C")]
	protected RoomCreateRuleDataManager m_DataManager;

	[Token(Token = "0x400E970")]
	[FieldOffset(Offset = "0x30")]
	protected UIModelCustomRoom m_CustomRoomModel;

	[Token(Token = "0x400E971")]
	[FieldOffset(Offset = "0x34")]
	private uint m_WeaponTypeTab;

	[Token(Token = "0x400E972")]
	[FieldOffset(Offset = "0x38")]
	protected int m_RoundCnt;

	[Token(Token = "0x400E973")]
	[FieldOffset(Offset = "0x3C")]
	private int m_CSShopMaxCost;

	[Token(Token = "0x400E974")]
	[FieldOffset(Offset = "0x40")]
	private int m_CSShopCostInterval;

	[Token(Token = "0x400E975")]
	[FieldOffset(Offset = "0x44")]
	private string m_ItemName;

	[Token(Token = "0x400E976")]
	private const string GUIDE_KEY = "KEY_CUSTOMROOM_ADCS_TOGGLE";

	[Token(Token = "0x400E977")]
	[FieldOffset(Offset = "0x48")]
	private List<UIRoomCheckSliderTemplateController> m_CachedWeaponControllers;

	[Token(Token = "0x400E978")]
	[FieldOffset(Offset = "0x4C")]
	protected List<UIRoomCheckSliderTemplateController> m_CachedRoundControllers;

	[Token(Token = "0x400E979")]
	protected const float CREATE_ROOM_SETTING_CSAD_POPMENU_OFFSET = 680f;

	[Token(Token = "0x400E97A")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, string> TAB_TYPE_NAME;

	[Token(Token = "0x600DD67")]
	[Address(RVA = "0x2731B70", Offset = "0x2731B70", VA = "0x2731B70")]
	public UICreateRoomSettingCSAdController()
	{
	}

	[Token(Token = "0x600DD68")]
	[Address(RVA = "0x27321F8", Offset = "0x27321F8", VA = "0x27321F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DD69")]
	[Address(RVA = "0x273229C", Offset = "0x273229C", VA = "0x273229C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DD6A")]
	[Address(RVA = "0x2732984", Offset = "0x2732984", VA = "0x2732984")]
	private void InitDefaultSettings()
	{
	}

	[Token(Token = "0x600DD6B")]
	[Address(RVA = "0x2733310", Offset = "0x2733310", VA = "0x2733310")]
	private void OnToggleADCSClick()
	{
	}

	[Token(Token = "0x600DD6C")]
	[Address(RVA = "0x27336D8", Offset = "0x27336D8", VA = "0x27336D8")]
	public void ResetOpen()
	{
	}

	[Token(Token = "0x600DD6D")]
	[Address(RVA = "0x27338F8", Offset = "0x27338F8", VA = "0x27338F8")]
	private void OnBtnTipsClick()
	{
	}

	[Token(Token = "0x600DD6E")]
	[Address(RVA = "0x2733BB8", Offset = "0x2733BB8", VA = "0x2733BB8")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600DD6F")]
	[Address(RVA = "0x2733FCC", Offset = "0x2733FCC", VA = "0x2733FCC")]
	public void SetIsCSMode(bool isCS, uint roomType)
	{
	}

	[Token(Token = "0x600DD70")]
	[Address(RVA = "0x2732B94", Offset = "0x2732B94", VA = "0x2732B94")]
	private void InitStoreSettings()
	{
	}

	[Token(Token = "0x600DD71")]
	[Address(RVA = "0x2734AA4", Offset = "0x2734AA4", VA = "0x2734AA4")]
	private List<PopMenuData> GenerateWeaponDropList()
	{
		return null;
	}

	[Token(Token = "0x600DD72")]
	[Address(RVA = "0x2734DFC", Offset = "0x2734DFC", VA = "0x2734DFC")]
	private void RefreshWeaponGrid(uint typeTab)
	{
	}

	[Token(Token = "0x600DD73")]
	[Address(RVA = "0x273450C", Offset = "0x273450C", VA = "0x273450C")]
	private void InitShopControllers(UIRoomCheckSliderTemplateController ctrl, RoomCreateCSShopData shopData)
	{
	}

	[Token(Token = "0x600DD74")]
	[Address(RVA = "0x273507C", Offset = "0x273507C", VA = "0x273507C", Slot = "31")]
	protected virtual void InitEcoSettings()
	{
	}

	[Token(Token = "0x600DD75")]
	[Address(RVA = "0x2735AB0", Offset = "0x2735AB0", VA = "0x2735AB0", Slot = "32")]
	protected virtual List<PopMenuData> GenerateRoundDropList()
	{
		return null;
	}

	[Token(Token = "0x600DD76")]
	[Address(RVA = "0x2735D54", Offset = "0x2735D54", VA = "0x2735D54")]
	public void RefreshRoundGrid(int round)
	{
	}

	[Token(Token = "0x600DD77")]
	[Address(RVA = "0x27354C0", Offset = "0x27354C0", VA = "0x27354C0")]
	protected void InitRoundController(UIRoomCheckSliderTemplateController ctrl, int index)
	{
	}

	[Token(Token = "0x600DD78")]
	[Address(RVA = "0x27357E0", Offset = "0x27357E0", VA = "0x27357E0")]
	protected void InitEcoController(UIRoomCheckSliderTemplateController ctrl, RoomCreateCSEcoData data)
	{
	}

	[Token(Token = "0x600DD79")]
	[Address(RVA = "0x2736068", Offset = "0x2736068", VA = "0x2736068")]
	private void OnToggleSettingClick()
	{
	}

	[Token(Token = "0x600DD7A")]
	[Address(RVA = "0x27331CC", Offset = "0x27331CC", VA = "0x27331CC")]
	private void RefreshCSTabButtons(bool value)
	{
	}

	[Token(Token = "0x600DD7B")]
	[Address(RVA = "0x273633C", Offset = "0x273633C", VA = "0x273633C")]
	public void ResetADCSToggle()
	{
	}

	[Token(Token = "0x600DD7C")]
	[Address(RVA = "0x27330F8", Offset = "0x27330F8", VA = "0x27330F8")]
	private void RefreshSelectedShopItemCnt()
	{
	}

	[Token(Token = "0x600DD7D")]
	[Address(RVA = "0x2734868", Offset = "0x2734868", VA = "0x2734868")]
	public void RepositionAllSettings(bool delayTableReposition = false)
	{
	}

	[Token(Token = "0x600DD7E")]
	[Address(RVA = "0x27363F0", Offset = "0x27363F0", VA = "0x27363F0")]
	private IEnumerator TableReposition()
	{
		return null;
	}

	[Token(Token = "0x600DD7F")]
	[Address(RVA = "0x27364C4", Offset = "0x27364C4", VA = "0x27364C4")]
	private void _003CGenerateWeaponDropList_003Em__0(object obj)
	{
	}

	[Token(Token = "0x600DD80")]
	[Address(RVA = "0x273653C", Offset = "0x273653C", VA = "0x273653C")]
	private void _003CGenerateRoundDropList_003Em__1(object obj)
	{
	}

	[Token(Token = "0x600DD81")]
	[Address(RVA = "0x27365DC", Offset = "0x27365DC", VA = "0x27365DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
