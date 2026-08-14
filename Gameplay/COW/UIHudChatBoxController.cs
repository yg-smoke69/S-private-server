using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023DB")]
public class UIHudChatBoxController : UIHudNameBaseController
{
	[Token(Token = "0x400DECE")]
	[FieldOffset(Offset = "0x50")]
	private UIHudChatboxView m_View;

	[Token(Token = "0x400DECF")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG m_TargetPlayerID;

	[Token(Token = "0x400DED0")]
	[FieldOffset(Offset = "0x70")]
	private Player m_Player;

	[Token(Token = "0x400DED1")]
	[FieldOffset(Offset = "0x74")]
	private uint m_DelayCallID;

	[Token(Token = "0x400DED2")]
	[FieldOffset(Offset = "0x78")]
	private int m_StickWidth;

	[Token(Token = "0x400DED3")]
	[FieldOffset(Offset = "0x7C")]
	private int m_StickHeight;

	[Token(Token = "0x600CA3E")]
	[Address(RVA = "0x214D32C", Offset = "0x214D32C", VA = "0x214D32C")]
	public UIHudChatBoxController()
	{
	}

	[Token(Token = "0x600CA3F")]
	[Address(RVA = "0x214D334", Offset = "0x214D334", VA = "0x214D334")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA40")]
	[Address(RVA = "0x214D3D8", Offset = "0x214D3D8", VA = "0x214D3D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA41")]
	[Address(RVA = "0x214D504", Offset = "0x214D504", VA = "0x214D504")]
	public void BindPlayer(IHAAMHPPLMG player_id, string msg)
	{
	}

	[Token(Token = "0x600CA42")]
	[Address(RVA = "0x214E07C", Offset = "0x214E07C", VA = "0x214E07C")]
	public void UnBindPlayer()
	{
	}

	[Token(Token = "0x600CA43")]
	[Address(RVA = "0x214E268", Offset = "0x214E268", VA = "0x214E268", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600CA44")]
	[Address(RVA = "0x214E4AC", Offset = "0x214E4AC", VA = "0x214E4AC", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600CA45")]
	[Address(RVA = "0x214E538", Offset = "0x214E538", VA = "0x214E538", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CA46")]
	[Address(RVA = "0x214E59C", Offset = "0x214E59C", VA = "0x214E59C", Slot = "44")]
	protected override bool IsVisibleWithZoneType(int zonetype)
	{
		return default(bool);
	}

	[Token(Token = "0x600CA47")]
	[Address(RVA = "0x214E60C", Offset = "0x214E60C", VA = "0x214E60C")]
	private void _003CBindPlayer_003Em__0()
	{
	}

	[Token(Token = "0x600CA48")]
	[Address(RVA = "0x214E704", Offset = "0x214E704", VA = "0x214E704")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA49")]
	[Address(RVA = "0x214E70C", Offset = "0x214E70C", VA = "0x214E70C")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600CA4A")]
	[Address(RVA = "0x214E714", Offset = "0x214E714", VA = "0x214E714")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600CA4B")]
	[Address(RVA = "0x214E728", Offset = "0x214E728", VA = "0x214E728")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CA4C")]
	[Address(RVA = "0x214E730", Offset = "0x214E730", VA = "0x214E730")]
	public bool _003C_003EiFixBaseProxy_IsVisibleWithZoneType(int P0)
	{
		return default(bool);
	}
}
