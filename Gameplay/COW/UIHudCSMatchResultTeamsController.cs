using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002048")]
internal class UIHudCSMatchResultTeamsController : UIHudMatchResult2TeamsController
{
	[Token(Token = "0x600A440")]
	[Address(RVA = "0x1F18258", Offset = "0x1F18258", VA = "0x1F18258")]
	public UIHudCSMatchResultTeamsController()
	{
	}

	[Token(Token = "0x600A441")]
	[Address(RVA = "0x1F18260", Offset = "0x1F18260", VA = "0x1F18260")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A442")]
	[Address(RVA = "0x1F18308", Offset = "0x1F18308", VA = "0x1F18308", Slot = "38")]
	protected override UIHudMatchResult2TeamsView OnCreateView()
	{
		return null;
	}

	[Token(Token = "0x600A443")]
	[Address(RVA = "0x1F183B4", Offset = "0x1F183B4", VA = "0x1F183B4")]
	public void ShowUIFromSpectator()
	{
	}

	[Token(Token = "0x600A444")]
	[Address(RVA = "0x1F18F74", Offset = "0x1F18F74", VA = "0x1F18F74")]
	public UIHudMatchResult2TeamsView _003C_003EiFixBaseProxy_OnCreateView()
	{
		return null;
	}
}
