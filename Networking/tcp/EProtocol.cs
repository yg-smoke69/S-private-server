using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D7B")]
public class EProtocol
{
	[Token(Token = "0x2001D7C")]
	public enum Proto
	{
		[Token(Token = "0x400BA06")]
		Proto_NONE = 0,
		[Token(Token = "0x400BA07")]
		INIT = 1,
		[Token(Token = "0x400BA08")]
		HEARTBEAT = 2,
		[Token(Token = "0x400BA09")]
		MATCHMAKING = 3,
		[Token(Token = "0x400BA0A")]
		STATS = 4,
		[Token(Token = "0x400BA0B")]
		GROUP = 5,
		[Token(Token = "0x400BA0C")]
		FRIEND = 6,
		[Token(Token = "0x400BA0D")]
		MAIL = 7,
		[Token(Token = "0x400BA0E")]
		INVENTORY = 8,
		[Token(Token = "0x400BA0F")]
		BACKPACK = 9,
		[Token(Token = "0x400BA10")]
		ACTIVITY = 10,
		[Token(Token = "0x400BA11")]
		ACCOUNT = 11,
		[Token(Token = "0x400BA12")]
		CLAN = 12,
		[Token(Token = "0x400BA13")]
		PROFILE = 13,
		[Token(Token = "0x400BA14")]
		ROOM = 14,
		[Token(Token = "0x400BA15")]
		PRESENCE = 15,
		[Token(Token = "0x400BA16")]
		ELITEPASS = 16,
		[Token(Token = "0x400BA17")]
		RECONNECTION = 17,
		[Token(Token = "0x400BA18")]
		CHANNEL = 18,
		[Token(Token = "0x400BA19")]
		STORE = 19,
		[Token(Token = "0x400BA1A")]
		PET = 21,
		[Token(Token = "0x400BA1B")]
		MANUAL = 22,
		[Token(Token = "0x400BA1C")]
		CHAMPIONSHIP = 23,
		[Token(Token = "0x400BA1D")]
		ANTIADDICTION = 24,
		[Token(Token = "0x400BA1E")]
		FRESH = 25,
		[Token(Token = "0x400BA1F")]
		LINKAGE = 26,
		[Token(Token = "0x400BA20")]
		ATTENDANCE = 27,
		[Token(Token = "0x400BA21")]
		LIMITEDEVENT = 28,
		[Token(Token = "0x400BA22")]
		ANO = 29,
		[Token(Token = "0x400BA23")]
		CHAT = 30,
		[Token(Token = "0x400BA24")]
		CUP = 31,
		[Token(Token = "0x400BA25")]
		VIPCARD = 32,
		[Token(Token = "0x400BA26")]
		CHUMMY = 33,
		[Token(Token = "0x400BA27")]
		CREDITSCORE = 34,
		[Token(Token = "0x400BA28")]
		GAMESERVERMANAGER = 35,
		[Token(Token = "0x400BA29")]
		MINIGAME = 36,
		[Token(Token = "0x400BA2A")]
		WORKSHOP = 37
	}

	[Token(Token = "0x2001D7D")]
	public enum ProtoSize
	{
		[Token(Token = "0x400BA2C")]
		ProtoSize_NONE = 0,
		[Token(Token = "0x400BA2D")]
		MAXPACKETSIZE = 20480,
		[Token(Token = "0x400BA2E")]
		MAXMTPPACKETSIZE = 10240,
		[Token(Token = "0x400BA2F")]
		MAXUGCDEBUGPACKETSIZE = 1048576
	}

	[Token(Token = "0x6008A20")]
	[Address(RVA = "0x33E9210", Offset = "0x33E9210", VA = "0x33E9210")]
	public EProtocol()
	{
	}
}
