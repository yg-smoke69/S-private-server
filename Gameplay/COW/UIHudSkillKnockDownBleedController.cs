using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002851")]
internal class UIHudSkillKnockDownBleedController : UIBaseController
{
	[Token(Token = "0x400F8A8")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSkillKnockDownBleedView m_View;

	[Token(Token = "0x600FC02")]
	[Address(RVA = "0x16C8868", Offset = "0x16C8868", VA = "0x16C8868")]
	public UIHudSkillKnockDownBleedController()
	{
	}

	[Token(Token = "0x600FC03")]
	[Address(RVA = "0x16C88EC", Offset = "0x16C88EC", VA = "0x16C88EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC04")]
	[Address(RVA = "0x16C8990", Offset = "0x16C8990", VA = "0x16C8990", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC05")]
	[Address(RVA = "0x16C8A60", Offset = "0x16C8A60", VA = "0x16C8A60", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC06")]
	[Address(RVA = "0x16C8AC4", Offset = "0x16C8AC4", VA = "0x16C8AC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC07")]
	[Address(RVA = "0x16C8ACC", Offset = "0x16C8ACC", VA = "0x16C8ACC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
