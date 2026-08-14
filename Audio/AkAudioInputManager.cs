using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003DB2")]
public static class AkAudioInputManager
{
	[Token(Token = "0x2003DB3")]
	public delegate void AudioFormatDelegate(uint playingID, AkAudioFormat format);

	[Token(Token = "0x2003DB4")]
	public delegate void AudioFormatInteropDelegate(uint playingID, IntPtr format);

	[Token(Token = "0x2003DB5")]
	public delegate bool AudioSamplesDelegate(uint playingID, uint channelIndex, float[] samples);

	[Token(Token = "0x2003DB6")]
	public delegate bool AudioSamplesInteropDelegate(uint playingID, [In][Out] float[] samples, uint channelIndex, uint frames);

	[Token(Token = "0x401A376")]
	[FieldOffset(Offset = "0x0")]
	private static bool initialized;

	[Token(Token = "0x401A377")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Dictionary<uint, AudioSamplesDelegate> audioSamplesDelegates;

	[Token(Token = "0x401A378")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<uint, AudioFormatDelegate> audioFormatDelegates;

	[Token(Token = "0x401A379")]
	[FieldOffset(Offset = "0xC")]
	private static readonly AkAudioFormat audioFormat;

	[Token(Token = "0x401A37A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly AudioSamplesInteropDelegate audioSamplesDelegate;

	[Token(Token = "0x401A37B")]
	[FieldOffset(Offset = "0x14")]
	private static readonly AudioFormatInteropDelegate audioFormatDelegate;

	[Token(Token = "0x401A37C")]
	[FieldOffset(Offset = "0x18")]
	private static AkCallbackManager.EventCallback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x401A37D")]
	[FieldOffset(Offset = "0x1C")]
	private static AkCallbackManager.EventCallback _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x401A37E")]
	[FieldOffset(Offset = "0x20")]
	private static AkCallbackManager.EventCallback _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x401A37F")]
	[FieldOffset(Offset = "0x24")]
	private static AudioSamplesInteropDelegate _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x401A380")]
	[FieldOffset(Offset = "0x28")]
	private static AudioFormatInteropDelegate _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x601920E")]
	[Address(RVA = "0x35C20A0", Offset = "0x35C20A0", VA = "0x35C20A0")]
	public static uint PostAudioInputEvent(Event akEvent, GameObject gameObject, AudioSamplesDelegate sampleDelegate, [Optional] AudioFormatDelegate formatDelegate)
	{
		return default(uint);
	}

	[Token(Token = "0x601920F")]
	[Address(RVA = "0x35C24BC", Offset = "0x35C24BC", VA = "0x35C24BC")]
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AudioSamplesDelegate sampleDelegate, [Optional] AudioFormatDelegate formatDelegate)
	{
		return default(uint);
	}

	[Token(Token = "0x6019210")]
	[Address(RVA = "0x35C2680", Offset = "0x35C2680", VA = "0x35C2680")]
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AudioSamplesDelegate sampleDelegate, [Optional] AudioFormatDelegate formatDelegate)
	{
		return default(uint);
	}

	[Token(Token = "0x6019211")]
	[Address(RVA = "0x35C1D68", Offset = "0x35C1D68", VA = "0x35C1D68")]
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames)
	{
		return default(bool);
	}

	[Token(Token = "0x6019212")]
	[Address(RVA = "0x35C1EE8", Offset = "0x35C1EE8", VA = "0x35C1EE8")]
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format)
	{
	}

	[Token(Token = "0x6019213")]
	[Address(RVA = "0x35C2244", Offset = "0x35C2244", VA = "0x35C2244")]
	private static void TryInitialize()
	{
	}

	[Token(Token = "0x6019214")]
	[Address(RVA = "0x35C2368", Offset = "0x35C2368", VA = "0x35C2368")]
	private static void AddPlayingID(uint playingID, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate)
	{
	}

	[Token(Token = "0x6019215")]
	[Address(RVA = "0x35C2D14", Offset = "0x35C2D14", VA = "0x35C2D14")]
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo)
	{
	}
}
