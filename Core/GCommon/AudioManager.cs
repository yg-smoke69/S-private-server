using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E68")]
public class AudioManager : MonoBehaviour
{
	[Token(Token = "0x2003E69")]
	public delegate void AudioEndCallBack(bool end_by_cancle, ResourceID res_id);

	[Token(Token = "0x2003E6A")]
	public class AudioRecordInfo
	{
		[Token(Token = "0x401A638")]
		[FieldOffset(Offset = "0x8")]
		public ERecordInfo InfoType;

		[Token(Token = "0x401A639")]
		[FieldOffset(Offset = "0xC")]
		public GameObject OwnedObject;

		[Token(Token = "0x401A63A")]
		[FieldOffset(Offset = "0x10")]
		public AudioResource OwnedResource;

		[Token(Token = "0x401A63B")]
		[FieldOffset(Offset = "0x14")]
		public EAudioEngineType EngineType;

		[Token(Token = "0x401A63C")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID AudioID;

		[Token(Token = "0x601964A")]
		[Address(RVA = "0x3070B28", Offset = "0x3070B28", VA = "0x3070B28")]
		public AudioRecordInfo()
		{
		}
	}

	[Token(Token = "0x2003E6B")]
	public enum ERecordInfo
	{
		[Token(Token = "0x401A63E")]
		eOneShot,
		[Token(Token = "0x401A63F")]
		e2DLoop,
		[Token(Token = "0x401A640")]
		e3DLoop,
		[Token(Token = "0x401A641")]
		eMusic
	}

	[Token(Token = "0x2003E6C")]
	private enum EAudioType
	{
		[Token(Token = "0x401A643")]
		eOneShot,
		[Token(Token = "0x401A644")]
		e2DLoop,
		[Token(Token = "0x401A645")]
		e3DLoop
	}

	[Token(Token = "0x2003E6D")]
	private class AudioInfo
	{
		[Token(Token = "0x401A646")]
		[FieldOffset(Offset = "0x8")]
		public EAudioType InfoType;

		[Token(Token = "0x401A647")]
		[FieldOffset(Offset = "0xC")]
		public AudioResWithCallBackBase OwnedResource;

		[Token(Token = "0x401A648")]
		[FieldOffset(Offset = "0x10")]
		public EAudioEngineType EngineType;

		[Token(Token = "0x401A649")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID AudioID;

		[Token(Token = "0x401A64A")]
		[FieldOffset(Offset = "0x18")]
		public AudioEndCallBack EndCallBack;

		[Token(Token = "0x601964B")]
		[Address(RVA = "0x3077250", Offset = "0x3077250", VA = "0x3077250")]
		public AudioInfo()
		{
		}
	}

	[Token(Token = "0x2003E6E")]
	private class AudioChannel
	{
		[Token(Token = "0x401A64B")]
		[FieldOffset(Offset = "0x8")]
		public bool m_IsSingle;

		[Token(Token = "0x401A64C")]
		[FieldOffset(Offset = "0xC")]
		private List<AudioInfo> m_CurPlayingAudiolist;

		[Token(Token = "0x601964C")]
		[Address(RVA = "0x3072168", Offset = "0x3072168", VA = "0x3072168")]
		public AudioChannel(bool is_single)
		{
		}

		[Token(Token = "0x601964D")]
		[Address(RVA = "0x3076D60", Offset = "0x3076D60", VA = "0x3076D60")]
		public void OnAudioEnd(AudioResWithCallBackBase audio_resource)
		{
		}

