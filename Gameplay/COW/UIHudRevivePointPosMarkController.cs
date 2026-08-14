using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002838")]
public class UIHudRevivePointPosMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F81E")]
	[FieldOffset(Offset = "0x50")]
	private UIHudRevivePointPosMarkView m_View;

	[Token(Token = "0x400F81F")]
	[FieldOffset(Offset = "0x54")]
	private uint m_RevivePointId;

	[Token(Token = "0x400F820")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_RevivePointPos;

	[Token(Token = "0x400F821")]
	[FieldOffset(Offset = "0x64")]
	private HMBBLFKNGGM m_CurrentState;

	[Token(Token = "0x400F822")]
	[FieldOffset(Offset = "0x68")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F823")]
	[FieldOffset(Offset = "0x6C")]
	private int m_RevivePointMarkShowDis;

	[Token(Token = "0x400F824")]
	[FieldOffset(Offset = "0x70")]
	private bool m_NeedUpdatePosition;

	[Token(Token = "0x400F825")]
	[FieldOffset(Offset = "0x0")]
	public static Color ReviveIconNormal;

	[Token(Token = "0x400F826")]
	[FieldOffset(Offset = "0x10")]
	public static Color ReviveBgNormal;

	[Token(Token = "0x400F827")]
	[FieldOffset(Offset = "0x20")]
	public static Color ReviveIconCD;

	[Token(Token = "0x400F828")]
	[FieldOffset(Offset = "0x30")]
	public static Color ReviveBgCD;

	[Token(Token = "0x400F829")]
	[FieldOffset(Offset = "0x74")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x600FAE7")]
	[Address(RVA = "0x13F81A4", Offset = "0x13F81A4", VA = "0x13F81A4")]
	public UIHudRevivePointPosMarkController()
	{
	}

	[Token(Token = "0x600FAE8")]
	[Address(RVA = "0x13F8250", Offset = "0x13F8250", VA = "0x13F8250")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FAE9")]
	[Address(RVA = "0x13F82F4", Offset = "0x13F82F4", VA = "0x13F82F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FAEA")]
	[Address(RVA = "0x13F8990", Offset = "0x13F8990", VA = "0x13F8990", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FAEB")]
	[Address(RVA = "0x13F8B7C", Offset = "0x13F8B7C", VA = "0x13F8B7C", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FAEC")]
	[Address(RVA = "0x13F8CA0", Offset = "0x13F8CA0", VA = "0x13F8CA0", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600FAED")]
	[Address(RVA = "0x13F8CF8", Offset = "0x13F8CF8", VA = "0x13F8CF8", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600FAEE")]
	[Address(RVA = "0x13F8DF8", Offset = "0x13F8DF8", VA = "0x13F8DF8", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600FAEF")]
	[Address(RVA = "0x13F8E50", Offset = "0x13F8E50", VA = "0x13F8E50", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600FAF0")]
	[Address(RVA = "0x13F8EA8", Offset = "0x13F8EA8", VA = "0x13F8EA8")]
	public void BindTarget(uint id, Vector3 target)
	{
	}

	[Token(Token = "0x600FAF1")]
	[Address(RVA = "0x13F9064", Offset = "0x13F9064", VA = "0x13F9064")]
	public void Reset()
	{
	}

	[Token(Token = "0x600FAF2")]
	[Address(RVA = "0x13F9164", Offset = "0x13F9164", VA = "0x13F9164")]
	public void SetState(HMBBLFKNGGM state)
	{
	}

	[Token(Token = "0x600FAF3")]
	[Address(RVA = "0x13F99F4", Offset = "0x13F99F4", VA = "0x13F99F4")]
	public void SetTime(int time)
	{
	}

	[Token(Token = "0x600FAF4")]
	[Address(RVA = "0x13F8F44", Offset = "0x13F8F44", VA = "0x13F8F44")]
	private void Update()
	{
	}

	[Token(Token = "0x600FAF5")]
	[Address(RVA = "0x13F9C88", Offset = "0x13F9C88", VA = "0x13F9C88", Slot = "36")]
	protected override void OnDistanceChanged(float distance)
	{
	}

	[Token(Token = "0x600FAF6")]
	[Address(RVA = "0x13F9DF4", Offset = "0x13F9DF4", VA = "0x13F9DF4")]
	private void OnEnterRevivePoint(object[] data)
	{
	}

	[Token(Token = "0x600FAF7")]
	[Address(RVA = "0x13F8768", Offset = "0x13F8768", VA = "0x13F8768")]
	private void OnLocalPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600FAF9")]
	[Address(RVA = "0x13FA288", Offset = "0x13FA288", VA = "0x13FA288")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FAFA")]
	[Address(RVA = "0x13FA290", Offset = "0x13FA290", VA = "0x13FA290")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600FAFB")]
	[Address(RVA = "0x13FA298", Offset = "0x13FA298", VA = "0x13FA298")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FAFC")]
	[Address(RVA = "0x13FA2AC", Offset = "0x13FA2AC", VA = "0x13FA2AC")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600FAFD")]
	[Address(RVA = "0x13FA2B4", Offset = "0x13FA2B4", VA = "0x13FA2B4")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600FAFE")]
	[Address(RVA = "0x13FA2C8", Offset = "0x13FA2C8", VA = "0x13FA2C8")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600FAFF")]
	[Address(RVA = "0x13FA2D0", Offset = "0x13FA2D0", VA = "0x13FA2D0")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB00")]
	[Address(RVA = "0x13FA2D8", Offset = "0x13FA2D8", VA = "0x13FA2D8")]
	public void _003C_003EiFixBaseProxy_OnDistanceChanged(float P0)
	{
	}
}
