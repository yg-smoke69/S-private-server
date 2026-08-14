using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CA3")]
public class UGCRunnerManager
{
	[Token(Token = "0x4006745")]
	[FieldOffset(Offset = "0x8")]
	private IUGCRunner<HEAABFEMIDG> m_MapRunner;

	[Token(Token = "0x4006746")]
	[FieldOffset(Offset = "0xC")]
	private IUGCRunner<HBLLODDOMEH> m_HudRunner;

	[Token(Token = "0x4006747")]
	[FieldOffset(Offset = "0x10")]
	private KEMMDGJBJNO _003CSceneBuilder_003Ek__BackingField;

	[Token(Token = "0x4006748")]
	[FieldOffset(Offset = "0x14")]
	private bool _003CHasCreatedAllEntityFromData_003Ek__BackingField;

	[Token(Token = "0x1700080B")]
	public KEMMDGJBJNO SceneBuilder
	{
		[Token(Token = "0x6006060")]
		[Address(RVA = "0x258A558", Offset = "0x258A558", VA = "0x258A558")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006061")]
		[Address(RVA = "0x258C9CC", Offset = "0x258C9CC", VA = "0x258C9CC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700080C")]
	public bool HasCreatedAllEntityFromData
	{
		[Token(Token = "0x6006062")]
		[Address(RVA = "0x258C9D4", Offset = "0x258C9D4", VA = "0x258C9D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006063")]
		[Address(RVA = "0x258A560", Offset = "0x258A560", VA = "0x258A560")]
		set
		{
		}
	}

	[Token(Token = "0x600605F")]
	[Address(RVA = "0x258C940", Offset = "0x258C940", VA = "0x258C940")]
	public UGCRunnerManager(IUGCRunner<HEAABFEMIDG> mapRunner, IUGCRunner<HBLLODDOMEH> hudRunner)
	{
	}

	[Token(Token = "0x6006064")]
	[Address(RVA = "0x258C9DC", Offset = "0x258C9DC", VA = "0x258C9DC")]
	public bool LoadRunners(byte[] runtimeDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6006065")]
	[Address(RVA = "0x258CCFC", Offset = "0x258CCFC", VA = "0x258CCFC")]
	public bool UnloadRunners()
	{
		return default(bool);
	}
}
