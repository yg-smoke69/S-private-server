using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027E3")]
public class UIHudOBInfoController : UIBaseController
{
	[Token(Token = "0x400F644")]
	[FieldOffset(Offset = "0x28")]
	private UIHudOBInfoView m_View;

	[Token(Token = "0x600F746")]
	[Address(RVA = "0x1F5B0D4", Offset = "0x1F5B0D4", VA = "0x1F5B0D4")]
	public UIHudOBInfoController()
	{
	}

	[Token(Token = "0x600F747")]
	[Address(RVA = "0x1F5B158", Offset = "0x1F5B158", VA = "0x1F5B158")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F748")]
	[Address(RVA = "0x1F5B1FC", Offset = "0x1F5B1FC", VA = "0x1F5B1FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F749")]
	[Address(RVA = "0x1F5B384", Offset = "0x1F5B384", VA = "0x1F5B384", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F74A")]
	[Address(RVA = "0x1F5B4AC", Offset = "0x1F5B4AC", VA = "0x1F5B4AC")]
	private void OnTeamFinisheGame(object[] data)
	{
	}

	[Token(Token = "0x600F74B")]
	[Address(RVA = "0x1F5B544", Offset = "0x1F5B544", VA = "0x1F5B544")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F74C")]
	[Address(RVA = "0x1F5B54C", Offset = "0x1F5B54C", VA = "0x1F5B54C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
