using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BFF")]
public class UIWeaponSkinLobbyMainController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002C00")]
	public enum PropertyType
	{
		[Token(Token = "0x4010CE7")]
		None,
		[Token(Token = "0x4010CE8")]
		Pve,
		[Token(Token = "0x4010CE9")]
		Pvp
	}

	[Token(Token = "0x2002C01")]
	public enum SwitchType
	{
		[Token(Token = "0x4010CEB")]
		Gun,
		[Token(Token = "0x4010CEC")]
		Person
	}

	[Token(Token = "0x2002C02")]
	public enum GridListType
	{
		[Token(Token = "0x4010CEE")]
		First,
		[Token(Token = "0x4010CEF")]
		Second,
		[Token(Token = "0x4010CF0")]
		Third
	}

	[Token(Token = "0x2002C03")]
	public enum ECollectionMutliSelectEquipBtnState
	{
		[Token(Token = "0x4010CF2")]
		none,
		[Token(Token = "0x4010CF3")]
		Equip,
		[Token(Token = "0x4010CF4")]
		Unequip,
		[Token(Token = "0x4010CF5")]
		EquipedRemainOne
	}

	[Token(Token = "0x2002C04")]
	private sealed class _003CSetHotFixTextShow_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010CF6")]
		[FieldOffset(Offset = "0x8")]
		internal CSSharedItemData item_data;

		[Token(Token = "0x4010CF7")]
		[FieldOffset(Offset = "0xC")]
		internal List<ResourceID> res_list;

		[Token(Token = "0x4010CF8")]
		[FieldOffset(Offset = "0x10")]
		internal UIWeaponSkinLobbyMainController _0024this;

		[Token(Token = "0x6012486")]
		[Address(RVA = "0x2EDAFF0", Offset = "0x2EDAFF0", VA = "0x2EDAFF0")]
		public _003CSetHotFixTextShow_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012487")]
		[Address(RVA = "0x2EDAFF8", Offset = "0x2EDAFF8", VA = "0x2EDAFF8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002C05")]
	private sealed class _003CResetWeapon_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010CF9")]
		[FieldOffset(Offset = "0x8")]
		internal Quaternion _003Clerproate_003E__0;

		[Token(Token = "0x4010CFA")]
		[FieldOffset(Offset = "0x18")]
		internal float _003Ctime_003E__0;

		[Token(Token = "0x4010CFB")]
		[FieldOffset(Offset = "0x1C")]
		internal UIWeaponSkinLobbyMainController _0024this;

		[Token(Token = "0x4010CFC")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4010CFD")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x4010CFE")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x1700131B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601248A")]
			[Address(RVA = "0x2EDAF44", Offset = "0x2EDAF44", VA = "0x2EDAF44", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700131C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601248B")]
			[Address(RVA = "0x2EDAF4C", Offset = "0x2EDAF4C", VA = "0x2EDAF4C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6012488")]
		[Address(RVA = "0x2EDAC10", Offset = "0x2EDAC10", VA = "0x2EDAC10")]
		public _003CResetWeapon_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6012489")]
		[Address(RVA = "0x2EDAC18", Offset = "0x2EDAC18", VA = "0x2EDAC18", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601248C")]
		[Address(RVA = "0x2EDAF54", Offset = "0x2EDAF54", VA = "0x2EDAF54", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601248D")]
		[Address(RVA = "0x2EDAF68", Offset = "0x2EDAF68", VA = "0x2EDAF68", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010CB8")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, string> m_DictWeaponType2Text;

	[Token(Token = "0x4010CB9")]
	[FieldOffset(Offset = "0x6C")]
	private PropertyType m_PropertyType;

	[Token(Token = "0x4010CBA")]
	[FieldOffset(Offset = "0x70")]
	private CollectionDataManager.ECollectionWeaponType m_WeaponTypeInternal;

	[Token(Token = "0x4010CBB")]
	[FieldOffset(Offset = "0x74")]
	private uint m_WeaponIdInternal;

	[Token(Token = "0x4010CBC")]
	[FieldOffset(Offset = "0x78")]
	private uint m_WeaponSkinIdInternal;

	[Token(Token = "0x4010CBD")]
	[FieldOffset(Offset = "0x7C")]
	private WeaponSkinBaseInfo m_WeaponSkinDataInternal;

	[Token(Token = "0x4010CBE")]
	[FieldOffset(Offset = "0x80")]
	private uint m_TargetWeaponSkinId;

	[Token(Token = "0x4010CBF")]
	private const string m_Parenta = "FirstGrid";

	[Token(Token = "0x4010CC0")]
	private const string m_Parentb = "SecondGrid";

	[Token(Token = "0x4010CC1")]
	private const string m_Parentc = "ThirdGrid";

	[Token(Token = "0x4010CC2")]
	[FieldOffset(Offset = "0x84")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x4010CC3")]
	[FieldOffset(Offset = "0x88")]
	private UIWeaponSkinLobbyMainView m_View;

	[Token(Token = "0x4010CC4")]
	[FieldOffset(Offset = "0x8C")]
	private UIPVEWeaponPropertyController m_SelectedWeaponPveProperty;

	[Token(Token = "0x4010CC5")]
	[FieldOffset(Offset = "0x90")]
	private UIWeaponKillNotificationItemController m_KillNotification;

	[Token(Token = "0x4010CC6")]
	[FieldOffset(Offset = "0x94")]
	private UIWeaponSkillItemController m_skillItem;

	[Token(Token = "0x4010CC7")]
	[FieldOffset(Offset = "0x98")]
	private uint m_WeaponScoreOpen;

	[Token(Token = "0x4010CC8")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject m_ItemCameraGo;

	[Token(Token = "0x4010CC9")]
	[FieldOffset(Offset = "0xA0")]
	private Camera m_ItemCamera;

	[Token(Token = "0x4010CCA")]
	[FieldOffset(Offset = "0xA4")]
	private GameObject m_MixCameraGo;

	[Token(Token = "0x4010CCB")]
	[FieldOffset(Offset = "0xA8")]
	private Camera m_MixCamera;

	[Token(Token = "0x4010CCC")]
	[FieldOffset(Offset = "0xAC")]
	private GameObject m_ShareCamera;

	[Token(Token = "0x4010CCD")]
	[FieldOffset(Offset = "0xB0")]
	private ResourceID m_CurrentWeaponResourceId;

	[Token(Token = "0x4010CCE")]
	[FieldOffset(Offset = "0xB4")]
	private GameObject m_PreviewWeaponObj;

	[Token(Token = "0x4010CCF")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x4010CD0")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_PreviewShareWeaponObj;

	[Token(Token = "0x4010CD1")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 m_PreviewSavePos;

	[Token(Token = "0x4010CD2")]
	[FieldOffset(Offset = "0xC8")]
	private Quaternion m_PreviewSaveRotation;

	[Token(Token = "0x4010CD3")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 m_PreviewSaveScale;

	[Token(Token = "0x4010CD4")]
	[FieldOffset(Offset = "0xE4")]
	private UIFrontEndPreviewWeaponZoomInController m_ZoomInController;

	[Token(Token = "0x4010CD5")]
	[FieldOffset(Offset = "0xE8")]
	private UIMaleAvatar m_PreviewAvatar;

	[Token(Token = "0x4010CD6")]
	[FieldOffset(Offset = "0xEC")]
	private SwitchType m_Swithtype;

	[Token(Token = "0x4010CD7")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_HasInit;

	[Token(Token = "0x4010CD8")]
	[FieldOffset(Offset = "0xF1")]
	private bool m_HasRefreshMainSkin;

	[Token(Token = "0x4010CD9")]
	[FieldOffset(Offset = "0xF4")]
	private uint m_SkinIdToRefresh;

	[Token(Token = "0x4010CDA")]
	[FieldOffset(Offset = "0xF8")]
	private Quaternion m_StopPos;

	[Token(Token = "0x4010CDB")]
	[FieldOffset(Offset = "0x108")]
	private bool m_NeedRefreshAllWhenNavigationShow;

	[Token(Token = "0x4010CDC")]
	[FieldOffset(Offset = "0x10C")]
	public Dictionary<uint, bool> m_DictCollctionTypeToTips;

	[Token(Token = "0x4010CDD")]
	[FieldOffset(Offset = "0x110")]
	public Dictionary<uint, bool> m_DictWeaponIdToTips;

	[Token(Token = "0x4010CDE")]
	[FieldOffset(Offset = "0x114")]
	public Dictionary<uint, bool> m_DictWeaponSkinIdToTips;

	[Token(Token = "0x4010CDF")]
	[FieldOffset(Offset = "0x118")]
	private double m_PauseTime;

	[Token(Token = "0x4010CE0")]
	[FieldOffset(Offset = "0x120")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x4010CE1")]
	private const string SHOW_MUTLI_GUIDE_KEY = "SHOW_MUTLI_GUIDE_KEY";

	[Token(Token = "0x4010CE2")]
	[FieldOffset(Offset = "0x124")]
	private UICommonGuideController m_guideCtrl;

	[Token(Token = "0x4010CE3")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010CE4")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4010CE5")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<uint> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17001316")]
	private CollectionDataManager.ECollectionWeaponType m_WeaponType
	{
		[Token(Token = "0x601240F")]
		[Address(RVA = "0x102CC24", Offset = "0x102CC24", VA = "0x102CC24")]
		get
		{
			return default(CollectionDataManager.ECollectionWeaponType);
		}
		[Token(Token = "0x6012410")]
		[Address(RVA = "0x102CC7C", Offset = "0x102CC7C", VA = "0x102CC7C")]
		set
		{
		}
	}

	[Token(Token = "0x17001317")]
	private uint m_WeaponId
	{
		[Token(Token = "0x6012411")]
		[Address(RVA = "0x102CDD4", Offset = "0x102CDD4", VA = "0x102CDD4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6012412")]
		[Address(RVA = "0x102CE2C", Offset = "0x102CE2C", VA = "0x102CE2C")]
		set
		{
		}
	}

	[Token(Token = "0x17001318")]
	private uint m_WeaponSkinId
	{
		[Token(Token = "0x6012413")]
		[Address(RVA = "0x102CF84", Offset = "0x102CF84", VA = "0x102CF84")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6012414")]
		[Address(RVA = "0x102CFDC", Offset = "0x102CFDC", VA = "0x102CFDC")]
		set
		{
		}
	}

	[Token(Token = "0x17001319")]
	private WeaponSkinBaseInfo m_WeaponSkinData
	{
		[Token(Token = "0x6012415")]
		[Address(RVA = "0x102D134", Offset = "0x102D134", VA = "0x102D134")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012416")]
		[Address(RVA = "0x102D18C", Offset = "0x102D18C", VA = "0x102D18C")]
		set
		{
		}
	}

	[Token(Token = "0x1700131A")]
	private bool IsShowMutliSelectGuide
	{
		[Token(Token = "0x6012470")]
		[Address(RVA = "0x1046B98", Offset = "0x1046B98", VA = "0x1046B98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012471")]
		[Address(RVA = "0x1046DCC", Offset = "0x1046DCC", VA = "0x1046DCC")]
		set
		{
		}
	}

	[Token(Token = "0x601240E")]
	[Address(RVA = "0x102C3F8", Offset = "0x102C3F8", VA = "0x102C3F8")]
	public UIWeaponSkinLobbyMainController()
	{
	}

	[Token(Token = "0x6012417")]
	[Address(RVA = "0x102D31C", Offset = "0x102D31C", VA = "0x102D31C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012418")]
	[Address(RVA = "0x102D3C4", Offset = "0x102D3C4", VA = "0x102D3C4")]
	public CollectionDataManager.ECollectionWeaponType GetWeaponType()
	{
		return default(CollectionDataManager.ECollectionWeaponType);
	}

	[Token(Token = "0x6012419")]
	[Address(RVA = "0x102D424", Offset = "0x102D424", VA = "0x102D424")]
	public uint GetWeaponId()
	{
		return default(uint);
	}

	[Token(Token = "0x601241A")]
	[Address(RVA = "0x102D484", Offset = "0x102D484", VA = "0x102D484")]
	private void RefreshLobbyWeaponTips()
	{
	}

	[Token(Token = "0x601241B")]
	[Address(RVA = "0x102D704", Offset = "0x102D704", VA = "0x102D704")]
	public void RefreshDictTips()
	{
	}

	[Token(Token = "0x601241C")]
	[Address(RVA = "0x102DCA8", Offset = "0x102DCA8", VA = "0x102DCA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601241D")]
	[Address(RVA = "0x102F798", Offset = "0x102F798", VA = "0x102F798")]
	private void OnWeaponSkinUpgradeInfoIconClick()
	{
	}

	[Token(Token = "0x601241E")]
	[Address(RVA = "0x1030140", Offset = "0x1030140", VA = "0x1030140")]
	private void OnDownloadBtnClick()
	{
	}

	[Token(Token = "0x601241F")]
	[Address(RVA = "0x1030538", Offset = "0x1030538", VA = "0x1030538")]
	public void SetHotFixTextShow(bool show)
	{
	}

	[Token(Token = "0x6012420")]
	[Address(RVA = "0x10308BC", Offset = "0x10308BC", VA = "0x10308BC", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6012421")]
	[Address(RVA = "0x10320A8", Offset = "0x10320A8", VA = "0x10320A8", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6012422")]
	[Address(RVA = "0x1032220", Offset = "0x1032220", VA = "0x1032220")]
	private void OnLevelUpClick()
	{
	}

	[Token(Token = "0x6012423")]
	[Address(RVA = "0x1030CA8", Offset = "0x1030CA8", VA = "0x1030CA8")]
	private void CreateSharePreviewModel()
	{
	}

	[Token(Token = "0x6012424")]
	[Address(RVA = "0x103270C", Offset = "0x103270C", VA = "0x103270C")]
	private void OnShareClick()
	{
	}

	[Token(Token = "0x6012425")]
	[Address(RVA = "0x1032A68", Offset = "0x1032A68", VA = "0x1032A68")]
	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6012426")]
	[Address(RVA = "0x1032C44", Offset = "0x1032C44", VA = "0x1032C44")]
	private void OndragStart(GameObject gameObject)
	{
	}

	[Token(Token = "0x6012427")]
	[Address(RVA = "0x1032CB0", Offset = "0x1032CB0", VA = "0x1032CB0")]
	private void OndragEnd(GameObject gameObject)
	{
	}

	[Token(Token = "0x6012428")]
	[Address(RVA = "0x1032DF4", Offset = "0x1032DF4", VA = "0x1032DF4")]
	private void OnBtnSwitchClick()
	{
	}

	[Token(Token = "0x6012429")]
	[Address(RVA = "0x10345B4", Offset = "0x10345B4", VA = "0x10345B4")]
	public void SetSwithBtnVisble(bool need_show, SwitchType type = SwitchType.Gun)
	{
	}

	[Token(Token = "0x601242A")]
	[Address(RVA = "0x1033B4C", Offset = "0x1033B4C", VA = "0x1033B4C")]
	private void SwithChange(SwitchType type)
	{
	}

	[Token(Token = "0x601242B")]
	[Address(RVA = "0x1032D28", Offset = "0x1032D28", VA = "0x1032D28")]
	private IEnumerator ResetWeapon()
	{
		return null;
	}

	[Token(Token = "0x601242C")]
	[Address(RVA = "0x103469C", Offset = "0x103469C", VA = "0x103469C")]
	private void OnWeaponSkillClick()
	{
	}

	[Token(Token = "0x601242D")]
	[Address(RVA = "0x103479C", Offset = "0x103479C", VA = "0x103479C")]
	private void OnBtnZoomClick()
	{
	}

	[Token(Token = "0x601242E")]
	[Address(RVA = "0x10350D4", Offset = "0x10350D4", VA = "0x10350D4")]
	private void OnShowIconBtnClick()
	{
	}

	[Token(Token = "0x601242F")]
	[Address(RVA = "0x1035330", Offset = "0x1035330", VA = "0x1035330")]
	public void ShowIPTag()
	{
	}

	[Token(Token = "0x6012430")]
	[Address(RVA = "0x10356C8", Offset = "0x10356C8", VA = "0x10356C8")]
	public void ShowNotReadyLabel()
	{
	}

	[Token(Token = "0x6012431")]
	[Address(RVA = "0x1035AB4", Offset = "0x1035AB4", VA = "0x1035AB4")]
	private void OnNotificationIconBtnClick()
	{
	}

	[Token(Token = "0x6012432")]
	[Address(RVA = "0x1035D10", Offset = "0x1035D10", VA = "0x1035D10")]
	private void ShowNotReachRankItemUseLevelTips(uint itemID)
	{
	}

	[Token(Token = "0x6012433")]
	[Address(RVA = "0x1036114", Offset = "0x1036114", VA = "0x1036114")]
	private void OnEquipBtnClick()
	{
	}

	[Token(Token = "0x6012434")]
	[Address(RVA = "0x10362C4", Offset = "0x10362C4", VA = "0x10362C4")]
	private void OnShownBtnClick()
	{
	}

	[Token(Token = "0x6012435")]
	[Address(RVA = "0x103655C", Offset = "0x103655C", VA = "0x103655C")]
	private void OnBtnNotificationClick()
	{
	}

	[Token(Token = "0x6012436")]
	[Address(RVA = "0x103667C", Offset = "0x103667C", VA = "0x103667C")]
	protected void SetEquipBtnStatus(bool isEquiped = false, bool isIgoreMutliSelect = false)
	{
	}

	[Token(Token = "0x6012437")]
	[Address(RVA = "0x10372CC", Offset = "0x10372CC", VA = "0x10372CC")]
	protected void SetShowBtnStatus(bool canBeShowed, bool isShowed)
	{
	}

	[Token(Token = "0x6012438")]
	[Address(RVA = "0x103755C", Offset = "0x103755C", VA = "0x103755C")]
	public void SetNotificationBtnVisble(bool need_show)
	{
	}

	[Token(Token = "0x6012439")]
	[Address(RVA = "0x10376F8", Offset = "0x10376F8", VA = "0x10376F8")]
	private void RrefreshToDefault()
	{
	}

	[Token(Token = "0x601243A")]
	[Address(RVA = "0x1038584", Offset = "0x1038584", VA = "0x1038584")]
	private void RefreshToTarget(CollectionDataManager.ECollectionWeaponType targetWeaponType, uint targetWeaponId, uint targetWeaponSkinId, WeaponSkinBaseInfo targetWeaponSkinData)
	{
	}

	[Token(Token = "0x601243B")]
	[Address(RVA = "0x1037D68", Offset = "0x1037D68", VA = "0x1037D68")]
	private void RefreshToTargetSkinId(uint targetSkinId)
	{
	}

	[Token(Token = "0x601243C")]
	[Address(RVA = "0x1037AE0", Offset = "0x1037AE0", VA = "0x1037AE0")]
	private int CalAllWeaponSkins()
	{
		return default(int);
	}

	[Token(Token = "0x601243D")]
	[Address(RVA = "0x102F38C", Offset = "0x102F38C", VA = "0x102F38C")]
	public void DisplayWeaponPropertyScore(bool show)
	{
	}

	[Token(Token = "0x601243E")]
	[Address(RVA = "0x103ACA4", Offset = "0x103ACA4", VA = "0x103ACA4")]
	private void ForeceRefreshWeaponData()
	{
	}

	[Token(Token = "0x601243F")]
	[Address(RVA = "0x103AD30", Offset = "0x103AD30", VA = "0x103AD30")]
	private bool UpdateWindowParm(UINavigationData navigationData)
	{
		return default(bool);
	}

	[Token(Token = "0x6012440")]
	[Address(RVA = "0x103B200", Offset = "0x103B200", VA = "0x103B200", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6012441")]
	[Address(RVA = "0x103C344", Offset = "0x103C344", VA = "0x103C344", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6012442")]
	[Address(RVA = "0x102EFB8", Offset = "0x102EFB8", VA = "0x102EFB8")]
	private void InitAllModelResource()
	{
	}

	[Token(Token = "0x6012443")]
	[Address(RVA = "0x103C554", Offset = "0x103C554", VA = "0x103C554")]
	private void ClearAllModelResource()
	{
	}

	[Token(Token = "0x6012444")]
	[Address(RVA = "0x103C8C8", Offset = "0x103C8C8", VA = "0x103C8C8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012445")]
	[Address(RVA = "0x103C934", Offset = "0x103C934", VA = "0x103C934", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012446")]
	[Address(RVA = "0x103CF68", Offset = "0x103CF68", VA = "0x103CF68")]
	private void OnRefreshEventTrigger(object[] data)
	{
	}

	[Token(Token = "0x6012447")]
	[Address(RVA = "0x103D1F8", Offset = "0x103D1F8", VA = "0x103D1F8")]
	private void OnWeaponSkinTimelineRefresh(object[] data)
	{
	}

	[Token(Token = "0x6012448")]
	[Address(RVA = "0x103D410", Offset = "0x103D410", VA = "0x103D410")]
	private void OnWeaponSkinNeedRefresh(object[] data)
	{
	}

	[Token(Token = "0x6012449")]
	[Address(RVA = "0x103D478", Offset = "0x103D478", VA = "0x103D478", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601244A")]
	[Address(RVA = "0x103D4F4", Offset = "0x103D4F4", VA = "0x103D4F4")]
	private void OnGridListItemSelected(object[] data)
	{
	}

	[Token(Token = "0x601244B")]
	[Address(RVA = "0x1037918", Offset = "0x1037918", VA = "0x1037918")]
	private void RefreshFirstGridAndSelectDefaultItem()
	{
	}

	[Token(Token = "0x601244C")]
	[Address(RVA = "0x103E0F8", Offset = "0x103E0F8", VA = "0x103E0F8")]
	private void RefreshSecondGridAndSelectDefaultItem(CollectionDataManager.ECollectionWeaponType curWeaponType)
	{
	}

	[Token(Token = "0x601244D")]
	[Address(RVA = "0x103AA50", Offset = "0x103AA50", VA = "0x103AA50")]
	private void RefreshThirdGridAndSelectDefaultItem(uint curWeaponID)
	{
	}

	[Token(Token = "0x601244E")]
	[Address(RVA = "0x103A030", Offset = "0x103A030", VA = "0x103A030")]
	private void RefreshPreview(uint curWeaponSkinId, WeaponSkinBaseInfo curData)
	{
	}

	[Token(Token = "0x601244F")]
	[Address(RVA = "0x1033CC0", Offset = "0x1033CC0", VA = "0x1033CC0")]
	private void RrefreshPreviewWeapon(uint curWeaponSkinId, bool needrefresh = true)
	{
	}

	[Token(Token = "0x6012450")]
	[Address(RVA = "0x10426F0", Offset = "0x10426F0", VA = "0x10426F0")]
	private UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, bool changanim = true, int doubleAnimid = 0, string resSpecial = "", string resIdle = "", bool uselight = true)
	{
		return null;
	}

	[Token(Token = "0x6012451")]
	[Address(RVA = "0x103F458", Offset = "0x103F458", VA = "0x103F458")]
	private void CreatePreviewAvatarOnly(List<uint> idlist)
	{
	}

	[Token(Token = "0x6012452")]
	[Address(RVA = "0x1033290", Offset = "0x1033290", VA = "0x1033290")]
	private void CreatePreviewAvatarWithWeapon(List<uint> idlist, uint weaponid)
	{
	}

	[Token(Token = "0x6012453")]
	[Address(RVA = "0x1042898", Offset = "0x1042898", VA = "0x1042898")]
	private bool CheckIsDualWield(uint weaponid)
	{
		return default(bool);
	}

	[Token(Token = "0x6012454")]
	[Address(RVA = "0x10324BC", Offset = "0x10324BC", VA = "0x10324BC")]
	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
	{
	}

	[Token(Token = "0x6012455")]
	[Address(RVA = "0x104324C", Offset = "0x104324C", VA = "0x104324C")]
	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
	{
	}

	[Token(Token = "0x6012456")]
	[Address(RVA = "0x10429B4", Offset = "0x10429B4", VA = "0x10429B4")]
	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	[Token(Token = "0x6012457")]
	[Address(RVA = "0x10442EC", Offset = "0x10442EC", VA = "0x10442EC")]
	private bool CheckInvaildCollider(Renderer render)
	{
		return default(bool);
	}

	[Token(Token = "0x6012458")]
	[Address(RVA = "0x103BCDC", Offset = "0x103BCDC", VA = "0x103BCDC")]
	private void ClearAllUI()
	{
	}

	[Token(Token = "0x6012459")]
	[Address(RVA = "0x1040310", Offset = "0x1040310", VA = "0x1040310")]
	private void Refresh3dWeapon(ResourceID model_id)
	{
	}

	[Token(Token = "0x601245A")]
	[Address(RVA = "0x1044548", Offset = "0x1044548", VA = "0x1044548")]
	private void SavePreviewWeaponTransform()
	{
	}

	[Token(Token = "0x601245B")]
	[Address(RVA = "0x104472C", Offset = "0x104472C", VA = "0x104472C")]
	private void ResetPreviewWeaponTransform()
	{
	}

	[Token(Token = "0x601245C")]
	[Address(RVA = "0x1044928", Offset = "0x1044928", VA = "0x1044928")]
	private void UpdateLevelUpVfx()
	{
	}

	[Token(Token = "0x601245D")]
	[Address(RVA = "0x103FB10", Offset = "0x103FB10", VA = "0x103FB10")]
	private void refrehItemInfo(uint itemid)
	{
	}

	[Token(Token = "0x601245E")]
	[Address(RVA = "0x10411A0", Offset = "0x10411A0", VA = "0x10411A0")]
	private void RefreshWeaponUI(uint weaponid, WeaponSkinData lData, bool needrefresh = true)
	{
	}

	[Token(Token = "0x601245F")]
	[Address(RVA = "0x103F228", Offset = "0x103F228", VA = "0x103F228")]
	private void ShowInAbWeapon(uint weaponid, uint wid)
	{
	}

	[Token(Token = "0x6012460")]
	[Address(RVA = "0x1045958", Offset = "0x1045958", VA = "0x1045958")]
	private void ShowPropertyContainer(bool isVisible, PropertyType pType)
	{
	}

	[Token(Token = "0x6012461")]
	[Address(RVA = "0x1045C88", Offset = "0x1045C88", VA = "0x1045C88")]
	public bool SetWeaponPvpPropertyScoreVisble(bool isVisble)
	{
		return default(bool);
	}

	[Token(Token = "0x6012462")]
	[Address(RVA = "0x1044F7C", Offset = "0x1044F7C", VA = "0x1044F7C")]
	public void RefreshWeaponPropertyScore(uint itemid)
	{
	}

	[Token(Token = "0x6012463")]
	[Address(RVA = "0x10457B4", Offset = "0x10457B4", VA = "0x10457B4")]
	public void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
	{
	}

	[Token(Token = "0x6012464")]
	[Address(RVA = "0x1045D94", Offset = "0x1045D94", VA = "0x1045D94")]
	private void RefreshScoreGrid()
	{
	}

	[Token(Token = "0x6012465")]
	[Address(RVA = "0x1045E64", Offset = "0x1045E64", VA = "0x1045E64")]
	private void OnPvpToggleClick()
	{
	}

	[Token(Token = "0x6012466")]
	[Address(RVA = "0x1045ECC", Offset = "0x1045ECC", VA = "0x1045ECC")]
	private void OnPveToggleClick()
	{
	}

	[Token(Token = "0x6012467")]
	[Address(RVA = "0x1045F34", Offset = "0x1045F34", VA = "0x1045F34", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6012468")]
	[Address(RVA = "0x10461B4", Offset = "0x10461B4", VA = "0x10461B4", Slot = "45")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012469")]
	[Address(RVA = "0x10462B4", Offset = "0x10462B4", VA = "0x10462B4")]
	private void RefreshEquipBtn(bool isIgoreMutliSelect = false)
	{
	}

	[Token(Token = "0x601246A")]
	[Address(RVA = "0x1046534", Offset = "0x1046534", VA = "0x1046534")]
	private void RefreshShowBtn()
	{
	}

	[Token(Token = "0x601246B")]
	[Address(RVA = "0x1046670", Offset = "0x1046670", VA = "0x1046670", Slot = "44")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601246C")]
	[Address(RVA = "0x103E9A4", Offset = "0x103E9A4", VA = "0x103E9A4")]
	private List<PopMenuData> PrepareFirstGridData()
	{
		return null;
	}

	[Token(Token = "0x601246D")]
	[Address(RVA = "0x103ED48", Offset = "0x103ED48", VA = "0x103ED48")]
	private List<PopMenuData> PrepareSecondGridListData(List<uint> allWeaponIdOfThisType)
	{
		return null;
	}

	[Token(Token = "0x601246E")]
	[Address(RVA = "0x103F0FC", Offset = "0x103F0FC", VA = "0x103F0FC")]
	private List<WeaponSkinBaseInfo> PrepareThirdGridListData(uint curWeaponID)
	{
		return null;
	}

	[Token(Token = "0x601246F")]
	[Address(RVA = "0x10396E4", Offset = "0x10396E4", VA = "0x10396E4")]
	private List<WeaponSkinBaseInfo> ReArrangeList(List<WeaponSkinBaseInfo> list, bool isMutliSelect = false)
	{
		return null;
	}

	[Token(Token = "0x6012472")]
	[Address(RVA = "0x1046FF8", Offset = "0x1046FF8", VA = "0x1046FF8")]
	private bool CheckWeaponTypeAndWeaponID()
	{
		return default(bool);
	}

	[Token(Token = "0x6012473")]
	[Address(RVA = "0x10369AC", Offset = "0x10369AC", VA = "0x10369AC")]
	private void RefreshMutliSelectBtn(bool isIgoreMutliSelect = false)
	{
	}

	[Token(Token = "0x6012474")]
	[Address(RVA = "0x1047158", Offset = "0x1047158", VA = "0x1047158")]
	private void OnClickMutliSelectGuide()
	{
	}

	[Token(Token = "0x6012475")]
	[Address(RVA = "0x1047580", Offset = "0x1047580", VA = "0x1047580")]
	private void OnClickMutliSelectSecondGuide()
	{
	}

	[Token(Token = "0x6012476")]
	[Address(RVA = "0x1036F34", Offset = "0x1036F34", VA = "0x1036F34")]
	private void RefreshMutliSelectEquipBtn()
	{
	}

	[Token(Token = "0x6012477")]
	[Address(RVA = "0x1047684", Offset = "0x1047684", VA = "0x1047684")]
	private void OnClickMutliTipsBtn()
	{
	}

	[Token(Token = "0x6012478")]
	[Address(RVA = "0x10479B4", Offset = "0x10479B4", VA = "0x10479B4")]
	private void OnClickMutliSelectUnequipBtn()
	{
	}

	[Token(Token = "0x6012479")]
	[Address(RVA = "0x1047A94", Offset = "0x1047A94", VA = "0x1047A94")]
	private void OnClickMutliSelectEquipBtn()
	{
	}

	[Token(Token = "0x601247A")]
	[Address(RVA = "0x1047B74", Offset = "0x1047B74", VA = "0x1047B74")]
	private void OnClickRandomCheckBoxBtn()
	{
	}

	[Token(Token = "0x601247B")]
	[Address(RVA = "0x1047C40", Offset = "0x1047C40", VA = "0x1047C40")]
	private void _003COnShareClick_003Em__0()
	{
	}

	[Token(Token = "0x601247C")]
	[Address(RVA = "0x1047FF8", Offset = "0x1047FF8", VA = "0x1047FF8")]
	private static int _003CRefreshToTarget_003Em__1(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x601247D")]
	[Address(RVA = "0x10480EC", Offset = "0x10480EC", VA = "0x10480EC")]
	private static int _003CRefreshToTargetSkinId_003Em__2(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x601247E")]
	[Address(RVA = "0x10481E0", Offset = "0x10481E0", VA = "0x10481E0")]
	private static int _003CPrepareFirstGridData_003Em__3(uint a, uint b)
	{
		return default(int);
	}

	[Token(Token = "0x601247F")]
	[Address(RVA = "0x10482D4", Offset = "0x10482D4", VA = "0x10482D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012480")]
	[Address(RVA = "0x10482DC", Offset = "0x10482DC", VA = "0x10482DC")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6012481")]
	[Address(RVA = "0x10482E4", Offset = "0x10482E4", VA = "0x10482E4")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6012482")]
	[Address(RVA = "0x10482EC", Offset = "0x10482EC", VA = "0x10482EC")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6012483")]
	[Address(RVA = "0x10482F4", Offset = "0x10482F4", VA = "0x10482F4")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6012484")]
	[Address(RVA = "0x10482FC", Offset = "0x10482FC", VA = "0x10482FC")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6012485")]
	[Address(RVA = "0x1048304", Offset = "0x1048304", VA = "0x1048304")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
