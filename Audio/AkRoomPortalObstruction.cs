using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003E32")]
public class AkRoomPortalObstruction : AkObstructionOcclusion
{
	[Token(Token = "0x401A55D")]
	[FieldOffset(Offset = "0x30")]
	private AkRoomPortal m_portal;

	[Token(Token = "0x6019493")]
	[Address(RVA = "0x36C9FF0", Offset = "0x36C9FF0", VA = "0x36C9FF0")]
	public AkRoomPortalObstruction()
	{
	}

	[Token(Token = "0x6019494")]
	[Address(RVA = "0x36C9FF4", Offset = "0x36C9FF4", VA = "0x36C9FF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019495")]
	[Address(RVA = "0x36CA080", Offset = "0x36CA080", VA = "0x36CA080", Slot = "4")]
	protected override void UpdateCurrentListenerList()
	{
	}

	[Token(Token = "0x6019496")]
	[Address(RVA = "0x36CA134", Offset = "0x36CA134", VA = "0x36CA134", Slot = "5")]
	protected override void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair)
	{
	}
}
