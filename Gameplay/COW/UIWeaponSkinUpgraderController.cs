using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C09")]
public class UIWeaponSkinUpgraderController : UINavigationController, _Attribute
{
	[Token(Token = "0x2002C0A")]
	private sealed class _003CPlayAnim_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010D24")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> resList;

		[Token(Token = "0x4010D25")]
		[FieldOffset(Offset = "0xC")]
		internal UIWeaponSkinUpgraderController _0024this;

		[Token(Token = "0x60124FE")]
		[Address(RVA = "0x2EED024", Offset = "0x2EED024", VA = "0x2EED024")]
		public _003CPlayAnim_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60124FF")]
		[Address(RVA = "0x2EF60F4", Offset = "0x2EF60F4", VA = "0x2EF60F4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002C0B")]
	private sealed class _003COnExchangeRemainToken_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010D26")]
		[FieldOffset(Offset = "0x8")]
		internal uint scale;

		[Token(Token = "0x4010D27")]
		[FieldOffset(Offset = "0xC")]
		internal WeaponSkinUpdateItemDesc exchangeItem;

		[Token(Token = "0x4010D28")]
		[FieldOffset(Offset = "0x10")]
		internal UIWeaponSkinUpgraderController _0024this;

		[Token(Token = "0x6012500")]
		[Address(RVA = "0x2EEDDE0", Offset = "0x2EEDDE0", VA = "0x2EEDDE0")]
		public _003COnExchangeRemainToken_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6012501")]
		[Address(RVA = "0x2EF5CE4", Offset = "0x2EF5CE4", VA = "0x2EF5CE4")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6012502")]
		[Address(RVA = "0x2EF60CC", Offset = "0x2EF60CC", VA = "0x2EF60CC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002C0C")]
	private sealed class _003COnDataChanged_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010D29")]
		[FieldOffset(Offset = "0x8")]
		internal object[] param;

		[Token(Token = "0x4010D2A")]
		[FieldOffset(Offset = "0xC")]
		internal UIWeaponSkinUpgraderController _0024this;

		[Token(Token = "0x6012503")]
		[Address(RVA = "0x2EF0E78", Offset = "0x2EF0E78", VA = "0x2EF0E78")]
		public _003COnDataChanged_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6012504")]
		[Address(RVA = "0x2EF5858", Offset = "0x2EF5858", VA = "0x2EF5858")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002C0D")]
	private sealed class _003CRefreshDownloadState_003Ec__AnonStorey4
	{
		[Token(Token = "0x4010D2B")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> listResNeedDownload;

		[Token(Token = "0x4010D2C")]
		[FieldOffset(Offset = "0xC")]
		internal UIWeaponSkinUpgraderController _0024this;

		[Token(Token = "0x6012505")]
		[Address(RVA = "0x2EF3B04", Offset = "0x2EF3B04", VA = "0x2EF3B04")]
		public _003CRefreshDownloadState_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6012506")]
		[Address(RVA = "0x2EF643C", Offset = "0x2EF643C", VA = "0x2EF643C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002C0E")]
	private sealed class _003CRefreshLevelPickContainer_003Ec__AnonStorey5
	{
		[Token(Token = "0x4010D2D")]
		[FieldOffset(Offset = "0x8")]
		internal bool needScorllLevel;

		[Token(Token = "0x4010D2E")]
		[FieldOffset(Offset = "0xC")]
		internal int chosenId;

		[Token(Token = "0x4010D2F")]
		[FieldOffset(Offset = "0x10")]
		internal UIWeaponSkinUpgraderController _0024this;

		[Token(Token = "0x6012507")]
		[Address(RVA = "0x2EF3B0C", Offset = "0x2EF3B0C", VA = "0x2EF3B0C")]
		public _003CRefreshLevelPickContainer_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6012508")]
		[Address(RVA = "0x2EF69B8", Offset = "0x2EF69B8", VA = "0x2EF69B8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002C0F")]
	private sealed class _003CResetWeapon_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010D30")]
		[FieldOffset(Offset = "0x8")]
		internal Quaternion _003Clerproate_003E__0;

		[Token(Token = "0x4010D31")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Ctime_003E__0;

		[Token(Token = "0x4010D32")]
		[FieldOffset(Offset = "0x1C")]
		internal UIWeaponSkinUpgraderController _0024this;

		[Token(Token = "0x4010D33")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4010D34")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4010D35")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x1700131F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601250B")]
			[Address(RVA = "0x2EF6F10", Offset = "0x2EF6F10", VA = "0x2EF6F10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001320")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601250C")]
			[Address(RVA = "0x2EF6F18", Offset = "0x2EF6F18", VA = "0x2EF6F18", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012509")]
		[Address(RVA = "0x2EF571C", Offset = "0x2EF571C", VA = "0x2EF571C")]
		public _003CResetWeapon_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601250A")]
		[Address(RVA = "0x2EF6BAC", Offset = "0x2EF6BAC", VA = "0x2EF6BAC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601250D")]
		[Address(RVA = "0x2EF6F20", Offset = "0x2EF6F20", VA = "0x2EF6F20", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601250E")]
		[Address(RVA = "0x2EF6F34", Offset = "0x2EF6F34", VA = "0x2EF6F34", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010D09")]
	[FieldOffset(Offset = "0x68")]
	private UIWeaponSkinUpgraderView m_View;

	[Token(Token = "0x4010D0A")]
	[FieldOffset(Offset = "0x6C")]
	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	[Token(Token = "0x4010D0B")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsOverview;

	[Token(Token = "0x4010D0C")]
	[FieldOffset(Offset = "0x71")]
	private bool m_ShowAnim;

	[Token(Token = "0x4010D0D")]
	[FieldOffset(Offset = "0x74")]
	private Transform m_FullScreenAnim;

	[Token(Token = "0x4010D0E")]
	[FieldOffset(Offset = "0x78")]
	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	[Token(Token = "0x4010D0F")]
	[FieldOffset(Offset = "0x7C")]
	private GameObject m_PreviewWeaponObj;

	[Token(Token = "0x4010D10")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_UpgradeEfx;

	[Token(Token = "0x4010D11")]
	[FieldOffset(Offset = "0x84")]
	private GameObject m_ItemCameraGo;

	[Token(Token = "0x4010D12")]
	[FieldOffset(Offset = "0x88")]
	private Camera m_ItemCamera;

	[Token(Token = "0x4010D13")]
	[FieldOffset(Offset = "0x8C")]
	private WeaponSkinFeature m_CurrentFeature;

	[Token(Token = "0x4010D14")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_JmpCgPanel;

	[Token(Token = "0x4010D15")]
	[FieldOffset(Offset = "0x94")]
	private PreviewWsuJumpCgPanelController m_JmpCgPanelCtrl;

	[Token(Token = "0x4010D16")]
	[FieldOffset(Offset = "0x98")]
	private ResourceID m_ModelId;

	[Token(Token = "0x4010D17")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x4010D18")]
	[FieldOffset(Offset = "0x9C")]
	private Coroutine m_RotateWeaponCoroutine;

	[Token(Token = "0x4010D19")]
	private const int m_MaxMaterialCount = 5000;

	[Token(Token = "0x4010D1A")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_EnableBtnUpgradeCallId;

	[Token(Token = "0x4010D1B")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_LevelGridReposCallId;

	[Token(Token = "0x4010D1C")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_UI3dCameraGo;

	[Token(Token = "0x4010D1D")]
	[FieldOffset(Offset = "0xAC")]
	private UIWeaponKillNotificationItemController m_AnnouncementObj;

	[Token(Token = "0x4010D1E")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_HasRequest;

	[Token(Token = "0x4010D1F")]
	[FieldOffset(Offset = "0xB4")]
	private float m_PreviewItemPosX;

	[Token(Token = "0x4010D20")]
	[FieldOffset(Offset = "0xB8")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x4010D21")]
	[FieldOffset(Offset = "0xBC")]
	private UINewDownloadInfoController m_AnimDownloadCtrl;

	[Token(Token = "0x4010D22")]
	[FieldOffset(Offset = "0xC0")]
	private List<uint> m_EvoGunExchangeItemIdList;

	[Token(Token = "0x4010D23")]
	[FieldOffset(Offset = "0xC4")]
	private List<uint> m_EvoGunExchangeItemCountList;

	[Token(Token = "0x60124C5")]
	[Address(RVA = "0x2EE5674", Offset = "0x2EE5674", VA = "0x2EE5674")]
	public UIWeaponSkinUpgraderController()
	{
	}

	[Token(Token = "0x60124C6")]
	[Address(RVA = "0x2EE5798", Offset = "0x2EE5798", VA = "0x2EE5798")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60124C7")]
	[Address(RVA = "0x2EE583C", Offset = "0x2EE583C", VA = "0x2EE583C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60124C8")]
	[Address(RVA = "0x2EE92E8", Offset = "0x2EE92E8", VA = "0x2EE92E8")]
	private void OnRefreshEventTrigger(object[] data)
	{
	}

	[Token(Token = "0x60124C9")]
	[Address(RVA = "0x2EE9578", Offset = "0x2EE9578", VA = "0x2EE9578", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60124CA")]
	[Address(RVA = "0x2EE9DA4", Offset = "0x2EE9DA4", VA = "0x2EE9DA4")]
	public void OnPickLevel(object[] data)
	{
	}

	[Token(Token = "0x60124CB")]
	[Address(RVA = "0x2EEA190", Offset = "0x2EEA190", VA = "0x2EEA190")]
	public void SetViewData(SkinOwnAndOpenInfo info, bool dismissShowOverview = false, bool needScollLevel = false)
	{
	}

	[Token(Token = "0x60124CC")]
	[Address(RVA = "0x2EEA640", Offset = "0x2EEA640", VA = "0x2EEA640")]
	private void OnUpgradePopupFinish(object[] param)
	{
	}

	[Token(Token = "0x60124CD")]
	[Address(RVA = "0x2EEAB68", Offset = "0x2EEAB68", VA = "0x2EEAB68")]
	private void ShowPropertyAndSkillPanel(bool show)
	{
	}

	[Token(Token = "0x60124CE")]
	[Address(RVA = "0x2EEADD8", Offset = "0x2EEADD8", VA = "0x2EEADD8")]
	private void ShowPropertyView(object[] param)
	{
	}

	[Token(Token = "0x60124CF")]
	[Address(RVA = "0x2EEC9A0", Offset = "0x2EEC9A0", VA = "0x2EEC9A0")]
	private void OnBtnClickPlayAnim()
	{
	}

	[Token(Token = "0x60124D0")]
	[Address(RVA = "0x2EECE10", Offset = "0x2EECE10", VA = "0x2EECE10")]
	private void RefreshPlayBtnSprite()
	{
	}

	[Token(Token = "0x60124D1")]
	[Address(RVA = "0x2EECA04", Offset = "0x2EECA04", VA = "0x2EECA04")]
	private void PlayAnim(bool autoPlay)
	{
	}

	[Token(Token = "0x60124D2")]
	[Address(RVA = "0x2EED154", Offset = "0x2EED154", VA = "0x2EED154")]
	private void OnInterfaceMaskClick(object[] data)
	{
	}

	[Token(Token = "0x60124D3")]
	[Address(RVA = "0x2EED02C", Offset = "0x2EED02C", VA = "0x2EED02C")]
	private void SetInterfaceMaskEnable(bool maskVisible, bool labelVisible)
	{
	}

	[Token(Token = "0x60124D4")]
	[Address(RVA = "0x2EED294", Offset = "0x2EED294", VA = "0x2EED294")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x60124D5")]
	[Address(RVA = "0x2EED684", Offset = "0x2EED684", VA = "0x2EED684")]
	private void OnClickDetail()
	{
	}

	[Token(Token = "0x60124D6")]
	[Address(RVA = "0x2EEC6F8", Offset = "0x2EEC6F8", VA = "0x2EEC6F8")]
	private void ShowEfxAttrUp()
	{
	}

	[Token(Token = "0x60124D7")]
	[Address(RVA = "0x2EEC868", Offset = "0x2EEC868", VA = "0x2EEC868")]
	private void ShowEfxSkill()
	{
	}

	[Token(Token = "0x60124D8")]
	[Address(RVA = "0x2EED75C", Offset = "0x2EED75C", VA = "0x2EED75C")]
	private void OnExchangeRemainToken()
	{
	}

	[Token(Token = "0x60124D9")]
	[Address(RVA = "0x2EEDDE8", Offset = "0x2EEDDE8", VA = "0x2EEDDE8")]
	private void OnGotoUpgrade()
	{
	}

	[Token(Token = "0x60124DA")]
	[Address(RVA = "0x2EEE0C4", Offset = "0x2EEE0C4", VA = "0x2EEE0C4")]
	private void OnClickDepot()
	{
	}

	[Token(Token = "0x60124DB")]
	[Address(RVA = "0x2EEE1E0", Offset = "0x2EEE1E0", VA = "0x2EEE1E0")]
	private void OnClickOverviewPurchase()
	{
	}

	[Token(Token = "0x60124DC")]
	[Address(RVA = "0x2EEE718", Offset = "0x2EEE718", VA = "0x2EEE718")]
	private void OnClickDetailPurchase()
	{
	}

	[Token(Token = "0x60124DD")]
	[Address(RVA = "0x2EEE3EC", Offset = "0x2EEE3EC", VA = "0x2EEE3EC")]
	private void OnClickPurchase()
	{
	}

	[Token(Token = "0x60124DE")]
	[Address(RVA = "0x2EEE924", Offset = "0x2EEE924", VA = "0x2EEE924")]
	private void OnClickUpgrade()
	{
	}

	[Token(Token = "0x60124DF")]
	[Address(RVA = "0x2EEEB6C", Offset = "0x2EEEB6C", VA = "0x2EEEB6C")]
	private void LogGetFragmentSuccess(string param)
	{
	}

	[Token(Token = "0x60124E0")]
	[Address(RVA = "0x2EEEE04", Offset = "0x2EEEE04", VA = "0x2EEEE04")]
	private void OnClickGetFragment()
	{
	}

	[Token(Token = "0x60124E1")]
	[Address(RVA = "0x2EEFCC8", Offset = "0x2EEFCC8", VA = "0x2EEFCC8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60124E2")]
	[Address(RVA = "0x2EF0168", Offset = "0x2EF0168", VA = "0x2EF0168", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60124E3")]
	[Address(RVA = "0x2EF0404", Offset = "0x2EF0404", VA = "0x2EF0404", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60124E4")]
	[Address(RVA = "0x2EF0E80", Offset = "0x2EF0E80", VA = "0x2EF0E80", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60124E5")]
	[Address(RVA = "0x2EE7098", Offset = "0x2EE7098", VA = "0x2EE7098")]
	private void RefreshView(bool needScorllLevel = false)
	{
	}

	[Token(Token = "0x60124E6")]
	[Address(RVA = "0x2EF21EC", Offset = "0x2EF21EC", VA = "0x2EF21EC")]
	private void RefreshMaxGradeRemainingEvoGunTokenForExchange()
	{
	}

	[Token(Token = "0x60124E7")]
	[Address(RVA = "0x2EF3790", Offset = "0x2EF3790", VA = "0x2EF3790")]
	private void RefreshDownloadState()
	{
	}

	[Token(Token = "0x60124E8")]
	[Address(RVA = "0x2EF3098", Offset = "0x2EF3098", VA = "0x2EF3098")]
	private List<int> RefreshPropertyContainer()
	{
		return null;
	}

	[Token(Token = "0x60124E9")]
	[Address(RVA = "0x2EF1CDC", Offset = "0x2EF1CDC", VA = "0x2EF1CDC")]
	private void RefreshFeatureAddContainer()
	{
	}

	[Token(Token = "0x60124EA")]
	[Address(RVA = "0x2EF293C", Offset = "0x2EF293C", VA = "0x2EF293C")]
	private void RefreshLevelPickContainer(bool needScorllLevel)
	{
	}

	[Token(Token = "0x60124EB")]
	[Address(RVA = "0x2EF3B14", Offset = "0x2EF3B14", VA = "0x2EF3B14")]
	private void ScrollTo(Vector3 pos)
	{
	}

	[Token(Token = "0x60124EC")]
	[Address(RVA = "0x2EEBD80", Offset = "0x2EEBD80", VA = "0x2EEBD80")]
	private void Refresh3dWeapon(ResourceID model_id, bool isWeapon = true)
	{
	}

	[Token(Token = "0x60124ED")]
	[Address(RVA = "0x2EF3E78", Offset = "0x2EF3E78", VA = "0x2EF3E78")]
	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
	{
	}

	[Token(Token = "0x60124EE")]
	[Address(RVA = "0x2EF48EC", Offset = "0x2EF48EC", VA = "0x2EF48EC")]
	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
	{
	}

	[Token(Token = "0x60124EF")]
	[Address(RVA = "0x2EF40C8", Offset = "0x2EF40C8", VA = "0x2EF40C8")]
	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	[Token(Token = "0x60124F0")]
	[Address(RVA = "0x2EF5118", Offset = "0x2EF5118", VA = "0x2EF5118")]
	private bool CheckInvaildCollider(Renderer render)
	{
		return default(bool);
	}

	[Token(Token = "0x60124F1")]
	[Address(RVA = "0x2EF5374", Offset = "0x2EF5374", VA = "0x2EF5374")]
	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x60124F2")]
	[Address(RVA = "0x2EF5550", Offset = "0x2EF5550", VA = "0x2EF5550")]
	private void OndragStart(GameObject gameObject)
	{
	}

	[Token(Token = "0x60124F3")]
	[Address(RVA = "0x2EF55BC", Offset = "0x2EF55BC", VA = "0x2EF55BC")]
	private void OndragEnd(GameObject gameObject)
	{
	}

	[Token(Token = "0x60124F4")]
	[Address(RVA = "0x2EF5650", Offset = "0x2EF5650", VA = "0x2EF5650")]
	private IEnumerator ResetWeapon()
	{
		return null;
	}

	[Token(Token = "0x60124F5")]
	[Address(RVA = "0x2EE6D20", Offset = "0x2EE6D20", VA = "0x2EE6D20")]
	public void DisplayWeaponPropertyScore(bool show)
	{
	}

	[Token(Token = "0x60124F6")]
	[Address(RVA = "0x2EF0FA4", Offset = "0x2EF0FA4", VA = "0x2EF0FA4")]
	public void RefreshWeaponPropertyScore()
	{
	}

	[Token(Token = "0x60124F7")]
	[Address(RVA = "0x2EF5724", Offset = "0x2EF5724", VA = "0x2EF5724")]
	private void RefreshScoreGrid()
	{
	}

	[Token(Token = "0x60124F8")]
	[Address(RVA = "0x2EEA850", Offset = "0x2EEA850", VA = "0x2EEA850")]
	private void ShowPreviewItem(bool showPreviewItem, bool showUpgradeEfx)
	{
	}

	[Token(Token = "0x60124F9")]
	[Address(RVA = "0x2EF57F4", Offset = "0x2EF57F4", VA = "0x2EF57F4")]
	private void _003COnClickUpgrade_003Em__0()
	{
	}

	[Token(Token = "0x60124FA")]
	[Address(RVA = "0x2EF5838", Offset = "0x2EF5838", VA = "0x2EF5838")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60124FB")]
	[Address(RVA = "0x2EF5840", Offset = "0x2EF5840", VA = "0x2EF5840")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x60124FC")]
	[Address(RVA = "0x2EF5848", Offset = "0x2EF5848", VA = "0x2EF5848")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60124FD")]
	[Address(RVA = "0x2EF5850", Offset = "0x2EF5850", VA = "0x2EF5850")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
