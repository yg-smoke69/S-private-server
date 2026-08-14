using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200237D")]
internal class MaxSettingInfo
{
	[Token(Token = "0x400DCDE")]
	[FieldOffset(Offset = "0x8")]
	public int ShowLobbyState;

	[Token(Token = "0x400DCDF")]
	[FieldOffset(Offset = "0xC")]
	public bool loginVideoEnabled;

	[Token(Token = "0x400DCE0")]
	[FieldOffset(Offset = "0xD")]
	public bool useHDAnimation;

	[Token(Token = "0x400DCE1")]
	[FieldOffset(Offset = "0x10")]
	public EAudioEngineType audioEngine;

	[Token(Token = "0x400DCE2")]
	[FieldOffset(Offset = "0x14")]
	public EHDWeaponEffect hdWeaponEffect;

	[Token(Token = "0x400DCE3")]
	[FieldOffset(Offset = "0x18")]
	public bool lobbyMotion;

	[Token(Token = "0x400DCE4")]
	[FieldOffset(Offset = "0x1C")]
	public EHDTexture hdTexture;

	[Token(Token = "0x400DCE5")]
	[FieldOffset(Offset = "0x20")]
	public EHDVehicleVFX hdVehicleVFX;

	[Token(Token = "0x400DCE6")]
	[FieldOffset(Offset = "0x24")]
	public EHDShowMyLobby hdShowMyLobby;

	[Token(Token = "0x400DCE7")]
	[FieldOffset(Offset = "0x28")]
	public EHDShowCaptainLobby hdShowCaptainLobby;

	[Token(Token = "0x600C699")]
	[Address(RVA = "0x22745B0", Offset = "0x22745B0", VA = "0x22745B0")]
	public MaxSettingInfo()
	{
	}
}
