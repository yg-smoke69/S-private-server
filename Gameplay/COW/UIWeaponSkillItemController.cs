using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BFE")]
internal class UIWeaponSkillItemController : UIBaseController
{
	[Token(Token = "0x4010CB5")]
	[FieldOffset(Offset = "0x28")]
	private UIWeaponSkillItemView m_View;

	[Token(Token = "0x4010CB6")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_Currentwpid;

	[Token(Token = "0x4010CB7")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CurrentSkinId;

	[Token(Token = "0x6012402")]
	[Address(RVA = "0x102B7C4", Offset = "0x102B7C4", VA = "0x102B7C4")]
	public UIWeaponSkillItemController()
	{
	}

	[Token(Token = "0x6012403")]
	[Address(RVA = "0x102B848", Offset = "0x102B848", VA = "0x102B848")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012404")]
	[Address(RVA = "0x102B8EC", Offset = "0x102B8EC", VA = "0x102B8EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012405")]
	[Address(RVA = "0x102BADC", Offset = "0x102BADC", VA = "0x102BADC")]
	private void OnClear()
	{
	}

	[Token(Token = "0x6012406")]
	[Address(RVA = "0x102BB44", Offset = "0x102BB44", VA = "0x102BB44", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012407")]
	[Address(RVA = "0x102BC78", Offset = "0x102BC78", VA = "0x102BC78")]
	public void SetData(uint wpid, uint skinid)
	{
	}

	[Token(Token = "0x6012408")]
	[Address(RVA = "0x102BCF8", Offset = "0x102BCF8", VA = "0x102BCF8")]
	public void ShowSkill()
	{
	}

	[Token(Token = "0x6012409")]
	[Address(RVA = "0x102BFBC", Offset = "0x102BFBC", VA = "0x102BFBC")]
	public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0u)
	{
	}

	[Token(Token = "0x601240A")]
	[Address(RVA = "0x102BD8C", Offset = "0x102BD8C", VA = "0x102BD8C")]
	private void SetUIData(uint wpid, uint skinId = 0u)
	{
	}

	[Token(Token = "0x601240B")]
	[Address(RVA = "0x102C048", Offset = "0x102C048", VA = "0x102C048")]
	private void OnWeaponSkinChanged(object[] data)
	{
	}

	[Token(Token = "0x601240C")]
	[Address(RVA = "0x102C170", Offset = "0x102C170", VA = "0x102C170")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601240D")]
	[Address(RVA = "0x102C178", Offset = "0x102C178", VA = "0x102C178")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
