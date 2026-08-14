using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E72")]
public class FFAudioEngine_Unity : _Attribute
{
	[Token(Token = "0x401A670")]
	[FieldOffset(Offset = "0x8")]
	private float m_MusicVolume;

	[Token(Token = "0x401A671")]
	[FieldOffset(Offset = "0xC")]
	private float m_SoundVolume;

	[Token(Token = "0x401A672")]
	[FieldOffset(Offset = "0x10")]
	private float m_VoiceVolume;

	[Token(Token = "0x401A673")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsInsertMusicPlaying;

	[Token(Token = "0x401A674")]
	[FieldOffset(Offset = "0x18")]
	private int m_InsertTicket;

	[Token(Token = "0x401A675")]
	[FieldOffset(Offset = "0x1C")]
	private AudioResource m_MusicResource;

	[Token(Token = "0x401A676")]
	[FieldOffset(Offset = "0x20")]
	private AudioResource m_CutSceneResource;

	[Token(Token = "0x401A677")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, AudioResource> m_RunningAudioResource;

	[Token(Token = "0x401A678")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ResourceID, AudioFadeEffect> m_AudioFadeEffect;

	[Token(Token = "0x401A679")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsMusicMuted;

	[Token(Token = "0x401A67A")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_IsSoundMuted;

	[Token(Token = "0x401A67B")]
	private const int ForcePositive = int.MaxValue;

	[Token(Token = "0x401A67C")]
	[FieldOffset(Offset = "0x30")]
	private List<ResourceID> m_FinishedFadeEffect;

	[Token(Token = "0x401A67D")]
	[FieldOffset(Offset = "0x34")]
	private List<int> m_FinishedResource;

	[Token(Token = "0x401A67E")]
	[FieldOffset(Offset = "0x38")]
	private List<int> m_EmoteAudioResource;

	[Token(Token = "0x401A67F")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsEmotePlaying;

	[Token(Token = "0x401A680")]
	private const int MaxSubTracks = 3;

	[Token(Token = "0x401A681")]
	[FieldOffset(Offset = "0x40")]
	private int m_subTracksCounter;

	[Token(Token = "0x601966E")]
	[Address(RVA = "0x32A0FB8", Offset = "0x32A0FB8", VA = "0x32A0FB8")]
	public FFAudioEngine_Unity()
	{
	}

	[Token(Token = "0x601966F")]
	[Address(RVA = "0x32A1108", Offset = "0x32A1108", VA = "0x32A1108", Slot = "4")]
	public bool PlayMusic(ResourceID resourceID, bool isFadeIn, bool isFadeOut, float startTime, bool isNoCache = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6019670")]
	[Address(RVA = "0x32A1A08", Offset = "0x32A1A08", VA = "0x32A1A08", Slot = "5")]
	public void StopMusic()
	{
	}

	[Token(Token = "0x6019671")]
	[Address(RVA = "0x32A1AE0", Offset = "0x32A1AE0", VA = "0x32A1AE0", Slot = "6")]
	public int InsertMusic(ResourceID resourceID)
	{
		return default(int);
	}

	[Token(Token = "0x6019672")]
	[Address(RVA = "0x32A1D3C", Offset = "0x32A1D3C", VA = "0x32A1D3C", Slot = "7")]
	public bool CancelInsertMusic(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x6019673")]
	[Address(RVA = "0x32A1F08", Offset = "0x32A1F08", VA = "0x32A1F08", Slot = "8")]
	public int PlayMusicSubtrack(ResourceID resourceID)
	{
		return default(int);
	}

	[Token(Token = "0x6019674")]
	[Address(RVA = "0x32A21F0", Offset = "0x32A21F0", VA = "0x32A21F0", Slot = "9")]
	public bool StopMusicSubtrack(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x6019675")]
	[Address(RVA = "0x32A235C", Offset = "0x32A235C", VA = "0x32A235C", Slot = "10")]
	public bool IsCurrentMusicExisit()
	{
		return default(bool);
	}

	[Token(Token = "0x6019676")]
	[Address(RVA = "0x32A23FC", Offset = "0x32A23FC", VA = "0x32A23FC", Slot = "11")]
	public float GetCurrentMusicTime()
	{
		return default(float);
	}

	[Token(Token = "0x6019677")]
	[Address(RVA = "0x32A2450", Offset = "0x32A2450", VA = "0x32A2450", Slot = "12")]
	public bool PlayCutScene(ResourceID resourceID, int audioMixerGroup, bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6019678")]
	[Address(RVA = "0x32A2910", Offset = "0x32A2910", VA = "0x32A2910", Slot = "13")]
	public bool StopCutScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6019679")]
	[Address(RVA = "0x32A2AC4", Offset = "0x32A2AC4", VA = "0x32A2AC4", Slot = "14")]
	public int PlayEmoteSound(ResourceID resourceID, bool isLoop = false)
	{
		return default(int);
	}

	[Token(Token = "0x601967A")]
	[Address(RVA = "0x32A2E48", Offset = "0x32A2E48", VA = "0x32A2E48", Slot = "15")]
	public bool StopEmoteSound(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x601967B")]
	[Address(RVA = "0x32A2FF8", Offset = "0x32A2FF8", VA = "0x32A2FF8", Slot = "16")]
	public void PlaySoundEffect(ResourceID resourceID)
	{
	}

	[Token(Token = "0x601967C")]
	[Address(RVA = "0x32A3224", Offset = "0x32A3224", VA = "0x32A3224", Slot = "17")]
	public void PlayUserVoice()
	{
	}

	[Token(Token = "0x601967D")]
	[Address(RVA = "0x32A3228", Offset = "0x32A3228", VA = "0x32A3228", Slot = "18")]
	public int PlayCharacterVoice(ResourceID resourceID, [Optional] Action endCallback)
	{
		return default(int);
	}

	[Token(Token = "0x601967E")]
	[Address(RVA = "0x32A3458", Offset = "0x32A3458", VA = "0x32A3458", Slot = "19")]
	public bool StopCharacterVoice(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x601967F")]
	[Address(RVA = "0x32A351C", Offset = "0x32A351C", VA = "0x32A351C", Slot = "20")]
	public bool IsCharacterVoicePlaying(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x6019680")]
	[Address(RVA = "0x32A35CC", Offset = "0x32A35CC", VA = "0x32A35CC", Slot = "21")]
	public int Start2DLoop(ResourceID resourceID)
	{
		return default(int);
	}

	[Token(Token = "0x6019681")]
	[Address(RVA = "0x32A37D4", Offset = "0x32A37D4", VA = "0x32A37D4", Slot = "22")]
	public bool End2DLoop(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x6019682")]
	[Address(RVA = "0x32A178C", Offset = "0x32A178C", VA = "0x32A178C")]
	private void SetFadeEffect(ResourceID resID, AudioResource res, float targetVol, bool isClosed, float volChangeSpeed = 1f)
	{
	}

	[Token(Token = "0x6019683")]
	[Address(RVA = "0x32A3960", Offset = "0x32A3960", VA = "0x32A3960", Slot = "23")]
	public void RunOneFrame(float deltaTime)
	{
	}

	[Token(Token = "0x6019684")]
	[Address(RVA = "0x32A482C", Offset = "0x32A482C", VA = "0x32A482C", Slot = "24")]
	public void SetMusicVolume(float vol)
	{
	}

	[Token(Token = "0x6019685")]
	[Address(RVA = "0x32A489C", Offset = "0x32A489C", VA = "0x32A489C", Slot = "25")]
	public void SetSoundVolume(float vol)
	{
	}

	[Token(Token = "0x6019686")]
	[Address(RVA = "0x32A4B04", Offset = "0x32A4B04", VA = "0x32A4B04", Slot = "26")]
	public void SetVoiceVolume(float vol)
	{
	}

	[Token(Token = "0x6019687")]
	[Address(RVA = "0x32A4B3C", Offset = "0x32A4B3C", VA = "0x32A4B3C", Slot = "27")]
	public void SetMusicOn(bool isOn)
	{
	}

	[Token(Token = "0x6019688")]
	[Address(RVA = "0x32A4BF4", Offset = "0x32A4BF4", VA = "0x32A4BF4", Slot = "28")]
	public void SetSoundOn(bool isOn)
	{
	}
}
