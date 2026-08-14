using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E74")]
public class FFAudioManager : SingletonModule<FFAudioManager>
{
	[Token(Token = "0x401A682")]
	public const int InVaildTicket = -1;

	[Token(Token = "0x401A683")]
	private const int ForcePositive = int.MaxValue;

	[Token(Token = "0x401A684")]
	[FieldOffset(Offset = "0xC")]
	private IAudioEngine m_WwiseEngine;

	[Token(Token = "0x401A685")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, AudioManager.AudioRecordInfo> m_PlayingSound;

	[Token(Token = "0x401A686")]
	[FieldOffset(Offset = "0x14")]
	private AudioManager.AudioRecordInfo m_CurPlayingMusic;

	[Token(Token = "0x401A687")]
	[FieldOffset(Offset = "0x18")]
	private AudioManager.AudioRecordInfo m_CurPlayingCutScene;

	[Token(Token = "0x401A688")]
	[FieldOffset(Offset = "0x1C")]
	private EAudioEngineType m_DefaultEngineType;

	[Token(Token = "0x401A689")]
	[FieldOffset(Offset = "0x20")]
	private IFFAudioEngine m_Engine;

	[Token(Token = "0x60196A2")]
	[Address(RVA = "0x32A4C00", Offset = "0x32A4C00", VA = "0x32A4C00")]
	public FFAudioManager()
	{
	}

	[Token(Token = "0x60196A3")]
	[Address(RVA = "0x32A4DD4", Offset = "0x32A4DD4", VA = "0x32A4DD4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60196A4")]
	[Address(RVA = "0x32A4E4C", Offset = "0x32A4E4C", VA = "0x32A4E4C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60196A5")]
	[Address(RVA = "0x32A4F1C", Offset = "0x32A4F1C", VA = "0x32A4F1C")]
	public bool PlayMusic(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, bool isFadeIn = true, bool isFadeOut = true, float startTime = 0f, bool isNoCache = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60196A6")]
	[Address(RVA = "0x32A52A4", Offset = "0x32A52A4", VA = "0x32A52A4")]
	public void StopMusic()
	{
	}

	[Token(Token = "0x60196A7")]
	[Address(RVA = "0x32A5434", Offset = "0x32A5434", VA = "0x32A5434")]
	public int InsertMusic(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, bool isFadeIn = true, bool isFadeOut = true, float startTime = 0f, bool isNoCache = false)
	{
		return default(int);
	}

	[Token(Token = "0x60196A8")]
	[Address(RVA = "0x32A554C", Offset = "0x32A554C", VA = "0x32A554C")]
	public bool CancelInsertMusic(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196A9")]
	[Address(RVA = "0x32A5640", Offset = "0x32A5640", VA = "0x32A5640")]
	public int PlayMusicSubtrack(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity)
	{
		return default(int);
	}

	[Token(Token = "0x60196AA")]
	[Address(RVA = "0x32A5A40", Offset = "0x32A5A40", VA = "0x32A5A40")]
	public bool IsCurrentMusicExisit()
	{
		return default(bool);
	}

	[Token(Token = "0x60196AB")]
	[Address(RVA = "0x32A5BA4", Offset = "0x32A5BA4", VA = "0x32A5BA4")]
	public float GetCurrentMusicTime()
	{
		return default(float);
	}

	[Token(Token = "0x60196AC")]
	[Address(RVA = "0x32A5C9C", Offset = "0x32A5C9C", VA = "0x32A5C9C")]
	public bool StopMusicSubtrack(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196AD")]
	[Address(RVA = "0x32A5FBC", Offset = "0x32A5FBC", VA = "0x32A5FBC")]
	public bool PlayCutScene(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60196AE")]
	[Address(RVA = "0x32A62E0", Offset = "0x32A62E0", VA = "0x32A62E0")]
	public bool StopCutScene()
	{
		return default(bool);
	}

	[Token(Token = "0x60196AF")]
	[Address(RVA = "0x32A652C", Offset = "0x32A652C", VA = "0x32A652C")]
	public bool PlayShopshow(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60196B0")]
	[Address(RVA = "0x32A6658", Offset = "0x32A6658", VA = "0x32A6658")]
	public bool StopShopShow()
	{
		return default(bool);
	}

	[Token(Token = "0x60196B1")]
	[Address(RVA = "0x32A6740", Offset = "0x32A6740", VA = "0x32A6740")]
	public bool PlayShopShowWithBGM(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60196B2")]
	[Address(RVA = "0x32A686C", Offset = "0x32A686C", VA = "0x32A686C")]
	public bool StopShopShowWithBGM()
	{
		return default(bool);
	}

	[Token(Token = "0x60196B3")]
	[Address(RVA = "0x32A6954", Offset = "0x32A6954", VA = "0x32A6954")]
	public void PlaySoundEffect(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity)
	{
	}

	[Token(Token = "0x60196B4")]
	[Address(RVA = "0x32A6CB0", Offset = "0x32A6CB0", VA = "0x32A6CB0")]
	public void PlayUserVoice(ResourceID resourceID)
	{
	}

	[Token(Token = "0x60196B5")]
	[Address(RVA = "0x32A6CB4", Offset = "0x32A6CB4", VA = "0x32A6CB4")]
	public int PlayCharacterVoice(ResourceID resourceID, Action endCallBack)
	{
		return default(int);
	}

	[Token(Token = "0x60196B6")]
	[Address(RVA = "0x32A6D9C", Offset = "0x32A6D9C", VA = "0x32A6D9C")]
	public bool StopCharacterVoice(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196B7")]
	[Address(RVA = "0x32A6E7C", Offset = "0x32A6E7C", VA = "0x32A6E7C")]
	public bool IsCharacterVoicePlaying(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196B8")]
	[Address(RVA = "0x32A5764", Offset = "0x32A5764", VA = "0x32A5764")]
	public int Start2DLoop(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity)
	{
		return default(int);
	}

	[Token(Token = "0x60196B9")]
	[Address(RVA = "0x32A5D98", Offset = "0x32A5D98", VA = "0x32A5D98")]
	public bool End2DLoop(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196BA")]
	[Address(RVA = "0x32A6F6C", Offset = "0x32A6F6C", VA = "0x32A6F6C")]
	public int PlayEmoteSound(ResourceID resourceID, bool isLoop = false, EAudioEngineType engine = EAudioEngineType.eUnity)
	{
		return default(int);
	}

	[Token(Token = "0x60196BB")]
	[Address(RVA = "0x32A72D4", Offset = "0x32A72D4", VA = "0x32A72D4")]
	public bool StopEmoteSound(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196BC")]
	[Address(RVA = "0x32A750C", Offset = "0x32A750C", VA = "0x32A750C")]
	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x60196BD")]
	[Address(RVA = "0x32A7684", Offset = "0x32A7684", VA = "0x32A7684")]
	public void SetMusicOn(bool isOn)
	{
	}

	[Token(Token = "0x60196BE")]
	[Address(RVA = "0x32A77E8", Offset = "0x32A77E8", VA = "0x32A77E8")]
	public void SetSoundEffectOn(bool isOn)
	{
	}

	[Token(Token = "0x60196BF")]
	[Address(RVA = "0x32A794C", Offset = "0x32A794C", VA = "0x32A794C")]
	public void SetMusicVolume(float vol)
	{
	}

	[Token(Token = "0x60196C0")]
	[Address(RVA = "0x32A7AB0", Offset = "0x32A7AB0", VA = "0x32A7AB0")]
	public void SetSoundVolume(float vol)
	{
	}

	[Token(Token = "0x60196C1")]
	[Address(RVA = "0x32A7C14", Offset = "0x32A7C14", VA = "0x32A7C14")]
	public void SetVoiceVolume(float vol)
	{
	}

	[Token(Token = "0x60196C2")]
	[Address(RVA = "0x32A7CF0", Offset = "0x32A7CF0", VA = "0x32A7CF0")]
	public void SetDefaultEngine(EAudioEngineType engine)
	{
	}

	[Token(Token = "0x60196C3")]
	[Address(RVA = "0x32A7EC4", Offset = "0x32A7EC4", VA = "0x32A7EC4")]
	public bool IsVaildTicket(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x60196C4")]
	[Address(RVA = "0x32A5144", Offset = "0x32A5144", VA = "0x32A5144")]
	public ResourceID ConvertResourIDToEventID(ResourceID audio_res, ref EAudioEngineType target_engine)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60196C5")]
	[Address(RVA = "0x32A7DAC", Offset = "0x32A7DAC", VA = "0x32A7DAC")]
	public void InitWwise(GameObject gameObject)
	{
	}

	[Token(Token = "0x60196C6")]
	[Address(RVA = "0x32A60E8", Offset = "0x32A60E8", VA = "0x32A60E8")]
	private void PlayCutSceneWwise(ResourceID resourceId)
	{
	}

	[Token(Token = "0x60196C7")]
	[Address(RVA = "0x32A63C8", Offset = "0x32A63C8", VA = "0x32A63C8")]
	private void StopCutSceneWwise()
	{
	}
}
