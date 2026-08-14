using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002448")]
internal class UIHUDUGC_CheckPointMarkShowController : UIHudNameBaseController
{
	[Token(Token = "0x400E180")]
	[FieldOffset(Offset = "0x50")]
	private UIHUDUGC_CheckPointMarkShowView m_View;

	[Token(Token = "0x400E181")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_BindWorldPosition;

	[Token(Token = "0x600CDD9")]
	[Address(RVA = "0x22268B0", Offset = "0x22268B0", VA = "0x22268B0")]
	public UIHUDUGC_CheckPointMarkShowController()
	{
	}

	[Token(Token = "0x600CDDA")]
	[Address(RVA = "0x22268B8", Offset = "0x22268B8", VA = "0x22268B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CDDB")]
	[Address(RVA = "0x222695C", Offset = "0x222695C", VA = "0x222695C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CDDC")]
	[Address(RVA = "0x2226A34", Offset = "0x2226A34", VA = "0x2226A34")]
	public void SetViewData(Vector3 targetPosition)
	{
	}

	[Token(Token = "0x600CDDD")]
	[Address(RVA = "0x2226AD0", Offset = "0x2226AD0", VA = "0x2226AD0")]
	public void SetEndPoint(bool isEnd)
	{
	}

	[Token(Token = "0x600CDDE")]
	[Address(RVA = "0x2226B68", Offset = "0x2226B68", VA = "0x2226B68", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600CDDF")]
	[Address(RVA = "0x2226BC0", Offset = "0x2226BC0", VA = "0x2226BC0", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600CDE0")]
	[Address(RVA = "0x2226C18", Offset = "0x2226C18", VA = "0x2226C18", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600CDE1")]
	[Address(RVA = "0x2226C70", Offset = "0x2226C70", VA = "0x2226C70", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600CDE2")]
	[Address(RVA = "0x2226E1C", Offset = "0x2226E1C", VA = "0x2226E1C", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600CDE3")]
	[Address(RVA = "0x2226E8C", Offset = "0x2226E8C", VA = "0x2226E8C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CDE4")]
	[Address(RVA = "0x2226E94", Offset = "0x2226E94", VA = "0x2226E94")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600CDE5")]
	[Address(RVA = "0x2226E9C", Offset = "0x2226E9C", VA = "0x2226E9C")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600CDE6")]
	[Address(RVA = "0x2226EA4", Offset = "0x2226EA4", VA = "0x2226EA4")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600CDE7")]
	[Address(RVA = "0x2226EAC", Offset = "0x2226EAC", VA = "0x2226EAC")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600CDE8")]
	[Address(RVA = "0x2226EC0", Offset = "0x2226EC0", VA = "0x2226EC0")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
