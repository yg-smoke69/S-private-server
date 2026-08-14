using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024FB")]
internal class UIBigMapController : UIMapBaseController
{
	[Token(Token = "0x20024FC")]
	private sealed class _003COnSceneEditRemoveObj_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E5AD")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x600D60C")]
		[Address(RVA = "0x10CFF94", Offset = "0x10CFF94", VA = "0x10CFF94")]
		public _003COnSceneEditRemoveObj_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D60D")]
		[Address(RVA = "0x10D0B4C", Offset = "0x10D0B4C", VA = "0x10D0B4C")]
		internal bool _003C_003Em__0(SceneEditMapIconItemDesc i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E58C")]
	[FieldOffset(Offset = "0x2C")]
	private UIBigMapViewExt m_View;

	[Token(Token = "0x400E58D")]
	[FieldOffset(Offset = "0x30")]
	private Player m_Player;

	[Token(Token = "0x400E58E")]
	[FieldOffset(Offset = "0x34")]
	private AudioResource m_ReviveCountDownAudio;

	[Token(Token = "0x400E58F")]
	[FieldOffset(Offset = "0x38")]
	public float SIZE_BIGMAP_X;

	[Token(Token = "0x400E590")]
	[FieldOffset(Offset = "0x3C")]
	public float SIZE_BIGMAP_Y;

	[Token(Token = "0x400E591")]
	[FieldOffset(Offset = "0x40")]
	private float ScreenHeight;

	[Token(Token = "0x400E592")]
	[FieldOffset(Offset = "0x44")]
	private float ScreenWidth;

	[Token(Token = "0x400E593")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 m_MapCenterScreenPosition;

	[Token(Token = "0x400E594")]
	private const float MAX_MAP_SCALE = 4f;

	[Token(Token = "0x400E595")]
	[FieldOffset(Offset = "0x50")]
	private float m_MaxMapScale;

	[Token(Token = "0x400E596")]
	[FieldOffset(Offset = "0x54")]
	public float WheelSensitivity;

	[Token(Token = "0x400E597")]
	[FieldOffset(Offset = "0x58")]
	public Camera Camera;

	[Token(Token = "0x400E598")]
	[FieldOffset(Offset = "0x5C")]
	public float Target;

	[Token(Token = "0x400E599")]
	[FieldOffset(Offset = "0x60")]
	public float Minimum;

	[Token(Token = "0x400E59A")]
	[FieldOffset(Offset = "0x64")]
	public float Maximum;

	[Token(Token = "0x400E59B")]
	[FieldOffset(Offset = "0x68")]
	public float Dampening;

	[Token(Token = "0x400E59C")]
	[FieldOffset(Offset = "0x6C")]
	private List<Vector3> m_MapMarkList;

	[Token(Token = "0x400E59D")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 m_LastTouchPos;

	[Token(Token = "0x400E59E")]
	[FieldOffset(Offset = "0x78")]
	private EBigMapType m_MapType;

	[Token(Token = "0x400E59F")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_ShowedHotzoneHint;

	[Token(Token = "0x400E5A0")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IsCatapultIconInited;

	[Token(Token = "0x400E5A1")]
	[FieldOffset(Offset = "0x7E")]
	private bool DEBUG_CATAPULT_ON;

	[Token(Token = "0x400E5A2")]
	[FieldOffset(Offset = "0x80")]
	private UIHudPopupController m_HotzoneHintCtrl;

	[Token(Token = "0x400E5A3")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 m_OrignalRebornMapEffectScale;

	[Token(Token = "0x400E5A4")]
	[FieldOffset(Offset = "0x90")]
	private bool mShowIconToggleBtn;

	[Token(Token = "0x400E5A5")]
	[FieldOffset(Offset = "0x94")]
	private Color mToggleIconBgColorOn;

	[Token(Token = "0x400E5A6")]
	[FieldOffset(Offset = "0xA4")]
	private Color mToggleIconBgColorOff;

	[Token(Token = "0x400E5A7")]
	[FieldOffset(Offset = "0xB4")]
	private float mRevivePointEndTime;

	[Token(Token = "0x400E5A8")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<uint, uint> m_WSMapIconCntMap;

	[Token(Token = "0x400E5A9")]
	[FieldOffset(Offset = "0xBC")]
	private List<SceneEditMapIconItemDesc> m_WSMapIconItemLst;

	[Token(Token = "0x400E5AA")]
	[FieldOffset(Offset = "0xC0")]
	private Queue<SceneEditMapIconItemDesc> m_WorskShopItemDescCache;

	[Token(Token = "0x400E5AB")]
	[FieldOffset(Offset = "0xC4")]
	private int lastReviveTime;

	[Token(Token = "0x400E5AC")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<SceneEditMapIconItemDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D5C0")]
	[Address(RVA = "0x10C34F0", Offset = "0x10C34F0", VA = "0x10C34F0")]
	public UIBigMapController()
	{
	}

	[Token(Token = "0x600D5C1")]
	[Address(RVA = "0x10C3764", Offset = "0x10C3764", VA = "0x10C3764")]
	public List<Vector3> getMapMarks()
	{
		return null;
	}

	[Token(Token = "0x600D5C2")]
	[Address(RVA = "0x10C37BC", Offset = "0x10C37BC", VA = "0x10C37BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D5C3")]
	[Address(RVA = "0x10C3860", Offset = "0x10C3860", VA = "0x10C3860", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D5C4")]
	[Address(RVA = "0x10C50B4", Offset = "0x10C50B4", VA = "0x10C50B4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D5C5")]
	[Address(RVA = "0x10C4A04", Offset = "0x10C4A04", VA = "0x10C4A04")]
	private void InitUIParams()
	{
	}

	[Token(Token = "0x600D5C6")]
	[Address(RVA = "0x10C4AF4", Offset = "0x10C4AF4", VA = "0x10C4AF4")]
	private void InitUIElements()
	{
	}

	[Token(Token = "0x600D5C7")]
	[Address(RVA = "0x10C5C30", Offset = "0x10C5C30", VA = "0x10C5C30", Slot = "31")]
	protected override void RegisterEvents()
	{
	}

	[Token(Token = "0x600D5C8")]
	[Address(RVA = "0x10C63E0", Offset = "0x10C63E0", VA = "0x10C63E0")]
	private void OnFateRandomStartFight(object[] data)
	{
	}

	[Token(Token = "0x600D5C9")]
	[Address(RVA = "0x10C68A8", Offset = "0x10C68A8", VA = "0x10C68A8")]
	private void ShowFateRandomTeamZone(object[] data)
	{
	}

	[Token(Token = "0x600D5CA")]
	[Address(RVA = "0x10C6940", Offset = "0x10C6940", VA = "0x10C6940", Slot = "32")]
	protected override void UnRegisterEvents()
	{
	}

	[Token(Token = "0x600D5CB")]
	[Address(RVA = "0x10C5788", Offset = "0x10C5788", VA = "0x10C5788")]
	private void ShowRankingGameTips()
	{
	}

	[Token(Token = "0x600D5CC")]
	[Address(RVA = "0x10C7024", Offset = "0x10C7024", VA = "0x10C7024")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600D5CD")]
	[Address(RVA = "0x10C6498", Offset = "0x10C6498", VA = "0x10C6498")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600D5CE")]
	[Address(RVA = "0x10C70AC", Offset = "0x10C70AC", VA = "0x10C70AC", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D5CF")]
	[Address(RVA = "0x10C784C", Offset = "0x10C784C", VA = "0x10C784C")]
	private void OnBtnRevive()
	{
	}

	[Token(Token = "0x600D5D0")]
	[Address(RVA = "0x10C80A8", Offset = "0x10C80A8", VA = "0x10C80A8")]
	private void OnBtnQuitRevive()
	{
	}

	[Token(Token = "0x600D5D1")]
	[Address(RVA = "0x10C7C74", Offset = "0x10C7C74", VA = "0x10C7C74")]
	private bool IsOutsideSafeZone(Vector3 pos, bool project)
	{
		return default(bool);
	}

	[Token(Token = "0x600D5D2")]
	[Address(RVA = "0x10C7E9C", Offset = "0x10C7E9C", VA = "0x10C7E9C")]
	private void WarnInvalidRevivePos()
	{
	}

	[Token(Token = "0x600D5D3")]
	[Address(RVA = "0x10C822C", Offset = "0x10C822C", VA = "0x10C822C")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x600D5D4")]
	[Address(RVA = "0x10C529C", Offset = "0x10C529C", VA = "0x10C529C")]
	private void StopReviveCoundDownSound()
	{
	}

	[Token(Token = "0x600D5D5")]
	[Address(RVA = "0x10C8524", Offset = "0x10C8524", VA = "0x10C8524", Slot = "36")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600D5D6")]
	[Address(RVA = "0x10C89D8", Offset = "0x10C89D8", VA = "0x10C89D8", Slot = "37")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600D5D7")]
	[Address(RVA = "0x10C8F14", Offset = "0x10C8F14", VA = "0x10C8F14")]
	private void OnAddLocalPlayer(object[] param)
	{
	}

	[Token(Token = "0x600D5D8")]
	[Address(RVA = "0x10C8FE8", Offset = "0x10C8FE8", VA = "0x10C8FE8")]
	public bool AddMarkOnMap(LeanFinger finger, bool checkWithinSafeZone)
	{
		return default(bool);
	}

	[Token(Token = "0x600D5D9")]
	[Address(RVA = "0x10C9608", Offset = "0x10C9608", VA = "0x10C9608")]
	private void UpdateLocalMark(Vector3 p, uint posType)
	{
	}

	[Token(Token = "0x600D5DA")]
	[Address(RVA = "0x10C9C4C", Offset = "0x10C9C4C", VA = "0x10C9C4C")]
	private void UpdateLocalAssistMark(Vector3 p, uint posType)
	{
	}

	[Token(Token = "0x600D5DB")]
	[Address(RVA = "0x10C9E7C", Offset = "0x10C9E7C", VA = "0x10C9E7C")]
	private void OnAssistantMarkRemoved(object[] data)
	{
	}

	[Token(Token = "0x600D5DC")]
	[Address(RVA = "0x10CA160", Offset = "0x10CA160", VA = "0x10CA160")]
	private void OnAddLocalAssistantMark(object[] data)
	{
	}

	[Token(Token = "0x600D5DD")]
	[Address(RVA = "0x10CA7F8", Offset = "0x10CA7F8", VA = "0x10CA7F8")]
	public void RemoveMarkOnMap()
	{
	}

	[Token(Token = "0x600D5DE")]
	[Address(RVA = "0x10CAAF4", Offset = "0x10CAAF4", VA = "0x10CAAF4", Slot = "35")]
	protected override void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600D5DF")]
	[Address(RVA = "0x10CAB78", Offset = "0x10CAB78", VA = "0x10CAB78")]
	public void SyncTeammateMapMark(object[] data)
	{
	}

	[Token(Token = "0x600D5E0")]
	[Address(RVA = "0x10C9898", Offset = "0x10C9898", VA = "0x10C9898")]
	private void ShowAssistantMarkForMapMark(Player targetPlayer, short posX, short posY, uint posType = 0u)
	{
	}

	[Token(Token = "0x600D5E1")]
	[Address(RVA = "0x10CA990", Offset = "0x10CA990", VA = "0x10CA990")]
	private void RemoveAssistantMarkForMapMark(Player targetPlayer)
	{
	}

	[Token(Token = "0x600D5E2")]
	[Address(RVA = "0x10CAFA4", Offset = "0x10CAFA4", VA = "0x10CAFA4")]
	private void OnTeamInfoGet(object[] data)
	{
	}

	[Token(Token = "0x600D5E3")]
	[Address(RVA = "0x10CB784", Offset = "0x10CB784", VA = "0x10CB784")]
	private void SyncTeamateState(object[] data)
	{
	}

	[Token(Token = "0x600D5E4")]
	[Address(RVA = "0x10CB808", Offset = "0x10CB808", VA = "0x10CB808")]
	private void SendMapMarkChanged(Vector2 screenPos, bool isDel)
	{
	}

	[Token(Token = "0x600D5E5")]
	[Address(RVA = "0x10CA2BC", Offset = "0x10CA2BC", VA = "0x10CA2BC")]
	private void SendMapMarkChanged(Vector3 localPos, uint posType)
	{
	}

	[Token(Token = "0x600D5E6")]
	[Address(RVA = "0x10CBF54", Offset = "0x10CBF54", VA = "0x10CBF54")]
	public void OnTap(LeanFinger finger)
	{
	}

	[Token(Token = "0x600D5E7")]
	[Address(RVA = "0x10CC580", Offset = "0x10CC580", VA = "0x10CC580")]
	public void OnGesture(List<LeanFinger> fingers)
	{
	}

	[Token(Token = "0x600D5E8")]
	[Address(RVA = "0x10CC9C8", Offset = "0x10CC9C8", VA = "0x10CC9C8")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x600D5E9")]
	[Address(RVA = "0x10CCBA8", Offset = "0x10CCBA8", VA = "0x10CCBA8")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x600D5EA")]
	[Address(RVA = "0x10CCC6C", Offset = "0x10CCC6C", VA = "0x10CCC6C")]
	private void OnEnableBigMap(object[] param)
	{
	}

	[Token(Token = "0x600D5EB")]
	[Address(RVA = "0x10C53BC", Offset = "0x10C53BC", VA = "0x10C53BC")]
	private void UpdateUIForMapMode()
	{
	}

	[Token(Token = "0x600D5EC")]
	[Address(RVA = "0x10CD8D4", Offset = "0x10CD8D4", VA = "0x10CD8D4")]
	private List<LGCOKIBHIJL> GetUsingWeaponsList(List<int> unUsedList)
	{
		return null;
	}

	[Token(Token = "0x600D5ED")]
	[Address(RVA = "0x10CDD0C", Offset = "0x10CDD0C", VA = "0x10CDD0C")]
	private void UpdateUIForCurrentAttachments(object[] param)
	{
	}

	[Token(Token = "0x600D5EE")]
	[Address(RVA = "0x10C91C0", Offset = "0x10C91C0", VA = "0x10C91C0")]
	private bool IsMapTouched(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600D5EF")]
	[Address(RVA = "0x10C92A8", Offset = "0x10C92A8", VA = "0x10C92A8")]
	private Vector3 ScreenToLocalPosition(Vector2 pos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600D5F0")]
	[Address(RVA = "0x10CE2B8", Offset = "0x10CE2B8", VA = "0x10CE2B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600D5F1")]
	[Address(RVA = "0x10CE52C", Offset = "0x10CE52C", VA = "0x10CE52C")]
	private void UpdateRevivePointLeftTime(int leftTime)
	{
	}

	[Token(Token = "0x600D5F2")]
	[Address(RVA = "0x10CE6BC", Offset = "0x10CE6BC", VA = "0x10CE6BC")]
	private void UpdateHPEP()
	{
	}

	[Token(Token = "0x600D5F3")]
	[Address(RVA = "0x10CEC0C", Offset = "0x10CEC0C", VA = "0x10CEC0C", Slot = "33")]
	protected override void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x600D5F4")]
	[Address(RVA = "0x10CEE00", Offset = "0x10CEE00", VA = "0x10CEE00")]
	private void OnJumpActionEnter(object[] data)
	{
	}

	[Token(Token = "0x600D5F5")]
	[Address(RVA = "0x10CEF60", Offset = "0x10CEF60", VA = "0x10CEF60")]
	private void OnJumpActionEnd(object[] data)
	{
	}

	[Token(Token = "0x600D5F6")]
	[Address(RVA = "0x10CEFF8", Offset = "0x10CEFF8", VA = "0x10CEFF8")]
	private void OnMatchEnd(object[] data)
	{
	}

	[Token(Token = "0x600D5F7")]
	[Address(RVA = "0x10CF0FC", Offset = "0x10CF0FC", VA = "0x10CF0FC")]
	private void OnShowIconToggle(object[] data)
	{
	}

	[Token(Token = "0x600D5F8")]
	[Address(RVA = "0x10CF2F0", Offset = "0x10CF2F0", VA = "0x10CF2F0")]
	private void OnRevivePointEndTimeRefresh(object[] data)
	{
	}

	[Token(Token = "0x600D5F9")]
	[Address(RVA = "0x10CF41C", Offset = "0x10CF41C", VA = "0x10CF41C")]
	private void OnSceneEditUpdateBigMapIconDesc(object[] data)
	{
	}

	[Token(Token = "0x600D5FA")]
	[Address(RVA = "0x10CF550", Offset = "0x10CF550", VA = "0x10CF550")]
	private void OnSceneEditAddObj(uint itemID)
	{
	}

	[Token(Token = "0x600D5FB")]
	[Address(RVA = "0x10CF974", Offset = "0x10CF974", VA = "0x10CF974")]
	private void OnSceneEditRemoveObj(uint itemID)
	{
	}

	[Token(Token = "0x600D5FC")]
	[Address(RVA = "0x10CFCE4", Offset = "0x10CFCE4", VA = "0x10CFCE4")]
	private void SortSceneEditItemIconDesc()
	{
	}

	[Token(Token = "0x600D5FD")]
	[Address(RVA = "0x10CFF9C", Offset = "0x10CFF9C", VA = "0x10CFF9C")]
	private void OnWorkShopSceneRefresh(object[] data)
	{
	}

	[Token(Token = "0x600D5FE")]
	[Address(RVA = "0x10D0234", Offset = "0x10D0234", VA = "0x10D0234")]
	private void OnBtnToggleShopIcon()
	{
	}

	[Token(Token = "0x600D5FF")]
	[Address(RVA = "0x10D0480", Offset = "0x10D0480", VA = "0x10D0480")]
	private void OnBtnToggleRevivePointIcon()
	{
	}

	[Token(Token = "0x600D600")]
	[Address(RVA = "0x10D06CC", Offset = "0x10D06CC", VA = "0x10D06CC")]
	public void ActiveWereWolvesTip(bool isWolf)
	{
	}

	[Token(Token = "0x600D601")]
	[Address(RVA = "0x10D079C", Offset = "0x10D079C", VA = "0x10D079C")]
	private void OnGameMissionStart(object[] data)
	{
	}

	[Token(Token = "0x600D602")]
	[Address(RVA = "0x10D0A0C", Offset = "0x10D0A0C", VA = "0x10D0A0C")]
	private void _003COnUIInit_003Em__0(GameObject go, bool v)
	{
	}

	[Token(Token = "0x600D603")]
	[Address(RVA = "0x10D0A74", Offset = "0x10D0A74", VA = "0x10D0A74")]
	private void _003COnVisibilityChanged_003Em__1()
	{
	}

	[Token(Token = "0x600D604")]
	[Address(RVA = "0x10D0AAC", Offset = "0x10D0AAC", VA = "0x10D0AAC")]
	private static int _003CSortSceneEditItemIconDesc_003Em__2(SceneEditMapIconItemDesc a, SceneEditMapIconItemDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x600D605")]
	[Address(RVA = "0x10D0B14", Offset = "0x10D0B14", VA = "0x10D0B14")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D606")]
	[Address(RVA = "0x10D0B1C", Offset = "0x10D0B1C", VA = "0x10D0B1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D607")]
	[Address(RVA = "0x10D0B24", Offset = "0x10D0B24", VA = "0x10D0B24")]
	public void _003C_003EiFixBaseProxy_RegisterEvents()
	{
	}

	[Token(Token = "0x600D608")]
	[Address(RVA = "0x10D0B2C", Offset = "0x10D0B2C", VA = "0x10D0B2C")]
	public void _003C_003EiFixBaseProxy_UnRegisterEvents()
	{
	}

	[Token(Token = "0x600D609")]
	[Address(RVA = "0x10D0B34", Offset = "0x10D0B34", VA = "0x10D0B34")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D60A")]
	[Address(RVA = "0x10D0B3C", Offset = "0x10D0B3C", VA = "0x10D0B3C")]
	public void _003C_003EiFixBaseProxy_OnPlayerHPChanged(object[] P0)
	{
	}

	[Token(Token = "0x600D60B")]
	[Address(RVA = "0x10D0B44", Offset = "0x10D0B44", VA = "0x10D0B44")]
	public void _003C_003EiFixBaseProxy_OnObservePlayer(object[] P0)
	{
	}
}
