using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;
using WwiseGameSyncs;

namespace GCommon;

[Token(Token = "0x2003E5A")]
public class AudioEngine_Wwise : _Attribute
{
	[Token(Token = "0x2003E5B")]
	private class AkBankResource
	{
		[Token(Token = "0x401A5E5")]
		[FieldOffset(Offset = "0x8")]
		public ResourceID BankResID;

		[Token(Token = "0x401A5E6")]
		[FieldOffset(Offset = "0xC")]
		public uint BankID;

		[Token(Token = "0x401A5E7")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr InMemoryBankPtr;

		[Token(Token = "0x401A5E8")]
		[FieldOffset(Offset = "0x14")]
		public GCHandle PinnedArray;

		[Token(Token = "0x60195C9")]
		[Address(RVA = "0x306DE3C", Offset = "0x306DE3C", VA = "0x306DE3C")]
		public AkBankResource()
		{
		}
	}

	[Token(Token = "0x2003E5C")]
	private class AudioEventRunningInfo
	{
		[Token(Token = "0x401A5E9")]
		[FieldOffset(Offset = "0x8")]
		public GameObject OwnedObject;

		[Token(Token = "0x401A5EA")]
		[FieldOffset(Offset = "0xC")]
		public AudioEvent EventInfo;

		[Token(Token = "0x401A5EB")]
		[FieldOffset(Offset = "0x10")]
		public AudioResWithCallBack_Wwise WwiseAudioRes;

		[Token(Token = "0x401A5EC")]
		[FieldOffset(Offset = "0x14")]
		public bool NeedAutoCollect;

		[Token(Token = "0x60195CA")]
		[Address(RVA = "0x306DEE4", Offset = "0x306DEE4", VA = "0x306DEE4")]
		public AudioEventRunningInfo()
		{
		}
	}

	[Token(Token = "0x401A5D1")]
	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16L;

	[Token(Token = "0x401A5D2")]
	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15L;

	[Token(Token = "0x401A5D3")]
	[FieldOffset(Offset = "0x0")]
	private static CallbackFlags END_FLAG;

