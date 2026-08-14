using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E58")]
public class AudioResWithCallBack_Wwise : AudioResWithCallBackBase
{
	[Token(Token = "0x401A5CC")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OwnedObject;

	[Token(Token = "0x401A5CD")]
	[FieldOffset(Offset = "0x20")]
	public AudioEvent OwnedEvent;

	[Token(Token = "0x401A5CE")]
	[FieldOffset(Offset = "0x24")]
	public ObjectPool<AudioResWithCallBack_Wwise> OwnedPool;

	[Token(Token = "0x6019585")]
	[Address(RVA = "0x30789AC", Offset = "0x30789AC", VA = "0x30789AC")]
	public AudioResWithCallBack_Wwise()
	{
	}

	[Token(Token = "0x6019586")]
	[Address(RVA = "0x30789B4", Offset = "0x30789B4", VA = "0x30789B4", Slot = "10")]
	protected override void OnOnCollected()
	{
	}

	[Token(Token = "0x6019587")]
	[Address(RVA = "0x30789C4", Offset = "0x30789C4", VA = "0x30789C4", Slot = "11")]
	public override void ReturnToPool()
	{
	}
}
