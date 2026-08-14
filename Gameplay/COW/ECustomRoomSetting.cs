using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200300D")]
public enum ECustomRoomSetting : uint
{
	[Token(Token = "0x401247F")]
	ECustomRoomSetting_HideKillInfo = 1u,
	[Token(Token = "0x4012480")]
	ECustomRoomSetting_UnlimitedAmmo = 2u,
	[Token(Token = "0x4012481")]
	ECustomRoomSetting_NoFallingDamage = 4u,
	[Token(Token = "0x4012482")]
	ECustomRoomSetting_NoLoadout = 8u,
	[Token(Token = "0x4012483")]
	ECustomRoomSetting_NoAirdrop = 0x10u,
	[Token(Token = "0x4012484")]
	ECustomRoomSetting_NoSkill = 0x20u,
	[Token(Token = "0x4012485")]
	ECustomRoomSetting_NoVehicle = 0x40u,
	[Token(Token = "0x4012486")]
	ECustomRoomSetting_PlayerHP_Start = 0x100u,
	[Token(Token = "0x4012487")]
	ECustomRoomSetting_PlayerHP_End = 0x400u,
	[Token(Token = "0x4012488")]
	ECustomRoomSetting_PlayerEP_Start = 0x800u,
	[Token(Token = "0x4012489")]
	ECustomRoomSetting_PlayerEP_End = 0x2000u,
	[Token(Token = "0x401248A")]
	ECustomRoomSetting_PlayerSpeed_Start = 0x4000u,
	[Token(Token = "0x401248B")]
	ECustomRoomSetting_PlayerSpeed_End = 0x10000u,
	[Token(Token = "0x401248C")]
	ECustomRoomSetting_DropList_Start = 0x20000u,
	[Token(Token = "0x401248D")]
	ECustomRoomSetting_DropList_End = 0x100000u,
	[Token(Token = "0x401248E")]
	ECustomRoomSetting_PlayerJumpHeight_Start = 0x200000u,
	[Token(Token = "0x401248F")]
	ECustomRoomSetting_PlayerJumpHeight_End = 0x800000u,
	[Token(Token = "0x4012490")]
	ECustomRoomSetting_AccTotalStats = 0x1000000u,
	[Token(Token = "0x4012491")]
	ECustomRoomSetting_RoundNum_Start = 0x2000000u,
	[Token(Token = "0x4012492")]
	ECustomRoomSetting_RoundNum_End = 0x4000000u,
	[Token(Token = "0x4012493")]
	ECustomRoomSetting_InitCoin_Start = 0x8000000u,
	[Token(Token = "0x4012494")]
	ECustomRoomSetting_InitCoin_End = 0x10000000u,
	[Token(Token = "0x4012495")]
	ECustomRoomSetting_NoPowerGun = 0x20000000u,
	[Token(Token = "0x4012496")]
	ECustomRoomSetting_HideEnemyCloth = 0x40000000u
}
