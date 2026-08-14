using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200284D")]
internal class UIHudSkillEffectCountingController : UIBaseController
{
	[Token(Token = "0x400F89E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSkillEffectCountingView m_View;

	[Token(Token = "0x400F89F")]
	[FieldOffset(Offset = "0x2C")]
	private PFLCPEHBBLN m_ActiveSkill;

	[Token(Token = "0x400F8A0")]
	[FieldOffset(Offset = "0x30")]
	private bool m_AlwaysKeep;

	[Token(Token = "0x600FBD3")]
	[Address(RVA = "0x16C2250", Offset = "0x16C2250", VA = "0x16C2250")]
	public UIHudSkillEffectCountingController()
	{
	}

	[Token(Token = "0x600FBD4")]
	[Address(RVA = "0x16C22D4", Offset = "0x16C22D4", VA = "0x16C22D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FBD5")]
	[Address(RVA = "0x16C2378", Offset = "0x16C2378", VA = "0x16C2378", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FBD6")]
	[Address(RVA = "0x16C25AC", Offset = "0x16C25AC", VA = "0x16C25AC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FBD7")]
	[Address(RVA = "0x16C27B0", Offset = "0x16C27B0", VA = "0x16C27B0")]
	public void TriggerActiveSkill(PFLCPEHBBLN newActiveSkill)
	{
	}

	[Token(Token = "0x600FBD8")]
	[Address(RVA = "0x16C2A24", Offset = "0x16C2A24", VA = "0x16C2A24")]
	public void StopActiveSkill()
	{
	}

	[Token(Token = "0x600FBD9")]
	[Address(RVA = "0x16C2A9C", Offset = "0x16C2A9C", VA = "0x16C2A9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600FBDA")]
	[Address(RVA = "0x16C2C70", Offset = "0x16C2C70", VA = "0x16C2C70")]
	private void OnUpdateSkillIcon(object[] param)
	{
	}

	[Token(Token = "0x600FBDB")]
	[Address(RVA = "0x16C2DDC", Offset = "0x16C2DDC", VA = "0x16C2DDC")]
	private void OnLocalPlayerDead(object[] param)
	{
	}

	[Token(Token = "0x600FBDC")]
	[Address(RVA = "0x16C2E50", Offset = "0x16C2E50", VA = "0x16C2E50")]
	private void OnAddLocalPlayer(object[] param)
	{
	}

	[Token(Token = "0x600FBDD")]
	[Address(RVA = "0x16C2F6C", Offset = "0x16C2F6C", VA = "0x16C2F6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FBDE")]
	[Address(RVA = "0x16C2F74", Offset = "0x16C2F74", VA = "0x16C2F74")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