	[Token(Token = "0x401A5D4")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, AkBankResource> m_LoadedBankRes;

	[Token(Token = "0x401A5D5")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ResourceID, string> m_LoadedBankNameMaps;

	[Token(Token = "0x401A5D6")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ResourceID, AudioEvent> m_LoadedAudioEvent;

	[Token(Token = "0x401A5D7")]
	[FieldOffset(Offset = "0x14")]
	private ObjectPool<AudioResource_Wwise> m_AudioResourcePool;

	[Token(Token = "0x401A5D8")]
	[FieldOffset(Offset = "0x18")]
	private ObjectPool<AudioResWithCallBack_Wwise> m_AudioResourceCallBackPool;

	[Token(Token = "0x401A5D9")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<AudioResWithCallBack_Wwise> m_PlayingAudioResCallBack;

	[Token(Token = "0x401A5DA")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<GameObject, AudioEvent> m_LoopEventMap;

	[Token(Token = "0x401A5DB")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<GameObject, AudioEvent> m_3DShotEventMap;

	[Token(Token = "0x401A5DC")]
	[FieldOffset(Offset = "0x28")]
	private bool _003CMusicOn_003Ek__BackingField;

	[Token(Token = "0x401A5DD")]
	[FieldOffset(Offset = "0x29")]
	private bool _003CSoundEffectOn_003Ek__BackingField;

	[Token(Token = "0x401A5DE")]
	[FieldOffset(Offset = "0x2C")]
	private float _003CMusicVolume_003Ek__BackingField;

	[Token(Token = "0x401A5DF")]
	[FieldOffset(Offset = "0x30")]
	private float _003CSoundEffectVolume_003Ek__BackingField;

	[Token(Token = "0x401A5E0")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_OwnedObject;

	[Token(Token = "0x401A5E1")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_WwiseGlobal;

	[Token(Token = "0x401A5E2")]
	[FieldOffset(Offset = "0x3C")]
	private Camera m_CurrentMainCamera;

	[Token(Token = "0x401A5E3")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsCameraModified;

	[Token(Token = "0x401A5E4")]
	[FieldOffset(Offset = "0x44")]
	public GameObject m_GlobalObj;

	[Token(Token = "0x17001BB0")]
	public bool MusicOn
	{
		[Token(Token = "0x601958A")]
		[Address(RVA = "0x26BF2A8", Offset = "0x26BF2A8", VA = "0x26BF2A8", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601958B")]
		[Address(RVA = "0x26BF2B0", Offset = "0x26BF2B0", VA = "0x26BF2B0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BB1")]
	public bool SoundEffectOn
	{
		[Token(Token = "0x601958C")]
		[Address(RVA = "0x26BF2B8", Offset = "0x26BF2B8", VA = "0x26BF2B8", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601958D")]
		[Address(RVA = "0x26BF2C0", Offset = "0x26BF2C0", VA = "0x26BF2C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BB2")]
	public float MusicVolume
	{
		[Token(Token = "0x601958E")]
		[Address(RVA = "0x26BF2C8", Offset = "0x26BF2C8", VA = "0x26BF2C8", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601958F")]
		[Address(RVA = "0x26BF2D0", Offset = "0x26BF2D0", VA = "0x26BF2D0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BB3")]
	public float SoundEffectVolume
	{
		[Token(Token = "0x6019590")]
		[Address(RVA = "0x26BF2D8", Offset = "0x26BF2D8", VA = "0x26BF2D8", Slot = "7")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019591")]
		[Address(RVA = "0x26BF2E0", Offset = "0x26BF2E0", VA = "0x26BF2E0")]
		private set
		{
		}
	}

	[Token(Token = "0x6019589")]
	[Address(RVA = "0x26BF0CC", Offset = "0x26BF0CC", VA = "0x26BF0CC")]
	public AudioEngine_Wwise()
	{
	}

	[Token(Token = "0x6019592")]
	[Address(RVA = "0x26BF2E8", Offset = "0x26BF2E8", VA = "0x26BF2E8", Slot = "33")]
	public void CancelCurrentMusicFadeEffect()
	{
	}

	[Token(Token = "0x6019593")]
	[Address(RVA = "0x26BF370", Offset = "0x26BF370", VA = "0x26BF370", Slot = "8")]
	public void Init(GameObject owned_object)
	{
	}

	[Token(Token = "0x6019594")]
	[Address(RVA = "0x26BF48C", Offset = "0x26BF48C", VA = "0x26BF48C")]
	public void SetMainCamera(Camera _camera)
	{
	}

	[Token(Token = "0x6019595")]
	[Address(RVA = "0x26BFBC0", Offset = "0x26BFBC0", VA = "0x26BFBC0")]
	public void ResetCameraModifyFlag()
	{
	}

	[Token(Token = "0x6019596")]
	[Address(RVA = "0x26BF5D0", Offset = "0x26BF5D0", VA = "0x26BF5D0")]
	private void ClearListener(Camera _camera)
	{
	}

	[Token(Token = "0x6019597")]
	[Address(RVA = "0x26BF8A8", Offset = "0x26BF8A8", VA = "0x26BF8A8")]
	private void AddListener(Camera _camera)
	{
	}

	[Token(Token = "0x6019598")]
	[Address(RVA = "0x26BFBCC", Offset = "0x26BFBCC", VA = "0x26BFBCC", Slot = "30")]
	public bool IsCurMusicPlayThisID(ResourceID AudioID)
	{
		return default(bool);
	}

	[Token(Token = "0x6019599")]
	[Address(RVA = "0x26BFBD4", Offset = "0x26BFBD4", VA = "0x26BFBD4", Slot = "15")]
	public void OnGameDestory()
	{
	}

	[Token(Token = "0x601959A")]
	[Address(RVA = "0x26C0054", Offset = "0x26C0054", VA = "0x26C0054", Slot = "14")]
	public void OnSettingChanged()
	{
	}

	[Token(Token = "0x601959B")]
	[Address(RVA = "0x26C0058", Offset = "0x26C0058", VA = "0x26C0058")]
	private GameObject Get2DSoundObject()
	{
		return null;
	}

	[Token(Token = "0x601959C")]
	[Address(RVA = "0x26C012C", Offset = "0x26C012C", VA = "0x26C012C", Slot = "19")]
	public AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
	{
		return null;
	}

	[Token(Token = "0x601959D")]
	[Address(RVA = "0x26C01A4", Offset = "0x26C01A4", VA = "0x26C01A4")]
	public AudioResource Play2DLoopStartWithSwitch(ResourceID sound, SwitchBase[] switches)
	{
		return null;
	}

	[Token(Token = "0x601959E")]
	[Address(RVA = "0x26C0B54", Offset = "0x26C0B54", VA = "0x26C0B54", Slot = "20")]
	public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumnChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x601959F")]
	[Address(RVA = "0x26C0D48", Offset = "0x26C0D48", VA = "0x26C0D48")]
	public void Set2DWwiseGroupValue(GroupBase[] groups)
	{
	}

	[Token(Token = "0x60195A0")]
	[Address(RVA = "0x26C0FA8", Offset = "0x26C0FA8", VA = "0x26C0FA8")]
	public void Set3DWwiseGroupValue(GameObject owned_object, GroupBase[] groups)
	{
	}

	[Token(Token = "0x60195A1")]
	[Address(RVA = "0x26C1248", Offset = "0x26C1248", VA = "0x26C1248", Slot = "21")]
	public GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
	{
		return null;
	}

	[Token(Token = "0x60195A2")]
	[Address(RVA = "0x26C12D0", Offset = "0x26C12D0", VA = "0x26C12D0")]
	public GameObject Payer3DLoopStartWithSwitch(ResourceID sound, Transform parent, SwitchBase[] switches)
	{
		return null;
	}

	[Token(Token = "0x60195A3")]
	[Address(RVA = "0x26C14EC", Offset = "0x26C14EC", VA = "0x26C14EC", Slot = "22")]
	public void Play3DLoopStop(GameObject audioSourceObj)
	{
	}

	[Token(Token = "0x60195A4")]
	[Address(RVA = "0x26C1830", Offset = "0x26C1830", VA = "0x26C1830")]
	public void PostAudioEventByResID(ResourceID sound_event, ref GameObject audio_go, Transform audio_parent, bool need_end_callback = false, bool need_auto_collect = false, SwitchBase[] switches)
	{
	}

	[Token(Token = "0x60195A5")]
	[Address(RVA = "0x26C1A20", Offset = "0x26C1A20", VA = "0x26C1A20")]
	public void Post3DAudioEventByResID(ResourceID sound_event, ref GameObject audio_go, Transform audio_parent, bool need_end_callback = false, bool need_auto_collect = false, SwitchBase[] switches)
	{
	}

	[Token(Token = "0x60195A6")]
	[Address(RVA = "0x26C1BF0", Offset = "0x26C1BF0", VA = "0x26C1BF0")]
	public void StopAllAudioEventByGameObject(GameObject audioSourceObj, bool need_collect_object = true)
	{
	}

	[Token(Token = "0x60195A7")]
	[Address(RVA = "0x26C1D7C", Offset = "0x26C1D7C", VA = "0x26C1D7C")]
	public GameObject Play3DShotWithSwitch(ResourceID sound, Vector3 worldPos, [Optional] GameObject owned_object, bool isStopable = false, SwitchBase[] switches)
	{
		return null;
	}

	[Token(Token = "0x60195A8")]
	[Address(RVA = "0x26C21A0", Offset = "0x26C21A0", VA = "0x26C21A0", Slot = "16")]
	public GameObject Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x60195A9")]
	[Address(RVA = "0x26C2244", Offset = "0x26C2244", VA = "0x26C2244", Slot = "17")]
	public GameObject Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x60195AA")]
	[Address(RVA = "0x26C2334", Offset = "0x26C2334", VA = "0x26C2334", Slot = "18")]
	public void Stop3DShot(GameObject gameObject)
	{
	}

	[Token(Token = "0x60195AB")]
	[Address(RVA = "0x26C247C", Offset = "0x26C247C", VA = "0x26C247C", Slot = "32")]
	public void PlayCurrentMusicFadeEffect(float targetvolume, bool need_override = false)
	{
	}

	[Token(Token = "0x60195AC")]
	[Address(RVA = "0x26C2480", Offset = "0x26C2480", VA = "0x26C2480", Slot = "27")]
	public void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, bool isNeedUnloadAudioData = false, float startTime = 0f, bool noCache = false)
	{
	}

	[Token(Token = "0x60195AD")]
	[Address(RVA = "0x26C2550", Offset = "0x26C2550", VA = "0x26C2550", Slot = "28")]
	public AudioSource GetCurMusic()
	{
		return null;
	}

	[Token(Token = "0x60195AE")]
	[Address(RVA = "0x26C2558", Offset = "0x26C2558", VA = "0x26C2558")]
	private AudioResWithCallBack_Wwise AllocaAudioResource(ResourceID sound, AudioEndInternalCallBack callBack)
	{
		return null;
	}

	[Token(Token = "0x60195AF")]
	[Address(RVA = "0x26C25F0", Offset = "0x26C25F0", VA = "0x26C25F0", Slot = "24")]
	public AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x60195B0")]
	[Address(RVA = "0x26C2800", Offset = "0x26C2800", VA = "0x26C2800", Slot = "29")]
	public void StopOneShotWithCallBack(AudioResWithCallBackBase resource)
	{
	}

	[Token(Token = "0x60195B1")]
	[Address(RVA = "0x26C2994", Offset = "0x26C2994", VA = "0x26C2994", Slot = "23")]
	public GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x60195B2")]
	[Address(RVA = "0x26C2AD0", Offset = "0x26C2AD0", VA = "0x26C2AD0")]
	public GameObject PlayOneShotWithSwitch(ResourceID sound, [Optional] GameObject owned_object, SwitchBase[] switches)
	{
		return null;
	}

	[Token(Token = "0x60195B3")]
	[Address(RVA = "0x26C2D28", Offset = "0x26C2D28", VA = "0x26C2D28")]
	public void PreloadResByAudioEvent(ResourceID event_res, out bool is_preloaded, out Object loaded_object)
	{
	}

	[Token(Token = "0x60195B4")]
	[Address(RVA = "0x26C0320", Offset = "0x26C0320", VA = "0x26C0320")]
	private AudioEvent PostEventWithResIDInternal(ResourceID sound_event, GameObject target_object, bool need_end_callback = false, bool need_auto_collect = false, [Optional] List<SwitchBase> switch_groups, [Optional] AudioResWithCallBack_Wwise wwise_res, float audio_volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x60195B5")]
	[Address(RVA = "0x26C305C", Offset = "0x26C305C", VA = "0x26C305C")]
	private void OnEventCallBack(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	[Token(Token = "0x60195B6")]
	[Address(RVA = "0x26C3250", Offset = "0x26C3250", VA = "0x26C3250", Slot = "9")]
	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x60195B7")]
	[Address(RVA = "0x26C33C0", Offset = "0x26C33C0", VA = "0x26C33C0", Slot = "10")]
	public void SetMusicOn(bool v)
	{
	}

	[Token(Token = "0x60195B8")]
	[Address(RVA = "0x26C34C8", Offset = "0x26C34C8", VA = "0x26C34C8", Slot = "11")]
	public void SetMusicVolume(float v)
	{
	}

	[Token(Token = "0x60195B9")]
	[Address(RVA = "0x26C3578", Offset = "0x26C3578", VA = "0x26C3578", Slot = "13")]
	public void SetSoundEffectOn(bool v)
	{
	}

	[Token(Token = "0x60195BA")]
	[Address(RVA = "0x26C3680", Offset = "0x26C3680", VA = "0x26C3680")]
	public void SetRTPCValueGlobal(WwiseGameSyncID rtpc_id, float value)
	{
	}

	[Token(Token = "0x60195BB")]
	[Address(RVA = "0x26C3748", Offset = "0x26C3748", VA = "0x26C3748")]
	public void SetSwitch(SwitchBase _switchBase, GameObject[] gameobject_list)
	{
	}

	[Token(Token = "0x60195BC")]
	[Address(RVA = "0x26C38E4", Offset = "0x26C38E4", VA = "0x26C38E4")]
	public void SetRTPCValue(WwiseGameSyncID rtpc_id, float value, GameObject[] gameobject_list)
	{
	}

	[Token(Token = "0x60195BD")]
	[Address(RVA = "0x26C3A4C", Offset = "0x26C3A4C", VA = "0x26C3A4C", Slot = "12")]
	public void SetSoundEffectVolume(float v)
	{
	}

	[Token(Token = "0x60195BE")]
	[Address(RVA = "0x26C3AFC", Offset = "0x26C3AFC", VA = "0x26C3AFC", Slot = "31")]
	public void StopMusic(bool fadeOutCurrent = true, float volChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x60195BF")]
	[Address(RVA = "0x26C3C2C", Offset = "0x26C3C2C", VA = "0x26C3C2C", Slot = "25")]
	public void StopPlayShot()
	{
	}

	[Token(Token = "0x60195C0")]
	[Address(RVA = "0x26C3C30", Offset = "0x26C3C30", VA = "0x26C3C30", Slot = "26")]
	public void StopPlayShot(GameObject go)
	{
	}

	[Token(Token = "0x60195C1")]
	[Address(RVA = "0x26C3CF8", Offset = "0x26C3CF8", VA = "0x26C3CF8")]
	private uint AllocateAlignedBuffer(byte[] data, AkBankResource bank_res)
	{
		return default(uint);
	}

	[Token(Token = "0x60195C2")]
	[Address(RVA = "0x26C401C", Offset = "0x26C401C", VA = "0x26C401C")]
	public AKRESULT LoadAudioBank(string bank_name, ResourceID bank_res_id, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195C3")]
	[Address(RVA = "0x26C4454", Offset = "0x26C4454", VA = "0x26C4454")]
	public AKRESULT LoadAndDecodeAudioBank(string bank_name, ResourceID bank_res_id, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195C4")]
	[Address(RVA = "0x26C48A8", Offset = "0x26C48A8", VA = "0x26C48A8")]
	public AKRESULT UnLoadAudioBank(string bank_name)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60195C5")]
	[Address(RVA = "0x26C4AEC", Offset = "0x26C4AEC", VA = "0x26C4AEC", Slot = "34")]
	public void UnloadAudio(ResourceID soundID)
	{
	}

	[Token(Token = "0x60195C6")]
	[Address(RVA = "0x26C4AF0", Offset = "0x26C4AF0", VA = "0x26C4AF0")]
	public void RemoveAudioBankRecord(string bank_name)
	{
	}

	[Token(Token = "0x60195C7")]
	[Address(RVA = "0x26C4BD4", Offset = "0x26C4BD4", VA = "0x26C4BD4", Slot = "35")]
	public void UnloadAudiosByABPath(string ab_path)
	{
	}
}
