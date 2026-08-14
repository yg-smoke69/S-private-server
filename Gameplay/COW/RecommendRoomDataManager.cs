using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E15")]
public class RecommendRoomDataManager : SingletonModule<RecommendRoomDataManager>
{
	[Token(Token = "0x4011A48")]
	[FieldOffset(Offset = "0xC")]
	private RecommendRoomData m_RecommendRoomData;

	[Token(Token = "0x60134B7")]
	[Address(RVA = "0x1970EF4", Offset = "0x1970EF4", VA = "0x1970EF4")]
	public RecommendRoomDataManager()
	{
	}

	[Token(Token = "0x60134B8")]
	[Address(RVA = "0x1970F84", Offset = "0x1970F84", VA = "0x1970F84", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60134B9")]
	[Address(RVA = "0x19710F0", Offset = "0x19710F0", VA = "0x19710F0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60134BA")]
	[Address(RVA = "0x1971144", Offset = "0x1971144", VA = "0x1971144")]
	public bool IsHotRoomType(uint roomType)
	{
		return default(bool);
	}

	[Token(Token = "0x60134BB")]
	[Address(RVA = "0x1971258", Offset = "0x1971258", VA = "0x1971258")]
	public bool IsNewRoomType(uint roomType)
	{
		return default(bool);
	}

	[Token(Token = "0x60134BC")]
	[Address(RVA = "0x197136C", Offset = "0x197136C", VA = "0x197136C")]
	public bool IsHotGameMode(uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x60134BD")]
	[Address(RVA = "0x1971480", Offset = "0x1971480", VA = "0x1971480")]
	public bool IsNewGameMode(uint gameMode)
	{
		return default(bool);
	}
}
