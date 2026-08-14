using Il2CppDummyDll;
using UnityEngine.Audio;

namespace GCommon;

[Token(Token = "0x2003E70")]
public class AudioMixerManager : SingletonModule<AudioMixerManager>
{
	[Token(Token = "0x401A652")]
	public const int AudioMixerGroup_None = -1;

	[Token(Token = "0x401A653")]
	public const int AudioMixerGroup_LobbyMusic = 0;

	[Token(Token = "0x401A654")]
	public const int AudioMixerGroup_CutScene = 1;

	[Token(Token = "0x401A655")]
	public const int AudioMixerGroup_ShopShow = 2;

	[Token(Token = "0x401A656")]
	public const int AudioMixerGroup_ShopShowWithBGM = 3;

	[Token(Token = "0x401A657")]
	public const int AudioMixerGroup_UI = 4;

	[Token(Token = "0x401A658")]
	public const int AudioMixerGroup_LobbyUserVoice = 5;

	[Token(Token = "0x401A659")]
	public const int AudioMixerGroup_CharacterVoice = 6;

	[Token(Token = "0x401A65A")]
	public const int AudioMixerGroup_Ingame_CharacterSpecial = 7;

	[Token(Token = "0x401A65B")]
	public const int AudioMixerGroup_Ingame_QucikChat = 8;

	[Token(Token = "0x401A65C")]
	private const int AudioMixerSnapshot_Default = 0;

	[Token(Token = "0x401A65D")]
	private const int AudioMixerSnapshot_CutScene = 1;

	[Token(Token = "0x401A65E")]
	private const int AudioMixerSnapshot_ShopShow = 2;

	[Token(Token = "0x401A65F")]
	private const int AudioMixerSnapshot_ShopShowWithBGM = 3;

	[Token(Token = "0x401A660")]
	private const int AudioMixerSnapshot_GolbalControl_VoCharacters_ReplaceChat = 4;

	[Token(Token = "0x401A661")]
	[FieldOffset(Offset = "0xC")]
	private AudioMixer m_Mixer;

	[Token(Token = "0x401A662")]
	[FieldOffset(Offset = "0x10")]
	private AudioMixerGroup[] m_Groups;

	[Token(Token = "0x401A663")]
	private const int GroupCount = 9;

	[Token(Token = "0x401A664")]
	[FieldOffset(Offset = "0x14")]
	private AudioMixerSnapshot[] m_Snapshots;

	[Token(Token = "0x401A665")]
	private const int SnapShotCount = 5;

	[Token(Token = "0x401A666")]
	[FieldOffset(Offset = "0x18")]
	private int m_SnapShotState;

	[Token(Token = "0x401A667")]
	[FieldOffset(Offset = "0x1C")]
	private int m_DefaultSnapshot;

	[Token(Token = "0x401A668")]
	private const float SnapshotFadeEffectTime = 0.2f;

	[Token(Token = "0x6019653")]
	[Address(RVA = "0x30773CC", Offset = "0x30773CC", VA = "0x30773CC")]
	public AudioMixerManager()
	{
	}

	[Token(Token = "0x6019654")]
	[Address(RVA = "0x307745C", Offset = "0x307745C", VA = "0x307745C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6019655")]
	[Address(RVA = "0x3077470", Offset = "0x3077470", VA = "0x3077470", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6019656")]
	[Address(RVA = "0x3077F74", Offset = "0x3077F74", VA = "0x3077F74")]
	public bool BindingWwiseBus()
	{
		return default(bool);
	}

	[Token(Token = "0x6019657")]
	[Address(RVA = "0x3077F84", Offset = "0x3077F84", VA = "0x3077F84")]
	public AudioMixerGroup GetAudioMixerGroup(int GroupID)
	{
		return null;
	}

	[Token(Token = "0x6019658")]
	[Address(RVA = "0x3077FD4", Offset = "0x3077FD4", VA = "0x3077FD4")]
	public bool IsInGameMixerGroup(int GroupID)
	{
		return default(bool);
	}

	[Token(Token = "0x6019659")]
	[Address(RVA = "0x3077FE8", Offset = "0x3077FE8", VA = "0x3077FE8")]
	public bool SwitchDefault()
	{
		return default(bool);
	}

	[Token(Token = "0x601965A")]
	[Address(RVA = "0x307812C", Offset = "0x307812C", VA = "0x307812C")]
	public bool SwitchCutScene()
	{
		return default(bool);
	}

	[Token(Token = "0x601965B")]
	[Address(RVA = "0x3078270", Offset = "0x3078270", VA = "0x3078270")]
	public bool SwitchShopShowNoBGM()
	{
		return default(bool);
	}

	[Token(Token = "0x601965C")]
	[Address(RVA = "0x30783B4", Offset = "0x30783B4", VA = "0x30783B4")]
	public bool SwitchShopShowWithBGM()
	{
		return default(bool);
	}

	[Token(Token = "0x601965D")]
	[Address(RVA = "0x30784F8", Offset = "0x30784F8", VA = "0x30784F8")]
	public bool SwitchQuickChat()
	{
		return default(bool);
	}
}
