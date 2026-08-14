using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002773")]
public class UIHudGuildWarIntroInfoController : UIBaseController
{
	[Token(Token = "0x400F38E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGuildWarIntroInfoView m_View;

	[Token(Token = "0x400F38F")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600F172")]
	[Address(RVA = "0x133B9B8", Offset = "0x133B9B8", VA = "0x133B9B8")]
	public UIHudGuildWarIntroInfoController()
	{
	}

	[Token(Token = "0x600F173")]
	[Address(RVA = "0x133BA3C", Offset = "0x133BA3C", VA = "0x133BA3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F174")]
	[Address(RVA = "0x133BAE0", Offset = "0x133BAE0", VA = "0x133BAE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F175")]
	[Address(RVA = "0x133C428", Offset = "0x133C428", VA = "0x133C428", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F176")]
	[Address(RVA = "0x133BD14", Offset = "0x133BD14", VA = "0x133BD14")]
	private void ShowTeamIcon(bool isLocalFactionInLeft)
	{
	}

	[Token(Token = "0x600F177")]
	[Address(RVA = "0x133C544", Offset = "0x133C544", VA = "0x133C544")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600F178")]
	[Address(RVA = "0x133C698", Offset = "0x133C698", VA = "0x133C698")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F179")]
	[Address(RVA = "0x133C6A0", Offset = "0x133C6A0", VA = "0x133C6A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
