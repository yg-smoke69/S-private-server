using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200288B")]
public class UIHudTriggerEventMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F9A6")]
	[FieldOffset(Offset = "0x50")]
	private UIEventTriggerView m_View;

	[Token(Token = "0x400F9A7")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_bindWorldPosition;

	[Token(Token = "0x400F9A8")]
	[FieldOffset(Offset = "0x60")]
	private StringBuilder m_Distance;

	[Token(Token = "0x400F9A9")]
	[FieldOffset(Offset = "0x64")]
	private bool m_NeedShowDistance;

	[Token(Token = "0x400F9AA")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CurrentDelegate;

	[Token(Token = "0x400F9AB")]
	[FieldOffset(Offset = "0x6C")]
	private InGameTriggerMaskData m_showData;

	[Token(Token = "0x400F9AC")]
	[FieldOffset(Offset = "0x70")]
	private bool m_NeedRecycle;

	[Token(Token = "0x600FE60")]
	[Address(RVA = "0x158AE5C", Offset = "0x158AE5C", VA = "0x158AE5C")]
	public UIHudTriggerEventMarkController()
	{
	}

	[Token(Token = "0x600FE61")]
	[Address(RVA = "0x158AE64", Offset = "0x158AE64", VA = "0x158AE64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE62")]
	[Address(RVA = "0x158AF0C", Offset = "0x158AF0C", VA = "0x158AF0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE63")]
	[Address(RVA = "0x158B058", Offset = "0x158B058", VA = "0x158B058")]
	public void BindWorldPosition(Vector3 targetPosition)
	{
	}

	[Token(Token = "0x600FE64")]
	[Address(RVA = "0x158B0E0", Offset = "0x158B0E0", VA = "0x158B0E0")]
	public void HideUIShowData()
	{
	}

	[Token(Token = "0x600FE65")]
	[Address(RVA = "0x158B478", Offset = "0x158B478", VA = "0x158B478")]
	public void SetUIShowData(InGameTriggerMaskData data, bool needRecycle)
	{
	}

	[Token(Token = "0x600FE66")]
	[Address(RVA = "0x158B8D0", Offset = "0x158B8D0", VA = "0x158B8D0")]
	private Color GetColorByMarkType(ONKGJBLICJL markType)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600FE67")]
	[Address(RVA = "0x158B140", Offset = "0x158B140", VA = "0x158B140")]
	private void ResetUI()
	{
	}

	[Token(Token = "0x600FE68")]
	[Address(RVA = "0x158B99C", Offset = "0x158B99C", VA = "0x158B99C")]
	public void SetShowDistance(bool enable)
	{
	}

	[Token(Token = "0x600FE69")]
	[Address(RVA = "0x158BA58", Offset = "0x158BA58", VA = "0x158BA58", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600FE6A")]
	[Address(RVA = "0x158BB78", Offset = "0x158BB78", VA = "0x158BB78", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FE6B")]
	[Address(RVA = "0x158BD4C", Offset = "0x158BD4C", VA = "0x158BD4C")]
	private void SetDistance(int distance)
	{
	}

	[Token(Token = "0x600FE6C")]
	[Address(RVA = "0x158BF04", Offset = "0x158BF04", VA = "0x158BF04")]
	private void RefreshDistanceToLocalPlayer()
	{
	}

	[Token(Token = "0x600FE6D")]
	[Address(RVA = "0x158C114", Offset = "0x158C114", VA = "0x158C114", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600FE6E")]
	[Address(RVA = "0x158C228", Offset = "0x158C228", VA = "0x158C228", Slot = "40")]
	protected override void LateUpdate()
	{
	}

	[Token(Token = "0x600FE6F")]
	[Address(RVA = "0x158C294", Offset = "0x158C294", VA = "0x158C294")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE70")]
	[Address(RVA = "0x158C29C", Offset = "0x158C29C", VA = "0x158C29C")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600FE71")]
	[Address(RVA = "0x158C2A4", Offset = "0x158C2A4", VA = "0x158C2A4")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FE72")]
	[Address(RVA = "0x158C2B8", Offset = "0x158C2B8", VA = "0x158C2B8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600FE73")]
	[Address(RVA = "0x158C2C0", Offset = "0x158C2C0", VA = "0x158C2C0")]
	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
