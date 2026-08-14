using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002132")]
public class UIHDStandLobbyManager : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2002133")]
	public enum HDLobbyState
	{
		[Token(Token = "0x400D030")]
		Lobby = 0,
		[Token(Token = "0x400D031")]
		Yard = 1,
		[Token(Token = "0x400D032")]
		WeaponRack = 2,
		[Token(Token = "0x400D033")]
		VehicleDisplay = 3,
		[Token(Token = "0x400D034")]
		IceDisplay = 4,
		[Token(Token = "0x400D035")]
		SkyboardDisplay = 5,
		[Token(Token = "0x400D036")]
		Others = 999
	}

	[Token(Token = "0x2002134")]
	public enum HDDefaultItemType
	{
		[Token(Token = "0x400D038")]
		Item = 1,
		[Token(Token = "0x400D039")]
		Skin
	}

	[Token(Token = "0x2002135")]
	private sealed class _003CLobbyEnter_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D03A")]
		[FieldOffset(Offset = "0x8")]
		internal UIHDStandLobbyManager _0024this;

		[Token(Token = "0x400D03B")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D03C")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D03D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001006")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AE39")]
			[Address(RVA = "0x166A2B4", Offset = "0x166A2B4", VA = "0x166A2B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001007")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AE3A")]
			[Address(RVA = "0x166A2BC", Offset = "0x166A2BC", VA = "0x166A2BC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AE37")]
		[Address(RVA = "0x1669F6C", Offset = "0x1669F6C", VA = "0x1669F6C")]
		public _003CLobbyEnter_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AE38")]
		[Address(RVA = "0x1669F74", Offset = "0x1669F74", VA = "0x1669F74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AE3B")]
		[Address(RVA = "0x166A2C4", Offset = "0x166A2C4", VA = "0x166A2C4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AE3C")]
		[Address(RVA = "0x166A2D8", Offset = "0x166A2D8", VA = "0x166A2D8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CFF2")]
	[FieldOffset(Offset = "0xC")]
	private GameObject _root;

	[Token(Token = "0x400CFF3")]
	[FieldOffset(Offset = "0x10")]
	private Animator m_CarPlatAnimator;

	[Token(Token = "0x400CFF4")]
	[FieldOffset(Offset = "0x14")]
	private Animator m_GunDoorAnimator;

	[Token(Token = "0x400CFF5")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_GunDoorRoot;

	[Token(Token = "0x400CFF6")]
	[FieldOffset(Offset = "0x1C")]
	private Transform m_VehicleRoot;

	[Token(Token = "0x400CFF7")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_VehicleCollider;

	[Token(Token = "0x400CFF8")]
	[FieldOffset(Offset = "0x24")]
	private Transform m_IceWallRoot;

	[Token(Token = "0x400CFF9")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_IceWallCollider;

	[Token(Token = "0x400CFFA")]
	[FieldOffset(Offset = "0x2C")]
	private Transform m_SkyboardRoot;

	[Token(Token = "0x400CFFB")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_SkyboardCollider;

	[Token(Token = "0x400CFFC")]
	[FieldOffset(Offset = "0x34")]
	private Transform m_FloorVFXRoot;

	[Token(Token = "0x400CFFD")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_BehindSkyRoot;

	[Token(Token = "0x400CFFE")]
	[FieldOffset(Offset = "0x3C")]
	private Transform[] m_WeaponSlot;

	[Token(Token = "0x400CFFF")]
	[FieldOffset(Offset = "0x40")]
	private GameObject[] m_WeaponOnSlotVFX;

	[Token(Token = "0x400D000")]
	[FieldOffset(Offset = "0x44")]
	private GameObject[] m_WeaponEquipedVFX;

	[Token(Token = "0x400D001")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_VehicleEquipedVFX;

	[Token(Token = "0x400D002")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_IceWallEquipedVFX;

	[Token(Token = "0x400D003")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_SkyboardEquipedVFX;

	[Token(Token = "0x400D004")]
	[FieldOffset(Offset = "0x54")]
	private Renderer m_VehiclePlatRenderer;

	[Token(Token = "0x400D005")]
	[FieldOffset(Offset = "0x58")]
	private Renderer m_WeaponPanelRenderer;

	[Token(Token = "0x400D006")]
	[FieldOffset(Offset = "0x5C")]
	private Transform m_PlannarShadowPanel;

	[Token(Token = "0x400D007")]
	[FieldOffset(Offset = "0x60")]
	private Renderer[] m_Renderer;

	[Token(Token = "0x400D008")]
	[FieldOffset(Offset = "0x64")]
	private Transform m_FloorLaceVFXRoot;

	[Token(Token = "0x400D009")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_LobbyLEDScreenVFXRoot;

	[Token(Token = "0x400D00A")]
	[FieldOffset(Offset = "0x6C")]
	private Transform[] m_Weapons;

	[Token(Token = "0x400D00B")]
	[FieldOffset(Offset = "0x70")]
	private bool[] m_WeaponNeedRefresh;

	[Token(Token = "0x400D00C")]
	[FieldOffset(Offset = "0x74")]
	private Transform m_VehicleTrans;

	[Token(Token = "0x400D00D")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_IceTrans;

	[Token(Token = "0x400D00E")]
	[FieldOffset(Offset = "0x7C")]
	private Transform m_SkyboardTrans;

	[Token(Token = "0x400D00F")]
	[FieldOffset(Offset = "0x80")]
	private bool m_LobbyShow;

	[Token(Token = "0x400D010")]
	[FieldOffset(Offset = "0x81")]
	private bool m_FirstEnter;

	[Token(Token = "0x400D011")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 m_deltaPosition;

	[Token(Token = "0x400D012")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_avatarLocalPosition;

	[Token(Token = "0x400D013")]
	[FieldOffset(Offset = "0x9C")]
	private Animator m_CameraAnimator;

	[Token(Token = "0x400D014")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_IsCameraMoving;

	[Token(Token = "0x400D015")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_CurrentVehicleSkinID;

	[Token(Token = "0x400D016")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_NeedEquipVehicleSkinID;

	[Token(Token = "0x400D017")]
	[FieldOffset(Offset = "0xAC")]
	private float m_CurrentVehicleRotate;

	[Token(Token = "0x400D018")]
	private const string HDVEHICLEDISPLAYANGLE = "HDVEHICLEDISPLAYANGLE_";

	[Token(Token = "0x400D019")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_currenticedalaycall;

	[Token(Token = "0x400D01A")]
	[FieldOffset(Offset = "0xB4")]
	private uint m_CurrentIceWallSkinID;

	[Token(Token = "0x400D01B")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_NeedEquipIceWallSkinID;

	[Token(Token = "0x400D01C")]
	[FieldOffset(Offset = "0xBC")]
	private float m_CurrentIceWallRotate;

	[Token(Token = "0x400D01D")]
	private const string HDIceWallDISPLAYANGLE = "HDIceWallDISPLAYANGLE_";

	[Token(Token = "0x400D01E")]
	[FieldOffset(Offset = "0xC0")]
	private uint m_currentSkyboardDelaycall;

	[Token(Token = "0x400D01F")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_CurrentSkyboardSkinID;

	[Token(Token = "0x400D020")]
	[FieldOffset(Offset = "0xC8")]
	private uint m_NeedEquipSkyboardSkinID;

	[Token(Token = "0x400D021")]
	[FieldOffset(Offset = "0xCC")]
	private float m_CurrentSkyboardRotate;

	[Token(Token = "0x400D022")]
	private const string HDSKYBOARDDISPLAYANGLE = "HDSKYBOARDDISPLAYANGLE_";

	[Token(Token = "0x400D023")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsStartToCloseUI;

	[Token(Token = "0x400D024")]
	[FieldOffset(Offset = "0x4")]
	public static HDLobbyState CurrentState;

	[Token(Token = "0x400D025")]
	[FieldOffset(Offset = "0xD0")]
	private float m_ShadowDistance;

	[Token(Token = "0x400D026")]
	public const float LOBBYSHADOWDISTANCE = 5f;

	[Token(Token = "0x400D027")]
	public const float LOBBY_DISPLAY_ITEM_SHADOW_DISTANCE = 7f;

	[Token(Token = "0x400D028")]
	[FieldOffset(Offset = "0xD4")]
	private ResourceID m_currentFloorVFx;

	[Token(Token = "0x400D029")]
	[FieldOffset(Offset = "0xD8")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400D02A")]
	[FieldOffset(Offset = "0xDC")]
	private HashSet<uint> m_HDWeaponHideScabbardIDs;

	[Token(Token = "0x400D02B")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_HindSkyObj;

	[Token(Token = "0x400D02C")]
	[FieldOffset(Offset = "0xE4")]
	private GameObject m_FloorLaceVFXObj;

	[Token(Token = "0x400D02D")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject m_LobbyLEDScreenVFXObj;

	[Token(Token = "0x400D02E")]
	[FieldOffset(Offset = "0x8")]
	private static uint NoneSkyboardSkinID;

	[Token(Token = "0x600ADDE")]
	[Address(RVA = "0x203B76C", Offset = "0x203B76C", VA = "0x203B76C")]
	public UIHDStandLobbyManager()
	{
	}

	[Token(Token = "0x600ADDF")]
	[Address(RVA = "0x203B900", Offset = "0x203B900", VA = "0x203B900")]
	private void Awake()
	{
	}

	[Token(Token = "0x600ADE0")]
	[Address(RVA = "0x20400D0", Offset = "0x20400D0", VA = "0x20400D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600ADE1")]
	[Address(RVA = "0x20401D8", Offset = "0x20401D8", VA = "0x20401D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600ADE2")]
	[Address(RVA = "0x20414BC", Offset = "0x20414BC", VA = "0x20414BC")]
	private void OnLobbyEnter(object[] data)
	{
	}

	[Token(Token = "0x600ADE3")]
	[Address(RVA = "0x2041630", Offset = "0x2041630", VA = "0x2041630")]
	private IEnumerator LobbyEnter()
	{
		return null;
	}

	[Token(Token = "0x600ADE4")]
	[Address(RVA = "0x20416FC", Offset = "0x20416FC", VA = "0x20416FC")]
	private void OnLobbyControllerVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x600ADE5")]
	[Address(RVA = "0x2041CB8", Offset = "0x2041CB8", VA = "0x2041CB8")]
	private void OnLobbyVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x600ADE6")]
	[Address(RVA = "0x2041DFC", Offset = "0x2041DFC", VA = "0x2041DFC")]
	private void OnLobbyYardVisibilityChanged(object[] data)
	{
	}

	[Token(Token = "0x600ADE7")]
	[Address(RVA = "0x2042328", Offset = "0x2042328", VA = "0x2042328")]
	private void OnWeaponRackUIOpen(object[] data)
	{
	}

	[Token(Token = "0x600ADE8")]
	[Address(RVA = "0x2042564", Offset = "0x2042564", VA = "0x2042564")]
	private void OnWeaponRackUINavigationShow(object[] data)
	{
	}

	[Token(Token = "0x600ADE9")]
	[Address(RVA = "0x2042758", Offset = "0x2042758", VA = "0x2042758")]
	private void OnVehicleDisplayUIOpen(object[] data)
	{
	}

	[Token(Token = "0x600ADEA")]
	[Address(RVA = "0x2042898", Offset = "0x2042898", VA = "0x2042898")]
	private void OnIceDisplayUIOpen(object[] data)
	{
	}

	[Token(Token = "0x600ADEB")]
	[Address(RVA = "0x20429D8", Offset = "0x20429D8", VA = "0x20429D8")]
	private void OnSkyboardDisplayUIOpen(object[] data)
	{
	}

	[Token(Token = "0x600ADEC")]
	[Address(RVA = "0x2042B18", Offset = "0x2042B18", VA = "0x2042B18")]
	private void OnLobbyItemClose(object[] data)
	{
	}

	[Token(Token = "0x600ADED")]
	[Address(RVA = "0x2042C04", Offset = "0x2042C04", VA = "0x2042C04")]
	private void OnVehicleDisplayUINavigationShow(object[] data)
	{
	}

	[Token(Token = "0x600ADEE")]
	[Address(RVA = "0x2042DF8", Offset = "0x2042DF8", VA = "0x2042DF8")]
	private void OnIceDisplayUINavigationShow(object[] data)
	{
	}

	[Token(Token = "0x600ADEF")]
	[Address(RVA = "0x2042FEC", Offset = "0x2042FEC", VA = "0x2042FEC")]
	private void OnSkyboardDisplayUINavigationShow(object[] data)
	{
	}

	[Token(Token = "0x600ADF0")]
	[Address(RVA = "0x20431E0", Offset = "0x20431E0", VA = "0x20431E0")]
	private void OnMallEnter(object[] data)
	{
	}

	[Token(Token = "0x600ADF1")]
	[Address(RVA = "0x20432E8", Offset = "0x20432E8", VA = "0x20432E8")]
	private void OnCameraMoveEnd(object[] data)
	{
	}

	[Token(Token = "0x600ADF2")]
	[Address(RVA = "0x20448FC", Offset = "0x20448FC", VA = "0x20448FC")]
	private void OnBeginToLeaveWeaponUI(object[] data)
	{
	}

	[Token(Token = "0x600ADF3")]
	[Address(RVA = "0x2044B84", Offset = "0x2044B84", VA = "0x2044B84")]
	private void OnBeginToLeaveCarPlatUI(object[] data)
	{
	}

	[Token(Token = "0x600ADF4")]
	[Address(RVA = "0x2044FCC", Offset = "0x2044FCC", VA = "0x2044FCC")]
	private void OnBeginToLeaveIcePlatUI(object[] data)
	{
	}

	[Token(Token = "0x600ADF5")]
	[Address(RVA = "0x2045414", Offset = "0x2045414", VA = "0x2045414")]
	private void OnBeginToLeaveSkyboardPlatUI(object[] data)
	{
	}

	[Token(Token = "0x600ADF6")]
	[Address(RVA = "0x204358C", Offset = "0x204358C", VA = "0x204358C")]
	private void ResetToLobbyState()
	{
	}

	[Token(Token = "0x600ADF7")]
	[Address(RVA = "0x203A7F0", Offset = "0x203A7F0", VA = "0x203A7F0")]
	public bool IsCameraAnimatorEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600ADF8")]
	[Address(RVA = "0x204585C", Offset = "0x204585C", VA = "0x204585C")]
	private void MoveIdleEnterGroup(object[] data)
	{
	}

	[Token(Token = "0x600ADF9")]
	[Address(RVA = "0x204596C", Offset = "0x204596C", VA = "0x204596C")]
	private void ResetLobbyIdle(object[] data)
	{
	}

	[Token(Token = "0x600ADFA")]
	[Address(RVA = "0x20459D4", Offset = "0x20459D4", VA = "0x20459D4")]
	private void OnWeaponShowInGunDoor(object[] data)
	{
	}

	[Token(Token = "0x600ADFB")]
	[Address(RVA = "0x2046C94", Offset = "0x2046C94", VA = "0x2046C94")]
	private void OnSwitchWeapons(object[] data)
	{
	}

	[Token(Token = "0x600ADFC")]
	[Address(RVA = "0x203ED68", Offset = "0x203ED68", VA = "0x203ED68")]
	private void OnWeaponInit(object[] data)
	{
	}

	[Token(Token = "0x600ADFD")]
	[Address(RVA = "0x2047A80", Offset = "0x2047A80", VA = "0x2047A80")]
	private void OnRemoveSlotWeapon(object[] data)
	{
	}

	[Token(Token = "0x600ADFE")]
	[Address(RVA = "0x2047B5C", Offset = "0x2047B5C", VA = "0x2047B5C")]
	private void OnDeleteSlotWeapon(int slot)
	{
	}

	[Token(Token = "0x600ADFF")]
	[Address(RVA = "0x2045D6C", Offset = "0x2045D6C", VA = "0x2045D6C")]
	private void SetSlotWeapon(int slot, WeaponSkinData skin)
	{
	}

	[Token(Token = "0x600AE00")]
	[Address(RVA = "0x2047EDC", Offset = "0x2047EDC", VA = "0x2047EDC")]
	private Transform FindTransformInChildren(Transform root, string name)
	{
		return null;
	}

	[Token(Token = "0x600AE01")]
	[Address(RVA = "0x204843C", Offset = "0x204843C", VA = "0x204843C")]
	private void OnWeaponOnSlot(object[] data)
	{
	}

	[Token(Token = "0x600AE02")]
	[Address(RVA = "0x2048608", Offset = "0x2048608", VA = "0x2048608")]
	private void OnWeaponLeaveSlot(object[] data)
	{
	}

	[Token(Token = "0x600AE03")]
	[Address(RVA = "0x203E51C", Offset = "0x203E51C", VA = "0x203E51C")]
	private void ClearWeaponVFX()
	{
	}

	[Token(Token = "0x600AE04")]
	[Address(RVA = "0x204785C", Offset = "0x204785C", VA = "0x204785C")]
	private bool IsWeaponOnRack()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE05")]
	[Address(RVA = "0x204383C", Offset = "0x204383C", VA = "0x204383C")]
	private void EquipDefaultWeapon()
	{
	}

	[Token(Token = "0x600AE06")]
	[Address(RVA = "0x2042470", Offset = "0x2042470", VA = "0x2042470")]
	private void DeEquipDefaultWeapon()
	{
	}

	[Token(Token = "0x600AE07")]
	[Address(RVA = "0x203F030", Offset = "0x203F030", VA = "0x203F030")]
	private void OnVehicleInit(object[] data)
	{
	}

	[Token(Token = "0x600AE08")]
	[Address(RVA = "0x20493F8", Offset = "0x20493F8", VA = "0x20493F8")]
	private void EquipDefaultVehicle()
	{
	}

	[Token(Token = "0x600AE09")]
	[Address(RVA = "0x2048B28", Offset = "0x2048B28", VA = "0x2048B28")]
	private void EquipVehicleSkin(VehicleSkinData info, bool needSFX = false)
	{
	}

	[Token(Token = "0x600AE0A")]
	[Address(RVA = "0x2048908", Offset = "0x2048908", VA = "0x2048908")]
	private void DeEquipVehicleSkin()
	{
	}

	[Token(Token = "0x600AE0B")]
	[Address(RVA = "0x2049B28", Offset = "0x2049B28", VA = "0x2049B28")]
	private void RemoveVehicle(object[] data)
	{
	}

	[Token(Token = "0x600AE0C")]
	[Address(RVA = "0x2049BDC", Offset = "0x2049BDC", VA = "0x2049BDC")]
	private void ChangeVehicle(object[] data)
	{
	}

	[Token(Token = "0x600AE0D")]
	[Address(RVA = "0x203F31C", Offset = "0x203F31C", VA = "0x203F31C")]
	private void OnIceWallInit(object[] data)
	{
	}

	[Token(Token = "0x600AE0E")]
	[Address(RVA = "0x204A118", Offset = "0x204A118", VA = "0x204A118")]
	private void EquipIceWallSkin(WeaponSkinData info, bool needSFX = false)
	{
	}

	[Token(Token = "0x600AE0F")]
	[Address(RVA = "0x2049EF8", Offset = "0x2049EF8", VA = "0x2049EF8")]
	private void DeEquipIceWallSkin()
	{
	}

	[Token(Token = "0x600AE10")]
	[Address(RVA = "0x204B9C8", Offset = "0x204B9C8", VA = "0x204B9C8")]
	private void RemoveIceWall(object[] data)
	{
	}

	[Token(Token = "0x600AE11")]
	[Address(RVA = "0x204BA7C", Offset = "0x204BA7C", VA = "0x204BA7C")]
	private void ChangeIceWall(object[] data)
	{
	}

	[Token(Token = "0x600AE12")]
	[Address(RVA = "0x204ADF0", Offset = "0x204ADF0", VA = "0x204ADF0")]
	private void EquipDefaultIceWall()
	{
	}

	[Token(Token = "0x600AE13")]
	[Address(RVA = "0x203F608", Offset = "0x203F608", VA = "0x203F608")]
	private void OnSkyboardInit(object[] data)
	{
	}

	[Token(Token = "0x600AE14")]
	[Address(RVA = "0x204C000", Offset = "0x204C000", VA = "0x204C000")]
	private void EquipSkyboardSkin(SkyboardData skyboardInfo, bool needSFX = false)
	{
	}

	[Token(Token = "0x600AE15")]
	[Address(RVA = "0x204CD08", Offset = "0x204CD08", VA = "0x204CD08")]
	private void EquipDefaultSkyboard()
	{
	}

	[Token(Token = "0x600AE16")]
	[Address(RVA = "0x204BDE0", Offset = "0x204BDE0", VA = "0x204BDE0")]
	private void DeEquipSkyboardSkin()
	{
	}

	[Token(Token = "0x600AE17")]
	[Address(RVA = "0x204DA50", Offset = "0x204DA50", VA = "0x204DA50")]
	private void RemoveSkyboard(object[] data)
	{
	}

	[Token(Token = "0x600AE18")]
	[Address(RVA = "0x204DB04", Offset = "0x204DB04", VA = "0x204DB04")]
	private void ChangeSkyboard(object[] data)
	{
	}

	[Token(Token = "0x600AE19")]
	[Address(RVA = "0x204DD34", Offset = "0x204DD34", VA = "0x204DD34")]
	public bool GetWeaponRackPosition(out Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600AE1A")]
	[Address(RVA = "0x204DECC", Offset = "0x204DECC", VA = "0x204DECC")]
	public bool GetVehiclePosition(out Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600AE1B")]
	[Address(RVA = "0x204E064", Offset = "0x204E064", VA = "0x204E064")]
	public bool GetIceWallPosition(out Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600AE1C")]
	[Address(RVA = "0x204E1FC", Offset = "0x204E1FC", VA = "0x204E1FC")]
	public bool GetSkyboardPosition(out Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600AE1D")]
	[Address(RVA = "0x2047DB0", Offset = "0x2047DB0", VA = "0x2047DB0")]
	private void ChangeLayer(Transform trans, string layerName)
	{
	}

	[Token(Token = "0x600AE1E")]
	[Address(RVA = "0x2044E14", Offset = "0x2044E14", VA = "0x2044E14")]
	private void SetVehicleRotate()
	{
	}

	[Token(Token = "0x600AE1F")]
	[Address(RVA = "0x204525C", Offset = "0x204525C", VA = "0x204525C")]
	private void SetIceWallRotate()
	{
	}

	[Token(Token = "0x600AE20")]
	[Address(RVA = "0x20456A4", Offset = "0x20456A4", VA = "0x20456A4")]
	private void SetSkyboardRotate()
	{
	}

	[Token(Token = "0x600AE21")]
	[Address(RVA = "0x20487D4", Offset = "0x20487D4", VA = "0x20487D4")]
	private float GetVehicleRotate()
	{
		return default(float);
	}

	[Token(Token = "0x600AE22")]
	[Address(RVA = "0x2049DC4", Offset = "0x2049DC4", VA = "0x2049DC4")]
	private float GetIceWallRotate()
	{
		return default(float);
	}

	[Token(Token = "0x600AE23")]
	[Address(RVA = "0x204BCAC", Offset = "0x204BCAC", VA = "0x204BCAC")]
	private float GetSkyboardRotate()
	{
		return default(float);
	}

	[Token(Token = "0x600AE24")]
	[Address(RVA = "0x203F8A8", Offset = "0x203F8A8", VA = "0x203F8A8")]
	private void InitDisplayObjectInputHandler()
	{
	}

	[Token(Token = "0x600AE25")]
	[Address(RVA = "0x204E394", Offset = "0x204E394", VA = "0x204E394")]
	private void CleanWeaponRack()
	{
	}

	[Token(Token = "0x600AE26")]
	[Address(RVA = "0x203E710", Offset = "0x203E710", VA = "0x203E710")]
	private void OnEnterCaptainLobby(object[] data)
	{
	}

	[Token(Token = "0x600AE27")]
	[Address(RVA = "0x204E608", Offset = "0x204E608", VA = "0x204E608")]
	private void OnLeaveCaptainLobby(object[] data)
	{
	}

	[Token(Token = "0x600AE28")]
	[Address(RVA = "0x203DF94", Offset = "0x203DF94", VA = "0x203DF94")]
	public ResourceID GetHDLobbyFloorRes()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE29")]
	[Address(RVA = "0x203E258", Offset = "0x203E258", VA = "0x203E258")]
	public ResourceID GetHDLobbyHindSkyRes()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE2A")]
	[Address(RVA = "0x204E718", Offset = "0x204E718", VA = "0x204E718")]
	private void OnMaxLobbyResUpdate(object[] data)
	{
	}

	[Token(Token = "0x600AE2B")]
	[Address(RVA = "0x204EB4C", Offset = "0x204EB4C", VA = "0x204EB4C")]
	private void SetLobbySkin()
	{
	}

	[Token(Token = "0x600AE2C")]
	[Address(RVA = "0x204EBBC", Offset = "0x204EBBC", VA = "0x204EBBC")]
	private void SetLobbyRendererMainTexture()
	{
	}

	[Token(Token = "0x600AE2D")]
	[Address(RVA = "0x204F128", Offset = "0x204F128", VA = "0x204F128")]
	private void SetLobbyScreenVFX()
	{
	}

	[Token(Token = "0x600AE2E")]
	[Address(RVA = "0x204F644", Offset = "0x204F644", VA = "0x204F644")]
	private void SetLobbyFloorLaceVFX()
	{
	}

	[Token(Token = "0x600AE2F")]
	[Address(RVA = "0x2048140", Offset = "0x2048140", VA = "0x2048140")]
	private void SetCastShadow(bool castShadow, Renderer[] renderers, EFrontendPlannarShadowType ePlannarShadowType = EFrontendPlannarShadowType.Main)
	{
	}

	[Token(Token = "0x600AE30")]
	[Address(RVA = "0x204FB60", Offset = "0x204FB60", VA = "0x204FB60")]
	private void OnClothesChange(object[] data)
	{
	}

	[Token(Token = "0x600AE31")]
	[Address(RVA = "0x20503C0", Offset = "0x20503C0", VA = "0x20503C0")]
	public void OnApplicationPause(bool pauseState)
	{
	}

	[Token(Token = "0x600AE32")]
	[Address(RVA = "0x2050430", Offset = "0x2050430", VA = "0x2050430", Slot = "4")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AE33")]
	[Address(RVA = "0x2050BB8", Offset = "0x2050BB8", VA = "0x2050BB8", Slot = "5")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AE35")]
	[Address(RVA = "0x2050C74", Offset = "0x2050C74", VA = "0x2050C74")]
	private void _003CEquipIceWallSkin_003Em__0()
	{
	}

	[Token(Token = "0x600AE36")]
	[Address(RVA = "0x2050CA4", Offset = "0x2050CA4", VA = "0x2050CA4")]
	private void _003CEquipSkyboardSkin_003Em__1()
	{
	}
}
