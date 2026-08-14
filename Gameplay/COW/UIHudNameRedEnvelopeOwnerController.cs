using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027D7")]
internal class UIHudNameRedEnvelopeOwnerController : UIHudNameBaseController
{
	[Token(Token = "0x400F60A")]
	[FieldOffset(Offset = "0x50")]
	private UIHudNameRedEnvelopeOwnerView m_View;

	[Token(Token = "0x400F60B")]
	[FieldOffset(Offset = "0x54")]
	private Player m_Owner;

	[Token(Token = "0x600F6CF")]
	[Address(RVA = "0x1F514D8", Offset = "0x1F514D8", VA = "0x1F514D8")]
	public UIHudNameRedEnvelopeOwnerController()
	{
	}

	[Token(Token = "0x600F6D0")]
	[Address(RVA = "0x1F514DC", Offset = "0x1F514DC", VA = "0x1F514DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F6D1")]
	[Address(RVA = "0x1F51584", Offset = "0x1F51584", VA = "0x1F51584", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F6D2")]
	[Address(RVA = "0x1F5163C", Offset = "0x1F5163C", VA = "0x1F5163C")]
	public void BindPlayer(Player owner)
	{
	}

	[Token(Token = "0x600F6D3")]
	[Address(RVA = "0x1F517A0", Offset = "0x1F517A0", VA = "0x1F517A0", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F6D4")]
	[Address(RVA = "0x1F51980", Offset = "0x1F51980", VA = "0x1F51980", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F6D5")]
	[Address(RVA = "0x1F519D8", Offset = "0x1F519D8", VA = "0x1F519D8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F6D6")]
	[Address(RVA = "0x1F519DC", Offset = "0x1F519DC", VA = "0x1F519DC")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F6D7")]
	[Address(RVA = "0x1F519EC", Offset = "0x1F519EC", VA = "0x1F519EC")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}
}
