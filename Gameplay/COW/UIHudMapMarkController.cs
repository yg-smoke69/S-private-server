using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027AB")]
public class UIHudMapMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F4E5")]
	[FieldOffset(Offset = "0x50")]
	private UIHudMapMarkView m_View;

	[Token(Token = "0x400F4E6")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_MarkPosition;

	[Token(Token = "0x600F4C2")]
	[Address(RVA = "0xFF9AA0", Offset = "0xFF9AA0", VA = "0xFF9AA0")]
	public UIHudMapMarkController()
	{
	}

	[Token(Token = "0x600F4C3")]
	[Address(RVA = "0xFF9B44", Offset = "0xFF9B44", VA = "0xFF9B44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F4C4")]
	[Address(RVA = "0xFF9BE8", Offset = "0xFF9BE8", VA = "0xFF9BE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F4C5")]
	[Address(RVA = "0xFF9D98", Offset = "0xFF9D98", VA = "0xFF9D98", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F4C6")]
	[Address(RVA = "0xFF9DF0", Offset = "0xFF9DF0", VA = "0xFF9DF0", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F4C7")]
	[Address(RVA = "0xFF9E48", Offset = "0xFF9E48", VA = "0xFF9E48", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F4C8")]
	[Address(RVA = "0xFF9EB8", Offset = "0xFF9EB8", VA = "0xFF9EB8", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600F4C9")]
	[Address(RVA = "0xFF9F40", Offset = "0xFF9F40", VA = "0xFF9F40")]
	public void PrepareForClose()
	{
	}

	[Token(Token = "0x600F4CA")]
	[Address(RVA = "0xFFA0E0", Offset = "0xFFA0E0", VA = "0xFFA0E0")]
	private void DelayClose()
	{
	}

	[Token(Token = "0x600F4CB")]
	[Address(RVA = "0xFFA260", Offset = "0xFFA260", VA = "0xFFA260")]
	public void SetMarkData(Vector3 position, int teamIndex)
	{
	}

	[Token(Token = "0x600F4CC")]
	[Address(RVA = "0xFFA574", Offset = "0xFFA574", VA = "0xFFA574")]
	public void SetIsLeader(bool leader = false)
	{
	}

	[Token(Token = "0x600F4CD")]
	[Address(RVA = "0xFFA3C4", Offset = "0xFFA3C4", VA = "0xFFA3C4")]
	private void RefreshMarkIconSprite(UISprite icon, int index)
	{
	}

	[Token(Token = "0x600F4CE")]
	[Address(RVA = "0xFFA684", Offset = "0xFFA684", VA = "0xFFA684")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F4CF")]
	[Address(RVA = "0xFFA68C", Offset = "0xFFA68C", VA = "0xFFA68C")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F4D0")]
	[Address(RVA = "0xFFA694", Offset = "0xFFA694", VA = "0xFFA694")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F4D1")]
	[Address(RVA = "0xFFA69C", Offset = "0xFFA69C", VA = "0xFFA69C")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F4D2")]
	[Address(RVA = "0xFFA6B0", Offset = "0xFFA6B0", VA = "0xFFA6B0")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}
}