		[Token(Token = "0x601964E")]
		[Address(RVA = "0x3074CE0", Offset = "0x3074CE0", VA = "0x3074CE0")]
		public void PlayOneShot(ResourceID sound, AudioEndCallBack callBack, float volume = 1f, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		[Token(Token = "0x601964F")]
		[Address(RVA = "0x3076260", Offset = "0x3076260", VA = "0x3076260")]
		public void StopChannelAudio()
		{
		}

		[Token(Token = "0x6019650")]
		[Address(RVA = "0x307717C", Offset = "0x307717C", VA = "0x307717C")]
		private void StopAudioWithInfo(AudioInfo info)
		{
		}

		[Token(Token = "0x6019651")]
		[Address(RVA = "0x3076428", Offset = "0x3076428", VA = "0x3076428")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6019652")]
		[Address(RVA = "0x3071520", Offset = "0x3071520", VA = "0x3071520")]
		public void Clean()
		{
		}
	}

	[Token(Token = "0x401A628")]
	[FieldOffset(Offset = "0x0")]
	private static AudioEngine_Unity m_UnityEngine;

	[Token(Token = "0x401A629")]
	[FieldOffset(Offset = "0x4")]
	private static AudioManager m_Instance;

	[Token(Token = "0x401A62A")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, IAudioEngine> m_AudioEngineMap;

	[Token(Token = "0x401A62B")]
	[FieldOffset(Offset = "0xC")]
	public static bool EnableMaxDistCheckForDefaultAudioSource;

	[Token(Token = "0x401A62C")]
	[FieldOffset(Offset = "0x10")]
	public static ResourceID DefaultAudioSourceId;

	[Token(Token = "0x401A62D")]
	[FieldOffset(Offset = "0x14")]
	public static float MaxDistForDefaultAudioSource;

	[Token(Token = "0x401A62E")]
	[FieldOffset(Offset = "0xC")]
	private GAGILKKDDMJ m_Quality;

	[Token(Token = "0x401A62F")]
	[FieldOffset(Offset = "0x18")]
	private static bool s_EnableAsyncLoadForLowest;

	[Token(Token = "0x401A630")]
	[FieldOffset(Offset = "0x19")]
	private static bool s_EnableAsyncLoadForLow;

	[Token(Token = "0x401A631")]
	[FieldOffset(Offset = "0x1A")]
	private static bool s_EnableAsyncLoadForUltra;

	[Token(Token = "0x401A632")]
	[FieldOffset(Offset = "0x1C")]
	private static float s_AsyncLoadMaxDelay;

	[Token(Token = "0x401A633")]
	[FieldOffset(Offset = "0x20")]
	private static float m_KillSoundEffectVolume;

	[Token(Token = "0x401A634")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, AudioRecordInfo> m_PlayingSound;

	[Token(Token = "0x401A635")]
	[FieldOffset(Offset = "0x14")]
	private AudioRecordInfo m_CurPlayingMusic;

	[Token(Token = "0x401A636")]
	[FieldOffset(Offset = "0x18")]
	private AudioChannel[] m_ChannelMap;

	[Token(Token = "0x401A637")]
	[FieldOffset(Offset = "0x1C")]
	private EAudioEngineType m_DefaultEngineType;

	[Token(Token = "0x17001BB5")]
	public static AudioManager instance
	{
		[Token(Token = "0x6019608")]
		[Address(RVA = "0x306E5DC", Offset = "0x306E5DC", VA = "0x306E5DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BB6")]
	public bool MusicOn
	{
		[Token(Token = "0x6019609")]
		[Address(RVA = "0x3070B30", Offset = "0x3070B30", VA = "0x3070B30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BB7")]
	public bool SoundEffectOn
	{
		[Token(Token = "0x601960A")]
		[Address(RVA = "0x3070BD8", Offset = "0x3070BD8", VA = "0x3070BD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BB8")]
	public float MusicVolume
	{
		[Token(Token = "0x601960B")]
		[Address(RVA = "0x306E668", Offset = "0x306E668", VA = "0x306E668")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BB9")]
	public float SoundEffectVolume
	{
		[Token(Token = "0x601960C")]
		[Address(RVA = "0x3070C80", Offset = "0x3070C80", VA = "0x3070C80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BBA")]
	public EAudioEngineType DefaultEngineType
	{
		[Token(Token = "0x601960D")]
		[Address(RVA = "0x3070D28", Offset = "0x3070D28", VA = "0x3070D28")]
		get
		{
			return default(EAudioEngineType);
		}
		[Token(Token = "0x601960E")]
		[Address(RVA = "0x3070D30", Offset = "0x3070D30", VA = "0x3070D30")]
		set
		{
		}
	}

	[Token(Token = "0x6019607")]
	[Address(RVA = "0x3070A10", Offset = "0x3070A10", VA = "0x3070A10")]
	public AudioManager()
	{
	}

	[Token(Token = "0x601960F")]
	[Address(RVA = "0x3071794", Offset = "0x3071794", VA = "0x3071794")]
	public bool UsedWwiseSound()
	{
		return default(bool);
	}

	[Token(Token = "0x6019610")]
	[Address(RVA = "0x30717A4", Offset = "0x30717A4", VA = "0x30717A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019611")]
	[Address(RVA = "0x3071D3C", Offset = "0x3071D3C", VA = "0x3071D3C")]
	public static void SetAsyncLoad(float maxDelay, bool enableForLowest, bool enableForLow, bool enableForUltra)
	{
	}

	[Token(Token = "0x6019612")]
	[Address(RVA = "0x3072078", Offset = "0x3072078", VA = "0x3072078")]
	public void SetQualityLevel(GAGILKKDDMJ q)
	{
	}

	[Token(Token = "0x6019613")]
	[Address(RVA = "0x3071EA8", Offset = "0x3071EA8", VA = "0x3071EA8")]
	private void UpdateEngineAsyncLoad()
	{
	}

	[Token(Token = "0x6019614")]
	[Address(RVA = "0x3072080", Offset = "0x3072080", VA = "0x3072080")]
	private void OnAudioConfigurationChanged(bool deviceWasChanged)
	{
	}

	[Token(Token = "0x6019615")]
	[Address(RVA = "0x3071BB8", Offset = "0x3071BB8", VA = "0x3071BB8")]
	private void InitAudioChannel()
	{
	}

	[Token(Token = "0x6019616")]
	[Address(RVA = "0x30711A0", Offset = "0x30711A0", VA = "0x30711A0")]
	public void InitialWwise()
	{
	}

	[Token(Token = "0x6019617")]
	public static T GetInstanceByEngineType<T>() where T : IAudioEngine
	{
		return (T)null;
	}

	[Token(Token = "0x6019618")]
	[Address(RVA = "0x30721FC", Offset = "0x30721FC", VA = "0x30721FC")]
	public static EAudioEngineType GetAudioEngineKeyByType(Type type)
	{
		return default(EAudioEngineType);
	}

	[Token(Token = "0x6019619")]
	[Address(RVA = "0x30722F8", Offset = "0x30722F8", VA = "0x30722F8")]
	private IAudioEngine GetAudioEngineByType(EAudioEngineType target_engine)
	{
		return null;
	}

	[Token(Token = "0x601961A")]
	[Address(RVA = "0x30723D4", Offset = "0x30723D4", VA = "0x30723D4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601961B")]
	[Address(RVA = "0x30724A4", Offset = "0x30724A4", VA = "0x30724A4")]
	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x601961C")]
	[Address(RVA = "0x30726C0", Offset = "0x30726C0", VA = "0x30726C0")]
	public void SaveCurrentBGMTime()
	{
	}

	[Token(Token = "0x601961D")]
	[Address(RVA = "0x30727A8", Offset = "0x30727A8", VA = "0x30727A8")]
	public void SetMusicOn(bool v)
	{
	}

	[Token(Token = "0x601961E")]
	[Address(RVA = "0x30729BC", Offset = "0x30729BC", VA = "0x30729BC")]
	public void SetMusicVolume(float v)
	{
	}

	[Token(Token = "0x601961F")]
	[Address(RVA = "0x3072BD0", Offset = "0x3072BD0", VA = "0x3072BD0")]
	public void SetSoundEffectVolume(float v)
	{
	}

	[Token(Token = "0x6019620")]
	[Address(RVA = "0x3072DE4", Offset = "0x3072DE4", VA = "0x3072DE4")]
	public void SetSoundEffectOn(bool v)
	{
	}

	[Token(Token = "0x6019621")]
	[Address(RVA = "0x3072FF8", Offset = "0x3072FF8", VA = "0x3072FF8")]
	public void OnSettingChanged()
	{
	}

	[Token(Token = "0x6019622")]
	[Address(RVA = "0x3073204", Offset = "0x3073204", VA = "0x3073204")]
	public void ClearAllSound()
	{
	}

	[Token(Token = "0x6019623")]
	[Address(RVA = "0x307349C", Offset = "0x307349C", VA = "0x307349C")]
	public void OnGameDestory()
	{
	}

	[Token(Token = "0x6019624")]
	[Address(RVA = "0x30734A0", Offset = "0x30734A0", VA = "0x30734A0")]
	public GameObject Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x6019625")]
	[Address(RVA = "0x3073B2C", Offset = "0x3073B2C", VA = "0x3073B2C")]
	public GameObject Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x6019626")]
	[Address(RVA = "0x3073E80", Offset = "0x3073E80", VA = "0x3073E80")]
	public void Stop3DShot(GameObject gameObject)
	{
	}

	[Token(Token = "0x6019627")]
	[Address(RVA = "0x30738FC", Offset = "0x30738FC", VA = "0x30738FC")]
	private bool WithinDefaultAudioSourceMaxDist(Vector3 worldPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019628")]
	[Address(RVA = "0x3074094", Offset = "0x3074094", VA = "0x3074094")]
	public void InitAudioGroupInfo(uint group_id, int limit_count, int max_range = 25)
	{
	}

	[Token(Token = "0x6019629")]
	[Address(RVA = "0x3074160", Offset = "0x3074160", VA = "0x3074160")]
	public void ClearAudioGroupMap()
	{
	}

	[Token(Token = "0x601962A")]
	[Address(RVA = "0x3074208", Offset = "0x3074208", VA = "0x3074208")]
	public void Play3DShotWithGroup(uint group_id, ResourceID sound, Vector3 worldPos, Vector3 listenerPos, ResourceID audioSourceID, float volume = 1f)
	{
	}

	[Token(Token = "0x601962B")]
	[Address(RVA = "0x3074324", Offset = "0x3074324", VA = "0x3074324")]
	public AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
		return null;
	}

	[Token(Token = "0x601962C")]
	[Address(RVA = "0x3074628", Offset = "0x3074628", VA = "0x3074628")]
	public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, EAudioEngineType target_engine = EAudioEngineType.eUnity, float volumnChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x601962D")]
	[Address(RVA = "0x3071328", Offset = "0x3071328", VA = "0x3071328")]
	private void Play2DLoopStopInternal(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData, EAudioEngineType target_engine, float volumnChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x601962E")]
	[Address(RVA = "0x3074780", Offset = "0x3074780", VA = "0x3074780")]
	public GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
		return null;
	}

	[Token(Token = "0x601962F")]
	[Address(RVA = "0x3074AEC", Offset = "0x3074AEC", VA = "0x3074AEC")]
	public void Play3DLoopStop(GameObject audioSourceObj, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x6019630")]
	[Address(RVA = "0x307143C", Offset = "0x307143C", VA = "0x307143C")]
	private void Play3DLoopStopInternal(GameObject audioSourceObj, EAudioEngineType target_engine)
	{
	}

	[Token(Token = "0x6019631")]
	[Address(RVA = "0x3074C68", Offset = "0x3074C68", VA = "0x3074C68")]
	public void PlayOneShotWithChannel(ResourceID sound, EAudioChannel channel, AudioEndCallBack callBack, float volume = 1f, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x6019632")]
	[Address(RVA = "0x307502C", Offset = "0x307502C", VA = "0x307502C")]
	public GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity, int inGameGroup = -1, bool needConvertToEventId = true)
	{
		return null;
	}

	[Token(Token = "0x6019633")]
	[Address(RVA = "0x30753C4", Offset = "0x30753C4", VA = "0x30753C4")]
	public void UnloadAudio(ResourceID sound, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x6019634")]
	[Address(RVA = "0x3075574", Offset = "0x3075574", VA = "0x3075574")]
	public void UnloadAudiosByABPath(string ab_path)
	{
	}

	[Token(Token = "0x6019635")]
	[Address(RVA = "0x3075898", Offset = "0x3075898", VA = "0x3075898")]
	private AudioResWithCallBackBase PlayOneShotInternal(ResourceID sound, ref EAudioEngineType target_engine, [Optional] AudioEndInternalCallBack callback, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6019636")]
	[Address(RVA = "0x3075A64", Offset = "0x3075A64", VA = "0x3075A64")]
	public void StopPlayShot()
	{
	}

	[Token(Token = "0x6019637")]
	[Address(RVA = "0x3075FCC", Offset = "0x3075FCC", VA = "0x3075FCC")]
	public void StopPlayShot(GameObject obj, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x6019638")]
	[Address(RVA = "0x307620C", Offset = "0x307620C", VA = "0x307620C")]
	public void StopPlayShotWithChannel(EAudioChannel channel)
	{
	}

	[Token(Token = "0x6019639")]
	[Address(RVA = "0x30763D0", Offset = "0x30763D0", VA = "0x30763D0")]
	public bool TargetChannelIsPlaying(EAudioChannel channel)
	{
		return default(bool);
	}

	[Token(Token = "0x601963A")]
	[Address(RVA = "0x30764B0", Offset = "0x30764B0", VA = "0x30764B0")]
	private void StopPlayShotInternal(AudioResWithCallBackBase resource, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x601963B")]
	[Address(RVA = "0x3071610", Offset = "0x3071610", VA = "0x3071610")]
	public void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, EAudioEngineType target_engine = EAudioEngineType.eUnity, bool isNeedUnloadAudioData = false, float startTime = 0f, bool noCache = false)
	{
	}

	[Token(Token = "0x601963C")]
	[Address(RVA = "0x307659C", Offset = "0x307659C", VA = "0x307659C")]
	public AudioResource GetCurMusicRes(EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
		return null;
	}

	[Token(Token = "0x601963D")]
	[Address(RVA = "0x307665C", Offset = "0x307665C", VA = "0x307665C")]
	public AudioSource GetCurMusic(EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
		return null;
	}

	[Token(Token = "0x601963E")]
	[Address(RVA = "0x307673C", Offset = "0x307673C", VA = "0x307673C")]
	public bool IsCurMusicPlayThisID(ResourceID AudioID, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
		return default(bool);
	}

	[Token(Token = "0x601963F")]
	[Address(RVA = "0x30768BC", Offset = "0x30768BC", VA = "0x30768BC")]
	public void StopMusic(bool fadeOutCurrent = true, EAudioEngineType target_engine = EAudioEngineType.eUnity, float volumnChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x6019640")]
	[Address(RVA = "0x3071524", Offset = "0x3071524", VA = "0x3071524")]
	private void StopMusicInternal(bool fadeOutCurrent, EAudioEngineType target_engine, float volumnChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x6019641")]
	[Address(RVA = "0x30769C0", Offset = "0x30769C0", VA = "0x30769C0")]
	public void PlayCurrentMusicFadeEffect(float targetvolume, bool need_override = false, EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x6019642")]
	[Address(RVA = "0x3076AAC", Offset = "0x3076AAC", VA = "0x3076AAC")]
	public void CancelCurrentMusicFadeEffect(EAudioEngineType target_engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x6019643")]
	[Address(RVA = "0x3076B84", Offset = "0x3076B84", VA = "0x3076B84")]
	public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
	{
	}

	[Token(Token = "0x6019644")]
	[Address(RVA = "0x307379C", Offset = "0x307379C", VA = "0x307379C")]
	public ResourceID ConvertResourIDToEventID(ResourceID audio_res, ref EAudioEngineType target_engine)
	{
		return default(ResourceID);
	}
}
