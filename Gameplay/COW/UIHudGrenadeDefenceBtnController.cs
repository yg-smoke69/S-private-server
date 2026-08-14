using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200276D")]
internal class UIHudGrenadeDefenceBtnController : UIHudGrenadeBtnController
{
	[Token(Token = "0x400F375")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_EnableSmartIceWall;

	[Token(Token = "0x400F376")]
	[FieldOffset(Offset = "0xB9")]
	private bool m_IsButtonDrag;

	[Token(Token = "0x400F377")]
	[FieldOffset(Offset = "0xBC")]
	private float m_PressTime;

	[Token(Token = "0x400F378")]
	[FieldOffset(Offset = "0xC0")]
	private Camera m_Camera;

	[Token(Token = "0x400F379")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 m_SmartIceWallIconOriginalPos;

	[Token(Token = "0x400F37A")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 m_SmartIceWallStartPos;

	[Token(Token = "0x400F37B")]
	[FieldOffset(Offset = "0xDC")]
	private float m_BGRangeRadius;

	[Token(Token = "0x400F37C")]
	[FieldOffset(Offset = "0xE0")]
	private float m_Multiscale;

	[Token(Token = "0x400F37D")]
	[FieldOffset(Offset = "0xE4")]
	private string m_StrButtonAction;

	[Token(Token = "0x400F37E")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_GlobalTouchEnd;

	[Token(Token = "0x600F136")]
	[Address(RVA = "0x1334480", Offset = "0x1334480", VA = "0x1334480")]
	public UIHudGrenadeDefenceBtnController()
	{
	}

	[Token(Token = "0x600F137")]
	[Address(RVA = "0x1334560", Offset = "0x1334560", VA = "0x1334560")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F138")]
	[Address(RVA = "0x1334604", Offset = "0x1334604", VA = "0x1334604", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F139")]
	[Address(RVA = "0x1334A1C", Offset = "0x1334A1C", VA = "0x1334A1C", Slot = "38")]
	protected override void InitRouletteAwake()
	{
	}

	[Token(Token = "0x600F13A")]
	[Address(RVA = "0x1334B50", Offset = "0x1334B50", VA = "0x1334B50", Slot = "40")]
	protected override void RefreshGrenadeItemList(object[] data)
	{
	}

	[Token(Token = "0x600F13B")]
	[Address(RVA = "0x1334BAC", Offset = "0x1334BAC", VA = "0x1334BAC", Slot = "39")]
	protected override void ShowRouletteGuide()
	{
	}

	[Token(Token = "0x600F13C")]
	[Address(RVA = "0x1334C00", Offset = "0x1334C00", VA = "0x1334C00", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F13D")]
	[Address(RVA = "0x1334C84", Offset = "0x1334C84", VA = "0x1334C84")]
	private void OnCancelUseBuindingGun(object[] param)
	{
	}

	[Token(Token = "0x600F13E")]
	[Address(RVA = "0x1334CEC", Offset = "0x1334CEC", VA = "0x1334CEC")]
	private void OnInGameSettingOpen(object[] param)
	{
	}

	[Token(Token = "0x600F13F")]
	[Address(RVA = "0x1334D54", Offset = "0x1334D54", VA = "0x1334D54")]
	private void OnSmartIceWallSettingChange(object[] para)
	{
	}

	[Token(Token = "0x600F140")]
	[Address(RVA = "0x1334950", Offset = "0x1334950", VA = "0x1334950")]
	private void UpdateSmartIceWallEnable()
	{
	}

	[Token(Token = "0x600F141")]
	[Address(RVA = "0x1334F20", Offset = "0x1334F20", VA = "0x1334F20", Slot = "37")]
	protected override void OnUpdateCustomGrenadeSlot()
	{
	}

	[Token(Token = "0x600F142")]
	[Address(RVA = "0x1334DC8", Offset = "0x1334DC8", VA = "0x1334DC8")]
	private void SwitchStyle(bool enableSmartIceWall)
	{
	}

	[Token(Token = "0x600F143")]
	[Address(RVA = "0x1334F90", Offset = "0x1334F90", VA = "0x1334F90", Slot = "31")]
	protected override void OnBtnDown()
	{
	}

	[Token(Token = "0x600F144")]
	[Address(RVA = "0x133520C", Offset = "0x133520C", VA = "0x133520C", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600F145")]
	[Address(RVA = "0x1335550", Offset = "0x1335550", VA = "0x1335550")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600F146")]
	[Address(RVA = "0x133589C", Offset = "0x133589C", VA = "0x133589C", Slot = "41")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600F147")]
	[Address(RVA = "0x1335068", Offset = "0x1335068", VA = "0x1335068")]
	private bool WeaponOnHandIsIceWall()
	{
		return default(bool);
	}

	[Token(Token = "0x600F148")]
	[Address(RVA = "0x1336560", Offset = "0x1336560", VA = "0x1336560", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F149")]
	[Address(RVA = "0x13365B8", Offset = "0x13365B8", VA = "0x13365B8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F14A")]
	[Address(RVA = "0x13365C0", Offset = "0x13365C0", VA = "0x13365C0")]
	public void _003C_003EiFixBaseProxy_InitRouletteAwake()
	{
	}

	[Token(Token = "0x600F14B")]
	[Address(RVA = "0x13365C8", Offset = "0x13365C8", VA = "0x13365C8")]
	public void _003C_003EiFixBaseProxy_RefreshGrenadeItemList(object[] P0)
	{
	}

	[Token(Token = "0x600F14C")]
	[Address(RVA = "0x13365D0", Offset = "0x13365D0", VA = "0x13365D0")]
	public void _003C_003EiFixBaseProxy_ShowRouletteGuide()
	{
	}

	[Token(Token = "0x600F14D")]
	[Address(RVA = "0x13365D8", Offset = "0x13365D8", VA = "0x13365D8")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F14E")]
	[Address(RVA = "0x13365E0", Offset = "0x13365E0", VA = "0x13365E0")]
	public void _003C_003EiFixBaseProxy_OnUpdateCustomGrenadeSlot()
	{
	}

	[Token(Token = "0x600F14F")]
	[Address(RVA = "0x13365E8", Offset = "0x13365E8", VA = "0x13365E8")]
	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	[Token(Token = "0x600F150")]
	[Address(RVA = "0x13365F0", Offset = "0x13365F0", VA = "0x13365F0")]
	public new void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	[Token(Token = "0x600F151")]
	[Address(RVA = "0x13365F8", Offset = "0x13365F8", VA = "0x13365F8")]
	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	[Token(Token = "0x600F152")]
	[Address(RVA = "0x1336600", Offset = "0x1336600", VA = "0x1336600")]
	public string _003C_003EiFixBaseProxy_GetMappingName()
	{
		return null;
	}
}
