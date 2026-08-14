using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027D6")]
internal class UIHudNameRedEnvelopeController : UIHudNameBaseController
{
	[Token(Token = "0x400F608")]
	[FieldOffset(Offset = "0x50")]
	private LevelRedEnvelope bindedLevelObject;

	[Token(Token = "0x400F609")]
	[FieldOffset(Offset = "0x54")]
	private UIHudNameRedEnvelopeView m_View;

	[Token(Token = "0x600F6C5")]
	[Address(RVA = "0x1F50DA8", Offset = "0x1F50DA8", VA = "0x1F50DA8")]
	public UIHudNameRedEnvelopeController()
	{
	}

	[Token(Token = "0x600F6C6")]
	[Address(RVA = "0x1F50DAC", Offset = "0x1F50DAC", VA = "0x1F50DAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F6C7")]
	[Address(RVA = "0x1F50E54", Offset = "0x1F50E54", VA = "0x1F50E54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F6C8")]
	[Address(RVA = "0x1F50F0C", Offset = "0x1F50F0C", VA = "0x1F50F0C")]
	public void BindLevelObject(LevelRedEnvelope red)
	{
	}

	[Token(Token = "0x600F6C9")]
	[Address(RVA = "0x1F50F6C", Offset = "0x1F50F6C", VA = "0x1F50F6C", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F6CA")]
	[Address(RVA = "0x1F5115C", Offset = "0x1F5115C", VA = "0x1F5115C")]
	public void OnRedEnvelopeStatusChanged(bool isAlive)
	{
	}

	[Token(Token = "0x600F6CB")]
	[Address(RVA = "0x1F51468", Offset = "0x1F51468", VA = "0x1F51468", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F6CC")]
	[Address(RVA = "0x1F514C0", Offset = "0x1F514C0", VA = "0x1F514C0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F6CD")]
	[Address(RVA = "0x1F514C4", Offset = "0x1F514C4", VA = "0x1F514C4")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F6CE")]
	[Address(RVA = "0x1F514D4", Offset = "0x1F514D4", VA = "0x1F514D4")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}
}
