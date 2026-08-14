using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003369")]
public class UITeamBaseProfileController : UIBaseController
{
	[Token(Token = "0x401393E")]
	[FieldOffset(Offset = "0x28")]
	private UITeamBaseProfileView m_View;

	[Token(Token = "0x401393F")]
	[FieldOffset(Offset = "0x2C")]
	private TeamInfo m_TeamInfo;

	[Token(Token = "0x6015DD6")]
	[Address(RVA = "0x20190CC", Offset = "0x20190CC", VA = "0x20190CC")]
	public UITeamBaseProfileController()
	{
	}

	[Token(Token = "0x6015DD7")]
	[Address(RVA = "0x2019150", Offset = "0x2019150", VA = "0x2019150")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015DD8")]
	[Address(RVA = "0x20191F4", Offset = "0x20191F4", VA = "0x20191F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015DD9")]
	[Address(RVA = "0x20192B0", Offset = "0x20192B0", VA = "0x20192B0")]
	public void SetData(TeamInfo teamInfo)
	{
	}

	[Token(Token = "0x6015DDA")]
	[Address(RVA = "0x20196F0", Offset = "0x20196F0", VA = "0x20196F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
