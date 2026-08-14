using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027C5")]
internal class UIHudMovingJoystickController : UIBaseController
{
	[Token(Token = "0x400F586")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMovingJoystickView m_View;

	[Token(Token = "0x400F587")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_DefaultPos;

	[Token(Token = "0x400F588")]
	[FieldOffset(Offset = "0x38")]
	private float m_BGRangeRadius;

	[Token(Token = "0x400F589")]
	[FieldOffset(Offset = "0x3C")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F58A")]
	[FieldOffset(Offset = "0x40")]
	private Camera m_Camera;

	[Token(Token = "0x400F58B")]
	[FieldOffset(Offset = "0x44")]
	private float dist;

	[Token(Token = "0x400F58C")]
	[FieldOffset(Offset = "0x48")]
	private bool m_NeedFastRun;

	[Token(Token = "0x400F58D")]
	[FieldOffset(Offset = "0x49")]
	private bool m_IsTouchUp;

	[Token(Token = "0x400F58E")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_Position;

	[Token(Token = "0x400F58F")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_Rotation;

	[Token(Token = "0x400F590")]
	[FieldOffset(Offset = "0x64")]
	private float m_MaxJoyLength;

	[Token(Token = "0x400F591")]
	[FieldOffset(Offset = "0x68")]
	private float multiscale;

	[Token(Token = "0x400F592")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_IsInSpeedUp;

	[Token(Token = "0x400F593")]
	[FieldOffset(Offset = "0x70")]
	private string commonstr;

	[Token(Token = "0x400F594")]
	[FieldOffset(Offset = "0x74")]
	private string upstr;

	[Token(Token = "0x400F595")]
	[FieldOffset(Offset = "0x78")]
	private bool m_UseNewRunning;

	[Token(Token = "0x400F596")]
	[FieldOffset(Offset = "0x79")]
	private bool m_IsFollowHide;

	[Token(Token = "0x600F5FE")]
	[Address(RVA = "0x1F491AC", Offset = "0x1F491AC", VA = "0x1F491AC")]
	public UIHudMovingJoystickController()
	{
	}

	[Token(Token = "0x600F5FF")]
	[Address(RVA = "0x1F492EC", Offset = "0x1F492EC", VA = "0x1F492EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F600")]
	[Address(RVA = "0x1F49390", Offset = "0x1F49390", VA = "0x1F49390", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F601")]
	[Address(RVA = "0x1F49998", Offset = "0x1F49998", VA = "0x1F49998", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F602")]
	[Address(RVA = "0x1F49CA0", Offset = "0x1F49CA0", VA = "0x1F49CA0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F603")]
	[Address(RVA = "0x1F49F0C", Offset = "0x1F49F0C", VA = "0x1F49F0C")]
	private void OnUseNewRunningChange(object[] data)
	{
	}

	[Token(Token = "0x600F604")]
	[Address(RVA = "0x1F4A24C", Offset = "0x1F4A24C", VA = "0x1F4A24C")]
	private void OnTutorialGuideShow(object[] data)
	{
	}

	[Token(Token = "0x600F605")]
	[Address(RVA = "0x1F4A400", Offset = "0x1F4A400", VA = "0x1F4A400", Slot = "18")]
	protected override void OnUIActiveGroupSwitch(ulong activeGroup)
	{
	}

	[Token(Token = "0x600F606")]
	[Address(RVA = "0x1F4A578", Offset = "0x1F4A578", VA = "0x1F4A578")]
	private void RefreshVisibleWithControlMode(object[] data)
	{
	}

	[Token(Token = "0x600F607")]
	[Address(RVA = "0x1F4A870", Offset = "0x1F4A870", VA = "0x1F4A870")]
	private bool CheckInSpeedUpCoillder(UserControlAxisData axisData)
	{
		return default(bool);
	}

	[Token(Token = "0x600F608")]
	[Address(RVA = "0x1F4ACD4", Offset = "0x1F4ACD4", VA = "0x1F4ACD4")]
	private bool CheckPosCanEnterSpeedUp(Vector3 delta)
	{
		return default(bool);
	}

	[Token(Token = "0x600F609")]
	[Address(RVA = "0x1F4AF74", Offset = "0x1F4AF74", VA = "0x1F4AF74")]
	private bool CheckPosCanShowSpeedUp(Vector3 delta)
	{
		return default(bool);
	}

	[Token(Token = "0x600F60A")]
	[Address(RVA = "0x1F4B214", Offset = "0x1F4B214", VA = "0x1F4B214")]
	private float GetSpeedUpRatio(Vector3 delta)
	{
		return default(float);
	}

	[Token(Token = "0x600F60B")]
	[Address(RVA = "0x1F4B4A4", Offset = "0x1F4B4A4", VA = "0x1F4B4A4")]
	private Vector3 CalLastPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F60C")]
	[Address(RVA = "0x1F4B684", Offset = "0x1F4B684", VA = "0x1F4B684")]
	private bool CheckState()
	{
		return default(bool);
	}

	[Token(Token = "0x600F60D")]
	[Address(RVA = "0x1F4B850", Offset = "0x1F4B850", VA = "0x1F4B850")]
	private void Update()
	{
	}

	[Token(Token = "0x600F60E")]
	[Address(RVA = "0x1F4DA3C", Offset = "0x1F4DA3C", VA = "0x1F4DA3C")]
	private void RequestJoyFastRun(bool flag)
	{
	}

	[Token(Token = "0x600F60F")]
	[Address(RVA = "0x1F4D83C", Offset = "0x1F4D83C", VA = "0x1F4D83C")]
	private void ActiveJoyStick(bool v)
	{
	}

	[Token(Token = "0x600F610")]
	[Address(RVA = "0x1F4DBF8", Offset = "0x1F4DBF8", VA = "0x1F4DBF8")]
	private void OnLocalPlayerTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x600F611")]
	[Address(RVA = "0x1F4DD3C", Offset = "0x1F4DD3C", VA = "0x1F4DD3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F612")]
	[Address(RVA = "0x1F4DD44", Offset = "0x1F4DD44", VA = "0x1F4DD44")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F613")]
	[Address(RVA = "0x1F4DD4C", Offset = "0x1F4DD4C", VA = "0x1F4DD4C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F614")]
	[Address(RVA = "0x1F4DD54", Offset = "0x1F4DD54", VA = "0x1F4DD54")]
	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(ulong P0)
	{
	}
}
