using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace GCommon;

[Token(Token = "0x2003E5E")]
public class AudioFFT : MonoBehaviour
{
	[Token(Token = "0x2003E5F")]
	public enum _channel
	{
		[Token(Token = "0x401A609")]
		Stereo,
		[Token(Token = "0x401A60A")]
		Left,
		[Token(Token = "0x401A60B")]
		Right
	}

	[Token(Token = "0x401A5EF")]
	[FieldOffset(Offset = "0xC")]
	private AudioSource _audioSource;

	[Token(Token = "0x401A5F0")]
	[FieldOffset(Offset = "0x10")]
	private AudioMixer _audioMixer;

	[Token(Token = "0x401A5F1")]
	[FieldOffset(Offset = "0x14")]
	public AudioClip _audioClip;

	[Token(Token = "0x401A5F2")]
	[FieldOffset(Offset = "0x0")]
	public static float[] _samplesLeft;

	[Token(Token = "0x401A5F3")]
	[FieldOffset(Offset = "0x4")]
	public static float[] _samplesRight;

	[Token(Token = "0x401A5F4")]
	[FieldOffset(Offset = "0x8")]
	public static float[] _freqBand;

	[Token(Token = "0x401A5F5")]
	[FieldOffset(Offset = "0xC")]
	public static float[] _bandBuffer;

	[Token(Token = "0x401A5F6")]
	[FieldOffset(Offset = "0x18")]
	private float[] _bufferDecrease;

	[Token(Token = "0x401A5F7")]
	[FieldOffset(Offset = "0x1C")]
	private float[] _freqBandHightest;

	[Token(Token = "0x401A5F8")]
	[FieldOffset(Offset = "0x10")]
	public static float[] _freqBand64;

	[Token(Token = "0x401A5F9")]
	[FieldOffset(Offset = "0x14")]
	public static float[] _bandBuffer64;

	[Token(Token = "0x401A5FA")]
	[FieldOffset(Offset = "0x20")]
	private float[] _bufferDecrease64;

	[Token(Token = "0x401A5FB")]
	[FieldOffset(Offset = "0x24")]
	private float[] _freqBandHightest64;

	[Token(Token = "0x401A5FC")]
	[FieldOffset(Offset = "0x18")]
	public static float[] _audioBand;

	[Token(Token = "0x401A5FD")]
	[FieldOffset(Offset = "0x1C")]
	public static float[] _audioBandBuffer;

	[Token(Token = "0x401A5FE")]
	[FieldOffset(Offset = "0x20")]
	public static float[] _audioBand64;

	[Token(Token = "0x401A5FF")]
	[FieldOffset(Offset = "0x24")]
	public static float[] _audioBandBuffer64;

	[Token(Token = "0x401A600")]
	[FieldOffset(Offset = "0x28")]
	public static float _Amplitude;

	[Token(Token = "0x401A601")]
	[FieldOffset(Offset = "0x2C")]
	public static float _AmplitudeBuffer;

	[Token(Token = "0x401A602")]
	[FieldOffset(Offset = "0x28")]
	private float _AmplitudeHighest;

	[Token(Token = "0x401A603")]
	[FieldOffset(Offset = "0x2C")]
	private float _baseAudioVolume;

	[Token(Token = "0x401A604")]
	[FieldOffset(Offset = "0x30")]
	public float _audioProfile;

	[Token(Token = "0x401A605")]
	[FieldOffset(Offset = "0x34")]
	public _channel channel;

	[Token(Token = "0x401A606")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Inited;

	[Token(Token = "0x401A607")]
	[FieldOffset(Offset = "0x30")]
	private static AudioFFT m_Instance;

	[Token(Token = "0x17001BB4")]
	public static AudioFFT instance
	{
		[Token(Token = "0x60195CD")]
		[Address(RVA = "0x306E030", Offset = "0x306E030", VA = "0x306E030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60195CC")]
	[Address(RVA = "0x306DF8C", Offset = "0x306DF8C", VA = "0x306DF8C")]
	public AudioFFT()
	{
	}

	[Token(Token = "0x60195CE")]
	[Address(RVA = "0x306E0BC", Offset = "0x306E0BC", VA = "0x306E0BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60195CF")]
	[Address(RVA = "0x306E14C", Offset = "0x306E14C", VA = "0x306E14C")]
	private void Start()
	{
	}

	[Token(Token = "0x60195D0")]
	[Address(RVA = "0x306E3C8", Offset = "0x306E3C8", VA = "0x306E3C8")]
	public void SetAudioClip(AudioClip clip)
	{
	}

	[Token(Token = "0x60195D1")]
	[Address(RVA = "0x306E480", Offset = "0x306E480", VA = "0x306E480")]
	public void PlayMusic(float playStartTime = 0f)
	{
	}

	[Token(Token = "0x60195D2")]
	[Address(RVA = "0x306E880", Offset = "0x306E880", VA = "0x306E880")]
	public void OnMusiceVolumeChange()
	{
	}

	[Token(Token = "0x60195D3")]
	[Address(RVA = "0x306E710", Offset = "0x306E710", VA = "0x306E710")]
	private void SetVolume(float volume)
	{
	}

	[Token(Token = "0x60195D4")]
	[Address(RVA = "0x306E994", Offset = "0x306E994", VA = "0x306E994")]
	public AudioSource GetCurMusic()
	{
		return null;
	}

	[Token(Token = "0x60195D5")]
	[Address(RVA = "0x306E99C", Offset = "0x306E99C", VA = "0x306E99C")]
	private void Update()
	{
	}

	[Token(Token = "0x60195D6")]
	[Address(RVA = "0x306E35C", Offset = "0x306E35C", VA = "0x306E35C")]
	private void AudioProfile(float audioProfile)
	{
	}

	[Token(Token = "0x60195D7")]
	[Address(RVA = "0x3070654", Offset = "0x3070654", VA = "0x3070654")]
	private void GetAmplitude()
	{
	}

	[Token(Token = "0x60195D8")]
	[Address(RVA = "0x306FAB4", Offset = "0x306FAB4", VA = "0x306FAB4")]
	private void CreateAudioBands()
	{
	}

	[Token(Token = "0x60195D9")]
	[Address(RVA = "0x3070084", Offset = "0x3070084", VA = "0x3070084")]
	private void CreateAudioBands64()
	{
	}

	[Token(Token = "0x60195DA")]
	[Address(RVA = "0x306E9E8", Offset = "0x306E9E8", VA = "0x306E9E8")]
	private void GetSpectrumAudioSource()
	{
	}

	[Token(Token = "0x60195DB")]
	[Address(RVA = "0x306F224", Offset = "0x306F224", VA = "0x306F224")]
	private void BandBuffer()
	{
	}

	[Token(Token = "0x60195DC")]
	[Address(RVA = "0x306F66C", Offset = "0x306F66C", VA = "0x306F66C")]
	private void BandBuffer64()
	{
	}

	[Token(Token = "0x60195DD")]
	[Address(RVA = "0x306EAB0", Offset = "0x306EAB0", VA = "0x306EAB0")]
	private void MakeFrequencyBands()
	{
	}

	[Token(Token = "0x60195DE")]
	[Address(RVA = "0x306EE58", Offset = "0x306EE58", VA = "0x306EE58")]
	private void MakeFrequencyBands64()
	{
	}
}
