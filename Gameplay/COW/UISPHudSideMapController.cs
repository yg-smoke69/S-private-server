using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B4E")]
internal class UISPHudSideMapController : UIMapBaseController
{
	[Token(Token = "0x4010986")]
	[FieldOffset(Offset = "0x2C")]
	private UISPHudSideMapView m_View;

	[Token(Token = "0x4010987")]
	[FieldOffset(Offset = "0x30")]
	private Player m_Player;

	[Token(Token = "0x4010988")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_MinMapLocalScale;

	[Token(Token = "0x4010989")]
	private const float MAP_SIZE_HEIGHT = 1024f;

	[Token(Token = "0x401098A")]
	[FieldOffset(Offset = "0x40")]
	public float WheelSensitivity;

	[Token(Token = "0x401098B")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 m_LastTouchPos;

	[Token(Token = "0x401098C")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsShowing;

	[Token(Token = "0x6011D44")]
	[Address(RVA = "0x1D2E3EC", Offset = "0x1D2E3EC", VA = "0x1D2E3EC")]
	public UISPHudSideMapController()
	{
	}

	[Token(Token = "0x6011D45")]
	[Address(RVA = "0x1D2E490", Offset = "0x1D2E490", VA = "0x1D2E490")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D46")]
	[Address(RVA = "0x1D2E538", Offset = "0x1D2E538", VA = "0x1D2E538", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D47")]
	[Address(RVA = "0x1D2EA10", Offset = "0x1D2EA10", VA = "0x1D2EA10", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D48")]
	[Address(RVA = "0x1D2E994", Offset = "0x1D2E994", VA = "0x1D2E994")]
	private void InitUIElements()
	{
	}

	[Token(Token = "0x6011D49")]
	[Address(RVA = "0x1D2EA88", Offset = "0x1D2EA88", VA = "0x1D2EA88", Slot = "31")]
	protected override void RegisterEvents()
	{
	}

	[Token(Token = "0x6011D4A")]
	[Address(RVA = "0x1D2EAEC", Offset = "0x1D2EAEC", VA = "0x1D2EAEC", Slot = "32")]
	protected override void UnRegisterEvents()
	{
	}

	[Token(Token = "0x6011D4B")]
	[Address(RVA = "0x1D2EB50", Offset = "0x1D2EB50", VA = "0x1D2EB50", Slot = "36")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6011D4C")]
	[Address(RVA = "0x1D2EE14", Offset = "0x1D2EE14", VA = "0x1D2EE14", Slot = "37")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6011D4D")]
	[Address(RVA = "0x1D2F158", Offset = "0x1D2F158", VA = "0x1D2F158", Slot = "35")]
	protected override void OnPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x6011D4E")]
	[Address(RVA = "0x1D2F1DC", Offset = "0x1D2F1DC", VA = "0x1D2F1DC")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x6011D4F")]
	[Address(RVA = "0x1D2F524", Offset = "0x1D2F524", VA = "0x1D2F524")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x6011D50")]
	[Address(RVA = "0x1D2F388", Offset = "0x1D2F388", VA = "0x1D2F388")]
	private bool IsMapTouched(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6011D51")]
	[Address(RVA = "0x1D2F5B4", Offset = "0x1D2F5B4", VA = "0x1D2F5B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6011D52")]
	[Address(RVA = "0x1D2F750", Offset = "0x1D2F750", VA = "0x1D2F750", Slot = "33")]
	protected override void OnObservePlayer(object[] data)
	{
	}

	[Token(Token = "0x6011D53")]
	[Address(RVA = "0x1D2F8D0", Offset = "0x1D2F8D0", VA = "0x1D2F8D0")]
	private void OnTweenFinished()
	{
	}

	[Token(Token = "0x6011D54")]
	[Address(RVA = "0x1D2F96C", Offset = "0x1D2F96C", VA = "0x1D2F96C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D55")]
	[Address(RVA = "0x1D2F974", Offset = "0x1D2F974", VA = "0x1D2F974")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011D56")]
	[Address(RVA = "0x1D2F97C", Offset = "0x1D2F97C", VA = "0x1D2F97C")]
	public void _003C_003EiFixBaseProxy_RegisterEvents()
	{
	}

	[Token(Token = "0x6011D57")]
	[Address(RVA = "0x1D2F984", Offset = "0x1D2F984", VA = "0x1D2F984")]
	public void _003C_003EiFixBaseProxy_UnRegisterEvents()
	{
	}

	[Token(Token = "0x6011D58")]
	[Address(RVA = "0x1D2F98C", Offset = "0x1D2F98C", VA = "0x1D2F98C")]
	public void _003C_003EiFixBaseProxy_OnPlayerHPChanged(object[] P0)
	{
	}

	[Token(Token = "0x6011D59")]
	[Address(RVA = "0x1D2F994", Offset = "0x1D2F994", VA = "0x1D2F994")]
	public void _003C_003EiFixBaseProxy_OnObservePlayer(object[] P0)
	{
	}
}
