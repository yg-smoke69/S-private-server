using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200284F")]
internal class UIHudSkillGrowthEntryController : UIBaseController
{
	[Token(Token = "0x400F8A3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSkillGrowthEntryView m_View;

	[Token(Token = "0x600FBEB")]
	[Address(RVA = "0x16C53E4", Offset = "0x16C53E4", VA = "0x16C53E4")]
	public UIHudSkillGrowthEntryController()
	{
	}

	[Token(Token = "0x600FBEC")]
	[Address(RVA = "0x16C5468", Offset = "0x16C5468", VA = "0x16C5468")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FBED")]
	[Address(RVA = "0x16C5510", Offset = "0x16C5510", VA = "0x16C5510", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FBEE")]
	[Address(RVA = "0x16C5BB8", Offset = "0x16C5BB8", VA = "0x16C5BB8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FBEF")]
	[Address(RVA = "0x16C5C1C", Offset = "0x16C5C1C", VA = "0x16C5C1C")]
	private PlayerZombieBR GetLocalZombiePlayer()
	{
		return null;
	}

	[Token(Token = "0x600FBF0")]
	[Address(RVA = "0x16C5810", Offset = "0x16C5810", VA = "0x16C5810")]
	private void SetView()
	{
	}

	[Token(Token = "0x600FBF1")]
	[Address(RVA = "0x16C5D80", Offset = "0x16C5D80", VA = "0x16C5D80")]
	private void OpenSkillGrowthWnd()
	{
	}

	[Token(Token = "0x600FBF2")]
	[Address(RVA = "0x16C5E90", Offset = "0x16C5E90", VA = "0x16C5E90")]
	private void OnRerandomSkillTokenCntChanged(object[] datas)
	{
	}

	[Token(Token = "0x600FBF3")]
	[Address(RVA = "0x16C5FD8", Offset = "0x16C5FD8", VA = "0x16C5FD8")]
	private void OnSkillCandidatesChanged(object[] datas)
	{
	}

	[Token(Token = "0x600FBF4")]
	[Address(RVA = "0x16C6244", Offset = "0x16C6244", VA = "0x16C6244")]
	private void RefreshEntryView(object[] datas)
	{
	}

	[Token(Token = "0x600FBF5")]
	[Address(RVA = "0x16C62AC", Offset = "0x16C62AC", VA = "0x16C62AC")]
	private void ForceHideEntry(object[] datas)
	{
	}

	[Token(Token = "0x600FBF6")]
	[Address(RVA = "0x16C6320", Offset = "0x16C6320", VA = "0x16C6320")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FBF7")]
	[Address(RVA = "0x16C6328", Offset = "0x16C6328", VA = "0x16C6328")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
