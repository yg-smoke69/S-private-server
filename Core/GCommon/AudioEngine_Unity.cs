using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E54")]
public class AudioEngine_Unity : _Attribute, IConvertible
{
	[Token(Token = "0x2003E55")]
	private class AudioGroup
	{
		[Token(Token = "0x2003E56")]
		private class AudioObject
		{
			[Token(Token = "0x401A5C8")]
			[FieldOffset(Offset = "0x8")]
			public AudioSource Audio;

			[Token(Token = "0x401A5C9")]
			[FieldOffset(Offset = "0xC")]
			public ReusableObject Recyle;

			[Token(Token = "0x401A5CA")]
			[FieldOffset(Offset = "0x10")]
			public float Distance;

			[Token(Token = "0x6019582")]
			[Address(RVA = "0x26BF03C", Offset = "0x26BF03C", VA = "0x26BF03C")]
			public AudioObject()
			{
			}
		}

		[Token(Token = "0x401A5C2")]
		private const float DISTANCE_CHANGE = 5f;

		[Token(Token = "0x401A5C3")]
		[FieldOffset(Offset = "0x8")]
		private float m_Max_Range;

		[Token(Token = "0x401A5C4")]
		[FieldOffset(Offset = "0xC")]
		private int m_Limit_Count;

		[Token(Token = "0x401A5C5")]
		[FieldOffset(Offset = "0x10")]
		private AudioEngine_Unity m_OwnEngine;

		[Token(Token = "0x401A5C6")]
		[FieldOffset(Offset = "0x14")]
		private HashSet<AudioObject> m_AudioSourceRuningPool;

		[Token(Token = "0x401A5C7")]
		[FieldOffset(Offset = "0x18")]
		private List<AudioObject> m_FinishedList;

		[Token(Token = "0x601957C")]
		[Address(RVA = "0x26BA2A4", Offset = "0x26BA2A4", VA = "0x26BA2A4")]
		public AudioGroup(AudioEngine_Unity owned_engine)
		{
		}

		[Token(Token = "0x601957D")]
		[Address(RVA = "0x26B8060", Offset = "0x26B8060", VA = "0x26B8060")]
		public AudioGroup(AudioEngine_Unity owned_engine, int limit_count, int max_range)
		{
		}

		[Token(Token = "0x601957E")]
		[Address(RVA = "0x26BA380", Offset = "0x26BA380", VA = "0x26BA380")]
		public void Play3DShot(ResourceID sound, Vector3 worldPos, Vector3 listenerPos, ResourceID audioSourceID, float volume = 1f)
		{
		}

		[Token(Token = "0x601957F")]
		[Address(RVA = "0x26BCD14", Offset = "0x26BCD14", VA = "0x26BCD14")]
		public void RunOneFrame(float gameTime, float deltaTime)
		{
		}

		[Token(Token = "0x6019580")]
		[Address(RVA = "0x26BF044", Offset = "0x26BF044", VA = "0x26BF044")]
		public bool IsAllFinished()
		{
			return default(bool);
		}

