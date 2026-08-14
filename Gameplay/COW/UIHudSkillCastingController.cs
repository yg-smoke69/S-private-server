using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200284C")]
internal class UIHudSkillCastingController : UIBaseController
{
	[Token(Token = "0x400F89C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSkillCastingView m_View;

	[Token(Token = "0x400F89D")]
	[FieldOffset(Offset = "0x2C")]
	private PFLCPEHBBLN m_ActiveSkill;

	[Token(Token = "0x600FBCA")]
	[Address(RVA = "0x16C18DC", Offset = "0x16C18DC", VA = "0x16C18DC")]
	public UIHudSkillCastingController()
	{
	}

	[Token(Token = "0x600FBCB")]
	[Address(RVA = "0x16C1960", Offset = "0x16C1960", VA = "0x16C1960")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FBCC")]
	[Address(RVA = "0x16C1A04", Offset = "0x16C1A04", VA = "0x16C1A04", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FBCD")]
	[Address(RVA = "0x16C1BD0", Offset = "0x16C1BD0", VA = "0x16C1BD0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FBCE")]
	[Address(RVA = "0x16C1D6C", Offset = "0x16C1D6C", VA = "0x16C1D6C")]
	public void OnCastActiveSkill(object[] param)
	{
	}

	[Token(Token = "0x600FBCF")]
	[Address(RVA = "0x16C1F10", Offset = "0x16C1F10", VA = "0x16C1F10")]
	protected void Update()
	{
	}

	[Token(Token = "0x600FBD0")]
	[Address(RVA = "0x16C2014", Offset = "0x16C2014", VA = "0x16C2014")]
	public void OnStopActiveSkill(object[] param)
	{
	}

	[Token(Token = "0x600FBD1")]
	[Address(RVA = "0x16C2088", Offset = "0x16C2088", VA = "0x16C2088")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FBD2")]
	[Address(RVA = "0x16C2090", Offset = "0x16C2090", VA = "0x16C2090")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
