using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20003F3")]
internal class AudioConfigDataManager : SingletonModule<AudioConfigDataManager>
{
	[Token(Token = "0x40039D3")]
	public const string DEFAULT_INGAME_CONFIGNAME = "default_ingame";

	[Token(Token = "0x40039D4")]
	[FieldOffset(Offset = "0xC")]
	private HashSet<ResourceID> m_AllKillSound;

	[Token(Token = "0x40039D5")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, List<AssistantAudioData>> m_AssistAudioConfigMap;

	[Token(Token = "0x40039D6")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, Dictionary<string, List<AssistantAudioData>>> m_multiLanguageAssistAudioConfigMap;

	[Token(Token = "0x40039D7")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<ResourceID, ResourceID> m_AudioEventMap;

	[Token(Token = "0x6001294")]
	[Address(RVA = "0x14CF85C", Offset = "0x14CF85C", VA = "0x14CF85C")]
	public AudioConfigDataManager()
	{
	}

	[Token(Token = "0x6001295")]
	[Address(RVA = "0x14CF9BC", Offset = "0x14CF9BC", VA = "0x14CF9BC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6001296")]
	[Address(RVA = "0x14CFAD4", Offset = "0x14CFAD4", VA = "0x14CFAD4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6001297")]
	[Address(RVA = "0x14D13E8", Offset = "0x14D13E8", VA = "0x14D13E8")]
	public bool IsKillSound(ResourceID resourceID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001298")]
	[Address(RVA = "0x14D1514", Offset = "0x14D1514", VA = "0x14D1514")]
	public List<AssistantAudioData> GetAssistantAudioDataByAvatarID(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6001299")]
	[Address(RVA = "0x14D1608", Offset = "0x14D1608", VA = "0x14D1608")]
	public List<AssistantAudioData> GetAssistantAudioDataByAvatarIDAndLanguage(uint avatarID, string laguage, bool needCheck = false)
	{
		return null;
	}

	[Token(Token = "0x600129A")]
	[Address(RVA = "0x14D1994", Offset = "0x14D1994", VA = "0x14D1994")]
	public bool GetAudioEventByAudioRes(ResourceID audio_res, out ResourceID event_res)
	{
		return default(bool);
	}

	[Token(Token = "0x600129B")]
	[Address(RVA = "0x14D1AFC", Offset = "0x14D1AFC", VA = "0x14D1AFC")]
	public void SetAudioEventByAudioRes(ResourceID audio_res, ResourceID event_res)
	{
	}
}
