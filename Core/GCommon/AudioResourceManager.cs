using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E71")]
public class AudioResourceManager : SingletonModule<AudioResourceManager>, _Attribute
{
	[Token(Token = "0x401A669")]
	[FieldOffset(Offset = "0xC")]
	private ResourceRefCache m_AudioClipCache;

	[Token(Token = "0x401A66A")]
	[FieldOffset(Offset = "0x10")]
	private ObjectPool<AudioResource> m_AudioResourcePool;

	[Token(Token = "0x401A66B")]
	[FieldOffset(Offset = "0x14")]
	private ObjectPool<AudioResWithCallBackDefault> m_AudioResourceWithCallBackPool;

	[Token(Token = "0x401A66C")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_OwnedObject;

	[Token(Token = "0x401A66D")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, GameObject> m_OneShotPool;

	[Token(Token = "0x401A66E")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, Action> m_CallBackPool;

	[Token(Token = "0x401A66F")]
	private const int ForcePositive = int.MaxValue;

	[Token(Token = "0x601965E")]
	[Address(RVA = "0x3078D34", Offset = "0x3078D34", VA = "0x3078D34")]
	public AudioResourceManager()
	{
	}

	[Token(Token = "0x601965F")]
	[Address(RVA = "0x3078DC4", Offset = "0x3078DC4", VA = "0x3078DC4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6019660")]
	[Address(RVA = "0x3078E74", Offset = "0x3078E74", VA = "0x3078E74", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6019661")]
	[Address(RVA = "0x3078FF4", Offset = "0x3078FF4", VA = "0x3078FF4", Slot = "10")]
	public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
	{
	}

	[Token(Token = "0x6019662")]
	[Address(RVA = "0x3071BB0", Offset = "0x3071BB0", VA = "0x3071BB0")]
	public void BindOnwer(GameObject owner)
	{
	}

	[Token(Token = "0x6019663")]
	[Address(RVA = "0x3079198", Offset = "0x3079198", VA = "0x3079198")]
	public AudioResource AllocAudioResource(ResourceID sound, bool loop, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x6019664")]
	[Address(RVA = "0x3079444", Offset = "0x3079444", VA = "0x3079444")]
	public AudioResWithCallBackDefault AllocAudioResource(ResourceID sound, bool loop, AudioEndInternalCallBack callBack)
	{
		return null;
	}

	[Token(Token = "0x6019665")]
	[Address(RVA = "0x3079630", Offset = "0x3079630", VA = "0x3079630")]
	public int AllocAudioObject(ResourceID sound, float volume, out AudioSource audio, out ReusableObject reusableObject, [Optional] Action endCallback)
	{
		return default(int);
	}

	[Token(Token = "0x6019666")]
	[Address(RVA = "0x30799CC", Offset = "0x30799CC", VA = "0x30799CC")]
	public void CollectAudioResource(AudioResource res)
	{
	}

	[Token(Token = "0x6019667")]
	[Address(RVA = "0x3079A4C", Offset = "0x3079A4C", VA = "0x3079A4C")]
	public void CollectAudioResource(AudioResWithCallBackDefault res)
	{
	}

	[Token(Token = "0x6019668")]
	[Address(RVA = "0x3079ACC", Offset = "0x3079ACC", VA = "0x3079ACC")]
	public void CollectAudioObject(int ticket)
	{
	}

	[Token(Token = "0x6019669")]
	[Address(RVA = "0x3079C40", Offset = "0x3079C40", VA = "0x3079C40")]
	public bool IsOneShotPlaying(int ticket)
	{
		return default(bool);
	}

	[Token(Token = "0x601966A")]
	[Address(RVA = "0x3079338", Offset = "0x3079338", VA = "0x3079338")]
	public AudioClip LoadAudioClip(ResourceID sound)
	{
		return null;
	}

	[Token(Token = "0x601966B")]
	[Address(RVA = "0x3079DE4", Offset = "0x3079DE4", VA = "0x3079DE4")]
	public void UnloadAudio(ResourceID sound)
	{
	}

	[Token(Token = "0x601966C")]
	[Address(RVA = "0x30757E8", Offset = "0x30757E8", VA = "0x30757E8")]
	public void UnloadAudiosByABPath(string ab_path)
	{
	}

	[Token(Token = "0x601966D")]
	[Address(RVA = "0x3079E94", Offset = "0x3079E94", VA = "0x3079E94")]
	private void ClearAudioClip(ResourceID sound_id, Object obj)
	{
	}
}
