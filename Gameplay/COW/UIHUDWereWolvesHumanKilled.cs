using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C44")]
public class UIHUDWereWolvesHumanKilled : UIBaseController
{
	[Token(Token = "0x4010E1B")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesHumanKilledView m_View;

	[Token(Token = "0x6012766")]
	[Address(RVA = "0x1620348", Offset = "0x1620348", VA = "0x1620348")]
	public UIHUDWereWolvesHumanKilled()
	{
	}

	[Token(Token = "0x6012767")]
	[Address(RVA = "0x16203CC", Offset = "0x16203CC", VA = "0x16203CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012768")]
	[Address(RVA = "0x1620474", Offset = "0x1620474", VA = "0x1620474", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012769")]
	[Address(RVA = "0x1620530", Offset = "0x1620530", VA = "0x1620530")]
	public void ShowData(int humanColorIndex, int wolfColorIndex, bool isFinalKill)
	{
	}

	[Token(Token = "0x601276A")]
	[Address(RVA = "0x1620860", Offset = "0x1620860", VA = "0x1620860")]
	private void SetShowInfo(UISprite indexBgSprite, UILabel indexLabel, UISprite IconSprite, int colorIndex)
	{
	}

	[Token(Token = "0x601276B")]
	[Address(RVA = "0x1620BE8", Offset = "0x1620BE8", VA = "0x1620BE8")]
	private void _003CShowData_003Em__0()
	{
	}

	[Token(Token = "0x601276C")]
	[Address(RVA = "0x1620BF0", Offset = "0x1620BF0", VA = "0x1620BF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
