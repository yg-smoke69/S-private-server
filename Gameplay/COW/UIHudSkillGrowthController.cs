using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200284E")]
internal class UIHudSkillGrowthController : UIPopupWindowController
{
	[Token(Token = "0x400F8A1")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSkillGrowthView m_View;

	[Token(Token = "0x400F8A2")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_Skill2Learn;

	[Token(Token = "0x600FBDF")]
	[Address(RVA = "0x16C32A8", Offset = "0x16C32A8", VA = "0x16C32A8")]
	public UIHudSkillGrowthController()
	{
	}

	[Token(Token = "0x600FBE0")]
	[Address(RVA = "0x16C32B0", Offset = "0x16C32B0", VA = "0x16C32B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FBE1")]
	[Address(RVA = "0x16C3358", Offset = "0x16C3358", VA = "0x16C3358", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FBE2")]
	[Address(RVA = "0x16C3FA4", Offset = "0x16C3FA4", VA = "0x16C3FA4")]
	private PlayerZombieBR GetLocalZombiePlayer()
	{
		return null;
	}

	[Token(Token = "0x600FBE3")]
	[Address(RVA = "0x16C36A4", Offset = "0x16C36A4", VA = "0x16C36A4")]
	private void SetView()
	{
	}

	[Token(Token = "0x600FBE4")]
	[Address(RVA = "0x16C4434", Offset = "0x16C4434", VA = "0x16C4434")]
	private void SetPlayerLevel()
	{
	}

	[Token(Token = "0x600FBE5")]
	[Address(RVA = "0x16C4590", Offset = "0x16C4590", VA = "0x16C4590")]
	private void SetRerandomView()
	{
	}

	[Token(Token = "0x600FBE6")]
	[Address(RVA = "0x16C4910", Offset = "0x16C4910", VA = "0x16C4910")]
	private void OnItemSelect(object[] data)
	{
	}

	[Token(Token = "0x600FBE7")]
	[Address(RVA = "0x16C4EB0", Offset = "0x16C4EB0", VA = "0x16C4EB0")]
	private void OnPlayerLevelChanged(object[] data)
	{
	}

	[Token(Token = "0x600FBE8")]
	[Address(RVA = "0x16C5028", Offset = "0x16C5028", VA = "0x16C5028")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x600FBE9")]
	[Address(RVA = "0x16C52C8", Offset = "0x16C52C8", VA = "0x16C52C8")]
	private void OnBtnRerandomClick()
	{
	}

	[Token(Token = "0x600FBEA")]
	[Address(RVA = "0x16C53DC", Offset = "0x16C53DC", VA = "0x16C53DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
