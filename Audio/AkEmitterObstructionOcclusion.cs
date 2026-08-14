using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003E15")]
public class AkEmitterObstructionOcclusion : AkObstructionOcclusion
{
	[Token(Token = "0x401A4C0")]
	[FieldOffset(Offset = "0x30")]
	private AkGameObj m_gameObj;

	[Token(Token = "0x60193EB")]
	[Address(RVA = "0x35D41C4", Offset = "0x35D41C4", VA = "0x35D41C4")]
	public AkEmitterObstructionOcclusion()
	{
	}

	[Token(Token = "0x60193EC")]
	[Address(RVA = "0x35D41CC", Offset = "0x35D41CC", VA = "0x35D41CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60193ED")]
	[Address(RVA = "0x35D4240", Offset = "0x35D4240", VA = "0x35D4240", Slot = "4")]
	protected override void UpdateCurrentListenerList()
	{
	}

	[Token(Token = "0x60193EE")]
	[Address(RVA = "0x35D4484", Offset = "0x35D4484", VA = "0x35D4484", Slot = "5")]
	protected override void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair)
	{
	}
}
