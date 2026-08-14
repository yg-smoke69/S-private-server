using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027D8")]
internal class UIHudNameRedEnvelopeReceiverController : UIHudNameBaseController
{
	[Token(Token = "0x400F60C")]
	[FieldOffset(Offset = "0x50")]
	private UIHudNameRedEnvelopeReceiverView m_View;

	[Token(Token = "0x400F60D")]
	[FieldOffset(Offset = "0x54")]
	private Player m_Receiver;

	[Token(Token = "0x600F6D8")]
	[Address(RVA = "0x1F51BA8", Offset = "0x1F51BA8", VA = "0x1F51BA8")]
	public UIHudNameRedEnvelopeReceiverController()
	{
	}

	[Token(Token = "0x600F6D9")]
	[Address(RVA = "0x1F51BAC", Offset = "0x1F51BAC", VA = "0x1F51BAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F6DA")]
	[Address(RVA = "0x1F51C54", Offset = "0x1F51C54", VA = "0x1F51C54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F6DB")]
	[Address(RVA = "0x1F51D0C", Offset = "0x1F51D0C", VA = "0x1F51D0C")]
	public void BindPlayer(Player player, ulong ownerID, string ownerName, bool isLucky)
	{
	}

	[Token(Token = "0x600F6DC")]
	[Address(RVA = "0x1F51FE0", Offset = "0x1F51FE0", VA = "0x1F51FE0")]
	private void RemoveSelf()
	{
	}

	[Token(Token = "0x600F6DD")]
	[Address(RVA = "0x1F52160", Offset = "0x1F52160", VA = "0x1F52160", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F6DE")]
	[Address(RVA = "0x1F52340", Offset = "0x1F52340", VA = "0x1F52340", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F6DF")]
	[Address(RVA = "0x1F52398", Offset = "0x1F52398", VA = "0x1F52398")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F6E0")]
	[Address(RVA = "0x1F5239C", Offset = "0x1F5239C", VA = "0x1F5239C")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F6E1")]
	[Address(RVA = "0x1F523AC", Offset = "0x1F523AC", VA = "0x1F523AC")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}
}
