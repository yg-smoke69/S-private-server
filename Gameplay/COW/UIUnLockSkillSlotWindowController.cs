using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002BC6")]
internal class UIUnLockSkillSlotWindowController : UIPopupWindowController
{
	[Token(Token = "0x4010B7F")]
	[FieldOffset(Offset = "0x48")]
	private UIUnLockSkillSlotWindowView m_View;

	[Token(Token = "0x4010B80")]
	[FieldOffset(Offset = "0x4C")]
	private uint avaterID;

	[Token(Token = "0x4010B81")]
	[FieldOffset(Offset = "0x50")]
	private int slotIndex;

	[Token(Token = "0x4010B82")]
	[FieldOffset(Offset = "0x54")]
	private int skillID;

	[Token(Token = "0x4010B83")]
	[FieldOffset(Offset = "0x58")]
	private int gemCount;

	[Token(Token = "0x4010B84")]
	[FieldOffset(Offset = "0x5C")]
	private int coinCount;

	[Token(Token = "0x4010B85")]
	[FieldOffset(Offset = "0x60")]
	private bool isClickClose;

	[Token(Token = "0x601219D")]
	[Address(RVA = "0xF5165C", Offset = "0xF5165C", VA = "0xF5165C")]
	public UIUnLockSkillSlotWindowController()
	{
	}

	[Token(Token = "0x601219E")]
	[Address(RVA = "0xF5166C", Offset = "0xF5166C", VA = "0xF5166C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601219F")]
	[Address(RVA = "0xF51714", Offset = "0xF51714", VA = "0xF51714", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60121A0")]
	[Address(RVA = "0xF518E4", Offset = "0xF518E4", VA = "0xF518E4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60121A1")]
	[Address(RVA = "0xF51EA4", Offset = "0xF51EA4", VA = "0xF51EA4")]
	private void OnBtnCoinsBuy()
	{
	}

	[Token(Token = "0x60121A2")]
	[Address(RVA = "0xF52664", Offset = "0xF52664", VA = "0xF52664")]
	private void OnBtnGemsBuy()
	{
	}

	[Token(Token = "0x60121A3")]
	[Address(RVA = "0xF52990", Offset = "0xF52990", VA = "0xF52990")]
	public void UpdateDate(int _slotIndex, uint _avatarID)
	{
	}

	[Token(Token = "0x60121A4")]
	[Address(RVA = "0xF5342C", Offset = "0xF5342C", VA = "0xF5342C")]
	private void UpdateFreeUnlockView()
	{
	}

	[Token(Token = "0x60121A5")]
	[Address(RVA = "0xF5238C", Offset = "0xF5238C", VA = "0xF5238C")]
	private bool IsAvatarSkillFreeUnlock()
	{
		return default(bool);
	}

	[Token(Token = "0x60121A6")]
	[Address(RVA = "0xF53538", Offset = "0xF53538", VA = "0xF53538")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60121A7")]
	[Address(RVA = "0xF53540", Offset = "0xF53540", VA = "0xF53540")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
