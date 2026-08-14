using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FA9")]
public class UIHUDArmsRaceTopLevelWarningController : UIBaseController
{
	[Token(Token = "0x400C688")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDArmsRaceTopLevelWarningView m_View;

	[Token(Token = "0x400C689")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x6009DE4")]
	[Address(RVA = "0x16736F0", Offset = "0x16736F0", VA = "0x16736F0")]
	public UIHUDArmsRaceTopLevelWarningController()
	{
	}

	[Token(Token = "0x6009DE5")]
	[Address(RVA = "0x1673774", Offset = "0x1673774", VA = "0x1673774")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DE6")]
	[Address(RVA = "0x167381C", Offset = "0x167381C", VA = "0x167381C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DE7")]
	[Address(RVA = "0x1673A0C", Offset = "0x1673A0C", VA = "0x1673A0C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009DE8")]
	[Address(RVA = "0x1673BA8", Offset = "0x1673BA8", VA = "0x1673BA8")]
	private void OnOtherIsTopLevel(object[] param)
	{
	}

	[Token(Token = "0x6009DE9")]
	[Address(RVA = "0x1673FE8", Offset = "0x1673FE8", VA = "0x1673FE8")]
	private void OnTeamIsTopLevel(object[] param)
	{
	}

	[Token(Token = "0x6009DEA")]
	[Address(RVA = "0x1673DE8", Offset = "0x1673DE8", VA = "0x1673DE8")]
	private void ShowWarning(string showInfo)
	{
	}

	[Token(Token = "0x6009DEB")]
	[Address(RVA = "0x1674238", Offset = "0x1674238", VA = "0x1674238")]
	private void _003CShowWarning_003Em__0()
	{
	}

	[Token(Token = "0x6009DEC")]
	[Address(RVA = "0x167427C", Offset = "0x167427C", VA = "0x167427C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009DED")]
	[Address(RVA = "0x1674284", Offset = "0x1674284", VA = "0x1674284")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
