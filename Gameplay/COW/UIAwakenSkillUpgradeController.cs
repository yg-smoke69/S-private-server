using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FB7")]
public class UIAwakenSkillUpgradeController : UIPopupWindowController
{
	[Token(Token = "0x400C6F4")]
	[FieldOffset(Offset = "0x48")]
	private UIAwakenSkillUpgradeView m_View;

	[Token(Token = "0x400C6F5")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400C6F6")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CurrentAvatarId;

	[Token(Token = "0x400C6F7")]
	[FieldOffset(Offset = "0x54")]
	private UIAvatarSkillSlotController m_skillSlotCtrl;

	[Token(Token = "0x6009E8A")]
	[Address(RVA = "0x13FF7A4", Offset = "0x13FF7A4", VA = "0x13FF7A4")]
	public UIAwakenSkillUpgradeController()
	{
	}

	[Token(Token = "0x6009E8B")]
	[Address(RVA = "0x13FF7AC", Offset = "0x13FF7AC", VA = "0x13FF7AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009E8C")]
	[Address(RVA = "0x13FF850", Offset = "0x13FF850", VA = "0x13FF850", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009E8D")]
	[Address(RVA = "0x13FFA1C", Offset = "0x13FFA1C", VA = "0x13FFA1C")]
	private void OnUpgradeBtn()
	{
	}

	[Token(Token = "0x6009E8E")]
	[Address(RVA = "0x13FFAA8", Offset = "0x13FFAA8", VA = "0x13FFAA8")]
	public void SetData(uint avatarID)
	{
	}

	[Token(Token = "0x6009E8F")]
	[Address(RVA = "0x13FFB6C", Offset = "0x13FFB6C", VA = "0x13FFB6C")]
	private void SetSkillInfo(AvatarProfile ap)
	{
	}

	[Token(Token = "0x6009E90")]
	[Address(RVA = "0x13FFF18", Offset = "0x13FFF18", VA = "0x13FFF18")]
	private void SetConsumeUI(AvatarProfile ap)
	{
	}

	[Token(Token = "0x6009E91")]
	[Address(RVA = "0x14006EC", Offset = "0x14006EC", VA = "0x14006EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
