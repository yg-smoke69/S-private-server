using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F45")]
public class UIFFWS03TopBtnController : UIBigEventTopBtnBaseController
{
	[Token(Token = "0x6009A73")]
	[Address(RVA = "0x1DB3B4C", Offset = "0x1DB3B4C", VA = "0x1DB3B4C")]
	public UIFFWS03TopBtnController()
	{
	}

	[Token(Token = "0x6009A74")]
	[Address(RVA = "0x1DB3B54", Offset = "0x1DB3B54", VA = "0x1DB3B54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A75")]
	[Address(RVA = "0x1DB3BFC", Offset = "0x1DB3BFC", VA = "0x1DB3BFC", Slot = "31")]
	public override string GetTokenClickSoundId()
	{
		return null;
	}

	[Token(Token = "0x6009A76")]
	[Address(RVA = "0x1DB3CA0", Offset = "0x1DB3CA0", VA = "0x1DB3CA0")]
	public string _003C_003EiFixBaseProxy_GetTokenClickSoundId()
	{
		return null;
	}
}
