using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002175")]
public class UILadderMatchSelectGameModeItemController : UIBaseController
{
	[Token(Token = "0x400D20B")]
	[FieldOffset(Offset = "0x28")]
	private UILadderMatchSelectGameModeItemView m_View;

	[Token(Token = "0x400D20C")]
	[FieldOffset(Offset = "0x2C")]
	private JOKABEAPNPP m_GameMode;

	[Token(Token = "0x400D20D")]
	[FieldOffset(Offset = "0x30")]
	private DGNDKMLMLPM m_MatchMode;

	[Token(Token = "0x400D20E")]
	[FieldOffset(Offset = "0x34")]
	private MapModeData m_MapModeData;

	[Token(Token = "0x600B14C")]
	[Address(RVA = "0x22D7404", Offset = "0x22D7404", VA = "0x22D7404")]
	public UILadderMatchSelectGameModeItemController()
	{
	}

	[Token(Token = "0x600B14D")]
	[Address(RVA = "0x22D7488", Offset = "0x22D7488", VA = "0x22D7488", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B14E")]
	[Address(RVA = "0x22D75E4", Offset = "0x22D75E4", VA = "0x22D75E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B14F")]
	[Address(RVA = "0x22D7688", Offset = "0x22D7688", VA = "0x22D7688")]
	public void SetViewData(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode, MapModeData mapModeData)
	{
	}

	[Token(Token = "0x600B150")]
	[Address(RVA = "0x22D7890", Offset = "0x22D7890", VA = "0x22D7890")]
	private void OnClickBtn()
	{
	}

	[Token(Token = "0x600B151")]
	[Address(RVA = "0x22D7AF4", Offset = "0x22D7AF4", VA = "0x22D7AF4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
