using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20003B1")]
public abstract class COWGameBase : BaseGame
{
	[Token(Token = "0x20003B2")]
	public enum GameType
	{
		[Token(Token = "0x40037CA")]
		FrontEndGame,
		[Token(Token = "0x40037CB")]
		MultiPlayerGame,
		[Token(Token = "0x40037CC")]
		SinglePlayerGame,
		[Token(Token = "0x40037CD")]
		TutorialGame,
		[Token(Token = "0x40037CE")]
		HotUpdaterGame,
		[Token(Token = "0x40037CF")]
		SceneEdit
	}

	[Token(Token = "0x20003B3")]
	public enum GameSubType
	{
		[Token(Token = "0x40037D1")]
		None,
		[Token(Token = "0x40037D2")]
		WaitingGame,
		[Token(Token = "0x40037D3")]
		BattleGame
	}

	[Token(Token = "0x20003B4")]
	public enum GameModeType
	{
		[Token(Token = "0x40037D5")]
		All,
		[Token(Token = "0x40037D6")]
		PVP,
		[Token(Token = "0x40037D7")]
		PVE
	}

	[Token(Token = "0x20003B5")]
	public enum GameMode : uint
	{
		[Token(Token = "0x40037D9")]
		GameModeNone = 0u,
		[Token(Token = "0x40037DA")]
		GameModeBattleRoyale = 1u,
		[Token(Token = "0x40037DB")]
		GameModeSpeedRoyale = 2u,
		[Token(Token = "0x40037DC")]
		GameModeFateRoyale = 3u,
		[Token(Token = "0x40037DD")]
		GameModeSpeedRoyaleZombie = 4u,
		[Token(Token = "0x40037DE")]
		GameModeSVZombie = 102u,
		[Token(Token = "0x40037DF")]
		GameModeBattleRoyaleZombie = 7u,
		[Token(Token = "0x40037E0")]
		GameModePurge = 12u,
		[Token(Token = "0x40037E1")]
		GameModeSnowMan = 25u,
		[Token(Token = "0x40037E2")]
		GameModeReborn = 13u,
		[Token(Token = "0x40037E3")]
		GameModeCS = 15u,
		[Token(Token = "0x40037E4")]
		GameModeTK = 22u,
		[Token(Token = "0x40037E5")]
		GameModePVEHyakki = 101u,
		[Token(Token = "0x40037E6")]
		GameModeTDM = 24u,
		[Token(Token = "0x40037E7")]
		GameModeTraining = 23u,
		[Token(Token = "0x40037E8")]
		GameModeWerewolves = 37u,
		[Token(Token = "0x40037E9")]
		GameModeReaper = 30u,
		[Token(Token = "0x40037EA")]
		GameModeGiant = 29u,
		[Token(Token = "0x40037EB")]
		GameModeTutorialBR = 40u,
		[Token(Token = "0x40037EC")]
		GameModeTutorialCS = 41u,
		[Token(Token = "0x40037ED")]
		GameModeHardCoreCS = 52u,
		[Token(Token = "0x40037EE")]
		GameModeSingerB = 56u,
		[Token(Token = "0x40037EF")]
		GameModeInfection = 58u
	}

	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x1815DA4", Offset = "0x1815DA4", VA = "0x1815DA4")]
	protected COWGameBase()
	{
	}

	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x1815E28", Offset = "0x1815E28", VA = "0x1815E28")]
	public static bool IsMatchGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x1815FE4", Offset = "0x1815FE4", VA = "0x1815FE4", Slot = "8")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x1816104", Offset = "0x1816104", VA = "0x1816104", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x18161F8", Offset = "0x18161F8", VA = "0x18161F8", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x1816340", Offset = "0x1816340", VA = "0x1816340")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x1816348", Offset = "0x1816348", VA = "0x1816348")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x1816350", Offset = "0x1816350", VA = "0x1816350")]
	public void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}
}
