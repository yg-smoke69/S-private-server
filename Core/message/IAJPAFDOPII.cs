using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000DF6")]
public enum IAJPAFDOPII : uint
{
	[Token(Token = "0x4007357")]
	ESkillSyncStatus_StartCasting,
	[Token(Token = "0x4007358")]
	ESkillSyncStatus_StartEffecting,
	[Token(Token = "0x4007359")]
	ESkillSyncStatus_StopEffecting,
	[Token(Token = "0x400735A")]
	ESkillSyncStatus_BanActiveSkill,
	[Token(Token = "0x400735B")]
	ESkillSyncStatus_RefreshCoolDown
}
