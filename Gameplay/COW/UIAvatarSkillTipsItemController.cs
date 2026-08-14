using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024D7")]
public class UIAvatarSkillTipsItemController : UIBaseController
{
	[Token(Token = "0x400E472")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarSkillTipsItemView m_View;

	[Token(Token = "0x400E473")]
	[FieldOffset(Offset = "0x2C")]
	private uint MaxDataListLength;

	[Token(Token = "0x600D414")]
	[Address(RVA = "0x2FA0F10", Offset = "0x2FA0F10", VA = "0x2FA0F10")]
	public UIAvatarSkillTipsItemController()
	{
	}

	[Token(Token = "0x600D415")]
	[Address(RVA = "0x2FA0F9C", Offset = "0x2FA0F9C", VA = "0x2FA0F9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D416")]
	[Address(RVA = "0x2FA1044", Offset = "0x2FA1044", VA = "0x2FA1044", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D417")]
	[Address(RVA = "0x2F9FC6C", Offset = "0x2F9FC6C", VA = "0x2F9FC6C")]
	public void RefreshData(List<string> datalist)
	{
	}

	[Token(Token = "0x600D418")]
	[Address(RVA = "0x2F9FFC8", Offset = "0x2F9FFC8", VA = "0x2F9FFC8")]
	public void RefreshCount(int count)
	{
	}

	[Token(Token = "0x600D419")]
	[Address(RVA = "0x2FA1100", Offset = "0x2FA1100", VA = "0x2FA1100")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
