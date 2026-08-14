using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E2B")]
public abstract class AkObstructionOcclusion : MonoBehaviour
{
	[Token(Token = "0x2003E2C")]
	protected class ObstructionOcclusionValue
	{
		[Token(Token = "0x401A547")]
		[FieldOffset(Offset = "0x8")]
		public float currentValue;

		[Token(Token = "0x401A548")]
		[FieldOffset(Offset = "0xC")]
		public float targetValue;

		[Token(Token = "0x6019465")]
		[Address(RVA = "0x36BC4A8", Offset = "0x36BC4A8", VA = "0x36BC4A8")]
		public ObstructionOcclusionValue()
		{
		}

		[Token(Token = "0x6019466")]
		[Address(RVA = "0x36BCB80", Offset = "0x36BCB80", VA = "0x36BCB80")]
		public bool Update(float fadeRate)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401A53E")]
	[FieldOffset(Offset = "0xC")]
	private readonly List<AkAudioListener> listenersToRemove;

	[Token(Token = "0x401A53F")]
	[FieldOffset(Offset = "0x10")]
	protected readonly List<AkAudioListener> currentListenerList;

	[Token(Token = "0x401A540")]
	[FieldOffset(Offset = "0x14")]
	private readonly Dictionary<AkAudioListener, ObstructionOcclusionValue> ObstructionOcclusionValues;

	[Token(Token = "0x401A541")]
	[FieldOffset(Offset = "0x18")]
	protected float fadeRate;

	[Token(Token = "0x401A542")]
	[FieldOffset(Offset = "0x1C")]
	public float fadeTime;

	[Token(Token = "0x401A543")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask LayerMask;

	[Token(Token = "0x401A544")]
	[FieldOffset(Offset = "0x24")]
	public float maxDistance;

	[Token(Token = "0x401A545")]
	[FieldOffset(Offset = "0x28")]
	public float refreshInterval;

	[Token(Token = "0x401A546")]
	[FieldOffset(Offset = "0x2C")]
	private float refreshTime;

	[Token(Token = "0x601945E")]
	[Address(RVA = "0x36BBF4C", Offset = "0x36BBF4C", VA = "0x36BBF4C")]
	protected AkObstructionOcclusion()
	{
	}

	[Token(Token = "0x601945F")]
	[Address(RVA = "0x36BC04C", Offset = "0x36BC04C", VA = "0x36BC04C")]
	protected void InitIntervalsAndFadeRates()
	{
	}

	[Token(Token = "0x6019460")]
	protected abstract void UpdateCurrentListenerList();

	[Token(Token = "0x6019461")]
	[Address(RVA = "0x36BC080", Offset = "0x36BC080", VA = "0x36BC080")]
	private void UpdateObstructionOcclusionValues()
	{
	}

	[Token(Token = "0x6019462")]
	[Address(RVA = "0x36BC4B0", Offset = "0x36BC4B0", VA = "0x36BC4B0")]
	private void CastRays()
	{
	}

	[Token(Token = "0x6019463")]
	protected abstract void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair);

	[Token(Token = "0x6019464")]
	[Address(RVA = "0x36BC958", Offset = "0x36BC958", VA = "0x36BC958")]
	private void Update()
	{
	}
}
