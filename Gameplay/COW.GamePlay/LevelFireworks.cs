using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000623")]
public class LevelFireworks : BaseLevelObject
{
	[Token(Token = "0x4004615")]
	[FieldOffset(Offset = "0x74")]
	public Animator FireworksAnimator;

	[Token(Token = "0x4004616")]
	[FieldOffset(Offset = "0x78")]
	public GameObject FireEffect;

	[Token(Token = "0x4004617")]
	[FieldOffset(Offset = "0x7C")]
	public AudioSource FireworksAudioSource;

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x27216BC", Offset = "0x27216BC", VA = "0x27216BC")]
	public LevelFireworks()
	{
	}

	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x27216C4", Offset = "0x27216C4", VA = "0x27216C4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x2721768", Offset = "0x2721768", VA = "0x2721768", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60025F4")]
	[Address(RVA = "0x27220A4", Offset = "0x27220A4", VA = "0x27220A4")]
	private void CMCNGEEBDHA()
	{
	}

	[Token(Token = "0x60025F5")]
	[Address(RVA = "0x27222C0", Offset = "0x27222C0", VA = "0x27222C0")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
