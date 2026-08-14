using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CD8")]
public class GameFunctionSwitchDataManager : SingletonModule<GameFunctionSwitchDataManager>
{
	[Token(Token = "0x6012C46")]
	[Address(RVA = "0x1DD3C0C", Offset = "0x1DD3C0C", VA = "0x1DD3C0C")]
	public GameFunctionSwitchDataManager()
	{
	}

	[Token(Token = "0x6012C47")]
	[Address(RVA = "0x1DD3C9C", Offset = "0x1DD3C9C", VA = "0x1DD3C9C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6012C48")]
	[Address(RVA = "0x1DD3DBC", Offset = "0x1DD3DBC", VA = "0x1DD3DBC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6012C49")]
	[Address(RVA = "0x1DD3E10", Offset = "0x1DD3E10", VA = "0x1DD3E10")]
	public bool CheckIsFunctionAvailable(FunctionType fType, bool ShowTips = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6012C4A")]
	[Address(RVA = "0x1DD4378", Offset = "0x1DD4378", VA = "0x1DD4378")]
	public bool CheckCanShowRankGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x6012C4B")]
	[Address(RVA = "0x1DD45BC", Offset = "0x1DD45BC", VA = "0x1DD45BC")]
	public void SetLevelLimit(FunctionType type, int levelLimit)
	{
	}
}
