using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200227D")]
internal class UIHudPartyNPCChatBubbleController : UIHudNameBaseController
{
	[Token(Token = "0x400D7E6")]
	[FieldOffset(Offset = "0x50")]
	private UIHudPartyNPCChatBubbleView m_View;

	[Token(Token = "0x400D7E7")]
	[FieldOffset(Offset = "0x54")]
	private NetworkAIPawn_NPC m_NPCOwner;

	[Token(Token = "0x400D7E8")]
	[FieldOffset(Offset = "0x58")]
	private uint m_HideDelayCall;

	[Token(Token = "0x600BD0E")]
	[Address(RVA = "0x184397C", Offset = "0x184397C", VA = "0x184397C")]
	public UIHudPartyNPCChatBubbleController()
	{
	}

	[Token(Token = "0x600BD0F")]
	[Address(RVA = "0x1843984", Offset = "0x1843984", VA = "0x1843984")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD10")]
	[Address(RVA = "0x1843A2C", Offset = "0x1843A2C", VA = "0x1843A2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD11")]
	[Address(RVA = "0x1843AE8", Offset = "0x1843AE8", VA = "0x1843AE8")]
	public void SetOwner(NetworkAIPawn_NPC npc)
	{
	}

	[Token(Token = "0x600BD12")]
	[Address(RVA = "0x1843B48", Offset = "0x1843B48", VA = "0x1843B48")]
	public void SetChatMessage(string message, float duration)
	{
	}

	[Token(Token = "0x600BD13")]
	[Address(RVA = "0x1843D9C", Offset = "0x1843D9C", VA = "0x1843D9C", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600BD14")]
	[Address(RVA = "0x1843F60", Offset = "0x1843F60", VA = "0x1843F60", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD15")]
	[Address(RVA = "0x1843FB8", Offset = "0x1843FB8", VA = "0x1843FB8", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD16")]
	[Address(RVA = "0x1844010", Offset = "0x1844010", VA = "0x1844010", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD17")]
	[Address(RVA = "0x1844068", Offset = "0x1844068", VA = "0x1844068")]
	private void _003CSetChatMessage_003Em__0()
	{
	}

	[Token(Token = "0x600BD18")]
	[Address(RVA = "0x1844094", Offset = "0x1844094", VA = "0x1844094")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BD19")]
	[Address(RVA = "0x184409C", Offset = "0x184409C", VA = "0x184409C")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600BD1A")]
	[Address(RVA = "0x18440B0", Offset = "0x18440B0", VA = "0x18440B0")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD1B")]
	[Address(RVA = "0x18440B8", Offset = "0x18440B8", VA = "0x18440B8")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD1C")]
	[Address(RVA = "0x18440C0", Offset = "0x18440C0", VA = "0x18440C0")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}
}
