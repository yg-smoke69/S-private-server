using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002719")]
internal class UIHudCrosshairsController : UIBaseController
{
	[Token(Token = "0x200271A")]
	private class ScaleTweenSeq
	{
		[Token(Token = "0x400F15E")]
		[FieldOffset(Offset = "0x8")]
		public float startScale;

		[Token(Token = "0x400F15F")]
		[FieldOffset(Offset = "0xC")]
		public float endScale;

		[Token(Token = "0x400F160")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		[Token(Token = "0x400F161")]
		[FieldOffset(Offset = "0x14")]
		public bool start;

		[Token(Token = "0x400F162")]
		[FieldOffset(Offset = "0x15")]
		public bool end;

		[Token(Token = "0x400F163")]
		[FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x400F164")]
		[FieldOffset(Offset = "0x1C")]
		public GameObject target;

		[Token(Token = "0x600EDD7")]
		[Address(RVA = "0x1372758", Offset = "0x1372758", VA = "0x1372758")]
		public ScaleTweenSeq(GameObject target, float startScale, float endScale, float duration)
		{
		}
	}

	[Token(Token = "0x200271B")]
	private class PositionTweenSeq
	{
		[Token(Token = "0x400F165")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 startPosition;

		[Token(Token = "0x400F166")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 endPosition;

		[Token(Token = "0x400F167")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x400F168")]
		[FieldOffset(Offset = "0x24")]
		public bool start;

		[Token(Token = "0x400F169")]
		[FieldOffset(Offset = "0x25")]
		public bool end;

		[Token(Token = "0x400F16A")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x400F16B")]
		[FieldOffset(Offset = "0x2C")]
		public GameObject target;

		[Token(Token = "0x600EDD8")]
		[Address(RVA = "0x1372984", Offset = "0x1372984", VA = "0x1372984")]
		public PositionTweenSeq(GameObject target, Vector3 startPosition, Vector3 endPosition, float duration)
		{
		}
	}

	[Token(Token = "0x200271C")]
	private class RotationTweenSeq
	{
		[Token(Token = "0x400F16C")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 startRotation;

		[Token(Token = "0x400F16D")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 endRotation;

		[Token(Token = "0x400F16E")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x400F16F")]
		[FieldOffset(Offset = "0x24")]
		public bool start;

		[Token(Token = "0x400F170")]
		[FieldOffset(Offset = "0x25")]
		public bool end;

		[Token(Token = "0x400F171")]
		[FieldOffset(Offset = "0x28")]
		public float tiem;

		[Token(Token = "0x400F172")]
		[FieldOffset(Offset = "0x2C")]
		public GameObject target;

		[Token(Token = "0x600EDD9")]
		[Address(RVA = "0x1372BBC", Offset = "0x1372BBC", VA = "0x1372BBC")]
		public RotationTweenSeq(GameObject target, Vector3 startRotation, Vector3 endRotation, float duration)
		{
		}
	}

	[Token(Token = "0x200271D")]
	private sealed class _003CPlayHitEffect_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F173")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudCrosshairsController _0024this;

		[Token(Token = "0x400F174")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F175")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F176")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EDDC")]
			[Address(RVA = "0x1375E44", Offset = "0x1375E44", VA = "0x1375E44", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EDDD")]
			[Address(RVA = "0x1375E4C", Offset = "0x1375E4C", VA = "0x1375E4C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EDDA")]
		[Address(RVA = "0x1373EB4", Offset = "0x1373EB4", VA = "0x1373EB4")]
		public _003CPlayHitEffect_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600EDDB")]
		[Address(RVA = "0x1375C2C", Offset = "0x1375C2C", VA = "0x1375C2C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EDDE")]
		[Address(RVA = "0x1375E54", Offset = "0x1375E54", VA = "0x1375E54", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EDDF")]
		[Address(RVA = "0x1375E68", Offset = "0x1375E68", VA = "0x1375E68", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200271E")]
	private sealed class _003CShieldGunShieldBrokenHide_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F177")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudCrosshairsController _0024this;

		[Token(Token = "0x400F178")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F179")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F17A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600EDE2")]
			[Address(RVA = "0x1375FDC", Offset = "0x1375FDC", VA = "0x1375FDC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600EDE3")]
			[Address(RVA = "0x1375FE4", Offset = "0x1375FE4", VA = "0x1375FE4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600EDE0")]
		[Address(RVA = "0x13756D0", Offset = "0x13756D0", VA = "0x13756D0")]
		public _003CShieldGunShieldBrokenHide_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600EDE1")]
		[Address(RVA = "0x1375EF0", Offset = "0x1375EF0", VA = "0x1375EF0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600EDE4")]
		[Address(RVA = "0x1375FEC", Offset = "0x1375FEC", VA = "0x1375FEC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600EDE5")]
		[Address(RVA = "0x1376000", Offset = "0x1376000", VA = "0x1376000", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F139")]
	private const uint VISIBILITY_STATE_NORMAL = 1u;

	[Token(Token = "0x400F13A")]
	private const uint VISIBILITY_STATE_HIT = 2u;

	[Token(Token = "0x400F13B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color AIM_COLOR_NO_TARGET;

	[Token(Token = "0x400F13C")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color AIM_COLOR_HAS_TARGET;

	[Token(Token = "0x400F13D")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Color CHARGE_COLOR_NO_TARGET;

	[Token(Token = "0x400F13E")]
	[FieldOffset(Offset = "0x30")]
	private static readonly Color CHARGE_COLOR_HAS_TARGET;

	[Token(Token = "0x400F13F")]
	[FieldOffset(Offset = "0x40")]
	private static readonly Color GUNSIGHTCENTER_COLOR_NO_TARGET;

	[Token(Token = "0x400F140")]
	[FieldOffset(Offset = "0x50")]
	private static readonly Color GUNSIGHTCENTER_COLOR_HAS_TARGET;

	[Token(Token = "0x400F141")]
	[FieldOffset(Offset = "0x60")]
	private static readonly Color GUNSIGHTCENTER_COLOR_THERMAL_HAS_TARGET;

	[Token(Token = "0x400F142")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCrosshairsView m_View;

	[Token(Token = "0x400F143")]
	[FieldOffset(Offset = "0x2C")]
	private BitArrayBoolean m_CrosshairVisibility;

	[Token(Token = "0x400F144")]
	[FieldOffset(Offset = "0x30")]
	private bool m_LastSightingState;

	[Token(Token = "0x400F145")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 defaultSize;

	[Token(Token = "0x400F146")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_BuildingCrossHair;

	[Token(Token = "0x400F147")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider[] m_BuildingCrossHairColliders;

	[Token(Token = "0x400F148")]
	[FieldOffset(Offset = "0x48")]
	private SpawnObjectCrossHairTrigger m_BuildingCrossHairTrigger;

	[Token(Token = "0x400F149")]
	[FieldOffset(Offset = "0x4C")]
	private IceWallCrossHairTrigger[] m_IcewallTriggers;

	[Token(Token = "0x400F14A")]
	[FieldOffset(Offset = "0x50")]
	private float m_OriginAngle;

	[Token(Token = "0x400F14B")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_OriginPos;

	[Token(Token = "0x400F14C")]
	[FieldOffset(Offset = "0x60")]
	private ResourceID m_BuildingCrossHairID;

	[Token(Token = "0x400F14D")]
	[FieldOffset(Offset = "0x64")]
	private bool m_StartCharge;

	[Token(Token = "0x400F14E")]
	[FieldOffset(Offset = "0x68")]
	private float m_ChargDuration;

	[Token(Token = "0x400F14F")]
	[FieldOffset(Offset = "0x6C")]
	private float m_WeaponMaxChargeTime;

	[Token(Token = "0x400F150")]
	[FieldOffset(Offset = "0x70")]
	private string m_IconAimSpriteName;

	[Token(Token = "0x400F151")]
	[FieldOffset(Offset = "0x74")]
	private string m_IconBanSpriteName;

	[Token(Token = "0x400F152")]
	[FieldOffset(Offset = "0x78")]
	private string m_AuoFlightSpriteName;

	[Token(Token = "0x400F153")]
	[FieldOffset(Offset = "0x7C")]
	private ResourceID m_CurrAimSpriteResId;

	[Token(Token = "0x400F154")]
	[FieldOffset(Offset = "0x80")]
	private uint m_HitHintDelayId;

	[Token(Token = "0x400F155")]
	[FieldOffset(Offset = "0x84")]
	private uint m_KillHintDelayId;

	[Token(Token = "0x400F156")]
	[FieldOffset(Offset = "0x88")]
	private uint m_FlashHintDelayId;

	[Token(Token = "0x400F157")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_ProtectHintDelayId;

	[Token(Token = "0x400F158")]
	[FieldOffset(Offset = "0x90")]
	private float m_LastOverlapPlayerCheckTime;

	[Token(Token = "0x400F159")]
	[FieldOffset(Offset = "0x94")]
	private FNCMBMMKLLI.IALJILGPBEL m_ObserverMode;

	[Token(Token = "0x400F15A")]
	[FieldOffset(Offset = "0x98")]
	private Queue<ScaleTweenSeq> m_QueueScaleTween;

	[Token(Token = "0x400F15B")]
	[FieldOffset(Offset = "0x9C")]
	private Queue<PositionTweenSeq> m_QueuePositionTween;

	[Token(Token = "0x400F15C")]
	[FieldOffset(Offset = "0xA0")]
	private Queue<RotationTweenSeq> m_QueueRotationTween;

	[Token(Token = "0x400F15D")]
	[FieldOffset(Offset = "0xA4")]
	private float m_LastIceWallChangedTime;

	[Token(Token = "0x170011B5")]
	public GameObject BuildingCrossHair
	{
		[Token(Token = "0x600EDA6")]
		[Address(RVA = "0x1369E38", Offset = "0x1369E38", VA = "0x1369E38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011B6")]
	public BoxCollider[] BuildingCrossHairColliders
	{
		[Token(Token = "0x600EDA7")]
		[Address(RVA = "0x1369E90", Offset = "0x1369E90", VA = "0x1369E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600EDA5")]
	[Address(RVA = "0x1369C3C", Offset = "0x1369C3C", VA = "0x1369C3C")]
	public UIHudCrosshairsController()
	{
	}

	[Token(Token = "0x600EDA8")]
	[Address(RVA = "0x1369EE8", Offset = "0x1369EE8", VA = "0x1369EE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EDA9")]
	[Address(RVA = "0x1369F8C", Offset = "0x1369F8C", VA = "0x1369F8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EDAA")]
	[Address(RVA = "0x136B180", Offset = "0x136B180", VA = "0x136B180", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EDAB")]
	[Address(RVA = "0x136BB78", Offset = "0x136BB78", VA = "0x136BB78")]
	private void FrameTick()
	{
	}

	[Token(Token = "0x600EDAC")]
	[Address(RVA = "0x1370144", Offset = "0x1370144", VA = "0x1370144")]
	private void Update()
	{
	}

	[Token(Token = "0x600EDAD")]
	[Address(RVA = "0x13701A4", Offset = "0x13701A4", VA = "0x13701A4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EDAE")]
	[Address(RVA = "0x136F7BC", Offset = "0x136F7BC", VA = "0x136F7BC")]
	private void UpdateScaleTween()
	{
	}

	[Token(Token = "0x600EDAF")]
	[Address(RVA = "0x136FADC", Offset = "0x136FADC", VA = "0x136FADC")]
	private void UpdatePositionTween()
	{
	}

	[Token(Token = "0x600EDB0")]
	[Address(RVA = "0x136FDEC", Offset = "0x136FDEC", VA = "0x136FDEC")]
	private void UpdateRotationTween()
	{
	}

	[Token(Token = "0x600EDB1")]
	[Address(RVA = "0x1370354", Offset = "0x1370354", VA = "0x1370354")]
	private void OnSightingStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600EDB2")]
	[Address(RVA = "0x137181C", Offset = "0x137181C", VA = "0x137181C")]
	private void OnChargeStateChange(object[] data)
	{
	}

	[Token(Token = "0x600EDB3")]
	[Address(RVA = "0x1371DF4", Offset = "0x1371DF4", VA = "0x1371DF4")]
	private void OnObserverSwitch(object[] data)
	{
	}

	[Token(Token = "0x600EDB4")]
	[Address(RVA = "0x1372180", Offset = "0x1372180", VA = "0x1372180")]
	private void OnSightingFired(object[] data)
	{
	}

	[Token(Token = "0x600EDB5")]
	[Address(RVA = "0x137251C", Offset = "0x137251C", VA = "0x137251C")]
	private void StartScaleTween(GameObject InObject, float InStartScale1, float InEndScale1, float InDuration1, float InEndScale2, float InDuration2)
	{
	}

	[Token(Token = "0x600EDB6")]
	[Address(RVA = "0x1371688", Offset = "0x1371688", VA = "0x1371688")]
	private void StartScaleTween(GameObject target, float startScale, float endScale, float duration)
	{
	}

	[Token(Token = "0x600EDB7")]
	[Address(RVA = "0x1372790", Offset = "0x1372790", VA = "0x1372790")]
	private void StartPositionTween(GameObject target, Vector3 startPosition, Vector3 endPosition, float duration)
	{
	}

	[Token(Token = "0x600EDB8")]
	[Address(RVA = "0x13729DC", Offset = "0x13729DC", VA = "0x13729DC")]
	private void StartRotaionTween(GameObject target, Vector3 startRotation, Vector3 endRotation, float duration)
	{
	}

	[Token(Token = "0x600EDB9")]
	[Address(RVA = "0x1372C14", Offset = "0x1372C14", VA = "0x1372C14")]
	private void TurnOffSighting()
	{
	}

	[Token(Token = "0x600EDBA")]
	[Address(RVA = "0x1372E70", Offset = "0x1372E70", VA = "0x1372E70")]
	private void OnInventoryOpened(object[] data)
	{
	}

	[Token(Token = "0x600EDBB")]
	[Address(RVA = "0x1372ED8", Offset = "0x1372ED8", VA = "0x1372ED8")]
	private void OnInventoryTryUseMedkit(object[] data)
	{
	}

	[Token(Token = "0x600EDBC")]
	[Address(RVA = "0x1372F40", Offset = "0x1372F40", VA = "0x1372F40")]
	private void OnInventoryTryUseRepairKit(object[] data)
	{
	}

	[Token(Token = "0x600EDBD")]
	[Address(RVA = "0x1372FA8", Offset = "0x1372FA8", VA = "0x1372FA8")]
	private void OnLeaderboardOpened(object[] data)
	{
	}

	[Token(Token = "0x600EDBE")]
	[Address(RVA = "0x1373010", Offset = "0x1373010", VA = "0x1373010")]
	private void OnFastRunningActivated(object[] data)
	{
	}

	[Token(Token = "0x600EDBF")]
	[Address(RVA = "0x1373078", Offset = "0x1373078", VA = "0x1373078")]
	private void OnLocalPlayerAutoFlightHit(object[] data)
	{
	}

	[Token(Token = "0x600EDC0")]
	[Address(RVA = "0x1373390", Offset = "0x1373390", VA = "0x1373390")]
	private void OnLocalPlayerHitOthers(object[] data)
	{
	}

	[Token(Token = "0x600EDC1")]
	[Address(RVA = "0x1373A74", Offset = "0x1373A74", VA = "0x1373A74")]
	private void OnFlashHitEnemy(object[] data)
	{
	}

	[Token(Token = "0x600EDC2")]
	[Address(RVA = "0x13738C8", Offset = "0x13738C8", VA = "0x13738C8")]
	private void ShowFlashHint()
	{
	}

	[Token(Token = "0x600EDC3")]
	[Address(RVA = "0x1373ADC", Offset = "0x1373ADC", VA = "0x1373ADC")]
	private void OnLocalPlayerKillOthers(object[] data)
	{
	}

	[Token(Token = "0x600EDC4")]
	[Address(RVA = "0x1373DE8", Offset = "0x1373DE8", VA = "0x1373DE8")]
	private IEnumerator PlayHitEffect()
	{
		return null;
	}

	[Token(Token = "0x600EDC5")]
	[Address(RVA = "0x1373EBC", Offset = "0x1373EBC", VA = "0x1373EBC")]
	private void OnUpdateAimTraceClosePos(object[] data)
	{
	}

	[Token(Token = "0x600EDC6")]
	[Address(RVA = "0x1374208", Offset = "0x1374208", VA = "0x1374208")]
	private void OnIceWallCrossHairChange(object[] data)
	{
	}

	[Token(Token = "0x600EDC7")]
	[Address(RVA = "0x1374904", Offset = "0x1374904", VA = "0x1374904")]
	private void OnCustomCrossHairChange(object[] data)
	{
	}

	[Token(Token = "0x600EDC8")]
	[Address(RVA = "0x1374C6C", Offset = "0x1374C6C", VA = "0x1374C6C")]
	private void OnRedEnvelopeCrossHairChange(object[] data)
	{
	}

	[Token(Token = "0x600EDC9")]
	[Address(RVA = "0x137509C", Offset = "0x137509C", VA = "0x137509C")]
	private void OnMatchEnd(object[] data)
	{
	}

	[Token(Token = "0x600EDCA")]
	[Address(RVA = "0x1375248", Offset = "0x1375248", VA = "0x1375248")]
	private void OnShowFireBanned(object[] data)
	{
	}

	[Token(Token = "0x600EDCB")]
	[Address(RVA = "0x1375368", Offset = "0x1375368", VA = "0x1375368")]
	private void OnShieldGunShieldHide(object[] data)
	{
	}

	[Token(Token = "0x600EDCC")]
	[Address(RVA = "0x1375604", Offset = "0x1375604", VA = "0x1375604")]
	private IEnumerator ShieldGunShieldBrokenHide()
	{
		return null;
	}

	[Token(Token = "0x600EDCD")]
	[Address(RVA = "0x13756D8", Offset = "0x13756D8", VA = "0x13756D8")]
	private void OnReplayObserverModeChange(object[] data)
	{
	}

	[Token(Token = "0x600EDCF")]
	[Address(RVA = "0x13759CC", Offset = "0x13759CC", VA = "0x13759CC")]
	private void _003COnLocalPlayerAutoFlightHit_003Em__0()
	{
	}

	[Token(Token = "0x600EDD0")]
	[Address(RVA = "0x1375A1C", Offset = "0x1375A1C", VA = "0x1375A1C")]
	private void _003COnLocalPlayerHitOthers_003Em__1()
	{
	}

	[Token(Token = "0x600EDD1")]
	[Address(RVA = "0x1375A6C", Offset = "0x1375A6C", VA = "0x1375A6C")]
	private void _003COnLocalPlayerHitOthers_003Em__2()
	{
	}

	[Token(Token = "0x600EDD2")]
	[Address(RVA = "0x1375B18", Offset = "0x1375B18", VA = "0x1375B18")]
	private void _003CShowFlashHint_003Em__3()
	{
	}

	[Token(Token = "0x600EDD3")]
	[Address(RVA = "0x1375BC4", Offset = "0x1375BC4", VA = "0x1375BC4")]
	private void _003COnLocalPlayerKillOthers_003Em__4()
	{
	}

	[Token(Token = "0x600EDD4")]
	[Address(RVA = "0x1375C14", Offset = "0x1375C14", VA = "0x1375C14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EDD5")]
	[Address(RVA = "0x1375C1C", Offset = "0x1375C1C", VA = "0x1375C1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EDD6")]
	[Address(RVA = "0x1375C24", Offset = "0x1375C24", VA = "0x1375C24")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
