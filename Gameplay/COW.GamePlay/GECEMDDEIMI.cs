using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000CFA")]
public enum GECEMDDEIMI : byte
{
	[Token(Token = "0x4006907")]
	OnLand = 0,
	[Token(Token = "0x4006908")]
	InWater = 1,
	[Token(Token = "0x4006909")]
	ParachuteJump = 2,
	[Token(Token = "0x400690A")]
	MissileLauncher = 4,
	[Token(Token = "0x400690B")]
	MachineGun = 8,
	[Token(Token = "0x400690C")]
	ShapeMask = 63,
	[Token(Token = "0x400690D")]
	Jump = 64,
	[Token(Token = "0x400690E")]
	Boost = 128
}
