using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200300E")]
public enum ECustomRoomSetting2 : uint
{
	[Token(Token = "0x4012498")]
	ECustomRoomSetting_NoUAV = 1u,
	[Token(Token = "0x4012499")]
	ECustomRoomSetting_NoBomb = 2u,
	[Token(Token = "0x401249A")]
	ECustomRoomSetting_Replay = 4u,
	[Token(Token = "0x401249B")]
	ECustomRoomSetting_NoZeppelin = 8u,
	[Token(Token = "0x401249C")]
	ECustomRoomSetting_NoHud = 0x10u,
	[Token(Token = "0x401249D")]
	ECustomRoomSetting_FriendDmg = 0x20u,
	[Token(Token = "0x401249E")]
	ECustomRoomSetting_FightClubRoundNum_Start = 0x40u,
	[Token(Token = "0x401249F")]
	ECustomRoomSetting_FightClubRoundNum_End = 0x80u,
	[Token(Token = "0x40124A0")]
	ECustomRoomSetting_ReviveSwitchStart = 0x100u,
	[Token(Token = "0x40124A1")]
	ECustomRoomSetting_ReviveSwitchEnd = 0x400u,
	[Token(Token = "0x40124A2")]
	ECustomRoomSetting_InGameChat = 0x800u,
	[Token(Token = "0x40124A3")]
	ECustomRoomSetting_ShopFlow = 0x1000u,
	[Token(Token = "0x40124A4")]
	ECustomRoomSetting_UseRandomMap = 0x2000u,
	[Token(Token = "0x40124A5")]
	ECustomRoomSetting_NoAuxAim = 0x4000u,
	[Token(Token = "0x40124A6")]
	ECustomRoomSetting_AutoRevival = 0x8000u,
	[Token(Token = "0x40124A7")]
	ECustomRoomSetting_SaveZoneSpeed = 0x10000u,
	[Token(Token = "0x40124A8")]
	ECustomRoomSetting_SaveZoneDamage = 0x20000u,
	[Token(Token = "0x40124A9")]
	ECustomRoomSetting_MatchStartBuff_Start = 0x40000u,
	[Token(Token = "0x40124AA")]
	ECustomRoomSetting_MatchStartBuff_End = 0x100000u,
	[Token(Token = "0x40124AB")]
	ECustomRoomSetting_GameMission = 0x200000u
}
