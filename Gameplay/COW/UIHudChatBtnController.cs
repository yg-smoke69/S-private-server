using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023DC")]
public class UIHudChatBtnController : UIBaseController
{
	[Token(Token = "0x400DED4")]
	[FieldOffset(Offset = "0x0")]
	public static float MaxDragDis;

	[Token(Token = "0x400DED5")]
	[FieldOffset(Offset = "0x4")]
	private static float MaxDragDisSquare;

	[Token(Token = "0x400DED6")]
	[FieldOffset(Offset = "0x8")]
	private static float QuickDragDis;

	[Token(Token = "0x400DED7")]
	[FieldOffset(Offset = "0xC")]
	private static float QuickDragDisSquare;

	[Token(Token = "0x400DED8")]
	[FieldOffset(Offset = "0x28")]
	private UIHudChatBtnView m_View;

	[Token(Token = "0x400DED9")]
	[FieldOffset(Offset = "0x2C")]
	private UIWidget m_Widget;

	[Token(Token = "0x400DEDA")]
	[FieldOffset(Offset = "0x30")]
	private uint m_UpdateCDCallID;

	[Token(Token = "0x400DEDB")]
	[FieldOffset(Offset = "0x34")]
	private float m_EndCDTime;

	[Token(Token = "0x400DEDC")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsPressed;

	[Token(Token = "0x400DEDD")]
	[FieldOffset(Offset = "0x3C")]
	private float m_PressTime;

	[Token(Token = "0x400DEDE")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_ChatBtnOriginalPos;

	[Token(Token = "0x400DEDF")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_ChatBtnStartPos;

	[Token(Token = "0x400DEE0")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_CurDirection;

	[Token(Token = "0x400DEE1")]
	[FieldOffset(Offset = "0x64")]
	private Camera m_Camera;

	[Token(Token = "0x400DEE2")]
	[FieldOffset(Offset = "0x68")]
	private bool m_RouletteSwitch;

	[Token(Token = "0x400DEE3")]
	[FieldOffset(Offset = "0x69")]
	private bool m_GlobalTouchEnd;

	[Token(Token = "0x600CA4D")]
	[Address(RVA = "0x1358CD0", Offset = "0x1358CD0", VA = "0x1358CD0")]
	public UIHudChatBtnController()
	{
	}

	[Token(Token = "0x600CA4E")]
	[Address(RVA = "0x1358DA8", Offset = "0x1358DA8", VA = "0x1358DA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA4F")]
	[Address(RVA = "0x1358E4C", Offset = "0x1358E4C", VA = "0x1358E4C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA50")]
	[Address(RVA = "0x1359724", Offset = "0x1359724", VA = "0x1359724", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600CA51")]
	[Address(RVA = "0x1359A04", Offset = "0x1359A04", VA = "0x1359A04", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CA52")]
	[Address(RVA = "0x1359C1C", Offset = "0x1359C1C", VA = "0x1359C1C")]
	public UIWidget GetMaskContainer()
	{
		return null;
	}

	[Token(Token = "0x600CA53")]
	[Address(RVA = "0x1359C8C", Offset = "0x1359C8C", VA = "0x1359C8C")]
	private void OnMessageVisibleChange(object[] data)
	{
	}

	[Token(Token = "0x600CA54")]
	[Address(RVA = "0x1359E00", Offset = "0x1359E00", VA = "0x1359E00")]
	private void OnNewMessageReceived(object[] data)
	{
	}

	[Token(Token = "0x600CA55")]
	[Address(RVA = "0x1359FB4", Offset = "0x1359FB4", VA = "0x1359FB4")]
	private void ShowTutorialQuickChat(object[] data)
	{
	}

	[Token(Token = "0x600CA56")]
	[Address(RVA = "0x135A110", Offset = "0x135A110", VA = "0x135A110")]
	private void OnQuickChatStartCD(object[] data)
	{
	}

	[Token(Token = "0x600CA57")]
	[Address(RVA = "0x135A46C", Offset = "0x135A46C", VA = "0x135A46C")]
	private void UpdateCDTime()
	{
	}

	[Token(Token = "0x600CA58")]
	[Address(RVA = "0x135A2EC", Offset = "0x135A2EC", VA = "0x135A2EC")]
	private void EnableChatBtn(bool enable)
	{
	}

	[Token(Token = "0x600CA59")]
	[Address(RVA = "0x135A6A4", Offset = "0x135A6A4", VA = "0x135A6A4")]
	private void OnChatClick()
	{
	}

	[Token(Token = "0x600CA5A")]
	[Address(RVA = "0x135A7E8", Offset = "0x135A7E8", VA = "0x135A7E8")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600CA5B")]
	[Address(RVA = "0x135AC2C", Offset = "0x135AC2C", VA = "0x135AC2C")]
	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	[Token(Token = "0x600CA5C")]
	[Address(RVA = "0x135AD1C", Offset = "0x135AD1C", VA = "0x135AD1C")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600CA5D")]
	[Address(RVA = "0x135B068", Offset = "0x135B068", VA = "0x135B068")]
	private void Update()
	{
	}

	[Token(Token = "0x600CA5F")]
	[Address(RVA = "0x135C040", Offset = "0x135C040", VA = "0x135C040")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA60")]
	[Address(RVA = "0x135C048", Offset = "0x135C048", VA = "0x135C048")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600CA61")]
	[Address(RVA = "0x135C050", Offset = "0x135C050", VA = "0x135C050")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
