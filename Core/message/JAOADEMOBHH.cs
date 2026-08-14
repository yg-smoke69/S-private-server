using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000E0B")]
public enum JAOADEMOBHH : uint
{
	[Token(Token = "0x40073DA")]
	EInGameShopBuy_OK = 1u,
	[Token(Token = "0x40073DB")]
	EInGameShopBuy_TokenLack,
	[Token(Token = "0x40073DC")]
	EInGameShopBuy_CapacityLack,
	[Token(Token = "0x40073DD")]
	EInGameShopBuy_Limitation,
	[Token(Token = "0x40073DE")]
	EInGameShopBuy_Unknown,
	[Token(Token = "0x40073DF")]
	EInGameShopBuy_NoItemSelected,
	[Token(Token = "0x40073E0")]
	EInGameShopBuy_OutOfRange,
	[Token(Token = "0x40073E1")]
	EInGameShopBuy_ReviveCard,
	[Token(Token = "0x40073E2")]
	EInGameShopBuy_GameMissionCantBuild,
	[Token(Token = "0x40073E3")]
	EInGameShopBuy_GameMissionCantParallel,
	[Token(Token = "0x40073E4")]
	EInGameShopBuy_GameMissionNoTarget
}