		[Token(Token = "0x6019581")]
		[Address(RVA = "0x26B7D28", Offset = "0x26B7D28", VA = "0x26B7D28")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x401A5AB")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CMusicOn_003Ek__BackingField;

	[Token(Token = "0x401A5AC")]
	[FieldOffset(Offset = "0x9")]
	private bool _003CSoundEffectOn_003Ek__BackingField;

	[Token(Token = "0x401A5AD")]
	[FieldOffset(Offset = "0xC")]
	private float _003CMusicVolume_003Ek__BackingField;

	[Token(Token = "0x401A5AE")]
	[FieldOffset(Offset = "0x10")]
	private float _003CSoundEffectVolume_003Ek__BackingField;

	[Token(Token = "0x401A5AF")]
	[FieldOffset(Offset = "0x14")]
	private AudioResource m_CurrectMusic;

	[Token(Token = "0x401A5B0")]
	[FieldOffset(Offset = "0x18")]
	private ObjectPool<AudioResource> m_AudioResourcePool;

	[Token(Token = "0x401A5B1")]
	[FieldOffset(Offset = "0x1C")]
	private ObjectPool<AudioResWithCallBackDefault> m_AudioResourceWithCallBackPool;

	[Token(Token = "0x401A5B2")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ResourceID, AudioFadeEffect> m_AudioFadeEffects;

	[Token(Token = "0x401A5B3")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, AudioGroup> m_AudioGroupMap;

	[Token(Token = "0x401A5B4")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ResourceID, int> m_OneShotCountInFrame;

	[Token(Token = "0x401A5B5")]
	[FieldOffset(Offset = "0x2C")]
	private HashSet<AudioResource> m_RunningAudioResource;

	[Token(Token = "0x401A5B6")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_OneShotAudioPool;

	[Token(Token = "0x401A5B7")]
	[FieldOffset(Offset = "0x34")]
	private HashSet<AudioResWithCallBackDefault> m_PlayingAudioResourceWithCallBack;

	[Token(Token = "0x401A5B8")]
	[FieldOffset(Offset = "0x38")]
	private bool m_ChangedSoundEffectVolume;

	[Token(Token = "0x401A5B9")]
	[FieldOffset(Offset = "0x3C")]
	private List<ResourceID> m_FinishFadeEffect;

	[Token(Token = "0x401A5BA")]
	[FieldOffset(Offset = "0x40")]
	private List<uint> m_FinishedAudioGroupIDs;

	[Token(Token = "0x401A5BB")]
	[FieldOffset(Offset = "0x0")]
	public static bool EnableAsyncLoad;

	[Token(Token = "0x401A5BC")]
	[FieldOffset(Offset = "0x4")]
	public static float AsyncLoadMaxDelay;

	[Token(Token = "0x401A5BD")]
	[FieldOffset(Offset = "0x44")]
	private List<AudioAsyncLoadData> m_AsyncLoadingDatas;

	[Token(Token = "0x401A5BE")]
	[FieldOffset(Offset = "0x48")]
	private List<AudioAsyncLoadData> m_PooledAsyncLoadingDatas;

	[Token(Token = "0x401A5BF")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_OwnedObject;

	[Token(Token = "0x401A5C0")]
	[FieldOffset(Offset = "0x50")]
	private ResourceRefCache m_AudioClipRefCache;

	[Token(Token = "0x401A5C1")]
	[FieldOffset(Offset = "0x54")]
	private float m_NextStartTime;

	[Token(Token = "0x17001BAC")]
	public bool MusicOn
	{
		[Token(Token = "0x601953F")]
		[Address(RVA = "0x26B7854", Offset = "0x26B7854", VA = "0x26B7854", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019540")]
		[Address(RVA = "0x26B785C", Offset = "0x26B785C", VA = "0x26B785C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BAD")]
	public bool SoundEffectOn
	{
		[Token(Token = "0x6019541")]
		[Address(RVA = "0x26B7864", Offset = "0x26B7864", VA = "0x26B7864", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019542")]
		[Address(RVA = "0x26B786C", Offset = "0x26B786C", VA = "0x26B786C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BAE")]
	public float MusicVolume
	{
		[Token(Token = "0x6019543")]
		[Address(RVA = "0x26B7874", Offset = "0x26B7874", VA = "0x26B7874", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019544")]
		[Address(RVA = "0x26B787C", Offset = "0x26B787C", VA = "0x26B787C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BAF")]
	public float SoundEffectVolume
	{
		[Token(Token = "0x6019545")]
		[Address(RVA = "0x26B7884", Offset = "0x26B7884", VA = "0x26B7884", Slot = "7")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019546")]
		[Address(RVA = "0x26B788C", Offset = "0x26B788C", VA = "0x26B788C")]
		private set
		{
		}
	}

	[Token(Token = "0x601953E")]
	[Address(RVA = "0x26B75A8", Offset = "0x26B75A8", VA = "0x26B75A8")]
	public AudioEngine_Unity()
	{
	}

	[Token(Token = "0x6019547")]
	[Address(RVA = "0x26B7894", Offset = "0x26B7894", VA = "0x26B7894", Slot = "8")]
	public void Init(GameObject owned_object)
	{
	}

	[Token(Token = "0x6019548")]
	[Address(RVA = "0x26B7A90", Offset = "0x26B7A90", VA = "0x26B7A90", Slot = "33")]
	public void CancelCurrentMusicFadeEffect()
	{
	}

	[Token(Token = "0x6019549")]
	[Address(RVA = "0x26B7B6C", Offset = "0x26B7B6C", VA = "0x26B7B6C")]
	public void ClearAudioGroupMap()
	{
	}

	[Token(Token = "0x601954A")]
	[Address(RVA = "0x26B7FA4", Offset = "0x26B7FA4", VA = "0x26B7FA4")]
	public void InitAudioGroupInfo(uint group_id, int limit_count, int max_range = 25)
	{
	}

	[Token(Token = "0x601954B")]
	[Address(RVA = "0x26B8154", Offset = "0x26B8154", VA = "0x26B8154", Slot = "30")]
	public bool IsCurMusicPlayThisID(ResourceID AudioID)
	{
		return default(bool);
	}

	[Token(Token = "0x601954C")]
	[Address(RVA = "0x26B81F8", Offset = "0x26B81F8", VA = "0x26B81F8")]
	public AudioClip LoadAudioClip(ResourceID sound, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601954D")]
	[Address(RVA = "0x26B8304", Offset = "0x26B8304", VA = "0x26B8304")]
	public void UnloadAllAudio()
	{
	}

	[Token(Token = "0x601954E")]
	[Address(RVA = "0x26B83AC", Offset = "0x26B83AC", VA = "0x26B83AC", Slot = "34")]
	public void UnloadAudio(ResourceID sound)
	{
	}

	[Token(Token = "0x601954F")]
	[Address(RVA = "0x26B845C", Offset = "0x26B845C", VA = "0x26B845C", Slot = "35")]
	public void UnloadAudiosByABPath(string ab_path)
	{
	}

	[Token(Token = "0x6019550")]
	[Address(RVA = "0x26B850C", Offset = "0x26B850C", VA = "0x26B850C")]
	private void ClearAudioClip(ResourceID sound_id, Object obj)
	{
	}

	[Token(Token = "0x6019551")]
	[Address(RVA = "0x26B85D0", Offset = "0x26B85D0", VA = "0x26B85D0", Slot = "15")]
	public void OnGameDestory()
	{
	}

	[Token(Token = "0x6019552")]
	[Address(RVA = "0x26B8660", Offset = "0x26B8660", VA = "0x26B8660")]
	private void StopAll2DLoopSound()
	{
	}

	[Token(Token = "0x6019553")]
	[Address(RVA = "0x26B8A74", Offset = "0x26B8A74", VA = "0x26B8A74", Slot = "36")]
	public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
	{
	}

	[Token(Token = "0x6019554")]
	[Address(RVA = "0x26B8B60", Offset = "0x26B8B60", VA = "0x26B8B60", Slot = "14")]
	public void OnSettingChanged()
	{
	}

	[Token(Token = "0x6019555")]
	[Address(RVA = "0x26B8D4C", Offset = "0x26B8D4C", VA = "0x26B8D4C", Slot = "19")]
	public AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
	{
		return null;
	}

	[Token(Token = "0x6019556")]
	[Address(RVA = "0x26B90BC", Offset = "0x26B90BC", VA = "0x26B90BC", Slot = "22")]
	public void Play3DLoopStop(GameObject audioSourceObj)
	{
	}

	[Token(Token = "0x6019557")]
	[Address(RVA = "0x26B9248", Offset = "0x26B9248", VA = "0x26B9248", Slot = "16")]
	public GameObject Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x6019558")]
	[Address(RVA = "0x26B9598", Offset = "0x26B9598", VA = "0x26B9598", Slot = "17")]
	public GameObject Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x6019559")]
	[Address(RVA = "0x26B9294", Offset = "0x26B9294", VA = "0x26B9294")]
	private GameObject Play3DShotWithTransOrPos(ResourceID sound, Transform parent, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x601955A")]
	[Address(RVA = "0x26B9AAC", Offset = "0x26B9AAC", VA = "0x26B9AAC")]
	private GameObject Play3DShotWithTransOrPosOnLoaded(ResourceID sound, Transform parent, Vector3 worldPos, ResourceID audioSourceID, float volume, AudioClip c, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x601955B")]
	[Address(RVA = "0x26BA138", Offset = "0x26BA138", VA = "0x26BA138")]
	public void Play3DShotWithGroup(uint group_id, ResourceID sound, Vector3 worldPos, Vector3 listenerPos, ResourceID audioSourceID, float volume = 1f)
	{
	}

	[Token(Token = "0x601955C")]
	[Address(RVA = "0x26BAB4C", Offset = "0x26BAB4C", VA = "0x26BAB4C", Slot = "32")]
	public void PlayCurrentMusicFadeEffect(float targetvolume, bool need_override = false)
	{
	}

	[Token(Token = "0x601955D")]
	[Address(RVA = "0x26BACE4", Offset = "0x26BACE4", VA = "0x26BACE4", Slot = "27")]
	public void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, bool isNeedUnloadAudioData = false, float startTime = 0f, bool noCache = false)
	{
	}

	[Token(Token = "0x601955E")]
	[Address(RVA = "0x26BB320", Offset = "0x26BB320", VA = "0x26BB320", Slot = "28")]
	public AudioSource GetCurMusic()
	{
		return null;
	}

	[Token(Token = "0x601955F")]
	[Address(RVA = "0x26B8ED4", Offset = "0x26B8ED4", VA = "0x26B8ED4")]
	private AudioResource AllocaAndLoadAudioResourceClip(ResourceID sound, bool loop, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x6019560")]
	[Address(RVA = "0x26BB334", Offset = "0x26BB334", VA = "0x26BB334")]
	private AudioResWithCallBackDefault AllocaAndLoadAudioResourceClip(ResourceID sound, bool loop, AudioEndInternalCallBack callBack)
	{
		return null;
	}

	[Token(Token = "0x6019561")]
	[Address(RVA = "0x26BB524", Offset = "0x26BB524", VA = "0x26BB524", Slot = "24")]
	public AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x6019562")]
	[Address(RVA = "0x26BB7AC", Offset = "0x26BB7AC", VA = "0x26BB7AC", Slot = "29")]
	public void StopOneShotWithCallBack(AudioResWithCallBackBase resource)
	{
	}

	[Token(Token = "0x6019563")]
	[Address(RVA = "0x26BB908", Offset = "0x26BB908", VA = "0x26BB908", Slot = "23")]
	public GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, int inGameGroup = -1)
	{
		return null;
	}

	[Token(Token = "0x6019564")]
	[Address(RVA = "0x26BBF2C", Offset = "0x26BBF2C", VA = "0x26BBF2C", Slot = "9")]
	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x6019565")]
	[Address(RVA = "0x26BD358", Offset = "0x26BD358", VA = "0x26BD358")]
	public void SaveCurrentBGMTime()
	{
	}

	[Token(Token = "0x6019566")]
	[Address(RVA = "0x26BD398", Offset = "0x26BD398", VA = "0x26BD398", Slot = "10")]
	public void SetMusicOn(bool v)
	{
	}

	[Token(Token = "0x6019567")]
	[Address(RVA = "0x26BD76C", Offset = "0x26BD76C", VA = "0x26BD76C", Slot = "11")]
	public void SetMusicVolume(float v)
	{
	}

	[Token(Token = "0x6019568")]
	[Address(RVA = "0x26BD7B0", Offset = "0x26BD7B0", VA = "0x26BD7B0")]
	public AudioResource GetCurMusicRes()
	{
		return null;
	}

	[Token(Token = "0x6019569")]
	[Address(RVA = "0x26BD7B8", Offset = "0x26BD7B8", VA = "0x26BD7B8", Slot = "13")]
	public void SetSoundEffectOn(bool v)
	{
	}

	[Token(Token = "0x601956A")]
	[Address(RVA = "0x26BD4C8", Offset = "0x26BD4C8", VA = "0x26BD4C8")]
	public void StopAndClearFadeEffect()
	{
	}

	[Token(Token = "0x601956B")]
	[Address(RVA = "0x26BB0EC", Offset = "0x26BB0EC", VA = "0x26BB0EC", Slot = "31")]
	public void StopMusic(bool fadeOutCurrent = true, float volChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x601956C")]
	[Address(RVA = "0x26BD7D0", Offset = "0x26BD7D0", VA = "0x26BD7D0", Slot = "25")]
	public void StopPlayShot()
	{
	}

	[Token(Token = "0x601956D")]
	[Address(RVA = "0x26BDA74", Offset = "0x26BDA74", VA = "0x26BDA74", Slot = "26")]
	public void StopPlayShot(GameObject go)
	{
	}

	[Token(Token = "0x601956E")]
	[Address(RVA = "0x26BDCC4", Offset = "0x26BDCC4", VA = "0x26BDCC4", Slot = "12")]
	public void SetSoundEffectVolume(float v)
	{
	}

	[Token(Token = "0x601956F")]
	[Address(RVA = "0x26BDCE4", Offset = "0x26BDCE4", VA = "0x26BDCE4", Slot = "20")]
	public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumnChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x6019570")]
	[Address(RVA = "0x26BDF54", Offset = "0x26BDF54", VA = "0x26BDF54", Slot = "21")]
	public GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
	{
		return null;
	}

	[Token(Token = "0x6019571")]
	[Address(RVA = "0x26BE334", Offset = "0x26BE334", VA = "0x26BE334")]
	public void RestoreLoopAudio()
	{
	}

	[Token(Token = "0x6019572")]
	[Address(RVA = "0x26BE3F8", Offset = "0x26BE3F8", VA = "0x26BE3F8")]
	public void SetAsyncLoad(bool enable, float maxDelay)
	{
	}

	[Token(Token = "0x6019573")]
	[Address(RVA = "0x26B96C0", Offset = "0x26B96C0", VA = "0x26B96C0")]
	private uint LoadAudioClipAsync(ResourceID sound)
	{
		return default(uint);
	}

	[Token(Token = "0x6019574")]
	[Address(RVA = "0x26BE474", Offset = "0x26BE474", VA = "0x26BE474")]
	private void OnAudioClipAsyncLoaded(uint ticket, bool ok, Object obj)
	{
	}

	[Token(Token = "0x6019575")]
	[Address(RVA = "0x26B9810", Offset = "0x26B9810", VA = "0x26B9810")]
	private void RegisterAsyncLoadData(uint ticket, ResourceID sound, Transform parent, Vector3 worldPos, ResourceID audioSourceID, float volume)
	{
	}

	[Token(Token = "0x6019576")]
	[Address(RVA = "0x26B88CC", Offset = "0x26B88CC", VA = "0x26B88CC")]
	public void CancelAllAsyncLoadings()
	{
	}

	[Token(Token = "0x6019577")]
	[Address(RVA = "0x26BEB70", Offset = "0x26BEB70", VA = "0x26BEB70")]
	private void CancelAndRecycleAsyncLoading(AudioAsyncLoadData data)
	{
	}

	[Token(Token = "0x6019578")]
	[Address(RVA = "0x26BD194", Offset = "0x26BD194", VA = "0x26BD194")]
	private void UpdateAsyncLoadings()
	{
	}

	[Token(Token = "0x6019579")]
	[Address(RVA = "0x26BEC68", Offset = "0x26BEC68", VA = "0x26BEC68")]
	private void PlayOnAudioClipAsyncLoadTimeout(AudioAsyncLoadData data)
	{
	}

	[Token(Token = "0x601957A")]
	[Address(RVA = "0x26BE810", Offset = "0x26BE810", VA = "0x26BE810")]
	private void PlayOnAudioClipAsyncLoaded(AudioAsyncLoadData data, Object obj)
	{
	}

	[Token(Token = "0x601957B")]
	[Address(RVA = "0x26BEF64", Offset = "0x26BEF64", VA = "0x26BEF64", Slot = "18")]
	public void Stop3DShot(GameObject gameObject)
	{
	}
}
