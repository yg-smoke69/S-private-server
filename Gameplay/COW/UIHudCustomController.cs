using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002720")]
public class UIHudCustomController : UIPopupWindowController
{
	[Token(Token = "0x2002721")]
	private enum TweenHeightType
	{
		[Token(Token = "0x400F1A1")]
		None,
		[Token(Token = "0x400F1A2")]
		ExpandAdjust
	}

	[Token(Token = "0x2002722")]
	private enum GrenadeSlot
	{
		[Token(Token = "0x400F1A4")]
		One,
		[Token(Token = "0x400F1A5")]
		Two
	}

	[Token(Token = "0x2002723")]
	private sealed class _003CCheckEnableHidden_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F1A6")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x600EE1C")]
		[Address(RVA = "0x1CC6C80", Offset = "0x1CC6C80", VA = "0x1CC6C80")]
		public _003CCheckEnableHidden_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EE1D")]
		[Address(RVA = "0x1CC6C88", Offset = "0x1CC6C88", VA = "0x1CC6C88")]
		internal bool _003C_003Em__0(string item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002724")]
	private sealed class _003COnCaseSwitchClicked_003Ec__AnonStorey1
	{
		[Token(Token = "0x400F1A7")]
		[FieldOffset(Offset = "0x8")]
		internal bool forward;

		[Token(Token = "0x400F1A8")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudCustomController _0024this;

		[Token(Token = "0x600EE1E")]
		[Address(RVA = "0x1CC6D18", Offset = "0x1CC6D18", VA = "0x1CC6D18")]
		public _003COnCaseSwitchClicked_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600EE1F")]
		[Address(RVA = "0x1CC6D20", Offset = "0x1CC6D20", VA = "0x1CC6D20")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F17D")]
	[FieldOffset(Offset = "0x48")]
	private UIHudCustomView m_View;

	[Token(Token = "0x400F17E")]
	[FieldOffset(Offset = "0x4C")]
	private CustomHudItem m_CurrentHudItem;

	[Token(Token = "0x400F17F")]
	[FieldOffset(Offset = "0x50")]
	private HudConfigItem m_HudConfigItem;

	[Token(Token = "0x400F180")]
	[FieldOffset(Offset = "0x54")]
	private bool m_FirstCase;

	[Token(Token = "0x400F181")]
	[FieldOffset(Offset = "0x58")]
	private List<CustomHudItem> m_CustomHudList;

	[Token(Token = "0x400F182")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<string, HudConfigItem> m_ConfigChangeList;

	[Token(Token = "0x400F183")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_EnableHiddenList;

	[Token(Token = "0x400F184")]
	private const string m_ReloadName = "HudReloadBtn";

	[Token(Token = "0x400F185")]
	private const string m_ChangeWeaponName = "HudSwapWeaponQuick";

	[Token(Token = "0x400F186")]
	private const string m_LeftFireName = "HudAuxFire";

	[Token(Token = "0x400F187")]
	private const string m_AuxAimName = "HudAuxAim";

	[Token(Token = "0x400F188")]
	private const string m_JoystickName = "HudMovingJoystick";

	[Token(Token = "0x400F189")]
	private const string m_UIHudGrenadeBtnName = "HudGrenadeChange";

	[Token(Token = "0x400F18A")]
	private const string m_SwimmingSurfName = "HudSwimmingSurf";

	[Token(Token = "0x400F18B")]
	private const int HEIGHT_BUTTONS = 132;

	[Token(Token = "0x400F18C")]
	private const int HEIGHT_ADJUST = 262;

	[Token(Token = "0x400F18D")]
	private const int HEIGHT_ADJUST_WITH_HIDE = 300;

	[Token(Token = "0x400F18E")]
	private const int HEIGHT_DIRECTIONS = 341;

	[Token(Token = "0x400F18F")]
	[FieldOffset(Offset = "0x64")]
	private UIWidget m_GrenadeWidget;

	[Token(Token = "0x400F190")]
	[FieldOffset(Offset = "0x68")]
	private BoxCollider m_GrenadeCollider;

	[Token(Token = "0x400F191")]
	[FieldOffset(Offset = "0x6C")]
	private EdgeDetectHudItem m_GrenadeEdgeDetect;

	[Token(Token = "0x400F192")]
	[FieldOffset(Offset = "0x70")]
	private UIWidget m_GrenadeWidget2;

	[Token(Token = "0x400F193")]
	[FieldOffset(Offset = "0x74")]
	private BoxCollider m_GrenadeCollider2;

	[Token(Token = "0x400F194")]
	[FieldOffset(Offset = "0x78")]
	private EdgeDetectHudItem m_GrenadeEdgeDetect2;

	[Token(Token = "0x400F195")]
	private const int GrenadeHLength = 70;

	[Token(Token = "0x400F196")]
	private const int GrenadeVLength = 100;

	[Token(Token = "0x400F197")]
	private const int GrenadeColliderHLength = 376;

	[Token(Token = "0x400F198")]
	private const int GrenadeColliderVLength = 124;

	[Token(Token = "0x400F199")]
	[FieldOffset(Offset = "0x7C")]
	private int m_CurrentGrenadeDirection;

	[Token(Token = "0x400F19A")]
	[FieldOffset(Offset = "0x80")]
	private int m_CurrentGrenadeDirection2;

	[Token(Token = "0x400F19B")]
	[FieldOffset(Offset = "0x84")]
	private bool m_IsDefault;

	[Token(Token = "0x400F19C")]
	[FieldOffset(Offset = "0x88")]
	private TweenHeightType m_TweenHeightType;

	[Token(Token = "0x400F19D")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<CustomHudItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400F19E")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<CustomHudItem> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400F19F")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<CustomHudItem> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600EDED")]
	[Address(RVA = "0x13788F8", Offset = "0x13788F8", VA = "0x13788F8")]
	public UIHudCustomController()
	{
	}

	[Token(Token = "0x600EDEE")]
	[Address(RVA = "0x1378A4C", Offset = "0x1378A4C", VA = "0x1378A4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EDEF")]
	[Address(RVA = "0x1378AF0", Offset = "0x1378AF0", VA = "0x1378AF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EDF0")]
	[Address(RVA = "0x137A8C0", Offset = "0x137A8C0", VA = "0x137A8C0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EDF1")]
	[Address(RVA = "0x137A69C", Offset = "0x137A69C", VA = "0x137A69C")]
	private void InitToggle()
	{
	}

	[Token(Token = "0x600EDF2")]
	[Address(RVA = "0x137AE14", Offset = "0x137AE14", VA = "0x137AE14")]
	private void OnCaseSwitchedToOne()
	{
	}

	[Token(Token = "0x600EDF3")]
	[Address(RVA = "0x137B6CC", Offset = "0x137B6CC", VA = "0x137B6CC")]
	private void OnCaseSwitchedToTwo()
	{
	}

	[Token(Token = "0x600EDF4")]
	[Address(RVA = "0x137B73C", Offset = "0x137B73C", VA = "0x137B73C")]
	private void OnArrowClicked()
	{
	}

	[Token(Token = "0x600EDF5")]
	[Address(RVA = "0x137BC1C", Offset = "0x137BC1C", VA = "0x137BC1C")]
	private void OnCloseButtonClick(int from = 262, int to = 132)
	{
	}

	[Token(Token = "0x600EDF6")]
	[Address(RVA = "0x137BAE4", Offset = "0x137BAE4", VA = "0x137BAE4")]
	private void OnExpandClicked(int from = 132, int to = 262)
	{
	}

	[Token(Token = "0x600EDF7")]
	[Address(RVA = "0x137BD8C", Offset = "0x137BD8C", VA = "0x137BD8C")]
	private void ExpandAdjustContainer()
	{
	}

	[Token(Token = "0x600EDF8")]
	[Address(RVA = "0x137C374", Offset = "0x137C374", VA = "0x137C374")]
	private void RefreshAdjustContainer()
	{
	}

	[Token(Token = "0x600EDF9")]
	[Address(RVA = "0x137B990", Offset = "0x137B990", VA = "0x137B990")]
	private bool CheckEnableHidden(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600EDFA")]
	[Address(RVA = "0x137C868", Offset = "0x137C868", VA = "0x137C868")]
	private void OnHudPressed(object[] param)
	{
	}

	[Token(Token = "0x600EDFB")]
	[Address(RVA = "0x137E0C4", Offset = "0x137E0C4", VA = "0x137E0C4")]
	private void OnHudChangePosition(object[] param)
	{
	}

	[Token(Token = "0x600EDFC")]
	[Address(RVA = "0x13799EC", Offset = "0x13799EC", VA = "0x13799EC")]
	private void InitData()
	{
	}

	[Token(Token = "0x600EDFD")]
	[Address(RVA = "0x137E468", Offset = "0x137E468", VA = "0x137E468")]
	private void SetAnchor(Transform transform, EUIAnchor anchor)
	{
	}

	[Token(Token = "0x600EDFE")]
	[Address(RVA = "0x1380348", Offset = "0x1380348", VA = "0x1380348")]
	private void ResetData()
	{
	}

	[Token(Token = "0x600EDFF")]
	[Address(RVA = "0x137E72C", Offset = "0x137E72C", VA = "0x137E72C")]
	private bool NeedShow(CustomHudItem hudItem)
	{
		return default(bool);
	}

	[Token(Token = "0x600EE00")]
	[Address(RVA = "0x1380DB0", Offset = "0x1380DB0", VA = "0x1380DB0")]
	private void OnResetButtonClick()
	{
	}

	[Token(Token = "0x600EE01")]
	[Address(RVA = "0x1381128", Offset = "0x1381128", VA = "0x1381128")]
	private void OnConfirmButtonClick()
	{
	}

	[Token(Token = "0x600EE02")]
	[Address(RVA = "0x1382C08", Offset = "0x1382C08", VA = "0x1382C08")]
	private void OnCancelButtonClick()
	{
	}

	[Token(Token = "0x600EE03")]
	[Address(RVA = "0x137AE84", Offset = "0x137AE84", VA = "0x137AE84")]
	private void OnCaseSwitchClicked(bool forward)
	{
	}

	[Token(Token = "0x600EE04")]
	[Address(RVA = "0x1382FC4", Offset = "0x1382FC4", VA = "0x1382FC4")]
	private void PlaySlideEffect(bool forward)
	{
	}

	[Token(Token = "0x600EE05")]
	[Address(RVA = "0x1383594", Offset = "0x1383594", VA = "0x1383594")]
	private void OnSizeSliderBarChange()
	{
	}

	[Token(Token = "0x600EE06")]
	[Address(RVA = "0x1383924", Offset = "0x1383924", VA = "0x1383924")]
	private void OnSizeSliderBarChangeFinished()
	{
	}

	[Token(Token = "0x600EE07")]
	[Address(RVA = "0x1383BA4", Offset = "0x1383BA4", VA = "0x1383BA4")]
	private void OnHiddenStatusChanged()
	{
	}

	[Token(Token = "0x600EE08")]
	[Address(RVA = "0x1383E10", Offset = "0x1383E10", VA = "0x1383E10")]
	public void OnAlphaSliderBarChange()
	{
	}

	[Token(Token = "0x600EE09")]
	[Address(RVA = "0x1384174", Offset = "0x1384174", VA = "0x1384174")]
	public void OnAlphaSliderBarChangeFinished()
	{
	}

	[Token(Token = "0x600EE0A")]
	[Address(RVA = "0x137C620", Offset = "0x137C620", VA = "0x137C620")]
	private void UpdateSliderBar(UISlider sliderBar, UILabel label, float value)
	{
	}

	[Token(Token = "0x600EE0B")]
	[Address(RVA = "0x137C7C8", Offset = "0x137C7C8", VA = "0x137C7C8")]
	private void UpdateHiddenToggle(UIToggle toggle, bool isHidden)
	{
	}

	[Token(Token = "0x600EE0C")]
	[Address(RVA = "0x137DF3C", Offset = "0x137DF3C", VA = "0x137DF3C")]
	private HudConfigItem GetCurrentHudConfigTemporary(string hudName)
	{
		return null;
	}

	[Token(Token = "0x600EE0D")]
	[Address(RVA = "0x137E338", Offset = "0x137E338", VA = "0x137E338")]
	private void ChangeHudConfigTemporary(string hudName, HudConfigItem hudConfig, bool isdefault = false)
	{
	}

	[Token(Token = "0x600EE0E")]
	[Address(RVA = "0x13843C4", Offset = "0x13843C4", VA = "0x13843C4")]
	private void OnHudChanged()
	{
	}

	[Token(Token = "0x600EE0F")]
	[Address(RVA = "0x13844C4", Offset = "0x13844C4", VA = "0x13844C4")]
	private void OnGrenadeLeftBtnClicked()
	{
	}

	[Token(Token = "0x600EE10")]
	[Address(RVA = "0x13846D4", Offset = "0x13846D4", VA = "0x13846D4")]
	private void OnGrenadeRightBtnClicked()
	{
	}

	[Token(Token = "0x600EE11")]
	[Address(RVA = "0x13848E4", Offset = "0x13848E4", VA = "0x13848E4")]
	private void OnGrenadeTopBtnClicked()
	{
	}

	[Token(Token = "0x600EE12")]
	[Address(RVA = "0x1384AF4", Offset = "0x1384AF4", VA = "0x1384AF4")]
	private void OnGrenadeBottomBtnClicked()
	{
	}

	[Token(Token = "0x600EE13")]
	[Address(RVA = "0x137EAEC", Offset = "0x137EAEC", VA = "0x137EAEC")]
	private void SetDirection(int direction, GrenadeSlot slot)
	{
	}

	[Token(Token = "0x600EE14")]
	[Address(RVA = "0x1382928", Offset = "0x1382928", VA = "0x1382928")]
	private void ShowPopupMessage(string message)
	{
	}

	[Token(Token = "0x600EE15")]
	[Address(RVA = "0x1384D04", Offset = "0x1384D04", VA = "0x1384D04")]
	private void _003COnResetButtonClick_003Em__0()
	{
	}

	[Token(Token = "0x600EE16")]
	[Address(RVA = "0x1384DF0", Offset = "0x1384DF0", VA = "0x1384DF0")]
	private static bool _003COnConfirmButtonClick_003Em__1(CustomHudItem a)
	{
		return default(bool);
	}

	[Token(Token = "0x600EE17")]
	[Address(RVA = "0x1384E98", Offset = "0x1384E98", VA = "0x1384E98")]
	private static bool _003COnConfirmButtonClick_003Em__2(CustomHudItem a)
	{
		return default(bool);
	}

	[Token(Token = "0x600EE18")]
	[Address(RVA = "0x1384F40", Offset = "0x1384F40", VA = "0x1384F40")]
	private static bool _003COnConfirmButtonClick_003Em__3(CustomHudItem a)
	{
		return default(bool);
	}

	[Token(Token = "0x600EE19")]
	[Address(RVA = "0x1384FE8", Offset = "0x1384FE8", VA = "0x1384FE8")]
	private void _003COnCancelButtonClick_003Em__4()
	{
	}

	[Token(Token = "0x600EE1A")]
	[Address(RVA = "0x1384FF0", Offset = "0x1384FF0", VA = "0x1384FF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE1B")]
	[Address(RVA = "0x1384FF8", Offset = "0x1384FF8", VA = "0x1384FF8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
