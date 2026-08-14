using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E53")]
public interface IAudioEngine
{
	[Token(Token = "0x17001BA8")]
	bool MusicOn
	{
		[Token(Token = "0x601951E")]
		get;
	}

	[Token(Token = "0x17001BA9")]
	bool SoundEffectOn
	{
		[Token(Token = "0x601951F")]
		get;
	}

	[Token(Token = "0x17001BAA")]
	float MusicVolume
	{
		[Token(Token = "0x6019520")]
		get;
	}

	[Token(Token = "0x17001BAB")]
	float SoundEffectVolume
	{
		[Token(Token = "0x6019521")]
		get;
	}

	[Token(Token = "0x6019522")]
	void Init(GameObject owned_object);

	[Token(Token = "0x6019523")]
	void RunOneFrame(float gameTime, float deltaTime);

	[Token(Token = "0x6019524")]
	void SetMusicOn(bool v);

	[Token(Token = "0x6019525")]
	void SetMusicVolume(float v);

	[Token(Token = "0x6019526")]
	void SetSoundEffectVolume(float v);

	[Token(Token = "0x6019527")]
	void SetSoundEffectOn(bool v);

	[Token(Token = "0x6019528")]
	void OnSettingChanged();

	[Token(Token = "0x6019529")]
	void OnGameDestory();

	[Token(Token = "0x601952A")]
	GameObject Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1);

	[Token(Token = "0x601952B")]
	GameObject Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, bool allowAsync = true, bool isStopable = false, int inGameGroup = -1);

	[Token(Token = "0x601952C")]
	void Stop3DShot(GameObject gameObject);

	[Token(Token = "0x601952D")]
	AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

	[Token(Token = "0x601952E")]
	void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumnChangeSpeed = 1f);

	[Token(Token = "0x601952F")]
	GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

	[Token(Token = "0x6019530")]
	void Play3DLoopStop(GameObject audioSourceObj);

	[Token(Token = "0x6019531")]
	GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, int inGameGroup = -1);

	[Token(Token = "0x6019532")]
	AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f);

	[Token(Token = "0x6019533")]
	void StopPlayShot();

	[Token(Token = "0x6019534")]
	void StopPlayShot(GameObject obj);

	[Token(Token = "0x6019535")]
	void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, bool isNeedUnloadAudioData = false, float startTime = 0f, bool noCache = false);

	[Token(Token = "0x6019536")]
	AudioSource GetCurMusic();

	[Token(Token = "0x6019537")]
	void StopOneShotWithCallBack(AudioResWithCallBackBase resource);

	[Token(Token = "0x6019538")]
	bool IsCurMusicPlayThisID(ResourceID AudioID);

	[Token(Token = "0x6019539")]
	void StopMusic(bool fadeOutCurrent = true, float volumnChangeSpeed = 1f);

	[Token(Token = "0x601953A")]
	void PlayCurrentMusicFadeEffect(float targetvolume, bool need_override = false);

	[Token(Token = "0x601953B")]
	void CancelCurrentMusicFadeEffect();

	[Token(Token = "0x601953C")]
	void UnloadAudio(ResourceID soundID);

	[Token(Token = "0x601953D")]
	void UnloadAudiosByABPath(string ab_path);
}
