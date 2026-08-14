using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002817")]
internal class UIHudQuickUseMedkitController : UIBaseController
{
	[Token(Token = "0x2002818")]
	private enum EQuickUseType
	{
		[Token(Token = "0x400F796")]
		Medkit,
		[Token(Token = "0x400F797")]
		Inhaler,
		[Token(Token = "0x400F798")]
		SuperMedkit
	}

	[Token(Token = "0x400F77B")]
	[FieldOffset(Offset = "0x0")]
	public static float MedkitMaxDragDis;

	[Token(Token = "0x400F77C")]
	[FieldOffset(Offset = "0x4")]
	private static float MedkitMaxDragDisSquare;

	[Token(Token = "0x400F77D")]
	[FieldOffset(Offset = "0x8")]
	private static float MedkitQuickDragDis;

	[Token(Token = "0x400F77E")]
	[FieldOffset(Offset = "0xC")]
	private static float MedkitQuickDragDisSquare;

	[Token(Token = "0x400F77F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudQuickUseMedkitView m_View;

	[Token(Token = "0x400F780")]
	[FieldOffset(Offset = "0x2C")]
	private float m_StartTime;

	[Token(Token = "0x400F781")]
	[FieldOffset(Offset = "0x30")]
	private float m_TotalTime;

	[Token(Token = "0x400F782")]
	[FieldOffset(Offset = "0x34")]
	private int m_MedkitCount;

	[Token(Token = "0x400F783")]
	[FieldOffset(Offset = "0x38")]
	private int m_InhalerCount;

	[Token(Token = "0x400F784")]
	[FieldOffset(Offset = "0x3C")]
	private Player m_LocalPlayer;

	[Token(Token = "0x400F785")]
	[FieldOffset(Offset = "0x40")]
	private bool isPlayerWalking;

	[Token(Token = "0x400F786")]
	[FieldOffset(Offset = "0x44")]
	private EQuickUseType showType;

	[Token(Token = "0x400F787")]
	private const string MEDKIT_ICON_SPRITENAME = "UI_icon_FirstAidKit";

	[Token(Token = "0x400F788")]
	private const string INHALER_ICON_SPRITENAME = "Icon_HUD_Gold_INHALER_Attachment";

	[Token(Token = "0x400F789")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsPressed;

	[Token(Token = "0x400F78A")]
	[FieldOffset(Offset = "0x4C")]
	private float m_PressTime;

	[Token(Token = "0x400F78B")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_MedkitBtnOriginalPos;

	[Token(Token = "0x400F78C")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_MedkitBtnStartPos;

	[Token(Token = "0x400F78D")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_CurDirection;

	[Token(Token = "0x400F78E")]
	[FieldOffset(Offset = "0x74")]
	private Camera m_Camera;

	[Token(Token = "0x400F78F")]
	[FieldOffset(Offset = "0x78")]
	private bool m_GlobalTouchEnd;

	[Token(Token = "0x400F790")]
	[FieldOffset(Offset = "0x7C")]
	private Color m_SelectedColor;

	[Token(Token = "0x400F791")]
	[FieldOffset(Offset = "0x8C")]
	private List<GameObject> m_CircleList;

	[Token(Token = "0x400F792")]
	[FieldOffset(Offset = "0x90")]
	private List<CureGearSettingData> m_GearSettingData;

	[Token(Token = "0x400F793")]
	[FieldOffset(Offset = "0x94")]
	private List<CureGearSettingData> m_EnumGearSettingData;

	[Token(Token = "0x400F794")]
	[FieldOffset(Offset = "0x98")]
	private uint m_ChangeToSuperMedkitDelayCall;

	[Token(Token = "0x170011EF")]
	private bool CanDriverUseMedkit
	{
		[Token(Token = "0x600F99E")]
		[Address(RVA = "0x1FCC2E4", Offset = "0x1FCC2E4", VA = "0x1FCC2E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600F99A")]
	[Address(RVA = "0x1FCAF58", Offset = "0x1FCAF58", VA = "0x1FCAF58")]
	public UIHudQuickUseMedkitController()
	{
	}

	[Token(Token = "0x600F99B")]
	[Address(RVA = "0x1FCB0A8", Offset = "0x1FCB0A8", VA = "0x1FCB0A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F99C")]
	[Address(RVA = "0x1FCB14C", Offset = "0x1FCB14C", VA = "0x1FCB14C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F99D")]
	[Address(RVA = "0x1FCBCF0", Offset = "0x1FCBCF0", VA = "0x1FCBCF0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F99F")]
	[Address(RVA = "0x1FCC3DC", Offset = "0x1FCC3DC", VA = "0x1FCC3DC")]
	private void OnRouletteUseMedkit(object[] data)
	{
	}

	[Token(Token = "0x600F9A0")]
	[Address(RVA = "0x1FCD09C", Offset = "0x1FCD09C", VA = "0x1FCD09C")]
	private void OnBtnQuickUse()
	{
	}

	[Token(Token = "0x600F9A1")]
	[Address(RVA = "0x1FCC4D0", Offset = "0x1FCC4D0", VA = "0x1FCC4D0")]
	private void OnBtnQuickUseInside(uint itemUniqueID, uint moveStatus)
	{
	}

	[Token(Token = "0x600F9A2")]
	[Address(RVA = "0x1FCD104", Offset = "0x1FCD104", VA = "0x1FCD104")]
	private void OnShowedEffect(object[] param)
	{
	}

	[Token(Token = "0x600F9A3")]
	[Address(RVA = "0x1FCD318", Offset = "0x1FCD318", VA = "0x1FCD318")]
	private void OnInventoryMedkitChanged(object[] param)
	{
	}

	[Token(Token = "0x600F9A4")]
	[Address(RVA = "0x1FCE440", Offset = "0x1FCE440", VA = "0x1FCE440")]
	private void OnInventoryInhalerChanged(object[] param)
	{
	}

	[Token(Token = "0x600F9A5")]
	[Address(RVA = "0x1FCE564", Offset = "0x1FCE564", VA = "0x1FCE564")]
	private void OnInventoryPickup(object[] param)
	{
	}

	[Token(Token = "0x600F9A6")]
	[Address(RVA = "0x1FCE774", Offset = "0x1FCE774", VA = "0x1FCE774", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F9A7")]
	[Address(RVA = "0x1FCEB74", Offset = "0x1FCEB74", VA = "0x1FCEB74")]
	private void Update()
	{
	}

	[Token(Token = "0x600F9A8")]
	[Address(RVA = "0x1FD0184", Offset = "0x1FD0184", VA = "0x1FD0184")]
	private void OnLocalPlayerPhysicsStateChange(object[] data)
	{
	}

	[Token(Token = "0x600F9A9")]
	[Address(RVA = "0x1FD01EC", Offset = "0x1FD01EC", VA = "0x1FD01EC")]
	private bool CheckToShowUse(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600F9AA")]
	[Address(RVA = "0x1FD0598", Offset = "0x1FD0598", VA = "0x1FD0598")]
	private void OnPlayerTryUseItem(object[] param)
	{
	}

	[Token(Token = "0x600F9AB")]
	[Address(RVA = "0x1FD09CC", Offset = "0x1FD09CC", VA = "0x1FD09CC")]
	private void OnPlayerCancelUseItem(object[] param)
	{
	}

	[Token(Token = "0x600F9AC")]
	[Address(RVA = "0x1FD0C5C", Offset = "0x1FD0C5C", VA = "0x1FD0C5C")]
	private void OnHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F9AD")]
	[Address(RVA = "0x1FD0E88", Offset = "0x1FD0E88", VA = "0x1FD0E88")]
	private void ShowMedkitTutorial(object[] data)
	{
	}

	[Token(Token = "0x600F9AE")]
	[Address(RVA = "0x1FD0FE4", Offset = "0x1FD0FE4", VA = "0x1FD0FE4")]
	private void ShowMedkitTutorialInForceTutorialGame(object[] data)
	{
	}

	[Token(Token = "0x600F9AF")]
	[Address(RVA = "0x1FD1140", Offset = "0x1FD1140", VA = "0x1FD1140")]
	private void ShowMedkitDontMoveTutorialInForceTutorialGame(object[] data)
	{
	}

	[Token(Token = "0x600F9B0")]
	[Address(RVA = "0x1FD129C", Offset = "0x1FD129C", VA = "0x1FD129C")]
	private void OnGetOnVehicle(object[] param)
	{
	}

	[Token(Token = "0x600F9B1")]
	[Address(RVA = "0x1FD1488", Offset = "0x1FD1488", VA = "0x1FD1488")]
	private void OnGetOffVehicle(object[] param)
	{
	}

	[Token(Token = "0x600F9B2")]
	[Address(RVA = "0x1FCE9D0", Offset = "0x1FCE9D0", VA = "0x1FCE9D0")]
	private void UpdateIconStatus(Player p)
	{
	}

	[Token(Token = "0x600F9B3")]
	[Address(RVA = "0x1FCDF24", Offset = "0x1FCDF24", VA = "0x1FCDF24")]
	private void UpdateUrgencyEffect()
	{
	}

	[Token(Token = "0x600F9B4")]
	[Address(RVA = "0x1FD1674", Offset = "0x1FD1674", VA = "0x1FD1674")]
	private void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600F9B5")]
	[Address(RVA = "0x1FCD444", Offset = "0x1FCD444", VA = "0x1FCD444")]
	private void RefreshQuickUseIconShow()
	{
	}

	[Token(Token = "0x600F9B6")]
	[Address(RVA = "0x1FD1774", Offset = "0x1FD1774", VA = "0x1FD1774")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600F9B7")]
	[Address(RVA = "0x1FCE2EC", Offset = "0x1FCE2EC", VA = "0x1FCE2EC")]
	private void ShowRouletteGuide()
	{
	}

	[Token(Token = "0x600F9B8")]
	[Address(RVA = "0x1FCDF78", Offset = "0x1FCDF78", VA = "0x1FCDF78")]
	private void RefreshMedkitItemList(object[] data)
	{
	}

	[Token(Token = "0x600F9B9")]
	[Address(RVA = "0x1FD1B00", Offset = "0x1FD1B00", VA = "0x1FD1B00")]
	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	[Token(Token = "0x600F9BA")]
	[Address(RVA = "0x1FCEFD0", Offset = "0x1FCEFD0", VA = "0x1FCEFD0")]
	private void UpdateRolette()
	{
	}

	[Token(Token = "0x600F9BC")]
	[Address(RVA = "0x1FD1C88", Offset = "0x1FD1C88", VA = "0x1FD1C88")]
	private void _003CRefreshQuickUseIconShow_003Em__0()
	{
	}

	[Token(Token = "0x600F9BD")]
	[Address(RVA = "0x1FD1C94", Offset = "0x1FD1C94", VA = "0x1FD1C94")]
	private void _003CRefreshQuickUseIconShow_003Em__1()
	{
	}

	[Token(Token = "0x600F9BE")]
	[Address(RVA = "0x1FD1CA0", Offset = "0x1FD1CA0", VA = "0x1FD1CA0")]
	private void _003CRefreshQuickUseIconShow_003Em__2()
	{
	}

	[Token(Token = "0x600F9BF")]
	[Address(RVA = "0x1FD1CAC", Offset = "0x1FD1CAC", VA = "0x1FD1CAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F9C0")]
	[Address(RVA = "0x1FD1CB4", Offset = "0x1FD1CB4", VA = "0x1FD1CB4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F9C1")]
	[Address(RVA = "0x1FD1CBC", Offset = "0x1FD1CBC", VA = "0x1FD1CBC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
